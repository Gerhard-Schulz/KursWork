namespace HomeWorkDoubleImage
{
    partial class StartForm
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
            this.playBtn = new System.Windows.Forms.Button();
            this.ratingBtn = new System.Windows.Forms.Button();
            this.nicknameTextBox = new System.Windows.Forms.TextBox();
            this.lb_welcome = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playBtn
            // 
            this.playBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.playBtn.BackColor = System.Drawing.SystemColors.Window;
            this.playBtn.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playBtn.Location = new System.Drawing.Point(125, 155);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(308, 42);
            this.playBtn.TabIndex = 0;
            this.playBtn.Text = "Играть!";
            this.playBtn.UseVisualStyleBackColor = false;
            this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
            // 
            // ratingBtn
            // 
            this.ratingBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ratingBtn.BackColor = System.Drawing.SystemColors.Window;
            this.ratingBtn.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ratingBtn.Location = new System.Drawing.Point(125, 204);
            this.ratingBtn.Name = "ratingBtn";
            this.ratingBtn.Size = new System.Drawing.Size(308, 42);
            this.ratingBtn.TabIndex = 1;
            this.ratingBtn.Text = "Рейтинг";
            this.ratingBtn.UseVisualStyleBackColor = false;
            this.ratingBtn.Click += new System.EventHandler(this.ratingBtn_Click);
            // 
            // nicknameTextBox
            // 
            this.nicknameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.nicknameTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.nicknameTextBox.Font = new System.Drawing.Font("Monotype Corsiva", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nicknameTextBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.nicknameTextBox.Location = new System.Drawing.Point(125, 126);
            this.nicknameTextBox.Name = "nicknameTextBox";
            this.nicknameTextBox.Size = new System.Drawing.Size(308, 24);
            this.nicknameTextBox.TabIndex = 2;
            this.nicknameTextBox.Text = "Ваш никнейм";
            this.nicknameTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nicknameTextBox.Enter += new System.EventHandler(this.nicknameTextBox_Enter);
            this.nicknameTextBox.Leave += new System.EventHandler(this.nicknameTextBox_Leave);
            // 
            // lb_welcome
            // 
            this.lb_welcome.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lb_welcome.BackColor = System.Drawing.Color.Transparent;
            this.lb_welcome.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lb_welcome.Font = new System.Drawing.Font("Monotype Corsiva", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lb_welcome.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lb_welcome.Location = new System.Drawing.Point(12, 48);
            this.lb_welcome.Name = "lb_welcome";
            this.lb_welcome.Size = new System.Drawing.Size(531, 75);
            this.lb_welcome.TabIndex = 3;
            this.lb_welcome.Text = "Кошачьи плитки";
            this.lb_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = global::HomeWorkDoubleImage.Properties.Resources._2022_05_19_01_22_33;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(555, 312);
            this.Controls.Add(this.lb_welcome);
            this.Controls.Add(this.nicknameTextBox);
            this.Controls.Add(this.ratingBtn);
            this.Controls.Add(this.playBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "StartForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Парные карточки";
            this.ResumeLayout(false);
            this.PerformLayout();
            
        }

        #endregion

        private System.Windows.Forms.Button playBtn;
        private System.Windows.Forms.Button ratingBtn;
        private System.Windows.Forms.TextBox nicknameTextBox;
        private System.Windows.Forms.Label lb_welcome;
    }
}