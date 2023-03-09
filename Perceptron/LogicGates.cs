using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Perceptron
{
    public class LogicGates
    {
        public int And(int input1, int input2)
        {
            if (input1 == 1 && input2 == 1)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public int Or(int input1, int input2)
        {
            if (input1 == -1 && input2 == -1)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }

        public int Nor(int input1, int input2)
        {
            if (input1 == -1 && input2 == -1)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public int Nand(int input1, int input2)
        {
            if (input1 == 1 && input2 == 1)
            {
                return -1;
            }
            else
            {
                return 1;
            }
        }

        public int Xor(int input1, int input2)
        {
            if (input1 != input2)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

        public int Xnor(int input1, int input2)
        {
            if (input1 == input2)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }

    }
}
