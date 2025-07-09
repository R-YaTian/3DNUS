namespace _3DNUS
{
    partial class Main
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
            this.t_titleid = new System.Windows.Forms.TextBox();
            this.t_version = new System.Windows.Forms.TextBox();
            this.l_titleid = new System.Windows.Forms.Label();
            this.l_version = new System.Windows.Forms.Label();
            this.c_cia = new System.Windows.Forms.CheckBox();
            this.b_download = new System.Windows.Forms.Button();
            this.t_log = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.t_spoof = new System.Windows.Forms.TextBox();
            this.c_spoof = new System.Windows.Forms.CheckBox();
            this.p_input = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.l_error = new System.Windows.Forms.Label();
            this.p_progress = new System.Windows.Forms.ProgressBar();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.p_input.SuspendLayout();
            this.SuspendLayout();
            // 
            // t_titleid
            // 
            this.t_titleid.Location = new System.Drawing.Point(13, 29);
            this.t_titleid.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.t_titleid.Name = "t_titleid";
            this.t_titleid.Size = new System.Drawing.Size(221, 25);
            this.t_titleid.TabIndex = 0;
            // 
            // t_version
            // 
            this.t_version.Location = new System.Drawing.Point(257, 29);
            this.t_version.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.t_version.Name = "t_version";
            this.t_version.Size = new System.Drawing.Size(99, 25);
            this.t_version.TabIndex = 1;
            // 
            // l_titleid
            // 
            this.l_titleid.AutoSize = true;
            this.l_titleid.Location = new System.Drawing.Point(13, 10);
            this.l_titleid.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_titleid.Name = "l_titleid";
            this.l_titleid.Size = new System.Drawing.Size(87, 15);
            this.l_titleid.TabIndex = 2;
            this.l_titleid.Text = "Title ID: ";
            // 
            // l_version
            // 
            this.l_version.AutoSize = true;
            this.l_version.Location = new System.Drawing.Point(253, 10);
            this.l_version.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_version.Name = "l_version";
            this.l_version.Size = new System.Drawing.Size(71, 15);
            this.l_version.TabIndex = 3;
            this.l_version.Text = "version:";
            // 
            // c_cia
            // 
            this.c_cia.AutoSize = true;
            this.c_cia.Location = new System.Drawing.Point(135, 95);
            this.c_cia.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.c_cia.Name = "c_cia";
            this.c_cia.Size = new System.Drawing.Size(114, 19);
            this.c_cia.TabIndex = 4;
            this.c_cia.Text = "打包为 .CIA";
            this.c_cia.UseVisualStyleBackColor = true;
            // 
            // b_download
            // 
            this.b_download.Location = new System.Drawing.Point(257, 89);
            this.b_download.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.b_download.Name = "b_download";
            this.b_download.Size = new System.Drawing.Size(100, 27);
            this.b_download.TabIndex = 5;
            this.b_download.Text = "下载";
            this.b_download.UseVisualStyleBackColor = true;
            this.b_download.Click += new System.EventHandler(this.b_download_Click);
            // 
            // t_log
            // 
            this.t_log.BackColor = System.Drawing.Color.White;
            this.t_log.Location = new System.Drawing.Point(16, 125);
            this.t_log.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.t_log.Multiline = true;
            this.t_log.Name = "t_log";
            this.t_log.ReadOnly = true;
            this.t_log.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.t_log.Size = new System.Drawing.Size(343, 361);
            this.t_log.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 524);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 15);
            this.label1.TabIndex = 7;
            this.label1.Text = "V1.10 by ground ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // t_spoof
            // 
            this.t_spoof.Enabled = false;
            this.t_spoof.Location = new System.Drawing.Point(244, 59);
            this.t_spoof.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.t_spoof.Name = "t_spoof";
            this.t_spoof.Size = new System.Drawing.Size(112, 25);
            this.t_spoof.TabIndex = 8;
            // 
            // c_spoof
            // 
            this.c_spoof.AutoSize = true;
            this.c_spoof.Location = new System.Drawing.Point(17, 61);
            this.c_spoof.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.c_spoof.Name = "c_spoof";
            this.c_spoof.Size = new System.Drawing.Size(127, 19);
            this.c_spoof.TabIndex = 9;
            this.c_spoof.Text = "魔改版本号为:";
            this.c_spoof.UseVisualStyleBackColor = true;
            this.c_spoof.CheckedChanged += new System.EventHandler(this.c_spoof_CheckedChanged);
            // 
            // p_input
            // 
            this.p_input.Controls.Add(this.button1);
            this.p_input.Controls.Add(this.c_spoof);
            this.p_input.Controls.Add(this.t_spoof);
            this.p_input.Controls.Add(this.b_download);
            this.p_input.Controls.Add(this.c_cia);
            this.p_input.Controls.Add(this.l_version);
            this.p_input.Controls.Add(this.l_titleid);
            this.p_input.Controls.Add(this.t_version);
            this.p_input.Controls.Add(this.t_titleid);
            this.p_input.Location = new System.Drawing.Point(3, 0);
            this.p_input.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.p_input.Name = "p_input";
            this.p_input.Size = new System.Drawing.Size(369, 123);
            this.p_input.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 90);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 27);
            this.button1.TabIndex = 10;
            this.button1.Text = "Titlelist";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // l_error
            // 
            this.l_error.AutoSize = true;
            this.l_error.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_error.ForeColor = System.Drawing.Color.Red;
            this.l_error.Location = new System.Drawing.Point(196, 524);
            this.l_error.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.l_error.Name = "l_error";
            this.l_error.Size = new System.Drawing.Size(152, 17);
            this.l_error.TabIndex = 11;
            this.l_error.Text = "! ERROR OCCURED";
            this.l_error.Visible = false;
            // 
            // p_progress
            // 
            this.p_progress.Location = new System.Drawing.Point(16, 493);
            this.p_progress.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.p_progress.Maximum = 200;
            this.p_progress.Name = "p_progress";
            this.p_progress.Size = new System.Drawing.Size(344, 27);
            this.p_progress.TabIndex = 12;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 545);
            this.Controls.Add(this.p_progress);
            this.Controls.Add(this.l_error);
            this.Controls.Add(this.p_input);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_log);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = global::_3DNUS.Properties.Resources.icon;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "Main";
            this.Text = "GUI";
            this.p_input.ResumeLayout(false);
            this.p_input.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t_titleid;
        private System.Windows.Forms.TextBox t_version;
        private System.Windows.Forms.Label l_titleid;
        private System.Windows.Forms.Label l_version;
        private System.Windows.Forms.CheckBox c_cia;
        private System.Windows.Forms.Button b_download;
        private System.Windows.Forms.TextBox t_log;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_spoof;
        private System.Windows.Forms.CheckBox c_spoof;
        private System.Windows.Forms.Panel p_input;
        private System.Windows.Forms.Label l_error;
        private System.Windows.Forms.ProgressBar p_progress;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

