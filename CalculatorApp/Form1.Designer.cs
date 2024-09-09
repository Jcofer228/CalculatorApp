namespace CalculatorApp
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
            this.btnON = new System.Windows.Forms.Button();
            this.calculatorDisplay = new System.Windows.Forms.Label();
            this.btnDivide = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnOFF = new System.Windows.Forms.Button();
            this.btnEight = new System.Windows.Forms.Button();
            this.btnNine = new System.Windows.Forms.Button();
            this.btnTimes = new System.Windows.Forms.Button();
            this.btnSeven = new System.Windows.Forms.Button();
            this.btnFive = new System.Windows.Forms.Button();
            this.btnSix = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.btnFour = new System.Windows.Forms.Button();
            this.btnTwo = new System.Windows.Forms.Button();
            this.btnThree = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnOne = new System.Windows.Forms.Button();
            this.btnZero = new System.Windows.Forms.Button();
            this.btnDecimal = new System.Windows.Forms.Button();
            this.btnEquals = new System.Windows.Forms.Button();
            this.btnPlusMinus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnON
            // 
            this.btnON.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnON.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnON.Location = new System.Drawing.Point(12, 95);
            this.btnON.Name = "btnON";
            this.btnON.Size = new System.Drawing.Size(83, 56);
            this.btnON.TabIndex = 0;
            this.btnON.Text = "ON";
            this.btnON.UseVisualStyleBackColor = false;
            this.btnON.Click += new System.EventHandler(this.btnON_Click);
            // 
            // calculatorDisplay
            // 
            this.calculatorDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.calculatorDisplay.Location = new System.Drawing.Point(12, 9);
            this.calculatorDisplay.Name = "calculatorDisplay";
            this.calculatorDisplay.Size = new System.Drawing.Size(335, 73);
            this.calculatorDisplay.TabIndex = 1;
            this.calculatorDisplay.Text = "0";
            this.calculatorDisplay.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // btnDivide
            // 
            this.btnDivide.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnDivide.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDivide.Location = new System.Drawing.Point(264, 95);
            this.btnDivide.Name = "btnDivide";
            this.btnDivide.Size = new System.Drawing.Size(83, 56);
            this.btnDivide.TabIndex = 7;
            this.btnDivide.Text = "/";
            this.btnDivide.UseVisualStyleBackColor = false;
            this.btnDivide.Click += new System.EventHandler(this.btnDivide_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnClear.Location = new System.Drawing.Point(180, 95);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(83, 56);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "AC";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnOFF
            // 
            this.btnOFF.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnOFF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnOFF.Location = new System.Drawing.Point(96, 95);
            this.btnOFF.Name = "btnOFF";
            this.btnOFF.Size = new System.Drawing.Size(83, 56);
            this.btnOFF.TabIndex = 9;
            this.btnOFF.Text = "OFF";
            this.btnOFF.UseVisualStyleBackColor = false;
            this.btnOFF.Click += new System.EventHandler(this.btnOFF_Click);
            // 
            // btnEight
            // 
            this.btnEight.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEight.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEight.Location = new System.Drawing.Point(96, 152);
            this.btnEight.Name = "btnEight";
            this.btnEight.Size = new System.Drawing.Size(83, 56);
            this.btnEight.TabIndex = 13;
            this.btnEight.Text = "8";
            this.btnEight.UseVisualStyleBackColor = false;
            this.btnEight.Click += new System.EventHandler(this.btnEight_Click);
            // 
            // btnNine
            // 
            this.btnNine.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnNine.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnNine.Location = new System.Drawing.Point(180, 152);
            this.btnNine.Name = "btnNine";
            this.btnNine.Size = new System.Drawing.Size(83, 56);
            this.btnNine.TabIndex = 12;
            this.btnNine.Text = "9";
            this.btnNine.UseVisualStyleBackColor = false;
            this.btnNine.Click += new System.EventHandler(this.btnNine_Click);
            // 
            // btnTimes
            // 
            this.btnTimes.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnTimes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTimes.Location = new System.Drawing.Point(264, 152);
            this.btnTimes.Name = "btnTimes";
            this.btnTimes.Size = new System.Drawing.Size(83, 56);
            this.btnTimes.TabIndex = 11;
            this.btnTimes.Text = "x";
            this.btnTimes.UseVisualStyleBackColor = false;
            this.btnTimes.Click += new System.EventHandler(this.btnTimes_Click);
            // 
            // btnSeven
            // 
            this.btnSeven.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSeven.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSeven.Location = new System.Drawing.Point(12, 152);
            this.btnSeven.Name = "btnSeven";
            this.btnSeven.Size = new System.Drawing.Size(83, 56);
            this.btnSeven.TabIndex = 10;
            this.btnSeven.Text = "7";
            this.btnSeven.UseVisualStyleBackColor = false;
            this.btnSeven.Click += new System.EventHandler(this.btnSeven_Click);
            // 
            // btnFive
            // 
            this.btnFive.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFive.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFive.Location = new System.Drawing.Point(96, 209);
            this.btnFive.Name = "btnFive";
            this.btnFive.Size = new System.Drawing.Size(83, 56);
            this.btnFive.TabIndex = 17;
            this.btnFive.Text = "5";
            this.btnFive.UseVisualStyleBackColor = false;
            this.btnFive.Click += new System.EventHandler(this.btnFive_Click);
            // 
            // btnSix
            // 
            this.btnSix.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSix.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnSix.Location = new System.Drawing.Point(180, 209);
            this.btnSix.Name = "btnSix";
            this.btnSix.Size = new System.Drawing.Size(83, 56);
            this.btnSix.TabIndex = 16;
            this.btnSix.Text = "6";
            this.btnSix.UseVisualStyleBackColor = false;
            this.btnSix.Click += new System.EventHandler(this.btnSix_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.btnMinus.Location = new System.Drawing.Point(264, 209);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(83, 56);
            this.btnMinus.TabIndex = 15;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // btnFour
            // 
            this.btnFour.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnFour.Location = new System.Drawing.Point(12, 209);
            this.btnFour.Name = "btnFour";
            this.btnFour.Size = new System.Drawing.Size(83, 56);
            this.btnFour.TabIndex = 14;
            this.btnFour.Text = "4";
            this.btnFour.UseVisualStyleBackColor = false;
            this.btnFour.Click += new System.EventHandler(this.btnFour_Click);
            // 
            // btnTwo
            // 
            this.btnTwo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnTwo.Location = new System.Drawing.Point(96, 266);
            this.btnTwo.Name = "btnTwo";
            this.btnTwo.Size = new System.Drawing.Size(83, 56);
            this.btnTwo.TabIndex = 21;
            this.btnTwo.Text = "2";
            this.btnTwo.UseVisualStyleBackColor = false;
            this.btnTwo.Click += new System.EventHandler(this.btnTwo_Click);
            // 
            // btnThree
            // 
            this.btnThree.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnThree.Location = new System.Drawing.Point(180, 266);
            this.btnThree.Name = "btnThree";
            this.btnThree.Size = new System.Drawing.Size(83, 56);
            this.btnThree.TabIndex = 20;
            this.btnThree.Text = "3";
            this.btnThree.UseVisualStyleBackColor = false;
            this.btnThree.Click += new System.EventHandler(this.btnThree_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.btnPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPlus.Location = new System.Drawing.Point(264, 266);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(83, 56);
            this.btnPlus.TabIndex = 19;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = false;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnOne
            // 
            this.btnOne.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnOne.Location = new System.Drawing.Point(12, 266);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(83, 56);
            this.btnOne.TabIndex = 18;
            this.btnOne.Text = "1";
            this.btnOne.UseVisualStyleBackColor = false;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // btnZero
            // 
            this.btnZero.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnZero.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnZero.Location = new System.Drawing.Point(96, 324);
            this.btnZero.Name = "btnZero";
            this.btnZero.Size = new System.Drawing.Size(83, 56);
            this.btnZero.TabIndex = 25;
            this.btnZero.Text = "0";
            this.btnZero.UseVisualStyleBackColor = false;
            this.btnZero.Click += new System.EventHandler(this.btnZero_Click);
            // 
            // btnDecimal
            // 
            this.btnDecimal.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDecimal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnDecimal.Location = new System.Drawing.Point(180, 324);
            this.btnDecimal.Name = "btnDecimal";
            this.btnDecimal.Size = new System.Drawing.Size(83, 56);
            this.btnDecimal.TabIndex = 24;
            this.btnDecimal.Text = ".";
            this.btnDecimal.UseVisualStyleBackColor = false;
            this.btnDecimal.Click += new System.EventHandler(this.btnDecimal_Click);
            // 
            // btnEquals
            // 
            this.btnEquals.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnEquals.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEquals.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEquals.Location = new System.Drawing.Point(264, 324);
            this.btnEquals.Name = "btnEquals";
            this.btnEquals.Size = new System.Drawing.Size(83, 56);
            this.btnEquals.TabIndex = 23;
            this.btnEquals.Text = "=";
            this.btnEquals.UseVisualStyleBackColor = false;
            this.btnEquals.Click += new System.EventHandler(this.btnEquals_Click);
            // 
            // btnPlusMinus
            // 
            this.btnPlusMinus.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlusMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnPlusMinus.Location = new System.Drawing.Point(12, 324);
            this.btnPlusMinus.Name = "btnPlusMinus";
            this.btnPlusMinus.Size = new System.Drawing.Size(83, 56);
            this.btnPlusMinus.TabIndex = 22;
            this.btnPlusMinus.Text = "+/-";
            this.btnPlusMinus.UseVisualStyleBackColor = false;
            this.btnPlusMinus.Click += new System.EventHandler(this.btnPlusMinus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 386);
            this.Controls.Add(this.btnZero);
            this.Controls.Add(this.btnDecimal);
            this.Controls.Add(this.btnEquals);
            this.Controls.Add(this.btnPlusMinus);
            this.Controls.Add(this.btnTwo);
            this.Controls.Add(this.btnThree);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnOne);
            this.Controls.Add(this.btnFive);
            this.Controls.Add(this.btnSix);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnFour);
            this.Controls.Add(this.btnEight);
            this.Controls.Add(this.btnNine);
            this.Controls.Add(this.btnTimes);
            this.Controls.Add(this.btnSeven);
            this.Controls.Add(this.btnOFF);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnDivide);
            this.Controls.Add(this.calculatorDisplay);
            this.Controls.Add(this.btnON);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnON;
        private System.Windows.Forms.Label calculatorDisplay;
        private System.Windows.Forms.Button btnDivide;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnOFF;
        private System.Windows.Forms.Button btnEight;
        private System.Windows.Forms.Button btnNine;
        private System.Windows.Forms.Button btnTimes;
        private System.Windows.Forms.Button btnSeven;
        private System.Windows.Forms.Button btnFive;
        private System.Windows.Forms.Button btnSix;
        private System.Windows.Forms.Button btnMinus;
        private System.Windows.Forms.Button btnFour;
        private System.Windows.Forms.Button btnTwo;
        private System.Windows.Forms.Button btnThree;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Button btnZero;
        private System.Windows.Forms.Button btnDecimal;
        private System.Windows.Forms.Button btnEquals;
        private System.Windows.Forms.Button btnPlusMinus;
    }
}

