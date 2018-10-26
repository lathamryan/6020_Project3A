namespace Latham_Project3A
{
    partial class frmCalorie
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
            this.grpGenderBox = new System.Windows.Forms.GroupBox();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtCalOutput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtRandomIn = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtRandomOut = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.grpGenderBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // grpGenderBox
            // 
            this.grpGenderBox.BackColor = System.Drawing.SystemColors.Control;
            this.grpGenderBox.Controls.Add(this.rdbMale);
            this.grpGenderBox.Controls.Add(this.rdbFemale);
            this.grpGenderBox.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpGenderBox.Location = new System.Drawing.Point(2, 2);
            this.grpGenderBox.Margin = new System.Windows.Forms.Padding(2);
            this.grpGenderBox.Name = "grpGenderBox";
            this.grpGenderBox.Padding = new System.Windows.Forms.Padding(2);
            this.grpGenderBox.Size = new System.Drawing.Size(236, 59);
            this.grpGenderBox.TabIndex = 0;
            this.grpGenderBox.TabStop = false;
            this.grpGenderBox.Text = "Gender";
            this.grpGenderBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.Location = new System.Drawing.Point(137, 21);
            this.rdbMale.Margin = new System.Windows.Forms.Padding(2);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(60, 23);
            this.rdbMale.TabIndex = 2;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(12, 21);
            this.rdbFemale.Margin = new System.Windows.Forms.Padding(2);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(74, 23);
            this.rdbFemale.TabIndex = 1;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // txtAge
            // 
            this.txtAge.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtAge.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAge.Location = new System.Drawing.Point(150, 74);
            this.txtAge.Margin = new System.Windows.Forms.Padding(2);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(76, 23);
            this.txtAge.TabIndex = 3;
            // 
            // txtWeight
            // 
            this.txtWeight.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.txtWeight.Font = new System.Drawing.Font("Trebuchet MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtWeight.Location = new System.Drawing.Point(150, 116);
            this.txtWeight.Margin = new System.Windows.Forms.Padding(2);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(76, 23);
            this.txtWeight.TabIndex = 4;
            // 
            // txtCalOutput
            // 
            this.txtCalOutput.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtCalOutput.Font = new System.Drawing.Font("Trebuchet MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCalOutput.Location = new System.Drawing.Point(11, 239);
            this.txtCalOutput.Margin = new System.Windows.Forms.Padding(2);
            this.txtCalOutput.Name = "txtCalOutput";
            this.txtCalOutput.ReadOnly = true;
            this.txtCalOutput.Size = new System.Drawing.Size(146, 26);
            this.txtCalOutput.TabIndex = 5;
            this.txtCalOutput.TabStop = false;
            this.txtCalOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 75);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Age (in years):";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "Weight (in lbs):";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(-2, 204);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(246, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "Recommended Daily Caloric Intake*";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnCalculate.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.Location = new System.Drawing.Point(11, 153);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(2);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(172, 35);
            this.btnCalculate.TabIndex = 5;
            this.btnCalculate.Text = "&Calculate Calories";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnExit.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(525, 373);
            this.btnExit.Margin = new System.Windows.Forms.Padding(2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 41);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "E&xit";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtRandomIn
            // 
            this.txtRandomIn.Location = new System.Drawing.Point(285, 340);
            this.txtRandomIn.Margin = new System.Windows.Forms.Padding(2);
            this.txtRandomIn.Name = "txtRandomIn";
            this.txtRandomIn.Size = new System.Drawing.Size(52, 20);
            this.txtRandomIn.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(-1, 340);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(266, 18);
            this.label5.TabIndex = 11;
            this.label5.Text = "Random number input for demonstration:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button1.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(36, 361);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 32);
            this.button1.TabIndex = 12;
            this.button1.Text = "Check DivideByZero/Overflow";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtRandomOut
            // 
            this.txtRandomOut.Location = new System.Drawing.Point(285, 396);
            this.txtRandomOut.Margin = new System.Windows.Forms.Padding(2);
            this.txtRandomOut.Name = "txtRandomOut";
            this.txtRandomOut.ReadOnly = true;
            this.txtRandomOut.Size = new System.Drawing.Size(52, 20);
            this.txtRandomOut.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Small", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-1, 396);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(274, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Random number output for demonstration:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Latham_Project3A.Properties.Resources.CalorieCounter;
            this.pictureBox1.Location = new System.Drawing.Point(245, -3);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 319);
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Small", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(162, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 19);
            this.label6.TabIndex = 16;
            this.label6.Text = "Calories";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-2, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(363, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "*Determines \"at rest baseline\", and does not account for daily activity levels";
            // 
            // frmCalorie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(624, 429);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRandomOut);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRandomIn);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCalOutput);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.grpGenderBox);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCalorie";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Calorie Counter";
            this.grpGenderBox.ResumeLayout(false);
            this.grpGenderBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpGenderBox;
        private System.Windows.Forms.RadioButton rdbFemale;
        private System.Windows.Forms.RadioButton rdbMale;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtCalOutput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtRandomIn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRandomOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

