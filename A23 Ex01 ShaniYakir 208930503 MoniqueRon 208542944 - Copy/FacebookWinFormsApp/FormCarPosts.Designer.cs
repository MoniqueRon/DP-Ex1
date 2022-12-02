namespace BasicFacebookFeatures
{
    partial class FormCarPosts
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
            this.listPostsByFilterBox = new System.Windows.Forms.ListBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.SuspendLayout();
            // 
            // listPostsByFilterBox
            // 
            this.listPostsByFilterBox.BackColor = System.Drawing.Color.LightPink;
            this.listPostsByFilterBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listPostsByFilterBox.Font = new System.Drawing.Font("MV Boli", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listPostsByFilterBox.FormattingEnabled = true;
            this.listPostsByFilterBox.HorizontalScrollbar = true;
            this.listPostsByFilterBox.ItemHeight = 26;
            this.listPostsByFilterBox.Location = new System.Drawing.Point(31, 32);
            this.listPostsByFilterBox.Name = "listPostsByFilterBox";
            this.listPostsByFilterBox.Size = new System.Drawing.Size(885, 338);
            this.listPostsByFilterBox.TabIndex = 0;
            this.listPostsByFilterBox.SelectedIndexChanged += new System.EventHandler(this.listPostsByFilter_SelectedIndexChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.Info;
            this.richTextBox2.Location = new System.Drawing.Point(31, 386);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(757, 217);
            this.richTextBox2.TabIndex = 1;
            this.richTextBox2.Text = "";
            this.richTextBox2.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // GroupsByFilterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 629);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.listPostsByFilterBox);
            this.Name = "GroupsByFilterForm";
            this.Text = "GroupsByFilterForm";
            this.Load += new System.EventHandler(this.GroupsByFilterForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listPostsByFilterBox;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
    }
}