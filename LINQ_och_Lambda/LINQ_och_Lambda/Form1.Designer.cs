
namespace LINQ_och_Lambda
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnCountRed = new System.Windows.Forms.Button();
            this.BtnCountolderthan2003 = new System.Windows.Forms.Button();
            this.btnGreyVolvos = new System.Windows.Forms.Button();
            this.BtnAverageDistance = new System.Windows.Forms.Button();
            this.BtnMostExpensiveCar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(399, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(647, 550);
            this.listBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.BtnCountRed.Location = new System.Drawing.Point(63, 28);
            this.BtnCountRed.Name = "button1";
            this.BtnCountRed.Size = new System.Drawing.Size(138, 49);
            this.BtnCountRed.TabIndex = 1;
            this.BtnCountRed.Text = "button1";
            this.BtnCountRed.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.BtnCountolderthan2003.Location = new System.Drawing.Point(63, 143);
            this.BtnCountolderthan2003.Name = "button2";
            this.BtnCountolderthan2003.Size = new System.Drawing.Size(138, 49);
            this.BtnCountolderthan2003.TabIndex = 2;
            this.BtnCountolderthan2003.Text = "button2";
            this.BtnCountolderthan2003.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.btnGreyVolvos.Location = new System.Drawing.Point(63, 256);
            this.btnGreyVolvos.Name = "button3";
            this.btnGreyVolvos.Size = new System.Drawing.Size(138, 49);
            this.btnGreyVolvos.TabIndex = 3;
            this.btnGreyVolvos.Text = "button3";
            this.btnGreyVolvos.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.BtnAverageDistance.Location = new System.Drawing.Point(63, 358);
            this.BtnAverageDistance.Name = "button4";
            this.BtnAverageDistance.Size = new System.Drawing.Size(138, 49);
            this.BtnAverageDistance.TabIndex = 4;
            this.BtnAverageDistance.Text = "button4";
            this.BtnAverageDistance.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.BtnMostExpensiveCar.Location = new System.Drawing.Point(63, 472);
            this.BtnMostExpensiveCar.Name = "button5";
            this.BtnMostExpensiveCar.Size = new System.Drawing.Size(138, 49);
            this.BtnMostExpensiveCar.TabIndex = 5;
            this.BtnMostExpensiveCar.Text = "button5";
            this.BtnMostExpensiveCar.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1069, 612);
            this.Controls.Add(this.BtnMostExpensiveCar);
            this.Controls.Add(this.BtnAverageDistance);
            this.Controls.Add(this.btnGreyVolvos);
            this.Controls.Add(this.BtnCountolderthan2003);
            this.Controls.Add(this.BtnCountRed);
            this.Controls.Add(this.listBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BtnCountRed;
        private System.Windows.Forms.Button BtnCountolderthan2003;
        private System.Windows.Forms.Button btnGreyVolvos;
        private System.Windows.Forms.Button BtnAverageDistance;
        private System.Windows.Forms.Button BtnMostExpensiveCar;
    }
}

