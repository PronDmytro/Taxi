using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Taxi
{
    public partial class CallsForm : Form
    {
        public string ConnectionString { get; set; }
        public SQLiteConnection connection;
        public CallsForm()
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
                string query = @"SELECT orders.id as '#',orders.date as 'Дата та час',drivers.carName as 'Авто',drivers.carNumbers as 'Номер Авто',drivers.fullName as 'Водій',clients.fullName as 'Замовник',tarifs.name as 'Тариф',orders.distance as 'Дистанція',orders.cost as 'Вартість' FROM orders LEFT JOIN drivers ON orders.driverId = drivers.id LEFT JOIN clients ON orders.customerId = clients.id LEFT JOIN tarifs ON orders.tarifId = tarifs.id";
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(query, connection);
                DataSet dataSet = new System.Data.DataSet();
                adapter.Fill(dataSet, "orders");
                dataGridViewCalls.DataSource = dataSet.Tables[0];
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

        private void pictureBoxAdd_Click(object sender, EventArgs e)
        {
            CallsFormDlg callsDlg = new CallsFormDlg();
            callsDlg.ConnectionString = ConnectionString;
            callsDlg.recordId = -1;
            callsDlg.button_action.Text = "Додати запис";

            callsDlg.ShowDialog();

            LoadData();
        }

        private void pictureBoxEdit_Click(object sender, EventArgs e)
        {
            int idForEdit = -1;
            try
            {
                if (dataGridViewCalls.SelectedRows[0].Cells["#"].Value == null)
                {
                    return;
                }
                idForEdit = Convert.ToInt32(dataGridViewCalls.SelectedRows[0].Cells["#"].Value.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(this,
                    "Помилка перетворення в дійсне число: " + ex.Message, "Помилка", MessageBoxButtons.OK,
                    MessageBoxIcon.Error,
                    MessageBoxDefaultButton.Button1, 0);
                return;
            }
            CallsFormDlg callsDlg = new CallsFormDlg();
            callsDlg.ConnectionString = ConnectionString;
            callsDlg.recordId = idForEdit;
            callsDlg.LoadDataInFiledsByRecordId(idForEdit);
            callsDlg.button_action.Text = "Редагувати запис";

            callsDlg.ShowDialog();
            LoadData();
        }

        private void pictureBoxDelete_Click(object sender, EventArgs e)
        {
            int id_for_edit = -1;
            try
            {
                if (dataGridViewCalls.SelectedRows[0].Cells["#"].Value == null)
                {
                    return;
                }
                id_for_edit = Convert.ToInt32(dataGridViewCalls.SelectedRows[0].Cells["#"].Value);
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
                            fmd.CommandText = @"DELETE FROM orders WHERE id = @l";
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
        private void CallsForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }
    }
}

