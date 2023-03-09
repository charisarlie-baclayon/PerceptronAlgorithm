using System;
using System.Drawing;
using System.Windows.Forms;

namespace Perceptron
{
    public partial class Form1 : Form
    {
        Perceptron perceptron;
        LogicGates gates;
        private int input1;
        private int input2;
        private int desiredOutput;
        private int epoch;
        private int output;
        public Form1()
        {
            InitializeComponent();
            perceptron = new Perceptron();
            gates = new LogicGates();
            imageList1.ImageSize = new Size(114, 127);
        }

        private int GetDesiredOutput(int input1, int input2)
        {
            var target = 0;
            if(radioButtonAnd.Checked)
            {
                target = gates.And(input1, input2);
            }
            else if (radioButtonOr.Checked)
            {
                target = gates.Or(input1, input2);
            }
            else if (radioButtonNand.Checked)
            {
                target = gates.Nand(input1, input2);
            }
            else if (radioButtonNor.Checked)
            {
                target = gates.Nor(input1, input2);
            }
            else if (radioButtonXnor.Checked)
            {
                target = gates.Xnor(input1, input2);
            }
            return target;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button0.BackColor = Color.White;
            button1.BackColor = Color.White;
            button3.BackColor = Color.White;
            radioButtonAnd.Checked = false;
            radioButtonOr.Checked = false;
            radioButtonNand.Checked = false;
            radioButtonNor.Checked = false;
            radioButtonXnor.Checked = false;
            label2.Text = "";
            pictureBox1.Image= null;
        }

        private void buttonTrain_Click(object sender, EventArgs e)
        {

            if (radioButtonAnd.Checked == false &&
                radioButtonOr.Checked == false &&
                radioButtonNand.Checked == false &&
                radioButtonNor.Checked == false &&
                radioButtonXnor.Checked == false)
            {
                MessageBox.Show("Please choose Logic Gate", "Error");
            }
            else
            {

                // Gather inputs
                if (button0.BackColor == Color.Black)
                {
                    input1 = 1;
                }
                else
                {
                    input1 = -1;
                }

                if (button1.BackColor == Color.Black)
                {
                    input2 = 1;

                }
                else
                {
                    input2 = -1;
                }

                // Determine desired output
                desiredOutput = GetDesiredOutput(input1, input2);

                // Train and get Output and the number of Epoch it took until Convergence
                int[] values = perceptron.Train(input1, input2, desiredOutput);
                output = values[0];
                epoch = values[1];
                label2.Text = epoch.ToString();

                if (output != -1)
                {
                    button3.BackColor = Color.Green;
                }
                else
                {
                    button3.BackColor = Color.Red;
                }
            }
        }

        public void ButtonColor(object sender, EventArgs e)
        {
            Button button = sender as Button;
            if (button.BackColor != Color.Black)
            {
                button.BackColor = Color.Black;
            }
            else
            {
                button.BackColor = Color.White;
            }
        }

        public void RadioImage(object sender, EventArgs e)
        {
            // Get desired output
            if (radioButtonAnd.Checked)
            {
                pictureBox1.Image = imageList1.Images[0];
            }
            if (radioButtonOr.Checked)
            {
                pictureBox1.Image = imageList1.Images[1];
            }
            if (radioButtonNand.Checked)
            {
                pictureBox1.Image = imageList1.Images[2];
            }
            if (radioButtonNor.Checked)
            {
                pictureBox1.Image = imageList1.Images[3];
            }
            if (radioButtonXnor.Checked)
            {
                pictureBox1.Image = imageList1.Images[4];
            }
        }
    }
}
