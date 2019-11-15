namespace Dictionary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.cbWord = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnSpeakEnglish1 = new System.Windows.Forms.Button();
            this.txtBoxExplain = new System.Windows.Forms.TextBox();
            this.txtBoxMeaning = new System.Windows.Forms.TextBox();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.cbWord);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(231, 545);
            this.panel1.TabIndex = 0;
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Location = new System.Drawing.Point(188, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(40, 42);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // cbWord
            // 
            this.cbWord.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cbWord.FormattingEnabled = true;
            this.cbWord.Location = new System.Drawing.Point(4, 4);
            this.cbWord.Name = "cbWord";
            this.cbWord.Size = new System.Drawing.Size(178, 537);
            this.cbWord.TabIndex = 0;
            this.cbWord.SelectedIndexChanged += new System.EventHandler(this.cbWord_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.btnSpeakEnglish1);
            this.panel2.Controls.Add(this.txtBoxExplain);
            this.panel2.Controls.Add(this.txtBoxMeaning);
            this.panel2.Location = new System.Drawing.Point(250, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(573, 545);
            this.panel2.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Location = new System.Drawing.Point(522, 503);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(48, 42);
            this.button1.TabIndex = 3;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSpeakEnglish1
            // 
            this.btnSpeakEnglish1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSpeakEnglish1.BackgroundImage")));
            this.btnSpeakEnglish1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSpeakEnglish1.Location = new System.Drawing.Point(522, 4);
            this.btnSpeakEnglish1.Name = "btnSpeakEnglish1";
            this.btnSpeakEnglish1.Size = new System.Drawing.Size(48, 42);
            this.btnSpeakEnglish1.TabIndex = 2;
            this.btnSpeakEnglish1.UseVisualStyleBackColor = true;
            this.btnSpeakEnglish1.Click += new System.EventHandler(this.btnSpeakEnglish1_Click);
            // 
            // txtBoxExplain
            // 
            this.txtBoxExplain.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtBoxExplain.Location = new System.Drawing.Point(4, 52);
            this.txtBoxExplain.Multiline = true;
            this.txtBoxExplain.Name = "txtBoxExplain";
            this.txtBoxExplain.ReadOnly = true;
            this.txtBoxExplain.Size = new System.Drawing.Size(512, 489);
            this.txtBoxExplain.TabIndex = 1;
            // 
            // txtBoxMeaning
            // 
            this.txtBoxMeaning.Font = new System.Drawing.Font("Courier New", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.txtBoxMeaning.Location = new System.Drawing.Point(4, 4);
            this.txtBoxMeaning.Multiline = true;
            this.txtBoxMeaning.Name = "txtBoxMeaning";
            this.txtBoxMeaning.ReadOnly = true;
            this.txtBoxMeaning.Size = new System.Drawing.Size(512, 42);
            this.txtBoxMeaning.TabIndex = 0;
            // 
            // webBrowser1
            // 
            this.webBrowser1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowser1.Location = new System.Drawing.Point(826, 17);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(20, 541);
            this.webBrowser1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 570);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Vietnames-English | Dictionary";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbWord;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtBoxExplain;
        private System.Windows.Forms.TextBox txtBoxMeaning;
        private System.Windows.Forms.Button btnSpeakEnglish1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.WebBrowser webBrowser1;
    }
}

