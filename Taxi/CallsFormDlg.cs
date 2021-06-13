using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Taxi
{
    public partial class CallsFormDlg : Form
    {
        public string ConnectionString { get; set; }
        public int recordId { get; set; }

        public SQLiteConnection connection;
        public CallsFormDlg()
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

        private void CallsFormDlg_Load(object sender, EventArgs e)
        {
            LoadDataInComboboxByTblAndFieldName(ref comboBoxDriversId, "drivers", "fullName", true);
            LoadDataInComboboxByTblAndFieldName(ref comboBoxClientsId, "clients", "fullName", true);
            LoadDataInComboboxByTblAndFieldName(ref comboBoxTarifsId, "tarifs", "name", true);

            if (recordId == -1)
            {
                textBoxId.Text = "Новий запис";
                Text = "Додання нового запису";

                string tmp = DateTime.Now.ToString("dd.MM.yyyy HH:mm");
                dateTimePicker.Text = tmp;
            }
            else
            {
                textBoxId.Text = recordId.ToString();
                Text = "Редагування запису #" + recordId.ToString();
            }
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
        private int GetIdInTextStringBySeparator(string inStr)
        {
            string[] array = inStr.Split(new char[] { ':' });

            if (array.Length > 0)
            {
                try
                {
                    return Convert.ToInt32(array[0].Trim());
                }
                catch
                {
                    return -1;
                }
            }

            return -1;

        }
        public void LoadDataInFiledsByRecordId(int rec_id)
        {
            if (ConnectToSQLiteDB() == 1)
            {
                using (SQLiteCommand fmd = connection.CreateCommand())
                {
                    try
                    {
                        fmd.CommandText = @"SELECT date,driverId,customerId,tarifId,distance,cost FROM orders WHERE id=@l";
                        fmd.Parameters.Add("@l", System.Data.DbType.Int32, -1);
                        fmd.Parameters["@l"].Value = rec_id;

                        SQLiteDataReader r = fmd.ExecuteReader();
                        while (r.Read())
                        {
                            LoadDataInComboboxByTblAndFieldName(ref comboBoxDriversId, "drivers", "fullName", true, Convert.ToInt32((r["driverId"]).ToString()));
                            LoadDataInComboboxByTblAndFieldName(ref comboBoxClientsId, "clients", "fullName", true, Convert.ToInt32((r["customerId"]).ToString()));
                            LoadDataInComboboxByTblAndFieldName(ref comboBoxTarifsId, "tarifs", "name", true, Convert.ToInt32((r["tarifId"]).ToString()));

                            textBox_distance.Text = (r["distance"]).ToString();
                            dateTimePicker.Text = (r["date"]).ToString();
                        }
                    }
                    catch (Exception ex)
                    {
                        connection.Close();
                        MessageBox.Show("SQLITE SELECT ERROR : " + ex.Message);
                    }
                }
                connection.Close();
            }
        }
        public void LoadDataInComboboxByTblAndFieldName(ref ComboBox comboboxtarger, string tblname, string fieldname, bool needID = false, int setid = -1)
        {
            if (ConnectToSQLiteDB() == 1)
            {
                using (SQLiteCommand fmd = connection.CreateCommand())
                {
                    try
                    {
                        fmd.CommandText = @"SELECT id," + fieldname + " FROM " + tblname;
                        comboboxtarger.Items.Clear();
                        int curIndex = 0;
                        SQLiteDataReader r = fmd.ExecuteReader();
                        int rememberId = 0;
                        while (r.Read())
                        {
                            comboboxtarger.Items.Add((needID ? r["id"] + " : " : "") + r[fieldname]);
                            string tmpxx = r["id"].ToString();
                            if (r["id"].ToString() == setid.ToString())
                            {
                                rememberId = curIndex;
                            }
                            curIndex++;
                        }
                        if (setid != -1)
                        {
                            comboboxtarger.SelectedIndex = rememberId;
                        }
                    }
                    catch (Exception ex)
                    {
                        connection.Close();
                        MessageBox.Show(ex.Message);
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
                int driverId = 0, customerId = 0, tarifId = 0;
                double distance = 0.0;
                string date = "";

                date = dateTimePicker.Text.Trim();

                driverId = GetIdInTextStringBySeparator(comboBoxDriversId.Text.Trim());
                if (driverId == -1)
                {
                    MessageBox.Show(this,"id не знайдено (Водій)","Помилка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1, 0);
                    return;
                }

                tarifId = GetIdInTextStringBySeparator(comboBoxTarifsId.Text.Trim());
                if (tarifId == -1)
                {
                    MessageBox.Show(this,"id не знайдено (Тариф)","Помилка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1, 0);
                    return;
                }

                customerId = GetIdInTextStringBySeparator(comboBoxClientsId.Text.Trim());
                if (customerId == -1)
                {
                    MessageBox.Show(this,"id не знайдено (Клієнт)","Помилка", MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1, 0);
                    connection.Close();
                    return;
                }

                try
                {
                    distance = Convert.ToDouble(textBox_distance.Text.Trim());
                    if (distance <= 0)
                    {
                        MessageBox.Show("Дистанція не може бути менше або дорівнювати нулю!");
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(this, "Помилка перетворення в дійсне число (Дистанція): " + ex.Message, "Помилка",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error,
                        MessageBoxDefaultButton.Button1, 0);

                    connection.Close();
                    return;

                }

                double cost = 0;
                try
                {
                    using (SQLiteCommand fmd = connection.CreateCommand())
                    {
                        fmd.CommandText = @"SELECT cost FROM tarifs WHERE id=@l";
                        fmd.Parameters.Add("@l", System.Data.DbType.Int32, -1);
                        fmd.Parameters["@l"].Value = tarifId;

                        SQLiteDataReader r = fmd.ExecuteReader();
                        while (r.Read())
                        {
                            cost = Convert.ToDouble((r["cost"]).ToString());
                        }

                        r.Close();
                    }
                }
                catch (Exception ex)
                {
                    connection.Close();
                    MessageBox.Show("SQLITE SELECT ERROR: " + ex.Message);
                    return;
                }

                if (recordId == -1)
                {
                    using (SQLiteCommand fmd = connection.CreateCommand())
                    {
                        try
                        {
                            fmd.CommandText = @"INSERT INTO orders (driverId,customerId,tarifId,distance,date,cost) VALUES (@driverId,@customerId,@tarifId,@distance,@date,@cost)";

                            fmd.Parameters.Add("@driverId", System.Data.DbType.Int32, -1);
                            fmd.Parameters["@driverId"].Value = driverId;

                            fmd.Parameters.Add("@customerId", System.Data.DbType.Int32, -1);
                            fmd.Parameters["@customerId"].Value = customerId;

                            fmd.Parameters.Add("@tarifId", System.Data.DbType.Int32, -1);
                            fmd.Parameters["@tarifId"].Value = tarifId;

                            fmd.Parameters.Add("@distance", System.Data.DbType.Double, -1);
                            fmd.Parameters["@distance"].Value = distance;

                            fmd.Parameters.Add("@date", System.Data.DbType.String, -1);
                            fmd.Parameters["@date"].Value = DateTime.Now.ToString("dd.MM.yyyy HH:mm");

                            fmd.Parameters.Add("@cost", System.Data.DbType.Double, -1);
                            fmd.Parameters["@cost"].Value = distance * cost;

                            DialogResult r8 = MessageBox.Show("Додати новий запис?",
                                "Підтвердження виконання операції", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);


                            if (r8 == DialogResult.Yes)
                            {
                                fmd.ExecuteNonQuery();
                                needToCloseThisWindow = true;
                            }
                            else
                            {
                                needToCloseThisWindow = false;
                            }

                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine("SQLITE SELECT ERROR : " + ex.Message);
                        }
                    }
                }
                else
                {
                    using (SQLiteCommand fmd = connection.CreateCommand())
                    {
                        try
                        {
                            fmd.CommandText = @"UPDATE orders SET driverId=@driverId,customerId=@customerId,tarifId=@tarifId,distance=@distance,date=@date,cost=@cost WHERE id=@a";
                            fmd.Parameters.Add("@driverId", System.Data.DbType.Int32, -1);
                            fmd.Parameters["@driverId"].Value = driverId;

                            fmd.Parameters.Add("@customerId", System.Data.DbType.Int32, -1);
                            fmd.Parameters["@customerId"].Value = customerId;

                            fmd.Parameters.Add("@tarifId", System.Data.DbType.Int32, -1);
                            fmd.Parameters["@tarifId"].Value = tarifId;

                            fmd.Parameters.Add("@distance", System.Data.DbType.Double, -1);
                            fmd.Parameters["@distance"].Value = distance;

                            fmd.Parameters.Add("@date", System.Data.DbType.String, -1);
                            fmd.Parameters["@date"].Value = date;

                            fmd.Parameters.Add("@cost", System.Data.DbType.Double, -1);
                            fmd.Parameters["@cost"].Value = cost*distance;

                            fmd.Parameters.Add("@a", System.Data.DbType.String, -1);
                            fmd.Parameters["@a"].Value = recordId;

                            DialogResult r8 = MessageBox.Show("Редагувати запис?",
                                "Підтвердження виконання операції", MessageBoxButtons.YesNo,
                                MessageBoxIcon.Question);


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
