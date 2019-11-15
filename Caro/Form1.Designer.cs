namespace Caro
{
    partial class Caro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Caro));
            this.panelChessBoard = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBoxMark = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonLAN = new System.Windows.Forms.Button();
            this.textBoxIP = new System.Windows.Forms.TextBox();
            this.pictureBoxAva = new System.Windows.Forms.PictureBox();
            this.textBoxplayerName = new System.Windows.Forms.TextBox();
            this.progressBarcoolDown = new System.Windows.Forms.ProgressBar();
            this.timerCoolDown = new System.Windows.Forms.Timer(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMark)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAva)).BeginInit();
            this.SuspendLayout();
            // 
            // panelChessBoard
            // 
            this.panelChessBoard.BackColor = System.Drawing.SystemColors.Control;
            this.panelChessBoard.Location = new System.Drawing.Point(13, 13);
            this.panelChessBoard.Name = "panelChessBoard";
            this.panelChessBoard.Size = new System.Drawing.Size(847, 740);
            this.panelChessBoard.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.Controls.Add(this.pictureBoxMark);
            this.panel2.Location = new System.Drawing.Point(862, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(380, 427);
            this.panel2.TabIndex = 1;
            // 
            // pictureBoxMark
            // 
            this.pictureBoxMark.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBoxMark.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBoxMark.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMark.Image")));
            this.pictureBoxMark.InitialImage = null;
            this.pictureBoxMark.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxMark.Name = "pictureBoxMark";
            this.pictureBoxMark.Size = new System.Drawing.Size(380, 427);
            this.pictureBoxMark.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMark.TabIndex = 0;
            this.pictureBoxMark.TabStop = false;
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.buttonLAN);
            this.panel3.Controls.Add(this.textBoxIP);
            this.panel3.Controls.Add(this.pictureBoxAva);
            this.panel3.Controls.Add(this.textBoxplayerName);
            this.panel3.Controls.Add(this.progressBarcoolDown);
            this.panel3.Location = new System.Drawing.Point(862, 446);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(380, 307);
            this.panel3.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(101, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(167, 34);
            this.button2.TabIndex = 7;
            this.button2.Text = "Undo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(101, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(167, 47);
            this.button1.TabIndex = 6;
            this.button1.Text = "New Game";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Text", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(25, 229);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 55);
            this.label1.TabIndex = 5;
            this.label1.Text = "5 in a line to win";
            // 
            // buttonLAN
            // 
            this.buttonLAN.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLAN.Location = new System.Drawing.Point(6, 101);
            this.buttonLAN.Name = "buttonLAN";
            this.buttonLAN.Size = new System.Drawing.Size(218, 32);
            this.buttonLAN.TabIndex = 4;
            this.buttonLAN.Text = "LAN";
            this.buttonLAN.UseVisualStyleBackColor = true;
            // 
            // textBoxIP
            // 
            this.textBoxIP.Location = new System.Drawing.Point(6, 73);
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.Size = new System.Drawing.Size(219, 22);
            this.textBoxIP.TabIndex = 3;
            // 
            // pictureBoxAva
            // 
            this.pictureBoxAva.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxAva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxAva.Location = new System.Drawing.Point(228, 0);
            this.pictureBoxAva.Name = "pictureBoxAva";
            this.pictureBoxAva.Size = new System.Drawing.Size(149, 133);
            this.pictureBoxAva.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxAva.TabIndex = 2;
            this.pictureBoxAva.TabStop = false;
            // 
            // textBoxplayerName
            // 
            this.textBoxplayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxplayerName.Location = new System.Drawing.Point(4, 3);
            this.textBoxplayerName.Name = "textBoxplayerName";
            this.textBoxplayerName.ReadOnly = true;
            this.textBoxplayerName.Size = new System.Drawing.Size(219, 24);
            this.textBoxplayerName.TabIndex = 1;
            // 
            // progressBarcoolDown
            // 
            this.progressBarcoolDown.Location = new System.Drawing.Point(4, 33);
            this.progressBarcoolDown.Name = "progressBarcoolDown";
            this.progressBarcoolDown.Size = new System.Drawing.Size(218, 34);
            this.progressBarcoolDown.TabIndex = 0;
            // 
            // timerCoolDown
            // 
            this.timerCoolDown.Tick += new System.EventHandler(this.timerCoolDown_Tick);
            // 
            // Caro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1254, 765);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelChessBoard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Caro";
            this.Text = "Caro";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Caro_FormClosing);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMark)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAva)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelChessBoard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBoxMark;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonLAN;
        private System.Windows.Forms.TextBox textBoxIP;
        private System.Windows.Forms.PictureBox pictureBoxAva;
        private System.Windows.Forms.TextBox textBoxplayerName;
        private System.Windows.Forms.ProgressBar progressBarcoolDown;
        private System.Windows.Forms.Timer timerCoolDown;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

