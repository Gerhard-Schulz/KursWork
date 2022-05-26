namespace HomeWorkDoubleImage
{
    partial class RatingForm
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
            this.dataView = new System.Windows.Forms.DataGridView();
            this.NicknameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PointColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).BeginInit();
            this.SuspendLayout();
            // 
            // dataView
            // 
            this.dataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NicknameColumn,
            this.PointColumn,
            this.TimeColumn});
            this.dataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataView.Location = new System.Drawing.Point(0, 0);
            this.dataView.Name = "dataView";
            this.dataView.Size = new System.Drawing.Size(343, 450);
            this.dataView.TabIndex = 0;
            // 
            // NicknameColumn
            // 
            this.NicknameColumn.HeaderText = "Никнейм";
            this.NicknameColumn.Name = "NicknameColumn";
            this.NicknameColumn.ReadOnly = true;
            // 
            // PointColumn
            // 
            this.PointColumn.HeaderText = "Очки";
            this.PointColumn.Name = "PointColumn";
            this.PointColumn.ReadOnly = true;
            // 
            // TimeColumn
            // 
            this.TimeColumn.HeaderText = "Время";
            this.TimeColumn.Name = "TimeColumn";
            this.TimeColumn.ReadOnly = true;
            // 
            // RatingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(343, 450);
            this.Controls.Add(this.dataView);
            this.Name = "RatingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Рейтинг";
            this.Load += new System.EventHandler(this.RatingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NicknameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn PointColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeColumn;
    }
}