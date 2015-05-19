using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Neurona
{
    /// <summary>
    /// 
    /// </summary>
    public class Neurotron
    {
        // Primera capa de la neurona
        private static List<Neuron> depth1;
        // Segunda capa de la neurona
        private static List<Neuron> depth2;
        // Indicador si la neurona debe aprender o no
        private bool train;
        // conexion con la base de datos
        private basedatosEntities db = new basedatosEntities();

        /// <summary>
        /// Constructor de la clase
        /// </summary>
        public Neurotron()
        {
            depth1 = new List<Neuron>();
            depth2 = new List<Neuron>();
            train = true;
        }

        /// <summary>
        /// Evalua que caracter es el que se ha ingresado
        /// </summary>
        /// <param name="pMatrix">Matriz que representa la imagen</param>
        /// <param name="pLearning">Factor de aprndizaje</param>
        /// <returns>Caracter detectado</returns>
        public string checkMatrix(int[] pMatrix, double pLearning)
        {
            if (train) 
            {
                fillLists(pMatrix.Length);
                trainNeuron(pMatrix, 10000, pLearning);
                train = false;
            }
                
            getWeights(pMatrix);

            for (int i = 0; i < 6; i++)
                depth2[i].result = Convert.ToInt32(Math.Round(depth2[i].result, 0));

            return getCharacter();
        }

        /// <summary>
        /// Llena las listas
        /// </summary>
        /// <param name="pSize">Tamaño de la lista</param>
        private void fillLists(int pSize) 
        {
            for (int i = 0; i < pSize; i++)
                depth1.Add(new Neuron(pSize));

            for (int i = 0; i < 6; i++)
                depth2.Add(new Neuron(pSize));
        }

        /// <summary>
        /// Obtener los pesos de las neuronas
        /// </summary>
        /// <param name="pMatrix">Matriz que representa la imagen</param>
        private void getWeights(int[] pMatrix)
        {
            getResultDepth1(pMatrix);
            getResultDepth2();
        }

        /// <summary>
        /// Obtiene los resultados de la primera capa de la neurona
        /// </summary>
        /// <param name="pMatrix">Matriz que representa la imagen</param>
        private void getResultDepth1(int[] pMatrix)
        {
            for (int i = 0; i < depth1.Count(); i++)
            {
                double _t = -1 * getInputDepth1(pMatrix, i);
                depth1[i].result = (1) / (1 + Math.Pow((Math.E), _t));
            }
        }

        /// <summary>
        /// Obtiene los resultados de la segunda capa de la neurona
        /// </summary>
        private void getResultDepth2()
        {
            for (int i = 0; i < depth2.Count(); i++)
            {
                double _t = -1 * getInputDepth2(i);
                depth2[i].result = (1) / (1 + Math.Pow((Math.E), _t));
            }
        }

        /// <summary>
        /// Obtiene las entradas de la primera capa de la neurona
        /// </summary>
        /// <param name="pMatrix">Matriz que representa la imagen</param>
        /// <param name="pID">Indice de la primera capa</param>
        /// <returns>valor de la primera capa de la neurona</returns>
        private double getInputDepth1(int[] pMatrix, int pID)
        {
            double result = 0.0;
            double weight = new double();
            double input = new double();
            for (int i = 0; i < pMatrix.Length; i++)
            {
                weight = depth1[pID].weight[i];
                input = pMatrix[i];
                result += weight * input;
            }
            return result;
        }

        /// <summary>
        /// Obtiene las entradas de la segunda capa de la neurona
        /// </summary>
        /// <param name="pID">Indice de la segunda capa</param>
        /// <returns>valor de la segunda capa de la neurona</returns>
        private double getInputDepth2(int pID)
        {
            double result = 0.0;
            double weight = new double();
            double input = new double();
            for (int i = 0; i < depth1.Count(); i++)
            {
                weight = depth2[pID].weight[i];
                input = depth1[i].result;
                result += weight * input;
            }
            return result;
        }

        /// <summary>
        /// Obtiene el caracter de la base de datos
        /// </summary>
        /// <returns>Retorna el codigo del caracter</returns>
        private string getCharacter() 
        {
            string result = "";
            for(int i=0; i < depth2.Count(); i++)
                result += (depth2[0].result).ToString();
 
            var query = from x in db.CARACTER
                      where x.OUT_CARACTER.Equals(result)
                      select x;

            foreach (var tmp in query) 
                result = tmp.CARACTER1;

            return result;
        }

        /// <summary>
        /// Entrenaiento de la neurona
        /// </summary>
        /// <param name="pMatrix">Matriz que representa la imagen</param>
        /// <param name="x">Cantidad total de iteraciones</param>
        /// <param name="pLearning">Factor de aprendizaje</param>
        private void trainNeuron(int[] pMatrix, int x, double pLearning)
        {
            var query = from tmp in db.CARACTER
                        select tmp;

            for (int i = 0; i < x; i++) 
            {
                foreach (var tmp in query) 
                {
                    getWeights(pMatrix);
                    trainNeuronAux(tmp.OUT_CARACTER, pMatrix, pLearning);
                }
            }
        }

        /// <summary>
        /// Procedimiento auxiliar del entrenamiento de la neurona
        /// </summary>
        /// <param name="pOut">Salida de la neurona</param>
        /// <param name="pMatrix">Matriz que representa la imagen</param>
        /// <param name="pLearning">Factor de aprendizaje</param>
        private void trainNeuronAux(string pOut, int[] pMatrix, double pLearning)
        {
            for (int i = 0; i < depth2.Count(); i++)
            {
                int x = int.Parse(pOut[i].ToString());
                if (Math.Round(depth2[i].result, 0) != x)
                    fixOutWeight(i, x, pMatrix, pLearning);
            }
            getResultDepth1(pMatrix);
            getResultDepth2();
        }

        /// <summary>
        /// Correccion de los pesos de la neurona
        /// </summary>
        /// <param name="pID">Indice de la primera capa</param>
        /// <param name="pOut">salida de la primera capa</param>
        /// <param name="pMatrix">Matriz que representa la imagen</param>
        /// <param name="pLearning">factor de aprendizaje</param>
        private void fixOutWeight(int pID, int pOut, int[] pMatrix, double pLearning)
        {
            double newWeight;
            double oldWeight;
            double input;
            double delta;
            for (int i = 0; i < depth1.Count(); i++)
            {
                delta = getDelta1(Convert.ToDouble(pOut), depth2[pID].result);
                input = depth1[i].result;
                oldWeight = depth2[pID].weight[i];
                newWeight = oldWeight + (pLearning * input * delta);
                depth2[pID].weight[i] = newWeight;
                fixHideDepth(delta, oldWeight, i, pMatrix, pLearning);
            }
        }

        /// <summary>
        /// Realiza la correccion a la segunda capa de la neurona
        /// </summary>
        /// <param name="pDelta">Valor del delta</param>
        /// <param name="pOutWeight">Peso de salida de la neurona</param>
        /// <param name="pID">Indice de la primera capa</param>
        /// <param name="pMatrix">Matriz que representa la imagen</param>
        /// <param name="pLearning">Factor de aprendizaje</param>
        private void fixHideDepth(double pDelta, double pOutWeight, int pID, int[] pMatrix, double pLearning)
        {
            double newWeight;
            double oldWeight;
            double input;
            for (int i = 0; i < depth1[pID].weight.Count(); i++)
            {
                oldWeight = depth1[pID].weight[i];
                input = pMatrix[i];
                newWeight = oldWeight + pLearning * input * getDelta2(depth1[pID].result, pOutWeight, pDelta);
                depth1[pID].weight[i] = newWeight;
            }
        }

        /// <summary>
        /// Obtiene el delta de la primera capa
        /// </summary>
        /// <param name="pResultValue">Valor esperado</param>
        /// <param name="pGetValue">Valor obtenido</param>
        /// <returns>delta de la primera capa</returns>
        private double getDelta1(double pResultValue, double pGetValue)
        {
            return pGetValue * (1 - pGetValue) * (pResultValue - pGetValue);
        }

        /// <summary>
        /// Obtiene el delta de la segunda capa
        /// </summary>
        /// <param name="pOut">Resultado esperado</param>
        /// <param name="pOldWeight">Peso anterior</param>
        /// <param name="pDelta">Delta de la primera capa</param>
        /// <returns>Delta de la segunda capa</returns>
        private double getDelta2(double pOut, double pOldWeight, double pDelta)
        {
            return pOut * (1 - pOut) * (pOldWeight * pDelta);
        }
    }
}