using System;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Windows.Forms;

namespace Taxi
{
    public partial class TarifsForm : Form
    {
        public string ConnectionString { get; set; }
        public SQLiteConnection connection;
        public TarifsForm()
        {
            InitializeComponent();
        }
        public int ConnectToSQLiteDB()
        {
            connection = new SQLiteConnection(ConnectionString);
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "SQLITE CONNECT ERROR : " + ex.Message,
                    "SQLite connection error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1, 0);
                return 0;
            }
            return 1;
        }
        public void LoadData()
        {
            if (ConnectToSQLiteDB() != 1) return;
            DataTable dt = new DataTable();
            try
            {
                
                string query = @"SELECT id as '#',name as 'Назва',cost as 'Вартість' FROM tarifs"; 
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
                DataSet dataSet = new System.Data.DataSet();
                adapter.Fill(dataSet, "tarifs");
                dataGridViewTarifs.DataSource = dataSet.Tables[0];
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,
                    "Помилка оновлення даних таблиці: " + ex.Message,
                    "Помилка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1, 0);
                connection.Close();
                return;
            }
            connection.Close();
        }
        private void pictureBox_MouseLeave(object sender, EventArgs e)
        {
            PictureBox btn = sender as PictureBox;
            btn.BackColor = Color.SkyBlue;
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            PictureBox btn = sender as PictureBox;
            btn.BackColor = Color.DeepSkyBlue;
        }
        private void TarifsForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void pictureBoxFullUp_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^{UP}");
        }

        private void pictureBoxUp_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^{UP}");
        }

        private void pictureBoxLeft_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{LEFT}");
        }

        private void pictureBoxRight_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{RIGHT}");
        }

        private void pictureBoxDown_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{DOWN}");
        }

        private void pictureBoxFullDown_Click(object sender, EventArgs e)
        {
            SendKeys.Send("^{DOWN}");
        }

        private void pictureBoxDelete_Click(object sender, EventArgs e)
        {
            int id_for_edit = -1;
            try
            {
                if (dataGridViewTarifs.SelectedRows[0].Cells["#"].Value == null)
                {
                    return;
                }


                id_for_edit = Convert.ToInt32(dataGridViewTarifs.SelectedRows[0].Cells["#"].Value);
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Помилка перетворення в дійсне число (номер запису): " + ex.Message, "Помилка",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error,
                                      MessageBoxDefaultButton.Button1, 0);
                return;
            }

            DialogResult r8 = MessageBox.Show("Видалити запис#" + id_for_edit + "?",
                                       "Підтвердження виконання операції", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (r8 == DialogResult.Yes)
            {
                if (ConnectToSQLiteDB() == 1)
                {
                    using (SQLiteCommand fmd = connection.CreateCommand())
                    {
                        try
                        {
                            fmd.CommandText = @"DELETE FROM tarifs WHERE id = @l";
                            fmd.Parameters.Add("@l", System.Data.DbType.Int32, -1);
                            fmd.Parameters["@l"].Value = id_for_edit;

                            int x = 0;
                            x = fmd.ExecuteNonQuery();
                            if (x != 0)
                            {
                                MessageBox.Show(this, "Успіх!",
                                   "Запис з ID#" + id_for_edit + " видалений успішно!", MessageBoxButtons.OK,
                                   MessageBoxIcon.Information,
                                   MessageBoxDefaultButton.Button1, 0);
                            }
                            else
                            {
                                MessageBox.Show(this, "Помилка видалення запису!",
                                   "Запис з ID#" + id_for_edit + " НЕ БУВ ВИДАЛЕНИЙ!", MessageBoxButtons.OK,
                                   MessageBoxIcon.Error,
                                   MessageBoxDefaultButton.Button1, 0);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(this, "Помилка SQL-запиту!",
                                  "Запис з ID#" + id_for_edit + " НЕ БУВ ВИДАЛЕНИЙ!" + ex.Message, MessageBoxButtons.OK,
                                  MessageBoxIcon.Error,
                                  MessageBoxDefaultButton.Button1, 0);
                        }
                    }
                }
                LoadData();
            }
        }

        private void pictureBoxAdd_Click(object sender, EventArgs e)
        {
            TarifsFormDlg tarifsDlg = new TarifsFormDlg();
            tarifsDlg.ConnectionString = ConnectionString;
            tarifsDlg.recordId = -1;
            tarifsDlg.button_action.Text = "Додати запис";

            tarifsDlg.ShowDialog();

            LoadData();
        }

        private void pictureBoxEdit_Click(object sender, EventArgs e)
        {
            int idForEdit = -1;
            try
            {
                if (dataGridViewTarifs.SelectedRows[0].Cells["#"].Value == null)
                {
                    return;
                }
                idForEdit = Convert.ToInt32(dataGridViewTarifs.SelectedRows[0].Cells["#"].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(this, "Помилка",
                    "Помилка перетворення в дійсне число: " + ex.Message, MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1, 0);
                return;
            }
            TarifsFormDlg tarifsDlg = new TarifsFormDlg();
            tarifsDlg.ConnectionString = ConnectionString;
            tarifsDlg.recordId = idForEdit;
            tarifsDlg.LoadDataInFiledsByRecordId(idForEdit);
            tarifsDlg.button_action.Text = "Редагувати запис";

            tarifsDlg.ShowDialog();
            LoadData();

        }
    }
}
