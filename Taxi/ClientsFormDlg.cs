using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Taxi
{
    public partial class ClientsFormDlg : Form
    {
        public string ConnectionString { get; set; }
        public int recordId { get; set; }

        public SQLiteConnection connection;
        public ClientsFormDlg()
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
        private void DriversFormDlg_Load(object sender, EventArgs e)
        {
            if (recordId == -1)
            {
                textBoxId.Text = "Новий запис";
                Text = "Додання нового запису";
            }
            else
            {
                textBoxId.Text = recordId.ToString();
                Text = "Редагування запису #" + recordId.ToString();
            }
        }
        public void LoadDataInFiledsByRecordId(int rec_id)
        {
            if (ConnectToSQLiteDB() == 1)
            {
                using (SQLiteCommand fmd = connection.CreateCommand())
                {
                    try
                    {
                        fmd.CommandText = @"SELECT fullName,tel,email,dateReg FROM clients WHERE id=@l";
                        fmd.Parameters.Add("@l", System.Data.DbType.Int32, -1);
                        fmd.Parameters["@l"].Value = rec_id;


                        SQLiteDataReader r = fmd.ExecuteReader();
                        while (r.Read())
                        {
                            textBoxId.Text = rec_id.ToString();
                            textBoxName.Text = (r["fullName"]).ToString();
                            textBoxTel.Text = (r["tel"]).ToString();
                            textBoxEmail.Text = (r["email"]).ToString();
                            dateTimePicker1.Text = (r["dateReg"]).ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("SQLITE SELECT ERROR : " + ex.Message);
                    }
                }
                connection.Close();
            }
        }

        private void button_action_Click(object sender, EventArgs e)
        {
            bool needToCloseThisWindow = false;
            if (ConnectToSQLiteDB() == 1)
            {
                string name = textBoxName.Text.Trim();
                long tel = 0;
                string email = textBoxEmail.Text.Trim();
                string date = dateTimePicker1.Text.Trim();
                try
                {
                    tel = Convert.ToInt64(textBoxTel.Text.Trim());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this,
                        "Помилка перетворення в дійсне число (Номер телефону): " + ex.Message, "Помилка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1, 0);

                    connection.Close();
                    return;
                }
                if (recordId == -1)
                {
                    using (SQLiteCommand fmd = connection.CreateCommand())
                    {
                        try
                        {
                            fmd.CommandText = @"INSERT INTO clients (fullName,tel,email,dateReg) VALUES (@n, @t, @e, @d)";
                            fmd.Parameters.Add("@n", System.Data.DbType.String, -1);
                            fmd.Parameters["@n"].Value = name;
                            fmd.Parameters.Add("@t", System.Data.DbType.Int64, -1);
                            fmd.Parameters["@t"].Value = tel;
                            fmd.Parameters.Add("@e", System.Data.DbType.String, -1);
                            fmd.Parameters["@e"].Value = email;
                            fmd.Parameters.Add("@d", System.Data.DbType.String, -1);
                            fmd.Parameters["@d"].Value = date;

                            DialogResult r8 = MessageBox.Show("Додати новий запис?",
                                       "Підтвердження виконання операції", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (r8 == DialogResult.Yes)
                            {
                                fmd.ExecuteNonQuery();
                                needToCloseThisWindow = true;
                            }
                            else
                            {
                                needToCloseThisWindow = true;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("SQLITE SELECT ERROR : " + ex.Message);
                        }
                    }
                    connection.Close();
                }
                else
                {
                    using (SQLiteCommand fmd = connection.CreateCommand())
                    {
                        try
                        {
                            fmd.CommandText = @"UPDATE clients SET fullName=@n,tel=@t,email=@p WHERE id=@a";
                            fmd.Parameters.Add("@n", System.Data.DbType.String, -1);
                            fmd.Parameters["@n"].Value = name;
                            fmd.Parameters.Add("@t", System.Data.DbType.Int64, -1);
                            fmd.Parameters["@t"].Value = tel;
                            fmd.Parameters.Add("@p", System.Data.DbType.String, -1);
                            fmd.Parameters["@p"].Value = email;
                            fmd.Parameters.Add("@a", System.Data.DbType.Int32, -1);
                            fmd.Parameters["@a"].Value = recordId;

                            DialogResult r8 = MessageBox.Show("Редагувати запис?",
                                       "Підтвердження виконання операції", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                            if (r8 == DialogResult.Yes)
                            {
                                fmd.ExecuteNonQuery();
                                needToCloseThisWindow = true;
                            }
                            else
                            {
                                needToCloseThisWindow = true;
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("SQLITE SELECT ERROR : " + ex.Message);
                        }
                    }
                    connection.Close();
                }
            }
            if (needToCloseThisWindow)
            {
                Close();
            }
        }
        private void button_close_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

