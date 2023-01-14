namespace WordGuessingGame
{
    partial class WordGuessingForm
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
            this.lblWords = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.btnGuess = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNew = new System.Windows.Forms.Button();
            this.lblHints = new System.Windows.Forms.Label();
            this.lbWrongGuess = new System.Windows.Forms.ListBox();
            this.lblAttemps = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblWords
            // 
            this.lblWords.BackColor = System.Drawing.Color.LightSalmon;
            this.lblWords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblWords.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblWords.Font = new System.Drawing.Font("Arial Rounded MT Bold", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblWords.Location = new System.Drawing.Point(12, 9);
            this.lblWords.Name = "lblWords";
            this.lblWords.Size = new System.Drawing.Size(505, 175);
            this.lblWords.TabIndex = 0;
            this.lblWords.Text = "WORD";
            this.lblWords.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.Color.Black;
            this.txtInput.Font = new System.Drawing.Font("Arial Rounded MT Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtInput.ForeColor = System.Drawing.Color.White;
            this.txtInput.Location = new System.Drawing.Point(12, 211);
            this.txtInput.Name = "txtInput";
            this.txtInput.PlaceholderText = "Enter Word";
            this.txtInput.Size = new System.Drawing.Size(505, 48);
            this.txtInput.TabIndex = 1;
            this.txtInput.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnGuess
            // 
            this.btnGuess.BackColor = System.Drawing.Color.Black;
            this.btnGuess.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnGuess.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnGuess.ForeColor = System.Drawing.Color.White;
            this.btnGuess.Location = new System.Drawing.Point(185, 280);
            this.btnGuess.Name = "btnGuess";
            this.btnGuess.Size = new System.Drawing.Size(158, 55);
            this.btnGuess.TabIndex = 2;
            this.btnGuess.Text = "Guess";
            this.btnGuess.UseVisualStyleBackColor = false;
            this.btnGuess.Click += new System.EventHandler(this.btnGuess_Click);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.LightSalmon;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(523, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 56);
            this.label2.TabIndex = 3;
            this.label2.Text = "Wrong Guess";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.Black;
            this.btnNew.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnNew.ForeColor = System.Drawing.Color.White;
            this.btnNew.Location = new System.Drawing.Point(12, 281);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(145, 55);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "New Word";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // lblHints
            // 
            this.lblHints.BackColor = System.Drawing.Color.LightSalmon;
            this.lblHints.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblHints.ForeColor = System.Drawing.Color.Black;
            this.lblHints.Location = new System.Drawing.Point(27, 145);
            this.lblHints.Name = "lblHints";
            this.lblHints.Size = new System.Drawing.Size(476, 32);
            this.lblHints.TabIndex = 6;
            this.lblHints.Text = "*Hint*";
            this.lblHints.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbWrongGuess
            // 
            this.lbWrongGuess.BackColor = System.Drawing.Color.Black;
            this.lbWrongGuess.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lbWrongGuess.ForeColor = System.Drawing.Color.White;
            this.lbWrongGuess.FormattingEnabled = true;
            this.lbWrongGuess.ItemHeight = 22;
            this.lbWrongGuess.Location = new System.Drawing.Point(523, 68);
            this.lbWrongGuess.MultiColumn = true;
            this.lbWrongGuess.Name = "lbWrongGuess";
            this.lbWrongGuess.Size = new System.Drawing.Size(192, 268);
            this.lbWrongGuess.TabIndex = 7;
            // 
            // lblAttemps
            // 
            this.lblAttemps.AutoEllipsis = true;
            this.lblAttemps.BackColor = System.Drawing.Color.LightSalmon;
            this.lblAttemps.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAttemps.ForeColor = System.Drawing.Color.Black;
            this.lblAttemps.Location = new System.Drawing.Point(369, 281);
            this.lblAttemps.Name = "lblAttemps";
            this.lblAttemps.Size = new System.Drawing.Size(148, 54);
            this.lblAttemps.TabIndex = 8;
            this.lblAttemps.Text = "Attempts: ";
            this.lblAttemps.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WordGuessingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(727, 345);
            this.Controls.Add(this.lblAttemps);
            this.Controls.Add(this.lbWrongGuess);
            this.Controls.Add(this.lblHints);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGuess);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblWords);
            this.Name = "WordGuessingForm";
            this.Text = "Word Guessing Game";
            this.Load += new System.EventHandler(this.WordGuessingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblWords;
        private TextBox txtInput;
        private Button btnGuess;
        private Label label2;
        private Button btnNew;
        private Label lblHints;
        private ListBox lbWrongGuess;
        private Label lblAttemps;
    }
}