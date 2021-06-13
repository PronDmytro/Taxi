using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Taxi
{
    public partial class TarifsFormDlg : Form
    {
        public string ConnectionString { get; set; }
        public int recordId { get; set; }

        public SQLiteConnection connection;
        public TarifsFormDlg()
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
        private void TarifsFormDlg_Load(object sender, EventArgs e)
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
                        fmd.CommandText = @"SELECT name,cost FROM tarifs WHERE id=@l";
                        fmd.Parameters.Add("@l", System.Data.DbType.Int32, -1);
                        fmd.Parameters["@l"].Value = rec_id;

                        SQLiteDataReader r = fmd.ExecuteReader();
                        while (r.Read())
                        {
                            textBoxId.Text = rec_id.ToString();
                            textBoxName.Text = (r["name"]).ToString();
                            textBoxCost.Text = (r["cost"]).ToString();

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
                int cost = 0;
                try
                {
                    cost = Convert.ToInt32(textBoxCost.Text.Trim());
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this,"Помилка перетворення в дійсне число (Вартість): " + ex.Message, "Помилка",MessageBoxButtons.OK,
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
                            fmd.CommandText = @"INSERT INTO tarifs (name, cost) VALUES (@n, @c)";
                            fmd.Parameters.Add("@n", System.Data.DbType.String, -1);
                            fmd.Parameters["@n"].Value = name;
                            fmd.Parameters.Add("@c", System.Data.DbType.Int32, -1);
                            fmd.Parameters["@c"].Value = cost;

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
                            fmd.CommandText = @"UPDATE tarifs SET name=@n, cost=@c WHERE id=@a";
                            fmd.Parameters.Add("@n", System.Data.DbType.String, -1);
                            fmd.Parameters["@n"].Value = name;
                            fmd.Parameters.Add("@c", System.Data.DbType.Int32, -1);
                            fmd.Parameters["@c"].Value = cost;
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
