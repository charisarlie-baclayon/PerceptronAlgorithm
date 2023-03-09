namespace Perceptron
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button0 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTrain = new System.Windows.Forms.Button();
            this.radioButtonAnd = new System.Windows.Forms.RadioButton();
            this.radioButtonOr = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.radioButtonXnor = new System.Windows.Forms.RadioButton();
            this.radioButtonNor = new System.Windows.Forms.RadioButton();
            this.radioButtonNand = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button0
            // 
            this.button0.Location = new System.Drawing.Point(16, 15);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(98, 83);
            this.button0.TabIndex = 0;
            this.button0.UseVisualStyleBackColor = true;
            this.button0.Click += new System.EventHandler(this.ButtonColor);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 122);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 83);
            this.button1.TabIndex = 1;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.ButtonColor);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(246, 68);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(98, 83);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button0);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(357, 232);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(305, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(187, 192);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "No. Of Epochs it took:";
            // 
            // buttonTrain
            // 
            this.buttonTrain.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.buttonTrain.Location = new System.Drawing.Point(222, 325);
            this.buttonTrain.Name = "buttonTrain";
            this.buttonTrain.Size = new System.Drawing.Size(134, 41);
            this.buttonTrain.TabIndex = 4;
            this.buttonTrain.Text = "Train";
            this.buttonTrain.UseVisualStyleBackColor = false;
            this.buttonTrain.Click += new System.EventHandler(this.buttonTrain_Click);
            // 
            // radioButtonAnd
            // 
            this.radioButtonAnd.AutoSize = true;
            this.radioButtonAnd.Location = new System.Drawing.Point(29, 32);
            this.radioButtonAnd.Name = "radioButtonAnd";
            this.radioButtonAnd.Size = new System.Drawing.Size(48, 17);
            this.radioButtonAnd.TabIndex = 5;
            this.radioButtonAnd.TabStop = true;
            this.radioButtonAnd.Text = "AND";
            this.radioButtonAnd.UseVisualStyleBackColor = true;
            this.radioButtonAnd.Click += new System.EventHandler(this.RadioImage);
            // 
            // radioButtonOr
            // 
            this.radioButtonOr.AutoSize = true;
            this.radioButtonOr.Location = new System.Drawing.Point(85, 32);
            this.radioButtonOr.Name = "radioButtonOr";
            this.radioButtonOr.Size = new System.Drawing.Size(41, 17);
            this.radioButtonOr.TabIndex = 6;
            this.radioButtonOr.TabStop = true;
            this.radioButtonOr.Text = "OR";
            this.radioButtonOr.UseVisualStyleBackColor = true;
            this.radioButtonOr.Click += new System.EventHandler(this.RadioImage);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.radioButtonXnor);
            this.panel2.Controls.Add(this.radioButtonNor);
            this.panel2.Controls.Add(this.radioButtonNand);
            this.panel2.Controls.Add(this.radioButtonOr);
            this.panel2.Controls.Add(this.radioButtonAnd);
            this.panel2.Location = new System.Drawing.Point(12, 254);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 65);
            this.panel2.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(130, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Choose Logic Gate";
            // 
            // radioButtonXnor
            // 
            this.radioButtonXnor.AutoSize = true;
            this.radioButtonXnor.Location = new System.Drawing.Point(249, 32);
            this.radioButtonXnor.Name = "radioButtonXnor";
            this.radioButtonXnor.Size = new System.Drawing.Size(56, 17);
            this.radioButtonXnor.TabIndex = 10;
            this.radioButtonXnor.TabStop = true;
            this.radioButtonXnor.Text = "XNOR";
            this.radioButtonXnor.UseVisualStyleBackColor = true;
            this.radioButtonXnor.Click += new System.EventHandler(this.RadioImage);
            // 
            // radioButtonNor
            // 
            this.radioButtonNor.AutoSize = true;
            this.radioButtonNor.Location = new System.Drawing.Point(194, 32);
            this.radioButtonNor.Name = "radioButtonNor";
            this.radioButtonNor.Size = new System.Drawing.Size(49, 17);
            this.radioButtonNor.TabIndex = 8;
            this.radioButtonNor.TabStop = true;
            this.radioButtonNor.Text = "NOR";
            this.radioButtonNor.UseVisualStyleBackColor = true;
            this.radioButtonNor.Click += new System.EventHandler(this.RadioImage);
            // 
            // radioButtonNand
            // 
            this.radioButtonNand.AutoSize = true;
            this.radioButtonNand.Location = new System.Drawing.Point(132, 32);
            this.radioButtonNand.Name = "radioButtonNand";
            this.radioButtonNand.Size = new System.Drawing.Size(56, 17);
            this.radioButtonNand.TabIndex = 7;
            this.radioButtonNand.TabStop = true;
            this.radioButtonNand.Text = "NAND";
            this.radioButtonNand.UseVisualStyleBackColor = true;
            this.radioButtonNand.Click += new System.EventHandler(this.RadioImage);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(28, 325);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 41);
            this.button2.TabIndex = 8;
            this.button2.Text = "Reset";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "and.png");
            this.imageList1.Images.SetKeyName(1, "or.png");
            this.imageList1.Images.SetKeyName(2, "nand.png");
            this.imageList1.Images.SetKeyName(3, "nor.png");
            this.imageList1.Images.SetKeyName(4, "xnor.png");
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(124, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(114, 127);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 387);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.buttonTrain);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Logic Gates Perceptron";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonTrain;
        private System.Windows.Forms.RadioButton radioButtonAnd;
        private System.Windows.Forms.RadioButton radioButtonOr;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton radioButtonNand;
        private System.Windows.Forms.RadioButton radioButtonNor;
        private System.Windows.Forms.RadioButton radioButtonXnor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ImageList imageList1;
    }
}

