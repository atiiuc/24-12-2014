namespace SalaryCalculateApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GetSalary = new System.Windows.Forms.Button();
            this.nameText = new System.Windows.Forms.TextBox();
            this.basicText = new System.Windows.Forms.TextBox();
            this.rentText = new System.Windows.Forms.TextBox();
            this.allowanceText = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(67, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Basic Amount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(67, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "House Rent";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Medical Allowance";
            // 
            // GetSalary
            // 
            this.GetSalary.Location = new System.Drawing.Point(231, 159);
            this.GetSalary.Name = "GetSalary";
            this.GetSalary.Size = new System.Drawing.Size(176, 23);
            this.GetSalary.TabIndex = 5;
            this.GetSalary.Text = "Show Me Salary";
            this.GetSalary.UseVisualStyleBackColor = true;
            this.GetSalary.Click += new System.EventHandler(this.button1_Click);
            // 
            // nameText
            // 
            this.nameText.Location = new System.Drawing.Point(159, 22);
            this.nameText.Name = "nameText";
            this.nameText.Size = new System.Drawing.Size(284, 20);
            this.nameText.TabIndex = 7;
            // 
            // basicText
            // 
            this.basicText.Location = new System.Drawing.Point(159, 48);
            this.basicText.Name = "basicText";
            this.basicText.Size = new System.Drawing.Size(284, 20);
            this.basicText.TabIndex = 8;
            // 
            // rentText
            // 
            this.rentText.Location = new System.Drawing.Point(159, 74);
            this.rentText.Name = "rentText";
            this.rentText.Size = new System.Drawing.Size(284, 20);
            this.rentText.TabIndex = 9;
            // 
            // allowanceText
            // 
            this.allowanceText.Location = new System.Drawing.Point(159, 107);
            this.allowanceText.Name = "allowanceText";
            this.allowanceText.Size = new System.Drawing.Size(284, 20);
            this.allowanceText.TabIndex = 10;
            this.allowanceText.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 261);
            this.Controls.Add(this.allowanceText);
            this.Controls.Add(this.rentText);
            this.Controls.Add(this.basicText);
            this.Controls.Add(this.nameText);
            this.Controls.Add(this.GetSalary);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button GetSalary;
        private System.Windows.Forms.TextBox nameText;
        private System.Windows.Forms.TextBox basicText;
        private System.Windows.Forms.TextBox rentText;
        private System.Windows.Forms.TextBox allowanceText;
    }
}

