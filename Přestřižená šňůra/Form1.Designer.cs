namespace Přestřižená_šňůra
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
            this.components = new System.ComponentModel.Container();
            this.tlPřestřihni = new System.Windows.Forms.Button();
            this.tlZnovu = new System.Windows.Forms.Button();
            this.časovač = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // tlPřestřihni
            // 
            this.tlPřestřihni.Location = new System.Drawing.Point(52, 218);
            this.tlPřestřihni.Name = "tlPřestřihni";
            this.tlPřestřihni.Size = new System.Drawing.Size(75, 23);
            this.tlPřestřihni.TabIndex = 0;
            this.tlPřestřihni.Text = "Přestřihni";
            this.tlPřestřihni.UseVisualStyleBackColor = true;
            this.tlPřestřihni.Click += new System.EventHandler(this.tlPřestřihni_Click);
            // 
            // tlZnovu
            // 
            this.tlZnovu.Location = new System.Drawing.Point(164, 218);
            this.tlZnovu.Name = "tlZnovu";
            this.tlZnovu.Size = new System.Drawing.Size(75, 23);
            this.tlZnovu.TabIndex = 1;
            this.tlZnovu.Text = "Znovu";
            this.tlZnovu.UseVisualStyleBackColor = true;
            this.tlZnovu.Click += new System.EventHandler(this.tlZnovu_Click);
            // 
            // časovač
            // 
            this.časovač.Enabled = true;
            this.časovač.Interval = 50;
            this.časovač.Tick += new System.EventHandler(this.časovač_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tlZnovu);
            this.Controls.Add(this.tlPřestřihni);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tlPřestřihni;
        private System.Windows.Forms.Button tlZnovu;
        private System.Windows.Forms.Timer časovač;
    }
}

