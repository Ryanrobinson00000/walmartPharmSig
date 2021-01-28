
namespace walmartPharmSig
{
    partial class modifyFiles
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
            this.expSigBox = new System.Windows.Forms.TextBox();
            this.sigBox = new System.Windows.Forms.TextBox();
            this.expSig = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addToList = new System.Windows.Forms.Button();
            this.cancelChanges = new System.Windows.Forms.Button();
            this.saveChanges = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.remove = new System.Windows.Forms.Button();
            this.addRemoveTableGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.fileLabel = new System.Windows.Forms.Label();
            this.error = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addRemoveTableGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // expSigBox
            // 
            this.expSigBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.expSigBox.Location = new System.Drawing.Point(258, 14);
            this.expSigBox.Name = "expSigBox";
            this.expSigBox.Size = new System.Drawing.Size(318, 31);
            this.expSigBox.TabIndex = 0;
            // 
            // sigBox
            // 
            this.sigBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.sigBox.Location = new System.Drawing.Point(258, 63);
            this.sigBox.Name = "sigBox";
            this.sigBox.Size = new System.Drawing.Size(318, 31);
            this.sigBox.TabIndex = 1;
            // 
            // expSig
            // 
            this.expSig.AutoSize = true;
            this.expSig.Location = new System.Drawing.Point(11, 14);
            this.expSig.Name = "expSig";
            this.expSig.Size = new System.Drawing.Size(241, 25);
            this.expSig.TabIndex = 2;
            this.expSig.Text = "Expanded Sig: ex. Twice Daily";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Sig: ex: bid";
            // 
            // addToList
            // 
            this.addToList.Location = new System.Drawing.Point(285, 110);
            this.addToList.Name = "addToList";
            this.addToList.Size = new System.Drawing.Size(112, 34);
            this.addToList.TabIndex = 4;
            this.addToList.Text = "Add";
            this.addToList.UseVisualStyleBackColor = true;
            this.addToList.Click += new System.EventHandler(this.addToList_Click);
            // 
            // cancelChanges
            // 
            this.cancelChanges.Location = new System.Drawing.Point(177, 446);
            this.cancelChanges.Name = "cancelChanges";
            this.cancelChanges.Size = new System.Drawing.Size(158, 34);
            this.cancelChanges.TabIndex = 5;
            this.cancelChanges.Text = "Cancel Changes";
            this.cancelChanges.UseVisualStyleBackColor = true;
            this.cancelChanges.Click += new System.EventHandler(this.cancelChanges_Click);
            // 
            // saveChanges
            // 
            this.saveChanges.Location = new System.Drawing.Point(497, 446);
            this.saveChanges.Name = "saveChanges";
            this.saveChanges.Size = new System.Drawing.Size(148, 34);
            this.saveChanges.TabIndex = 6;
            this.saveChanges.Text = "Save Changes";
            this.saveChanges.UseVisualStyleBackColor = true;
            this.saveChanges.Click += new System.EventHandler(this.saveChanges_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.addToList);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.expSig);
            this.panel1.Controls.Add(this.sigBox);
            this.panel1.Controls.Add(this.expSigBox);
            this.panel1.Location = new System.Drawing.Point(46, 279);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 161);
            this.panel1.TabIndex = 7;
            // 
            // remove
            // 
            this.remove.Location = new System.Drawing.Point(332, 239);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(112, 34);
            this.remove.TabIndex = 8;
            this.remove.Text = "Remove";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // addRemoveTableGrid
            // 
            this.addRemoveTableGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.addRemoveTableGrid.Location = new System.Drawing.Point(154, 55);
            this.addRemoveTableGrid.Name = "addRemoveTableGrid";
            this.addRemoveTableGrid.ReadOnly = true;
            this.addRemoveTableGrid.RowHeadersWidth = 62;
            this.addRemoveTableGrid.RowTemplate.Height = 33;
            this.addRemoveTableGrid.Size = new System.Drawing.Size(479, 152);
            this.addRemoveTableGrid.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(261, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 25);
            this.label1.TabIndex = 10;
            this.label1.Text = "Add/Remove to";
            // 
            // fileLabel
            // 
            this.fileLabel.AutoSize = true;
            this.fileLabel.Location = new System.Drawing.Point(406, 16);
            this.fileLabel.Name = "fileLabel";
            this.fileLabel.Size = new System.Drawing.Size(82, 25);
            this.fileLabel.TabIndex = 11;
            this.fileLabel.Text = "fileName";
            // 
            // error
            // 
            this.error.AutoSize = true;
            this.error.Location = new System.Drawing.Point(497, 502);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(208, 25);
            this.error.TabIndex = 12;
            this.error.Text = "ERROR WRITING TO FILE";
            this.error.Visible = false;
            // 
            // modifyFiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.error);
            this.Controls.Add(this.fileLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addRemoveTableGrid);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.saveChanges);
            this.Controls.Add(this.cancelChanges);
            this.Name = "modifyFiles";
            this.Size = new System.Drawing.Size(834, 650);
            this.Load += new System.EventHandler(this.modifyFiles_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addRemoveTableGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox expSigBox;
        private System.Windows.Forms.TextBox sigBox;
        private System.Windows.Forms.Label expSig;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button addToList;
        private System.Windows.Forms.Button cancelChanges;
        private System.Windows.Forms.Button saveChanges;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.DataGridView addRemoveTableGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label fileLabel;
        private System.Windows.Forms.Label error;
    }
}
