namespace ProjectEuler
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
            this.getProblemBtn = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.problemText = new System.Windows.Forms.RichTextBox();
            this.problemInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.errorText = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.userAnswerText = new System.Windows.Forms.TextBox();
            this.checkAnswerBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // getProblemBtn
            // 
            this.getProblemBtn.Location = new System.Drawing.Point(631, 21);
            this.getProblemBtn.Name = "getProblemBtn";
            this.getProblemBtn.Size = new System.Drawing.Size(75, 23);
            this.getProblemBtn.TabIndex = 0;
            this.getProblemBtn.Text = "Get Problem";
            this.getProblemBtn.UseVisualStyleBackColor = true;
            this.getProblemBtn.Click += new System.EventHandler(this.getProblemBtn_Click);
            // 
            // closeButton
            // 
            this.closeButton.Location = new System.Drawing.Point(704, 415);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(75, 23);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "Close";
            this.closeButton.UseVisualStyleBackColor = true;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // problemText
            // 
            this.problemText.Location = new System.Drawing.Point(344, 70);
            this.problemText.Name = "problemText";
            this.problemText.ReadOnly = true;
            this.problemText.Size = new System.Drawing.Size(362, 227);
            this.problemText.TabIndex = 4;
            this.problemText.Text = "";
            // 
            // problemInput
            // 
            this.problemInput.Location = new System.Drawing.Point(435, 21);
            this.problemInput.Name = "problemInput";
            this.problemInput.Size = new System.Drawing.Size(39, 20);
            this.problemInput.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(341, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Problem Number:";
            // 
            // errorText
            // 
            this.errorText.ForeColor = System.Drawing.Color.Crimson;
            this.errorText.Location = new System.Drawing.Point(69, 70);
            this.errorText.Name = "errorText";
            this.errorText.ReadOnly = true;
            this.errorText.Size = new System.Drawing.Size(227, 227);
            this.errorText.TabIndex = 7;
            this.errorText.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Type your answer here:";
            // 
            // userAnswerText
            // 
            this.userAnswerText.Location = new System.Drawing.Point(187, 354);
            this.userAnswerText.Name = "userAnswerText";
            this.userAnswerText.Size = new System.Drawing.Size(139, 20);
            this.userAnswerText.TabIndex = 9;
            // 
            // checkAnswerBtn
            // 
            this.checkAnswerBtn.Location = new System.Drawing.Point(354, 354);
            this.checkAnswerBtn.Name = "checkAnswerBtn";
            this.checkAnswerBtn.Size = new System.Drawing.Size(93, 23);
            this.checkAnswerBtn.TabIndex = 10;
            this.checkAnswerBtn.Text = "Check answer";
            this.checkAnswerBtn.UseVisualStyleBackColor = true;
            this.checkAnswerBtn.Click += new System.EventHandler(this.checkAnswerBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkAnswerBtn);
            this.Controls.Add(this.userAnswerText);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.errorText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.problemInput);
            this.Controls.Add(this.problemText);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.getProblemBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button getProblemBtn;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.RichTextBox problemText;
        private System.Windows.Forms.TextBox problemInput;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox errorText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox userAnswerText;
        private System.Windows.Forms.Button checkAnswerBtn;
    }
}

