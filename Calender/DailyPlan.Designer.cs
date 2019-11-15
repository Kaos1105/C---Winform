namespace Calender
{
    partial class DailyPlan
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DailyPlan));
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFwr = new System.Windows.Forms.Button();
            this.btnPrev = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnstripItemPlan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnstripItemToday = new System.Windows.Forms.ToolStripMenuItem();
            this.fPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnFwr);
            this.panel2.Controls.Add(this.btnPrev);
            this.panel2.Controls.Add(this.dateTimePicker);
            this.panel2.Location = new System.Drawing.Point(10, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 42);
            this.panel2.TabIndex = 1;
            // 
            // btnFwr
            // 
            this.btnFwr.BackColor = System.Drawing.SystemColors.Control;
            this.btnFwr.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFwr.BackgroundImage")));
            this.btnFwr.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFwr.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFwr.Location = new System.Drawing.Point(903, 0);
            this.btnFwr.Name = "btnFwr";
            this.btnFwr.Size = new System.Drawing.Size(54, 39);
            this.btnFwr.TabIndex = 10;
            this.btnFwr.UseVisualStyleBackColor = false;
            this.btnFwr.Click += new System.EventHandler(this.btnFwr_Click);
            // 
            // btnPrev
            // 
            this.btnPrev.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrev.BackgroundImage")));
            this.btnPrev.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrev.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrev.Location = new System.Drawing.Point(3, 3);
            this.btnPrev.Name = "btnPrev";
            this.btnPrev.Size = new System.Drawing.Size(54, 39);
            this.btnPrev.TabIndex = 9;
            this.btnPrev.UseVisualStyleBackColor = true;
            this.btnPrev.Click += new System.EventHandler(this.btnPrev_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker.Location = new System.Drawing.Point(299, 3);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(347, 27);
            this.dateTimePicker.TabIndex = 0;
            this.dateTimePicker.ValueChanged += new System.EventHandler(this.dateTimePicker_ValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnstripItemPlan,
            this.mnstripItemToday});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(983, 31);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnstripItemPlan
            // 
            this.mnstripItemPlan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnstripItemPlan.Name = "mnstripItemPlan";
            this.mnstripItemPlan.Size = new System.Drawing.Size(91, 27);
            this.mnstripItemPlan.Text = "Add plan";
            this.mnstripItemPlan.Click += new System.EventHandler(this.mnstripItemPlan_Click);
            // 
            // mnstripItemToday
            // 
            this.mnstripItemToday.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnstripItemToday.Name = "mnstripItemToday";
            this.mnstripItemToday.Size = new System.Drawing.Size(66, 27);
            this.mnstripItemToday.Text = "Today";
            this.mnstripItemToday.Click += new System.EventHandler(this.mnstripItemToday_Click);
            // 
            // fPanel
            // 
            this.fPanel.AutoScroll = true;
            this.fPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.fPanel.Location = new System.Drawing.Point(10, 90);
            this.fPanel.Name = "fPanel";
            this.fPanel.Size = new System.Drawing.Size(961, 392);
            this.fPanel.TabIndex = 4;
            // 
            // DailyPlan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 494);
            this.Controls.Add(this.fPanel);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel2);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "DailyPlan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Daily Plan";
            this.panel2.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnstripItemPlan;
        private System.Windows.Forms.ToolStripMenuItem mnstripItemToday;
        private System.Windows.Forms.Button btnPrev;
        private System.Windows.Forms.Button btnFwr;
        private System.Windows.Forms.FlowLayoutPanel fPanel;
    }
}