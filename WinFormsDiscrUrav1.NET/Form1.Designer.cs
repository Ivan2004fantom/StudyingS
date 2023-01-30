
namespace WinFormsDiscrUrav1.NET
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            this.textBoxA = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.textBoxC = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBoxINPUT = new System.Windows.Forms.TextBox();
            this.textBoxX1 = new System.Windows.Forms.TextBox();
            this.textBoxX2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.textBoxMatrix = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxA
            // 
            this.textBoxA.Location = new System.Drawing.Point(129, 153);
            this.textBoxA.Name = "textBoxA";
            this.textBoxA.Size = new System.Drawing.Size(86, 20);
            this.textBoxA.TabIndex = 0;
            this.textBoxA.Text = "0";
            // 
            // label1
            // 
            this.label1.AccessibleName = "";
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 155);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(20, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "A=";
            // 
            // label2
            // 
            this.label2.AccessibleName = "";
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "B=";
            // 
            // label3
            // 
            this.label3.AccessibleName = "";
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "C=";
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(129, 178);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(86, 20);
            this.textBoxB.TabIndex = 4;
            this.textBoxB.Text = "0";
            // 
            // textBoxC
            // 
            this.textBoxC.Location = new System.Drawing.Point(129, 202);
            this.textBoxC.Name = "textBoxC";
            this.textBoxC.Size = new System.Drawing.Size(86, 20);
            this.textBoxC.TabIndex = 5;
            this.textBoxC.Text = "0";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(220, 153);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 69);
            this.button1.TabIndex = 6;
            this.button1.Text = "Вычислить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(129, 46);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(170, 94);
            this.textBox1.TabIndex = 7;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBoxINPUT
            // 
            this.textBoxINPUT.Location = new System.Drawing.Point(129, 12);
            this.textBoxINPUT.Name = "textBoxINPUT";
            this.textBoxINPUT.Size = new System.Drawing.Size(170, 20);
            this.textBoxINPUT.TabIndex = 8;
            // 
            // textBoxX1
            // 
            this.textBoxX1.Location = new System.Drawing.Point(129, 259);
            this.textBoxX1.Name = "textBoxX1";
            this.textBoxX1.Size = new System.Drawing.Size(100, 20);
            this.textBoxX1.TabIndex = 9;
            // 
            // textBoxX2
            // 
            this.textBoxX2.Location = new System.Drawing.Point(129, 285);
            this.textBoxX2.Name = "textBoxX2";
            this.textBoxX2.Size = new System.Drawing.Size(100, 20);
            this.textBoxX2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AccessibleName = "";
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(103, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "X1=";
            // 
            // label5
            // 
            this.label5.AccessibleName = "";
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "X2=";
            // 
            // label6
            // 
            this.label6.AccessibleName = "";
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Уравнение:";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chart1.Legends.Add(legend3);
            this.chart1.Location = new System.Drawing.Point(395, 83);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(258, 222);
            this.chart1.TabIndex = 14;
            this.chart1.Text = "chart1";
            // 
            // textBoxMatrix
            // 
            this.textBoxMatrix.Location = new System.Drawing.Point(305, 46);
            this.textBoxMatrix.Multiline = true;
            this.textBoxMatrix.Name = "textBoxMatrix";
            this.textBoxMatrix.Size = new System.Drawing.Size(69, 280);
            this.textBoxMatrix.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.textBoxMatrix);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxX2);
            this.Controls.Add(this.textBoxX1);
            this.Controls.Add(this.textBoxINPUT);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBoxC);
            this.Controls.Add(this.textBoxB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxA);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxA;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.TextBox textBoxC;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBoxINPUT;
        private System.Windows.Forms.TextBox textBoxX1;
        private System.Windows.Forms.TextBox textBoxX2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.TextBox textBoxMatrix;
    }
}

