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
            this.cpu_label = new System.Windows.Forms.Label();
            this.cpu_usage_label = new System.Windows.Forms.Label();
            this.ram_usage_label = new System.Windows.Forms.Label();
            this.ram_label = new System.Windows.Forms.Label();
            this.ram_progressbar = new System.Windows.Forms.ProgressBar();
            this.gpu_usage_label = new System.Windows.Forms.Label();
            this.GPU_label = new System.Windows.Forms.Label();
            this.gpu_progressbar = new System.Windows.Forms.ProgressBar();
            this.start_stop_button = new System.Windows.Forms.Button();
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
            // cpu_label
            // 
            this.cpu_label.AutoSize = true;
            this.cpu_label.BackColor = System.Drawing.Color.Transparent;
            this.cpu_label.Location = new System.Drawing.Point(9, 15);
            this.cpu_label.Name = "cpu_label";
            this.cpu_label.Size = new System.Drawing.Size(35, 13);
            this.cpu_label.TabIndex = 1;
            this.cpu_label.Text = "CPU :";
            // 
            // cpu_usage_label
            // 
            this.cpu_usage_label.AutoSize = true;
            this.cpu_usage_label.BackColor = System.Drawing.Color.Transparent;
            this.cpu_usage_label.Location = new System.Drawing.Point(50, 15);
            this.cpu_usage_label.Name = "cpu_usage_label";
            this.cpu_usage_label.Size = new System.Drawing.Size(64, 13);
            this.cpu_usage_label.TabIndex = 2;
            this.cpu_usage_label.Text = "CPU_usage";
            // 
            // ram_usage_label
            // 
            this.ram_usage_label.AutoSize = true;
            this.ram_usage_label.BackColor = System.Drawing.Color.Transparent;
            this.ram_usage_label.Location = new System.Drawing.Point(50, 71);
            this.ram_usage_label.Name = "ram_usage_label";
            this.ram_usage_label.Size = new System.Drawing.Size(66, 13);
            this.ram_usage_label.TabIndex = 5;
            this.ram_usage_label.Text = "RAM_usage";
            // 
            // ram_label
            // 
            this.ram_label.AutoSize = true;
            this.ram_label.BackColor = System.Drawing.Color.Transparent;
            this.ram_label.Location = new System.Drawing.Point(9, 71);
            this.ram_label.Name = "ram_label";
            this.ram_label.Size = new System.Drawing.Size(37, 13);
            this.ram_label.TabIndex = 4;
            this.ram_label.Text = "RAM :";
            // 
            // ram_progressbar
            // 
            this.ram_progressbar.Location = new System.Drawing.Point(12, 87);
            this.ram_progressbar.Name = "ram_progressbar";
            this.ram_progressbar.Size = new System.Drawing.Size(630, 38);
            this.ram_progressbar.TabIndex = 3;
            // 
            // gpu_usage_label
            // 
            this.gpu_usage_label.AutoSize = true;
            this.gpu_usage_label.BackColor = System.Drawing.Color.Transparent;
            this.gpu_usage_label.Location = new System.Drawing.Point(50, 127);
            this.gpu_usage_label.Name = "gpu_usage_label";
            this.gpu_usage_label.Size = new System.Drawing.Size(65, 13);
            this.gpu_usage_label.TabIndex = 8;
            this.gpu_usage_label.Text = "GPU_usage";
            // 
            // GPU_label
            // 
            this.GPU_label.AutoSize = true;
            this.GPU_label.BackColor = System.Drawing.Color.Transparent;
            this.GPU_label.Location = new System.Drawing.Point(9, 127);
            this.GPU_label.Name = "GPU_label";
            this.GPU_label.Size = new System.Drawing.Size(36, 13);
            this.GPU_label.TabIndex = 7;
            this.GPU_label.Text = "GPU :";
            // 
            // gpu_progressbar
            // 
            this.gpu_progressbar.Location = new System.Drawing.Point(12, 143);
            this.gpu_progressbar.Name = "gpu_progressbar";
            this.gpu_progressbar.Size = new System.Drawing.Size(630, 38);
            this.gpu_progressbar.TabIndex = 6;
            // 
            // start_stop_button
            // 
            this.start_stop_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.start_stop_button.Location = new System.Drawing.Point(127, 255);
            this.start_stop_button.Name = "start_stop_button";
            this.start_stop_button.Size = new System.Drawing.Size(390, 120);
            this.start_stop_button.TabIndex = 9;
            this.start_stop_button.Text = "Start";
            this.start_stop_button.UseVisualStyleBackColor = true;
            this.start_stop_button.Click += new System.EventHandler(this.start_stop_button_Click);
            this.start_stop_button.BackColor = System.Drawing.Color.DarkGreen;
            // 
            // Analyse_programm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(659, 450);
            this.Controls.Add(this.start_stop_button);
            this.Controls.Add(this.gpu_usage_label);
            this.Controls.Add(this.GPU_label);
            this.Controls.Add(this.gpu_progressbar);
            this.Controls.Add(this.ram_usage_label);
            this.Controls.Add(this.ram_label);
            this.Controls.Add(this.ram_progressbar);
            this.Controls.Add(this.cpu_usage_label);
            this.Controls.Add(this.cpu_label);
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
        private System.Windows.Forms.Label cpu_label;
        private System.Windows.Forms.Label cpu_usage_label;
        private System.Windows.Forms.Label ram_usage_label;
        private System.Windows.Forms.Label ram_label;
        private System.Windows.Forms.ProgressBar ram_progressbar;
        private System.Windows.Forms.Label gpu_usage_label;
        private System.Windows.Forms.Label GPU_label;
        private System.Windows.Forms.ProgressBar gpu_progressbar;
        private System.Windows.Forms.Button start_stop_button;
    }
}

