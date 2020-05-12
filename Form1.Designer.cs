namespace Max_Laba_WindowsForm_ComplexNumber
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
            this.textBoxCN1Rl = new System.Windows.Forms.TextBox();
            this.textBoxCN1Im = new System.Windows.Forms.TextBox();
            this.textBoxCN2Rl = new System.Windows.Forms.TextBox();
            this.textBoxCN2Im = new System.Windows.Forms.TextBox();
            this.textBoxCN3Rl = new System.Windows.Forms.TextBox();
            this.textBoxCN3Im = new System.Windows.Forms.TextBox();
            this.textBoxCN4Rl = new System.Windows.Forms.TextBox();
            this.textBoxCN4Im = new System.Windows.Forms.TextBox();
            this.buttonRandom = new System.Windows.Forms.Button();
            this.buttonInfa = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonOpen = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonResult = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // textBoxCN1Rl
            // 
            this.textBoxCN1Rl.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxCN1Rl.Location = new System.Drawing.Point(0, 0);
            this.textBoxCN1Rl.Name = "textBoxCN1Rl";
            this.textBoxCN1Rl.Size = new System.Drawing.Size(100, 22);
            this.textBoxCN1Rl.TabIndex = 0;
            this.textBoxCN1Rl.Text = "FirstReal";
            // 
            // textBoxCN1Im
            // 
            this.textBoxCN1Im.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxCN1Im.Location = new System.Drawing.Point(0, 28);
            this.textBoxCN1Im.Name = "textBoxCN1Im";
            this.textBoxCN1Im.Size = new System.Drawing.Size(100, 22);
            this.textBoxCN1Im.TabIndex = 0;
            this.textBoxCN1Im.Text = "FirstImaginary";
            // 
            // textBoxCN2Rl
            // 
            this.textBoxCN2Rl.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxCN2Rl.Location = new System.Drawing.Point(0, 69);
            this.textBoxCN2Rl.Name = "textBoxCN2Rl";
            this.textBoxCN2Rl.Size = new System.Drawing.Size(100, 22);
            this.textBoxCN2Rl.TabIndex = 0;
            this.textBoxCN2Rl.Text = "SecondReal";
            // 
            // textBoxCN2Im
            // 
            this.textBoxCN2Im.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxCN2Im.Location = new System.Drawing.Point(0, 97);
            this.textBoxCN2Im.Name = "textBoxCN2Im";
            this.textBoxCN2Im.Size = new System.Drawing.Size(100, 22);
            this.textBoxCN2Im.TabIndex = 0;
            this.textBoxCN2Im.Text = "SecondImaginary";
            // 
            // textBoxCN3Rl
            // 
            this.textBoxCN3Rl.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxCN3Rl.Location = new System.Drawing.Point(0, 137);
            this.textBoxCN3Rl.Name = "textBoxCN3Rl";
            this.textBoxCN3Rl.Size = new System.Drawing.Size(100, 22);
            this.textBoxCN3Rl.TabIndex = 0;
            this.textBoxCN3Rl.Text = "ThirdReal";
            // 
            // textBoxCN3Im
            // 
            this.textBoxCN3Im.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxCN3Im.Location = new System.Drawing.Point(0, 165);
            this.textBoxCN3Im.Name = "textBoxCN3Im";
            this.textBoxCN3Im.Size = new System.Drawing.Size(100, 22);
            this.textBoxCN3Im.TabIndex = 0;
            this.textBoxCN3Im.Text = "ThirdImaginary";
            // 
            // textBoxCN4Rl
            // 
            this.textBoxCN4Rl.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxCN4Rl.Location = new System.Drawing.Point(0, 205);
            this.textBoxCN4Rl.Name = "textBoxCN4Rl";
            this.textBoxCN4Rl.Size = new System.Drawing.Size(100, 22);
            this.textBoxCN4Rl.TabIndex = 0;
            this.textBoxCN4Rl.Text = "FourthReal";
            // 
            // textBoxCN4Im
            // 
            this.textBoxCN4Im.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.textBoxCN4Im.Location = new System.Drawing.Point(0, 233);
            this.textBoxCN4Im.Name = "textBoxCN4Im";
            this.textBoxCN4Im.Size = new System.Drawing.Size(100, 22);
            this.textBoxCN4Im.TabIndex = 0;
            this.textBoxCN4Im.Text = "FourthImaginary";
            // 
            // buttonRandom
            // 
            this.buttonRandom.Location = new System.Drawing.Point(106, 0);
            this.buttonRandom.Name = "buttonRandom";
            this.buttonRandom.Size = new System.Drawing.Size(100, 50);
            this.buttonRandom.TabIndex = 1;
            this.buttonRandom.Text = "Random";
            this.buttonRandom.UseVisualStyleBackColor = true;
            this.buttonRandom.Click += new System.EventHandler(this.buttonRandom_Click);
            // 
            // buttonInfa
            // 
            this.buttonInfa.Location = new System.Drawing.Point(106, 69);
            this.buttonInfa.Name = "buttonInfa";
            this.buttonInfa.Size = new System.Drawing.Size(100, 50);
            this.buttonInfa.TabIndex = 1;
            this.buttonInfa.Text = "button1";
            this.buttonInfa.UseVisualStyleBackColor = true;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(106, 137);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(100, 50);
            this.buttonSave.TabIndex = 1;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonOpen
            // 
            this.buttonOpen.Location = new System.Drawing.Point(106, 205);
            this.buttonOpen.Name = "buttonOpen";
            this.buttonOpen.Size = new System.Drawing.Size(100, 50);
            this.buttonOpen.TabIndex = 1;
            this.buttonOpen.Text = "button1";
            this.buttonOpen.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(106, 69);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 50);
            this.button1.TabIndex = 1;
            this.button1.Text = "Information";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(106, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(100, 50);
            this.button2.TabIndex = 1;
            this.button2.Text = "Open";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonResult
            // 
            this.buttonResult.Location = new System.Drawing.Point(212, 69);
            this.buttonResult.Name = "buttonResult";
            this.buttonResult.Size = new System.Drawing.Size(100, 118);
            this.buttonResult.TabIndex = 1;
            this.buttonResult.Text = "R=b^3+(a+b)*d/(c-a)";
            this.buttonResult.UseVisualStyleBackColor = true;
            this.buttonResult.Click += new System.EventHandler(this.buttonResult_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(314, 264);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.buttonOpen);
            this.Controls.Add(this.buttonResult);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonInfa);
            this.Controls.Add(this.buttonRandom);
            this.Controls.Add(this.textBoxCN4Im);
            this.Controls.Add(this.textBoxCN4Rl);
            this.Controls.Add(this.textBoxCN2Im);
            this.Controls.Add(this.textBoxCN3Im);
            this.Controls.Add(this.textBoxCN2Rl);
            this.Controls.Add(this.textBoxCN3Rl);
            this.Controls.Add(this.textBoxCN1Im);
            this.Controls.Add(this.textBoxCN1Rl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxCN1Rl;
        private System.Windows.Forms.TextBox textBoxCN1Im;
        private System.Windows.Forms.TextBox textBoxCN2Rl;
        private System.Windows.Forms.TextBox textBoxCN2Im;
        private System.Windows.Forms.TextBox textBoxCN3Rl;
        private System.Windows.Forms.TextBox textBoxCN3Im;
        private System.Windows.Forms.TextBox textBoxCN4Rl;
        private System.Windows.Forms.TextBox textBoxCN4Im;
        private System.Windows.Forms.Button buttonRandom;
        private System.Windows.Forms.Button buttonInfa;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonOpen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonResult;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}

