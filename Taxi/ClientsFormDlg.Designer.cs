
namespace Taxi
{
    partial class ClientsFormDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientsFormDlg));
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.label_productName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.button_action = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 140);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 15);
            this.label3.TabIndex = 43;
            this.label3.Text = "Дата реєстрації";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 111);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 15);
            this.label2.TabIndex = 42;
            this.label2.Text = "Електронна пошта";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(130, 108);
            this.textBoxEmail.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(220, 23);
            this.textBoxEmail.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 82);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 41;
            this.label1.Text = "Номер телефону";
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(130, 79);
            this.textBoxTel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(220, 23);
            this.textBoxTel.TabIndex = 33;
            // 
            // label_productName
            // 
            this.label_productName.AutoSize = true;
            this.label_productName.Location = new System.Drawing.Point(53, 53);
            this.label_productName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_productName.Name = "label_productName";
            this.label_productName.Size = new System.Drawing.Size(69, 15);
            this.label_productName.TabIndex = 40;
            this.label_productName.Text = "ПІБ клієнта";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(130, 50);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(220, 23);
            this.textBoxName.TabIndex = 31;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(97, 23);
            this.label_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(24, 15);
            this.label_id.TabIndex = 39;
            this.label_id.Text = "id#";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(130, 20);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(220, 23);
            this.textBoxId.TabIndex = 30;
            this.textBoxId.TabStop = false;
            // 
            // button_action
            // 
            this.button_action.Location = new System.Drawing.Point(237, 181);
            this.button_action.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_action.Name = "button_action";
            this.button_action.Size = new System.Drawing.Size(113, 46);
            this.button_action.TabIndex = 38;
            this.button_action.Text = "Внести зміни";
            this.button_action.UseVisualStyleBackColor = true;
            this.button_action.Click += new System.EventHandler(this.button_action_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(11, 181);
            this.button_close.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(113, 46);
            this.button_close.TabIndex = 37;
            this.button_close.Text = "Закрити";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Enabled = false;
            this.dateTimePicker1.Location = new System.Drawing.Point(130, 134);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(220, 23);
            this.dateTimePicker1.TabIndex = 44;
            // 
            // ClientsFormDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 240);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxEmail);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxTel);
            this.Controls.Add(this.label_productName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.button_action);
            this.Controls.Add(this.button_close);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(386, 279);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(386, 279);
            this.Name = "ClientsFormDlg";
            this.Text = "ClientsFormDlg";
            this.Load += new System.EventHandler(this.DriversFormDlg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Label label_productName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBoxId;
        public System.Windows.Forms.Button button_action;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}