
namespace walmartPharmSig
{
    partial class sectionTest
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Submit = new System.Windows.Forms.Button();
            this.skip = new System.Windows.Forms.Button();
            this.Next = new System.Windows.Forms.Button();
            this.goBack = new System.Windows.Forms.Button();
            this.toMainMenu = new System.Windows.Forms.Button();
            this.titleLabel = new System.Windows.Forms.Label();
            this.directions = new System.Windows.Forms.Label();
            this.sigLabel = new System.Windows.Forms.Label();
            this.userAnswerTextBox = new System.Windows.Forms.TextBox();
            this.questionCount = new System.Windows.Forms.Label();
            this.rightWrong = new System.Windows.Forms.Label();
            this.answer = new System.Windows.Forms.Label();
            this.restart = new System.Windows.Forms.Button();
            this.notSkippedLabel = new System.Windows.Forms.Label();
            this.firstTimeCorrect = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(94, 253);
            this.Submit.Margin = new System.Windows.Forms.Padding(2);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(92, 34);
            this.Submit.TabIndex = 0;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Submit_Click);
            // 
            // skip
            // 
            this.skip.Location = new System.Drawing.Point(246, 253);
            this.skip.Margin = new System.Windows.Forms.Padding(2);
            this.skip.Name = "skip";
            this.skip.Size = new System.Drawing.Size(85, 34);
            this.skip.TabIndex = 1;
            this.skip.Text = "Skip";
            this.skip.UseVisualStyleBackColor = true;
            this.skip.Click += new System.EventHandler(this.skip_Click);
            // 
            // Next
            // 
            this.Next.Enabled = false;
            this.Next.Location = new System.Drawing.Point(408, 253);
            this.Next.Margin = new System.Windows.Forms.Padding(2);
            this.Next.Name = "Next";
            this.Next.Size = new System.Drawing.Size(94, 34);
            this.Next.TabIndex = 2;
            this.Next.Text = "Next";
            this.Next.UseVisualStyleBackColor = true;
            this.Next.Click += new System.EventHandler(this.Next_Click);
            // 
            // goBack
            // 
            this.goBack.Location = new System.Drawing.Point(98, 306);
            this.goBack.Margin = new System.Windows.Forms.Padding(2);
            this.goBack.Name = "goBack";
            this.goBack.Size = new System.Drawing.Size(88, 35);
            this.goBack.TabIndex = 3;
            this.goBack.Text = "Options";
            this.goBack.UseVisualStyleBackColor = true;
            this.goBack.Click += new System.EventHandler(this.goBack_Click);
            // 
            // toMainMenu
            // 
            this.toMainMenu.Location = new System.Drawing.Point(242, 305);
            this.toMainMenu.Margin = new System.Windows.Forms.Padding(2);
            this.toMainMenu.Name = "toMainMenu";
            this.toMainMenu.Size = new System.Drawing.Size(89, 36);
            this.toMainMenu.TabIndex = 4;
            this.toMainMenu.Text = "Main Menu";
            this.toMainMenu.UseVisualStyleBackColor = true;
            this.toMainMenu.Click += new System.EventHandler(this.toMainMenu_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(239, 23);
            this.titleLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(57, 15);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "TitleLabel";
            // 
            // directions
            // 
            this.directions.Location = new System.Drawing.Point(92, 109);
            this.directions.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.directions.Name = "directions";
            this.directions.Size = new System.Drawing.Size(431, 60);
            this.directions.TabIndex = 6;
            this.directions.Text = "directions will be placed here";
            // 
            // sigLabel
            // 
            this.sigLabel.AutoSize = true;
            this.sigLabel.Location = new System.Drawing.Point(46, 197);
            this.sigLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.sigLabel.Name = "sigLabel";
            this.sigLabel.Size = new System.Drawing.Size(26, 15);
            this.sigLabel.TabIndex = 7;
            this.sigLabel.Text = "Sig:";
            // 
            // userAnswerTextBox
            // 
            this.userAnswerTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.userAnswerTextBox.Location = new System.Drawing.Point(108, 193);
            this.userAnswerTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.userAnswerTextBox.Name = "userAnswerTextBox";
            this.userAnswerTextBox.Size = new System.Drawing.Size(234, 23);
            this.userAnswerTextBox.TabIndex = 8;
            // 
            // questionCount
            // 
            this.questionCount.AutoSize = true;
            this.questionCount.Location = new System.Drawing.Point(49, 52);
            this.questionCount.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.questionCount.Name = "questionCount";
            this.questionCount.Size = new System.Drawing.Size(86, 15);
            this.questionCount.TabIndex = 9;
            this.questionCount.Text = "questionCount";
            // 
            // rightWrong
            // 
            this.rightWrong.AutoSize = true;
            this.rightWrong.Location = new System.Drawing.Point(46, 226);
            this.rightWrong.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.rightWrong.Name = "rightWrong";
            this.rightWrong.Size = new System.Drawing.Size(46, 15);
            this.rightWrong.TabIndex = 10;
            this.rightWrong.Text = "Correct";
            this.rightWrong.Visible = false;
            // 
            // answer
            // 
            this.answer.AutoSize = true;
            this.answer.Location = new System.Drawing.Point(108, 169);
            this.answer.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.answer.Name = "answer";
            this.answer.Size = new System.Drawing.Size(147, 15);
            this.answer.TabIndex = 11;
            this.answer.Text = "Answer will be placed here";
            this.answer.Visible = false;
            // 
            // restart
            // 
            this.restart.Location = new System.Drawing.Point(408, 305);
            this.restart.Margin = new System.Windows.Forms.Padding(2);
            this.restart.Name = "restart";
            this.restart.Size = new System.Drawing.Size(94, 36);
            this.restart.TabIndex = 12;
            this.restart.Text = "Restart";
            this.restart.UseVisualStyleBackColor = true;
            this.restart.Visible = false;
            this.restart.Click += new System.EventHandler(this.restart_Click);
            // 
            // notSkippedLabel
            // 
            this.notSkippedLabel.AutoSize = true;
            this.notSkippedLabel.Location = new System.Drawing.Point(223, 52);
            this.notSkippedLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.notSkippedLabel.Name = "notSkippedLabel";
            this.notSkippedLabel.Size = new System.Drawing.Size(107, 15);
            this.notSkippedLabel.TabIndex = 13;
            this.notSkippedLabel.Text = "Not Skipped: 0 of 0";
            // 
            // firstTimeCorrect
            // 
            this.firstTimeCorrect.AutoSize = true;
            this.firstTimeCorrect.Location = new System.Drawing.Point(379, 52);
            this.firstTimeCorrect.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstTimeCorrect.Name = "firstTimeCorrect";
            this.firstTimeCorrect.Size = new System.Drawing.Size(135, 15);
            this.firstTimeCorrect.TabIndex = 14;
            this.firstTimeCorrect.Text = "First Time Correct: 0 of 0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 109);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "Exp Sig:";
            // 
            // sectionTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.firstTimeCorrect);
            this.Controls.Add(this.notSkippedLabel);
            this.Controls.Add(this.restart);
            this.Controls.Add(this.answer);
            this.Controls.Add(this.rightWrong);
            this.Controls.Add(this.questionCount);
            this.Controls.Add(this.userAnswerTextBox);
            this.Controls.Add(this.sigLabel);
            this.Controls.Add(this.directions);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.toMainMenu);
            this.Controls.Add(this.goBack);
            this.Controls.Add(this.Next);
            this.Controls.Add(this.skip);
            this.Controls.Add(this.Submit);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "sectionTest";
            this.Size = new System.Drawing.Size(575, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Button skip;
        private System.Windows.Forms.Button Next;
        private System.Windows.Forms.Button goBack;
        private System.Windows.Forms.Button toMainMenu;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label directions;
        private System.Windows.Forms.Label sigLabel;
        private System.Windows.Forms.TextBox userAnswerTextBox;
        private System.Windows.Forms.Label questionCount;
        private System.Windows.Forms.Label rightWrong;
        private System.Windows.Forms.Label answer;
        private System.Windows.Forms.Button restart;
        private System.Windows.Forms.Label notSkippedLabel;
        private System.Windows.Forms.Label firstTimeCorrect;
        private System.Windows.Forms.Label label1;
    }
}
