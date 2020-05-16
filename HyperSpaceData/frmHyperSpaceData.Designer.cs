namespace HyperSpaceData
{
    partial class frmHyperSpaceData
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
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.btXML = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBox
            // 
            this.richTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox.BackColor = System.Drawing.Color.Black;
            this.richTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox.BulletIndent = 10;
            this.richTextBox.Font = new System.Drawing.Font("Montserrat", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox.ForeColor = System.Drawing.Color.White;
            this.richTextBox.Location = new System.Drawing.Point(516, 307);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.ReadOnly = true;
            this.richTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBox.Size = new System.Drawing.Size(5, 500);
            this.richTextBox.TabIndex = 55;
            this.richTextBox.Text = "Visualitzador XML";
            // 
            // btXML
            // 
            this.btXML.BackColor = System.Drawing.Color.Black;
            this.btXML.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btXML.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btXML.Font = new System.Drawing.Font("Montserrat", 12F);
            this.btXML.ForeColor = System.Drawing.Color.White;
            this.btXML.Location = new System.Drawing.Point(516, 157);
            this.btXML.Name = "btXML";
            this.btXML.Size = new System.Drawing.Size(150, 60);
            this.btXML.TabIndex = 56;
            this.btXML.Text = "Generar XML";
            this.btXML.UseVisualStyleBackColor = false;
            this.btXML.Click += new System.EventHandler(this.btXML_Click);
            // 
            // frmHyperSpaceData
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btXML);
            this.Controls.Add(this.richTextBox);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmHyperSpaceData";
            this.Text = "HyperSpace Data";
            this.Controls.SetChildIndex(this.richTextBox, 0);
            this.Controls.SetChildIndex(this.btXML, 0);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.RichTextBox richTextBox;
        private System.Windows.Forms.Button btXML;
    }
}