namespace CefSharpCookies.Forms
{
    partial class BrowserForm
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
            this.LblLoading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblLoading
            // 
            this.LblLoading.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblLoading.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLoading.Location = new System.Drawing.Point(0, 0);
            this.LblLoading.Name = "LblLoading";
            this.LblLoading.Size = new System.Drawing.Size(800, 450);
            this.LblLoading.TabIndex = 0;
            this.LblLoading.Text = "Loading...";
            this.LblLoading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblLoading);
            this.Name = "BrowserForm";
            this.Text = "BrowserForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label LblLoading;
    }
}