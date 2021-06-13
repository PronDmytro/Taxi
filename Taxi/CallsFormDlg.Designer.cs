
namespace Taxi
{
    partial class CallsFormDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CallsFormDlg));
            this.comboBoxDriversId = new System.Windows.Forms.ComboBox();
            this.comboBoxClientsId = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_distance = new System.Windows.Forms.TextBox();
            this.label_distance = new System.Windows.Forms.Label();
            this.labelClients = new System.Windows.Forms.Label();
            this.labelDrivers = new System.Windows.Forms.Label();
            this.label_id = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.button_action = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.comboBoxTarifsId = new System.Windows.Forms.ComboBox();
            this.rifs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBoxDriversId
            // 
            this.comboBoxDriversId.FormattingEnabled = true;
            this.comboBoxDriversId.Location = new System.Drawing.Point(156, 46);
            this.comboBoxDriversId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxDriversId.Name = "comboBoxDriversId";
            this.comboBoxDriversId.Size = new System.Drawing.Size(270, 23);
            this.comboBoxDriversId.TabIndex = 2;
            // 
            // comboBoxClientsId
            // 
            this.comboBoxClientsId.FormattingEnabled = true;
            this.comboBoxClientsId.Location = new System.Drawing.Point(156, 77);
            this.comboBoxClientsId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxClientsId.Name = "comboBoxClientsId";
            this.comboBoxClientsId.Size = new System.Drawing.Size(270, 23);
            this.comboBoxClientsId.TabIndex = 3;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.CustomFormat = "dd.MM.yyyy HH:mm";
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker.Location = new System.Drawing.Point(156, 164);
            this.dateTimePicker.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(270, 23);
            this.dateTimePicker.TabIndex = 6;
            this.dateTimePicker.Value = new System.DateTime(2021, 6, 13, 1, 28, 34, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 15);
            this.label4.TabIndex = 80;
            this.label4.Text = "Дата та час замовлення";
            // 
            // textBox_distance
            // 
            this.textBox_distance.Location = new System.Drawing.Point(156, 135);
            this.textBox_distance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBox_distance.Name = "textBox_distance";
            this.textBox_distance.Size = new System.Drawing.Size(270, 23);
            this.textBox_distance.TabIndex = 5;
            // 
            // label_distance
            // 
            this.label_distance.AutoSize = true;
            this.label_distance.Location = new System.Drawing.Point(92, 138);
            this.label_distance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_distance.Name = "label_distance";
            this.label_distance.Size = new System.Drawing.Size(53, 15);
            this.label_distance.TabIndex = 76;
            this.label_distance.Text = "Відстань";
            // 
            // labelClients
            // 
            this.labelClients.AutoSize = true;
            this.labelClients.Location = new System.Drawing.Point(99, 80);
            this.labelClients.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelClients.Name = "labelClients";
            this.labelClients.Size = new System.Drawing.Size(49, 15);
            this.labelClients.TabIndex = 75;
            this.labelClients.Text = "Клієнти";
            // 
            // labelDrivers
            // 
            this.labelDrivers.AutoSize = true;
            this.labelDrivers.Location = new System.Drawing.Point(114, 49);
            this.labelDrivers.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDrivers.Name = "labelDrivers";
            this.labelDrivers.Size = new System.Drawing.Size(33, 15);
            this.labelDrivers.TabIndex = 74;
            this.labelDrivers.Text = "Водії";
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(123, 16);
            this.label_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(24, 15);
            this.label_id.TabIndex = 73;
            this.label_id.Text = "id#";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(156, 13);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(270, 23);
            this.textBoxId.TabIndex = 1;
            // 
            // button_action
            // 
            this.button_action.Location = new System.Drawing.Point(313, 202);
            this.button_action.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_action.Name = "button_action";
            this.button_action.Size = new System.Drawing.Size(113, 46);
            this.button_action.TabIndex = 8;
            this.button_action.Text = "Внести зміни";
            this.button_action.UseVisualStyleBackColor = true;
            this.button_action.Click += new System.EventHandler(this.button_action_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(10, 202);
            this.button_close.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(113, 46);
            this.button_close.TabIndex = 7;
            this.button_close.Text = "Закрити";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // comboBoxTarifsId
            // 
            this.comboBoxTarifsId.FormattingEnabled = true;
            this.comboBoxTarifsId.Location = new System.Drawing.Point(156, 106);
            this.comboBoxTarifsId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxTarifsId.Name = "comboBoxTarifsId";
            this.comboBoxTarifsId.Size = new System.Drawing.Size(270, 23);
            this.comboBoxTarifsId.TabIndex = 4;
            // 
            // rifs
            // 
            this.rifs.AutoSize = true;
            this.rifs.Location = new System.Drawing.Point(99, 109);
            this.rifs.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.rifs.Name = "rifs";
            this.rifs.Size = new System.Drawing.Size(49, 15);
            this.rifs.TabIndex = 86;
            this.rifs.Text = "Тарифи";
            // 
            // CallsFormDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 258);
            this.Controls.Add(this.comboBoxTarifsId);
            this.Controls.Add(this.rifs);
            this.Controls.Add(this.comboBoxDriversId);
            this.Controls.Add(this.comboBoxClientsId);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox_distance);
            this.Controls.Add(this.label_distance);
            this.Controls.Add(this.labelClients);
            this.Controls.Add(this.labelDrivers);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.button_action);
            this.Controls.Add(this.button_close);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(459, 297);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(459, 297);
            this.Name = "CallsFormDlg";
            this.Text = "CallsFormDlg";
            this.Load += new System.EventHandler(this.CallsFormDlg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxDriversId;
        private System.Windows.Forms.ComboBox comboBoxClientsId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_distance;
        private System.Windows.Forms.Label label_distance;
        private System.Windows.Forms.Label labelClients;
        private System.Windows.Forms.Label labelDrivers;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBoxId;
        public System.Windows.Forms.Button button_action;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.ComboBox comboBoxTarifsId;
        private System.Windows.Forms.Label rifs;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
    }
}