namespace SerialMaster
{
    partial class SailingInterface
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
            this.topText = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bottomText = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.leftButton = new System.Windows.Forms.Button();
            this.rightButton = new System.Windows.Forms.Button();
            this.wintchBar1 = new System.Windows.Forms.ProgressBar();
            this.comport = new System.Windows.Forms.ComboBox();
            this.bodrate = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.send = new System.Windows.Forms.Button();
            this.sheetIn = new System.Windows.Forms.Button();
            this.sheetOut = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // topText
            // 
            this.topText.AutoSize = true;
            this.topText.Location = new System.Drawing.Point(13, 13);
            this.topText.Name = "topText";
            this.topText.Size = new System.Drawing.Size(43, 13);
            this.topText.TabIndex = 0;
            this.topText.Text = "topText";
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::SerialMaster.Properties.Resources.sonarOverhead;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.panel1.Location = new System.Drawing.Point(466, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 511);
            this.panel1.TabIndex = 1;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bottomText
            // 
            this.bottomText.AutoSize = true;
            this.bottomText.Location = new System.Drawing.Point(369, 532);
            this.bottomText.Name = "bottomText";
            this.bottomText.Size = new System.Drawing.Size(60, 13);
            this.bottomText.TabIndex = 2;
            this.bottomText.Text = "bottomText";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(16, 30);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(413, 493);
            this.textBox1.TabIndex = 3;
            // 
            // leftButton
            // 
            this.leftButton.Location = new System.Drawing.Point(466, 532);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(75, 23);
            this.leftButton.TabIndex = 4;
            this.leftButton.Text = "Left";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // rightButton
            // 
            this.rightButton.Location = new System.Drawing.Point(547, 532);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(75, 23);
            this.rightButton.TabIndex = 5;
            this.rightButton.Text = "Right";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // wintchBar1
            // 
            this.wintchBar1.Location = new System.Drawing.Point(790, 530);
            this.wintchBar1.Name = "wintchBar1";
            this.wintchBar1.Size = new System.Drawing.Size(187, 23);
            this.wintchBar1.TabIndex = 7;
            // 
            // comport
            // 
            this.comport.FormattingEnabled = true;
            this.comport.Location = new System.Drawing.Point(16, 529);
            this.comport.Name = "comport";
            this.comport.Size = new System.Drawing.Size(80, 21);
            this.comport.TabIndex = 8;
            // 
            // bodrate
            // 
            this.bodrate.FormattingEnabled = true;
            this.bodrate.Location = new System.Drawing.Point(102, 529);
            this.bodrate.Name = "bodrate";
            this.bodrate.Size = new System.Drawing.Size(84, 21);
            this.bodrate.TabIndex = 9;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(192, 529);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(90, 20);
            this.textBox2.TabIndex = 10;
            // 
            // send
            // 
            this.send.Location = new System.Drawing.Point(288, 527);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(75, 23);
            this.send.TabIndex = 11;
            this.send.Text = "Send";
            this.send.UseVisualStyleBackColor = true;
            // 
            // sheetIn
            // 
            this.sheetIn.Location = new System.Drawing.Point(628, 532);
            this.sheetIn.Name = "sheetIn";
            this.sheetIn.Size = new System.Drawing.Size(75, 23);
            this.sheetIn.TabIndex = 12;
            this.sheetIn.Text = "In";
            this.sheetIn.UseVisualStyleBackColor = true;
            // 
            // sheetOut
            // 
            this.sheetOut.Location = new System.Drawing.Point(709, 532);
            this.sheetOut.Name = "sheetOut";
            this.sheetOut.Size = new System.Drawing.Size(75, 23);
            this.sheetOut.TabIndex = 13;
            this.sheetOut.Text = "Out";
            this.sheetOut.UseVisualStyleBackColor = true;
            // 
            // SailingInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(989, 567);
            this.Controls.Add(this.sheetOut);
            this.Controls.Add(this.sheetIn);
            this.Controls.Add(this.send);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.bodrate);
            this.Controls.Add(this.comport);
            this.Controls.Add(this.wintchBar1);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.leftButton);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.bottomText);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.topText);
            this.Name = "SailingInterface";
            this.Text = "SailingInterface";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label topText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label bottomText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button leftButton;
        private System.Windows.Forms.Button rightButton;
        private System.Windows.Forms.ProgressBar wintchBar1;
        private System.Windows.Forms.ComboBox comport;
        private System.Windows.Forms.ComboBox bodrate;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button send;
        private System.Windows.Forms.Button sheetIn;
        private System.Windows.Forms.Button sheetOut;
    }
}