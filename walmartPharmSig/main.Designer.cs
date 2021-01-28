
namespace walmartPharmSig
{
    partial class main
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
            this.Simple = new System.Windows.Forms.Button();
            this.Advanced = new System.Windows.Forms.Button();
            this.addRemoveButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Simple
            // 
            this.Simple.Location = new System.Drawing.Point(106, 255);
            this.Simple.Name = "Simple";
            this.Simple.Size = new System.Drawing.Size(125, 49);
            this.Simple.TabIndex = 0;
            this.Simple.Text = "All Sigs";
            this.Simple.UseVisualStyleBackColor = true;
            this.Simple.Click += new System.EventHandler(this.Simple_Click_1);
            // 
            // Advanced
            // 
            this.Advanced.Location = new System.Drawing.Point(311, 255);
            this.Advanced.Name = "Advanced";
            this.Advanced.Size = new System.Drawing.Size(132, 70);
            this.Advanced.TabIndex = 1;
            this.Advanced.Text = "Common Sigs";
            this.Advanced.UseVisualStyleBackColor = true;
            this.Advanced.Click += new System.EventHandler(this.Advanced_Click);
            // 
            // addRemoveButton
            // 
            this.addRemoveButton.Location = new System.Drawing.Point(499, 255);
            this.addRemoveButton.Name = "addRemoveButton";
            this.addRemoveButton.Size = new System.Drawing.Size(176, 49);
            this.addRemoveButton.TabIndex = 2;
            this.addRemoveButton.Text = "Add/Remove Sigs";
            this.addRemoveButton.UseVisualStyleBackColor = true;
            this.addRemoveButton.Click += new System.EventHandler(this.addRemoveButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.ForeColor = System.Drawing.Color.Maroon;
            this.errorLabel.Location = new System.Drawing.Point(158, 93);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(517, 121);
            this.errorLabel.TabIndex = 3;
            this.errorLabel.Text = "No Questions were available for Common Sigs. Go to the main menu->add/remove and " +
    "add questions to Common Sigs as desired or redownload program with default quest" +
    "ions";
            this.errorLabel.Visible = false;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.addRemoveButton);
            this.Controls.Add(this.Advanced);
            this.Controls.Add(this.Simple);
            this.Name = "main";
            this.Size = new System.Drawing.Size(822, 650);
            this.Load += new System.EventHandler(this.main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Simple;
        private System.Windows.Forms.Button Advanced;
        private System.Windows.Forms.Button addRemoveButton;
        private System.Windows.Forms.Label errorLabel;
    }
}
