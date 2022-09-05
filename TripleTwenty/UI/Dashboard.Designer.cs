namespace TripleTwenty.UI
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.btnStartWorkingMode = new System.Windows.Forms.Button();
            this.btnStartMovieMode = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openAppToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.LblRemainingTime = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnStartWorkingMode
            // 
            this.btnStartWorkingMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStartWorkingMode.Location = new System.Drawing.Point(37, 218);
            this.btnStartWorkingMode.Margin = new System.Windows.Forms.Padding(37, 4, 37, 4);
            this.btnStartWorkingMode.Name = "btnStartWorkingMode";
            this.btnStartWorkingMode.Size = new System.Drawing.Size(258, 206);
            this.btnStartWorkingMode.TabIndex = 0;
            this.btnStartWorkingMode.Text = "Working Mode";
            this.btnStartWorkingMode.UseVisualStyleBackColor = true;
            this.btnStartWorkingMode.Click += new System.EventHandler(this.BtnStartWorkingMode_Click);
            // 
            // btnStartMovieMode
            // 
            this.btnStartMovieMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnStartMovieMode.Location = new System.Drawing.Point(369, 218);
            this.btnStartMovieMode.Margin = new System.Windows.Forms.Padding(37, 4, 37, 4);
            this.btnStartMovieMode.Name = "btnStartMovieMode";
            this.btnStartMovieMode.Size = new System.Drawing.Size(259, 206);
            this.btnStartMovieMode.TabIndex = 1;
            this.btnStartMovieMode.Text = "Movie Mode";
            this.btnStartMovieMode.UseVisualStyleBackColor = true;
            this.btnStartMovieMode.Click += new System.EventHandler(this.BtnStartMovieMode_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.notifyIcon1.BalloonTipText = "Text";
            this.notifyIcon1.BalloonTipTitle = "TripleTwenty";
            this.notifyIcon1.ContextMenuStrip = this.contextMenuStrip1;
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "TripleTwenty";
            this.notifyIcon1.Visible = true;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openAppToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 28);
            // 
            // openAppToolStripMenuItem
            // 
            this.openAppToolStripMenuItem.Name = "openAppToolStripMenuItem";
            this.openAppToolStripMenuItem.Size = new System.Drawing.Size(146, 24);
            this.openAppToolStripMenuItem.Text = "Open App";
            this.openAppToolStripMenuItem.Click += new System.EventHandler(this.OpenAppToolStripMenuItem_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // LblRemainingTime
            // 
            this.LblRemainingTime.AutoSize = true;
            this.tableLayoutPanel1.SetColumnSpan(this.LblRemainingTime, 2);
            this.LblRemainingTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LblRemainingTime.Font = new System.Drawing.Font("Segoe UI", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LblRemainingTime.Location = new System.Drawing.Point(3, 0);
            this.LblRemainingTime.Name = "LblRemainingTime";
            this.LblRemainingTime.Size = new System.Drawing.Size(659, 214);
            this.LblRemainingTime.TabIndex = 2;
            this.LblRemainingTime.Text = "00:00:00";
            this.LblRemainingTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.LblRemainingTime, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.btnStartWorkingMode, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.btnStartMovieMode, 1, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(37, 43, 37, 43);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 45.45454F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.090909F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(665, 471);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // timer2
            // 
            this.timer2.Interval = 3000;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 471);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(683, 518);
            this.MinimumSize = new System.Drawing.Size(683, 518);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.Resize += new System.EventHandler(this.Dashboard_Resize);
            this.contextMenuStrip1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnStartWorkingMode;
        private Button btnStartMovieMode;
        private NotifyIcon notifyIcon1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem openAppToolStripMenuItem;
        private System.Windows.Forms.Timer timer1;
        private Label LblRemainingTime;
        private TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Timer timer2;
    }
}