
namespace _18_LeThanhDanh_Bai_2_5_B7_8
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
            this.btnURL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnURL
            // 
            this.btnURL.Location = new System.Drawing.Point(340, 175);
            this.btnURL.Name = "btnURL";
            this.btnURL.Size = new System.Drawing.Size(119, 60);
            this.btnURL.TabIndex = 0;
            this.btnURL.Text = "Open";
            this.btnURL.UseVisualStyleBackColor = true;
            this.btnURL.Click += new System.EventHandler(this.btnURL_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnURL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnURL;
    }
}

