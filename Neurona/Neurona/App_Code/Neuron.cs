using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Neurona
{
    class Neuron
    {
        public double[] weight;
        public double result;

        public Neuron(int n)
        {
            this.weight = new double[n];
            this.result = 0.0;
        }
    }
}
