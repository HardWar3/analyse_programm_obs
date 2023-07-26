namespace analyse_programm_obs
{
    partial class Analyse_programm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.cpu_prozessbar = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.cpu_usage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cpu_prozessbar
            // 
            this.cpu_prozessbar.Location = new System.Drawing.Point(12, 31);
            this.cpu_prozessbar.Name = "cpu_prozessbar";
            this.cpu_prozessbar.Size = new System.Drawing.Size(630, 38);
            this.cpu_prozessbar.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "CPU :";
            // 
            // cpu_usage
            // 
            this.cpu_usage.AutoSize = true;
            this.cpu_usage.BackColor = System.Drawing.Color.Transparent;
            this.cpu_usage.Location = new System.Drawing.Point(50, 15);
            this.cpu_usage.Name = "cpu_usage";
            this.cpu_usage.Size = new System.Drawing.Size(66, 13);
            this.cpu_usage.TabIndex = 2;
            this.cpu_usage.Text = "CPU_Usage";
            // 
            // Analyse_programm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cpu_usage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cpu_prozessbar);
            this.Name = "Analyse_programm";
            this.Text = "Analyse_programm";
            this.Load += new System.EventHandler(this.Analyse_programm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar cpu_prozessbar;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label cpu_usage;
    }
}

