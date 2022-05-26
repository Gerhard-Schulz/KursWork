using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeWorkDoubleImage
{
    public partial class RatingForm : Form
    {
        public RatingForm()
        {
            InitializeComponent();
        }

        private void RatingForm_Load(object sender, EventArgs e)
        {
            if (File.Exists("baze.db"))
            {
                using (SQLiteConnection connection = new SQLiteConnection("Data Source=baze.db;Version=3;"))
                {
                    connection.Open();
                    using (SQLiteCommand command = connection.CreateCommand())
                    {
                        command.CommandText = "SELECT * FROM Users;";
                        using (SQLiteDataReader reader = command.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())
                                {
                                    dataView.Rows.Add(reader.GetValue(0), reader.GetInt32(1), $"{reader.GetInt32(2)} сек");
                                }
                            }
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("База данных не найдена","Ошибка");
                Close();
            }
        }
    }
}
