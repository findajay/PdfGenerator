namespace VanhackPdfGenerator
{
    partial class PdfUploader
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
            this.btnRender = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.srcPath = new System.Windows.Forms.Label();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.outputPath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRender
            // 
            this.btnRender.Location = new System.Drawing.Point(295, 171);
            this.btnRender.Name = "btnRender";
            this.btnRender.Size = new System.Drawing.Size(130, 32);
            this.btnRender.TabIndex = 4;
            this.btnRender.Text = "Generate pdf";
            this.btnRender.UseVisualStyleBackColor = true;
            this.btnRender.Click += new System.EventHandler(this.btnRender_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(33, 50);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(115, 35);
            this.btnBrowse.TabIndex = 5;
            this.btnBrowse.Text = "Browse source pdf";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.browseSrc_Click);
            // 
            // srcPath
            // 
            this.srcPath.AutoSize = true;
            this.srcPath.Location = new System.Drawing.Point(227, 61);
            this.srcPath.Name = "srcPath";
            this.srcPath.Size = new System.Drawing.Size(0, 13);
            this.srcPath.TabIndex = 6;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(33, 114);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 33);
            this.button1.TabIndex = 7;
            this.button1.Text = "Browse output pdf";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.browseOut_Click);
            // 
            // outputPath
            // 
            this.outputPath.AutoSize = true;
            this.outputPath.Location = new System.Drawing.Point(192, 124);
            this.outputPath.Name = "outputPath";
            this.outputPath.Size = new System.Drawing.Size(0, 13);
            this.outputPath.TabIndex = 8;
            // 
            // PdfUploader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(833, 231);
            this.Controls.Add(this.outputPath);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.srcPath);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.btnRender);
            this.Name = "PdfUploader";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRender;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.Label srcPath;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label outputPath;
    }
}

