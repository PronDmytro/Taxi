
namespace Taxi
{
    partial class DriversFormDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DriversFormDlg));
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxTel = new System.Windows.Forms.TextBox();
            this.label_productName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.button_action = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxPasport = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxCar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxCarNumbers = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxVINCode = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 74);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 21;
            this.label1.Text = "Номер телефону";
            // 
            // textBoxTel
            // 
            this.textBoxTel.Location = new System.Drawing.Point(168, 71);
            this.textBoxTel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxTel.Name = "textBoxTel";
            this.textBoxTel.Size = new System.Drawing.Size(220, 23);
            this.textBoxTel.TabIndex = 2;
            // 
            // label_productName
            // 
            this.label_productName.AutoSize = true;
            this.label_productName.Location = new System.Drawing.Point(102, 50);
            this.label_productName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_productName.Name = "label_productName";
            this.label_productName.Size = new System.Drawing.Size(57, 15);
            this.label_productName.TabIndex = 19;
            this.label_productName.Text = "ПІБ водія";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(168, 42);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(220, 23);
            this.textBoxName.TabIndex = 2;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(135, 15);
            this.label_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(24, 15);
            this.label_id.TabIndex = 17;
            this.label_id.Text = "id#";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(168, 12);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(220, 23);
            this.textBoxId.TabIndex = 1;
            this.textBoxId.TabStop = false;
            // 
            // button_action
            // 
            this.button_action.Location = new System.Drawing.Point(275, 237);
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
            this.button_close.Location = new System.Drawing.Point(16, 237);
            this.button_close.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(113, 46);
            this.button_close.TabIndex = 7;
            this.button_close.Text = "Закрити";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 15);
            this.label2.TabIndex = 23;
            this.label2.Text = "Серія та номер паспорта";
            // 
            // textBoxPasport
            // 
            this.textBoxPasport.Location = new System.Drawing.Point(168, 100);
            this.textBoxPasport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPasport.Name = "textBoxPasport";
            this.textBoxPasport.Size = new System.Drawing.Size(220, 23);
            this.textBoxPasport.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 132);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 15);
            this.label3.TabIndex = 25;
            this.label3.Text = "Модель авто";
            // 
            // textBoxCar
            // 
            this.textBoxCar.Location = new System.Drawing.Point(168, 129);
            this.textBoxCar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxCar.Name = "textBoxCar";
            this.textBoxCar.Size = new System.Drawing.Size(220, 23);
            this.textBoxCar.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 161);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(78, 15);
            this.label4.TabIndex = 27;
            this.label4.Text = "Номера авто";
            // 
            // textBoxCarNumbers
            // 
            this.textBoxCarNumbers.Location = new System.Drawing.Point(168, 158);
            this.textBoxCarNumbers.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxCarNumbers.Name = "textBoxCarNumbers";
            this.textBoxCarNumbers.Size = new System.Drawing.Size(220, 23);
            this.textBoxCarNumbers.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(112, 190);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 15);
            this.label5.TabIndex = 29;
            this.label5.Text = "ВІН код";
            // 
            // textBoxVINCode
            // 
            this.textBoxVINCode.Location = new System.Drawing.Point(168, 187);
            this.textBoxVINCode.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxVINCode.Name = "textBoxVINCode";
            this.textBoxVINCode.Size = new System.Drawing.Size(220, 23);
            this.textBoxVINCode.TabIndex = 6;
            // 
            // DriversFormDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 304);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBoxVINCode);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxCarNumbers);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxCar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxPasport);
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
            this.MaximumSize = new System.Drawing.Size(437, 343);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(437, 343);
            this.Name = "DriversFormDlg";
            this.Text = "DriversFormDlg";
            this.Load += new System.EventHandler(this.DriversFormDlg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxTel;
        private System.Windows.Forms.Label label_productName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBoxId;
        public System.Windows.Forms.Button button_action;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxPasport;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxCar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCarNumbers;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxVINCode;
    }
}