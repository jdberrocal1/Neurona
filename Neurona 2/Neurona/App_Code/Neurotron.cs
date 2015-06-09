using System;
using System.Collections;
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
        private basedatosEntities1 db = new basedatosEntities1();

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
        public string checkMatrix(List<int[]> pVector, double pLearning)
        {
            string result = "";

            for (int i = 0; i < pVector.Count(); i++)
            {
                result += checkMatrixAux(string.Join("",pVector[i]), pLearning);
            }

            return result;
        }

        private string checkMatrixAux(/*int[]*/string pMatrix, double pLearning)
        {
            if (train)
            {
                fillLists(pMatrix.Count());
                trainNeuron(pMatrix, 1000, pLearning);
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
        private void fillLists(int pSize) /////////////////
        {
            for (int i = 0; i < pSize; i++)
                depth1.Add(new Neuron(pSize));

            for (int i = 0; i < 6; i++)
                depth2.Add(new Neuron(pSize));

            createWeights();
        }

        private void createWeights() /////////////////////////////
        {
            Random random = new Random();
            double numRandom;
            //randoms capa oculta
            for (int i = 0; i < depth1.Count(); i++)
            {
                for (int j = 0; j < depth1[i].weight.Length; j++)
                {
                    numRandom = random.NextDouble();
                    depth1[i].weight[j] = numRandom;
                }
            }
            //randoms capa de salida
            for (int i = 0; i < depth2.Count; i++)
            {
                for (int j = 0; j < depth2[i].weight.Length; j++)
                {
                    numRandom = random.NextDouble();
                    depth2[i].weight[j] = numRandom;
                }
            }
        }

        /// <summary>
        /// Obtener los pesos de las neuronas
        /// </summary>
        /// <param name="pMatrix">Matriz que representa la imagen</param>
        private void getWeights(/*int[]*/string pMatrix) ////
        {
            getResultDepth1(pMatrix);
            getResultDepth2();
        }

        /// <summary>
        /// Obtiene los resultados de la primera capa de la neurona
        /// </summary>
        /// <param name="pMatrix">Matriz que representa la imagen</param>
        private void getResultDepth1(/*int[]*/string pMatrix) //////////////
        {
            for (int i = 0; i < depth1.Count(); i++)
            {
                double t = -1 * getInputDepth1(pMatrix, i);
                depth1[i].result = (1) / (1 + Math.Pow((Math.E), t));
            }
        }

        /// <summary>
        /// Obtiene los resultados de la segunda capa de la neurona
        /// </summary>
        private void getResultDepth2() /////////////////////
        {
            for (int i = 0; i < depth2.Count(); i++)
            {
                double t = -1 * (getInputDepth2(i)/3);
                depth2[i].result = (1) / (1 + Math.Pow((Math.E), t));
            }
        }

        /// <summary>
        /// Obtiene las entradas de la primera capa de la neurona
        /// </summary>
        /// <param name="pMatrix">Matriz que representa la imagen</param>
        /// <param name="pID">Indice de la primera capa</param>
        /// <returns>valor de la primera capa de la neurona</returns>
        private double getInputDepth1(/*int[]*/string pMatrix, int pID) /////////
        {
            double result = 0.0;
            double weight;
            double input;
            for (int i = 0; i < pMatrix.Length; i++)  
            {
                weight = depth1[pID].weight[i];
                input = (double)(pMatrix[i]-'0');//Convert.ToDouble(pMatrix[i]);
                result += weight * input;
            }
            return result;
        }

        /// <summary>
        /// Obtiene las entradas de la segunda capa de la neurona
        /// </summary>
        /// <param name="pID">Indice de la segunda capa</param>
        /// <returns>valor de la segunda capa de la neurona</returns>
        private double getInputDepth2(int pID) //////////////////////////
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
        private string getCharacter()  /////////////////////
        {
            string patron = "";
            string result = "";
            int cont = 0;
            int max = 0;

            for (int i = 0; i < depth2.Count(); i++)
                patron += (depth2[i].result).ToString();

            var query = from x in db.CARACTER
                        //where x.OUT_CARACTER.Equals(result)
                        select x;

            foreach (var tmp in query)
            {
                for (int i = 0; i < tmp.OUT_CARACTER.Length; i++)
                {
                    if (patron[i].Equals(tmp.OUT_CARACTER[i]))
                        cont++;
                }
                if (max < cont)
                {
                    result = tmp.CARACTER1;
                    max = cont;
                }

                cont = 0;
            }

            return result;
        }

        /// <summary>
        /// Entrenaiento de la neurona
        /// </summary>
        /// <param name="pMatrix">Matriz que representa la imagen</param>
        /// <param name="x">Cantidad total de iteraciones</param>
        /// <param name="pLearning">Factor de aprendizaje</param>
        private void trainNeuron(/*int[]*/string pMatrix, int x, double pLearning) //////
        {
            var query = from tmp in db.CARACTER
                        select tmp;

            for (int i = 0; i < x; i++) 
            {
                foreach (var tmp in query) 
                {
                    getWeights(tmp.IN_CARACTER/*pMatrix*/);
                    //trainNeuronAux(tmp.OUT_CARACTER, pMatrix, pLearning);
                    if(!tmp.IN_CARACTER.Equals(""))
                        trainNeuronAux(tmp.OUT_CARACTER, /*pMatrix*/tmp.IN_CARACTER, pLearning);
                }
                double r = depth1[0].weight[0];
                double k = depth2[0].weight[0];
            }
        }

        /// <summary>
        /// Procedimiento auxiliar del entrenamiento de la neurona
        /// </summary>
        /// <param name="pOut">Salida de la neurona</param>
        /// <param name="pMatrix">Matriz que representa la imagen</param>
        /// <param name="pLearning">Factor de aprendizaje</param>
        private void trainNeuronAux(string pOut, /*int[]*/string pMatrix, double pLearning) //////////////////////////
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
        private void fixOutWeight(int pID, int pOut, /*int[]*/string pMatrix, double pLearning) ///////////////
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
        private void fixHideDepth(double pDelta, double pOutWeight, int pID, /*int[]*/string pMatrix, double pLearning)  ///// ->
        {
            double newWeight;
            double oldWeight;
            double input;
            for (int i = 0; i < depth1[pID].weight.Count(); i++)
            {
                oldWeight = depth1[pID].weight[i];
                input = (double)(pMatrix[i]-'0');
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
        private double getDelta1(double pResultValue, double pGetValue) /////////////
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
        private double getDelta2(double pOut, double pOldWeight, double pDelta) ///////////////
        {
            return pOut * (1 - pOut) * (pOldWeight * pDelta);
        }
    }
}