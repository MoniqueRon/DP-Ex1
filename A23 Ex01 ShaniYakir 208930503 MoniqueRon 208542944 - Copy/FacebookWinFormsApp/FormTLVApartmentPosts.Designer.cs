namespace BasicFacebookFeatures
{
    partial class FormTLVApartmentPosts
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
            this.tlvListPoststBox = new System.Windows.Forms.ListBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // tlvListPoststBox
            // 
            this.tlvListPoststBox.BackColor = System.Drawing.Color.LightPink;
            this.tlvListPoststBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tlvListPoststBox.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlvListPoststBox.FormattingEnabled = true;
            this.tlvListPoststBox.HorizontalScrollbar = true;
            this.tlvListPoststBox.ItemHeight = 26;
            this.tlvListPoststBox.Location = new System.Drawing.Point(31, 32);
            this.tlvListPoststBox.Name = "tlvListPoststBox";
            this.tlvListPoststBox.Size = new System.Drawing.Size(885, 340);
            this.tlvListPoststBox.TabIndex = 0;
            this.tlvListPoststBox.SelectedIndexChanged += new System.EventHandler(this.tlvListPoststBox_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox1.Font = new System.Drawing.Font("MV Boli", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.Location = new System.Drawing.Point(31, 378);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(885, 195);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // TlvPostsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 653);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.tlvListPoststBox);
            this.Name = "TlvPostsForm";
            this.Text = "TlvPostsForm";
            this.Load += new System.EventHandler(this.TlvPostsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox tlvListPoststBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}