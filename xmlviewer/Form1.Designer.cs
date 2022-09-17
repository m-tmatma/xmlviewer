namespace xmlviewer
{
    partial class Form1
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
            this.txtXmlFile = new System.Windows.Forms.TextBox();
            this.xmlReadButton = new System.Windows.Forms.Button();
            this.treeXml = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // txtXmlFile
            // 
            this.txtXmlFile.Location = new System.Drawing.Point(59, 30);
            this.txtXmlFile.Name = "txtXmlFile";
            this.txtXmlFile.Size = new System.Drawing.Size(1694, 39);
            this.txtXmlFile.TabIndex = 0;
            // 
            // xmlReadButton
            // 
            this.xmlReadButton.Location = new System.Drawing.Point(1792, 26);
            this.xmlReadButton.Name = "xmlReadButton";
            this.xmlReadButton.Size = new System.Drawing.Size(150, 46);
            this.xmlReadButton.TabIndex = 1;
            this.xmlReadButton.Text = "button1";
            this.xmlReadButton.UseVisualStyleBackColor = true;
            this.xmlReadButton.Click += new System.EventHandler(this.xmlReadButton_Click);
            // 
            // treeXml
            // 
            this.treeXml.Location = new System.Drawing.Point(75, 142);
            this.treeXml.Name = "treeXml";
            this.treeXml.Size = new System.Drawing.Size(1678, 1075);
            this.treeXml.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1985, 1276);
            this.Controls.Add(this.treeXml);
            this.Controls.Add(this.xmlReadButton);
            this.Controls.Add(this.txtXmlFile);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtXmlFile;
        private Button xmlReadButton;
        private TreeView treeXml;
    }
}