
namespace HomeWorkDoubleImage
{
    partial class GameForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.gamePanel = new System.Windows.Forms.Panel();
            this.infoPanel = new System.Windows.Forms.Panel();
            this.EndGameBtn = new System.Windows.Forms.Button();
            this.ballsLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.wrongTimer = new System.Windows.Forms.Timer(this.components);
            this.infoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // gamePanel
            // 
            this.gamePanel.BackColor = System.Drawing.SystemColors.Window;
            this.gamePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.gamePanel.Location = new System.Drawing.Point(0, 0);
            this.gamePanel.Name = "gamePanel";
            this.gamePanel.Size = new System.Drawing.Size(607, 651);
            this.gamePanel.TabIndex = 0;
            // 
            // infoPanel
            // 
            this.infoPanel.BackColor = System.Drawing.SystemColors.Window;
            this.infoPanel.Controls.Add(this.EndGameBtn);
            this.infoPanel.Controls.Add(this.ballsLabel);
            this.infoPanel.Controls.Add(this.timeLabel);
            this.infoPanel.Controls.Add(this.statusLabel);
            this.infoPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.infoPanel.Location = new System.Drawing.Point(607, 0);
            this.infoPanel.Name = "infoPanel";
            this.infoPanel.Size = new System.Drawing.Size(337, 651);
            this.infoPanel.TabIndex = 1;
            // 
            // EndGameBtn
            // 
            this.EndGameBtn.BackColor = System.Drawing.Color.Gold;
            this.EndGameBtn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.EndGameBtn.FlatAppearance.BorderSize = 0;
            this.EndGameBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EndGameBtn.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.EndGameBtn.Location = new System.Drawing.Point(0, 608);
            this.EndGameBtn.Name = "EndGameBtn";
            this.EndGameBtn.Size = new System.Drawing.Size(337, 43);
            this.EndGameBtn.TabIndex = 3;
            this.EndGameBtn.Text = "Завершить игру";
            this.EndGameBtn.UseVisualStyleBackColor = false;
            this.EndGameBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ballsLabel
            // 
            this.ballsLabel.BackColor = System.Drawing.SystemColors.Window;
            this.ballsLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.ballsLabel.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ballsLabel.Location = new System.Drawing.Point(0, 140);
            this.ballsLabel.Name = "ballsLabel";
            this.ballsLabel.Size = new System.Drawing.Size(337, 70);
            this.ballsLabel.TabIndex = 2;
            this.ballsLabel.Text = "Очки: 0";
            this.ballsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLabel
            // 
            this.timeLabel.BackColor = System.Drawing.SystemColors.Window;
            this.timeLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.timeLabel.Font = new System.Drawing.Font("Monotype Corsiva", 21.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.timeLabel.Location = new System.Drawing.Point(0, 70);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(337, 70);
            this.timeLabel.TabIndex = 1;
            this.timeLabel.Text = "Время:\r\n0.0 сек";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // statusLabel
            // 
            this.statusLabel.BackColor = System.Drawing.SystemColors.Window;
            this.statusLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.statusLabel.Font = new System.Drawing.Font("Monotype Corsiva", 26.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.statusLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.statusLabel.Location = new System.Drawing.Point(0, 0);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(337, 70);
            this.statusLabel.TabIndex = 0;
            this.statusLabel.Text = "Выберите картинку";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Tick += new System.EventHandler(this.OnTimerTick);
            // 
            // wrongTimer
            // 
            this.wrongTimer.Interval = 750;
            this.wrongTimer.Tick += new System.EventHandler(this.wrongTimer_Tick);
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(944, 651);
            this.Controls.Add(this.gamePanel);
            this.Controls.Add(this.infoPanel);
            this.MaximumSize = new System.Drawing.Size(960, 690);
            this.MinimumSize = new System.Drawing.Size(798, 690);
            this.Name = "GameForm";
            this.Text = "Парные карточки";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GameForm_FormClosing);
            this.infoPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel gamePanel;
        private System.Windows.Forms.Panel infoPanel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label ballsLabel;
        private System.Windows.Forms.Timer wrongTimer;
        private System.Windows.Forms.Button EndGameBtn;
    }
}

