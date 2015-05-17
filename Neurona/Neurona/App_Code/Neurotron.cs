using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Neurona
{
    public class Neurotron
    {
        private static List<Neuron> depth1;
        private static List<Neuron> depth2;
        private basedatosEntities db = new basedatosEntities();

        public Neurotron()
        {
            depth1 = new List<Neuron>();
            depth2 = new List<Neuron>();
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="pMatrix"></param>
        /// <returns></returns>
        public string checkMatrix(int[] pMatrix)
        {
            fillLists();
            getWeights(pMatrix);

            for (int i = 0; i < 6; i++)
                depth2[i].result = Convert.ToInt32(Math.Round(depth2[i].result, 0));

            return getCharacter();
        }

        private void fillLists() 
        {
            for (int i = 0; i < 25; i++)
                depth1.Add(new Neuron(25));

            for (int i = 0; i < 6; i++)
                depth2.Add(new Neuron(25));
        }

        private void getWeights(int[] pMatrix)
        {
            getResultDepth1(pMatrix);
            getResultDepth2();
        }

        private void getResultDepth1(int[] pMatrix)
        {
            for (int i = 0; i < depth1.Count(); i++)
            {
                double _t = -1 * getInputDepth1(pMatrix, i);
                depth1[i].result = (1) / (1 + Math.Pow((Math.E), _t));
            }
        }

        private void getResultDepth2()
        {
            for (int i = 0; i < depth2.Count(); i++)
            {
                double _t = -1 * getInputDepth2(i);
                depth2[i].result = (1) / (1 + Math.Pow((Math.E), _t));
            }
        }

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
    }
}