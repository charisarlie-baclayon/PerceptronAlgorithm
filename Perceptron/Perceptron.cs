using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perceptron
{
    public class Perceptron
    {
        private double[] weights = new double[2];
        private double learningRate;
        private double bias;
        private Random random;

        public Perceptron()
        {
            random = new Random();
            Initialize();
        }

        public void Initialize()
        {
            weights[0] = random.NextDouble() * 2 - 1;
            weights[1] = random.NextDouble() * 2 - 1;
            bias = random.NextDouble() * 2 - 1;
            learningRate = 1;
        }

        public int Activate (double input1, double input2)
        {
            double activation = bias + input1 * weights[0] + input2 * weights[1];
            if (activation > 0)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public int[] Train (double input1, double input2, int desiredOutput)
        {
            int epoch = 0;
            int[] values = new int[2];
            int output;
            do
            {
                output = Activate(input1, input2);
                weights[0] = weights[0] + learningRate * desiredOutput * input1;
                weights[1] = weights[1] + learningRate * desiredOutput * input2;

                bias = bias + learningRate * desiredOutput;
                epoch++;
                Console.WriteLine("Epoch num:" + epoch);
                Console.WriteLine("Output:" + output);
                Console.WriteLine("Desired:" + desiredOutput);
            } while (output != desiredOutput);
            Console.WriteLine("Total Epochs: " + epoch);
            Console.WriteLine("Final Output: " + output);
            values[0] = output;
            values[1] = epoch;
            return values;
        } 
    }
}
