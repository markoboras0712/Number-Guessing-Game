
namespace Programming_Language_2_Task_3
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
            this.labelNumberOfDigits = new System.Windows.Forms.Label();
            this.labelTimeRemaining = new System.Windows.Forms.Label();
            this.numberOfDigits = new System.Windows.Forms.NumericUpDown();
            this.numberOfRightDigits = new System.Windows.Forms.NumericUpDown();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelNumberOfRightDigits = new System.Windows.Forms.Label();
            this.timeRemaining = new System.Windows.Forms.Label();
            this.labelNumberOfDigitsToGuess = new System.Windows.Forms.Label();
            this.numberOfDigitsToGuess = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.repetitive = new System.Windows.Forms.CheckBox();
            this.generateNumbers = new System.Windows.Forms.Button();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.numberOfDigits)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfRightDigits)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelNumberOfDigits
            // 
            this.labelNumberOfDigits.AutoSize = true;
            this.labelNumberOfDigits.Location = new System.Drawing.Point(6, 37);
            this.labelNumberOfDigits.Name = "labelNumberOfDigits";
            this.labelNumberOfDigits.Size = new System.Drawing.Size(119, 17);
            this.labelNumberOfDigits.TabIndex = 1;
            this.labelNumberOfDigits.Text = "Number of digits :";
            // 
            // labelTimeRemaining
            // 
            this.labelTimeRemaining.AutoSize = true;
            this.labelTimeRemaining.Location = new System.Drawing.Point(6, 85);
            this.labelTimeRemaining.Name = "labelTimeRemaining";
            this.labelTimeRemaining.Size = new System.Drawing.Size(118, 17);
            this.labelTimeRemaining.TabIndex = 2;
            this.labelTimeRemaining.Text = "Remaining Time :";
            // 
            // numberOfDigits
            // 
            this.numberOfDigits.Location = new System.Drawing.Point(131, 35);
            this.numberOfDigits.Maximum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numberOfDigits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfDigits.Name = "numberOfDigits";
            this.numberOfDigits.Size = new System.Drawing.Size(120, 22);
            this.numberOfDigits.TabIndex = 4;
            this.numberOfDigits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfDigits.ValueChanged += new System.EventHandler(this.numberOfDigits_ValueChanged);
            // 
            // numberOfRightDigits
            // 
            this.numberOfRightDigits.Location = new System.Drawing.Point(443, 35);
            this.numberOfRightDigits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numberOfRightDigits.Name = "numberOfRightDigits";
            this.numberOfRightDigits.Size = new System.Drawing.Size(120, 22);
            this.numberOfRightDigits.TabIndex = 5;
            this.numberOfRightDigits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.repetitive);
            this.groupBox1.Controls.Add(this.generateNumbers);
            this.groupBox1.Controls.Add(this.panel9);
            this.groupBox1.Controls.Add(this.panel8);
            this.groupBox1.Controls.Add(this.panel7);
            this.groupBox1.Controls.Add(this.panel6);
            this.groupBox1.Controls.Add(this.textBox9);
            this.groupBox1.Controls.Add(this.textBox8);
            this.groupBox1.Controls.Add(this.textBox7);
            this.groupBox1.Controls.Add(this.panel4);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.labelNumberOfRightDigits);
            this.groupBox1.Controls.Add(this.labelNumberOfDigits);
            this.groupBox1.Controls.Add(this.numberOfDigits);
            this.groupBox1.Controls.Add(this.numberOfRightDigits);
            this.groupBox1.Controls.Add(this.labelTimeRemaining);
            this.groupBox1.Controls.Add(this.timeRemaining);
            this.groupBox1.Controls.Add(this.labelNumberOfDigitsToGuess);
            this.groupBox1.Controls.Add(this.numberOfDigitsToGuess);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Location = new System.Drawing.Point(12, 34);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(610, 315);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Number Guessing Game";
            // 
            // labelNumberOfRightDigits
            // 
            this.labelNumberOfRightDigits.AutoSize = true;
            this.labelNumberOfRightDigits.Location = new System.Drawing.Point(282, 35);
            this.labelNumberOfRightDigits.Name = "labelNumberOfRightDigits";
            this.labelNumberOfRightDigits.Size = new System.Drawing.Size(155, 17);
            this.labelNumberOfRightDigits.TabIndex = 19;
            this.labelNumberOfRightDigits.Text = "Number of right digits : ";
            // 
            // timeRemaining
            // 
            this.timeRemaining.AutoSize = true;
            this.timeRemaining.Location = new System.Drawing.Point(130, 85);
            this.timeRemaining.Name = "timeRemaining";
            this.timeRemaining.Size = new System.Drawing.Size(52, 17);
            this.timeRemaining.TabIndex = 7;
            this.timeRemaining.Text = "00 : 00";
            // 
            // labelNumberOfDigitsToGuess
            // 
            this.labelNumberOfDigitsToGuess.AutoSize = true;
            this.labelNumberOfDigitsToGuess.Location = new System.Drawing.Point(282, 85);
            this.labelNumberOfDigitsToGuess.Name = "labelNumberOfDigitsToGuess";
            this.labelNumberOfDigitsToGuess.Size = new System.Drawing.Size(186, 17);
            this.labelNumberOfDigitsToGuess.TabIndex = 8;
            this.labelNumberOfDigitsToGuess.Text = "Number of Digits to Guess : ";
            // 
            // numberOfDigitsToGuess
            // 
            this.numberOfDigitsToGuess.AutoSize = true;
            this.numberOfDigitsToGuess.Location = new System.Drawing.Point(474, 85);
            this.numberOfDigitsToGuess.Name = "numberOfDigitsToGuess";
            this.numberOfDigitsToGuess.Size = new System.Drawing.Size(16, 17);
            this.numberOfDigitsToGuess.TabIndex = 9;
            this.numberOfDigitsToGuess.Text = "0";
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(9, 132);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 45);
            this.textBox4.TabIndex = 14;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gold;
            this.panel4.Location = new System.Drawing.Point(9, 183);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(100, 26);
            this.panel4.TabIndex = 17;
            // 
            // repetitive
            // 
            this.repetitive.AutoSize = true;
            this.repetitive.Location = new System.Drawing.Point(9, 235);
            this.repetitive.Name = "repetitive";
            this.repetitive.Size = new System.Drawing.Size(105, 21);
            this.repetitive.TabIndex = 0;
            this.repetitive.Text = "Repetitive : ";
            this.repetitive.UseVisualStyleBackColor = true;
            // 
            // generateNumbers
            // 
            this.generateNumbers.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateNumbers.Location = new System.Drawing.Point(212, 235);
            this.generateNumbers.Name = "generateNumbers";
            this.generateNumbers.Size = new System.Drawing.Size(214, 52);
            this.generateNumbers.TabIndex = 18;
            this.generateNumbers.Text = "Generate Numbers";
            this.generateNumbers.UseVisualStyleBackColor = true;
            this.generateNumbers.Click += new System.EventHandler(this.generateNumbers_Click);
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.Location = new System.Drawing.Point(131, 132);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 45);
            this.textBox6.TabIndex = 20;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.Location = new System.Drawing.Point(250, 132);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(100, 45);
            this.textBox7.TabIndex = 21;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.Location = new System.Drawing.Point(368, 132);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(100, 45);
            this.textBox8.TabIndex = 22;
            this.textBox8.TextChanged += new System.EventHandler(this.textBox8_TextChanged);
            // 
            // textBox9
            // 
            this.textBox9.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox9.Location = new System.Drawing.Point(487, 132);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(100, 45);
            this.textBox9.TabIndex = 23;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Gold;
            this.panel6.Location = new System.Drawing.Point(133, 183);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(100, 26);
            this.panel6.TabIndex = 18;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gold;
            this.panel7.Location = new System.Drawing.Point(250, 183);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(100, 26);
            this.panel7.TabIndex = 19;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Gold;
            this.panel8.Location = new System.Drawing.Point(368, 183);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(100, 26);
            this.panel8.TabIndex = 20;
            // 
            // panel9
            // 
            this.panel9.BackColor = System.Drawing.Color.Gold;
            this.panel9.Location = new System.Drawing.Point(487, 183);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(100, 26);
            this.panel9.TabIndex = 21;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 390);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numberOfDigits)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numberOfRightDigits)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelNumberOfDigits;
        private System.Windows.Forms.Label labelTimeRemaining;
        private System.Windows.Forms.NumericUpDown numberOfDigits;
        private System.Windows.Forms.NumericUpDown numberOfRightDigits;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label timeRemaining;
        private System.Windows.Forms.Label labelNumberOfDigitsToGuess;
        private System.Windows.Forms.Label numberOfDigitsToGuess;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox repetitive;
        private System.Windows.Forms.Button generateNumbers;
        private System.Windows.Forms.Label labelNumberOfRightDigits;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
    }
}

