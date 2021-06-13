
namespace Taxi
{
    partial class TarifsFormDlg
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TarifsFormDlg));
            this.label_productName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label_id = new System.Windows.Forms.Label();
            this.textBoxId = new System.Windows.Forms.TextBox();
            this.button_action = new System.Windows.Forms.Button();
            this.button_close = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxCost = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label_productName
            // 
            this.label_productName.AutoSize = true;
            this.label_productName.Location = new System.Drawing.Point(42, 50);
            this.label_productName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_productName.Name = "label_productName";
            this.label_productName.Size = new System.Drawing.Size(82, 15);
            this.label_productName.TabIndex = 11;
            this.label_productName.Text = "Назва тарифу";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(144, 42);
            this.textBoxName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(148, 23);
            this.textBoxName.TabIndex = 10;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(111, 15);
            this.label_id.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(24, 15);
            this.label_id.TabIndex = 9;
            this.label_id.Text = "id#";
            // 
            // textBoxId
            // 
            this.textBoxId.Location = new System.Drawing.Point(144, 12);
            this.textBoxId.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxId.Name = "textBoxId";
            this.textBoxId.ReadOnly = true;
            this.textBoxId.Size = new System.Drawing.Size(148, 23);
            this.textBoxId.TabIndex = 8;
            // 
            // button_action
            // 
            this.button_action.Location = new System.Drawing.Point(179, 113);
            this.button_action.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_action.Name = "button_action";
            this.button_action.Size = new System.Drawing.Size(113, 46);
            this.button_action.TabIndex = 7;
            this.button_action.Text = "Внести зміни";
            this.button_action.UseVisualStyleBackColor = true;
            this.button_action.Click += new System.EventHandler(this.button_action_Click);
            // 
            // button_close
            // 
            this.button_close.Location = new System.Drawing.Point(29, 113);
            this.button_close.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button_close.Name = "button_close";
            this.button_close.Size = new System.Drawing.Size(113, 46);
            this.button_close.TabIndex = 6;
            this.button_close.Text = "Закрити";
            this.button_close.UseVisualStyleBackColor = true;
            this.button_close.Click += new System.EventHandler(this.button_close_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(29, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Вартість тарифу";
            // 
            // textBoxCost
            // 
            this.textBoxCost.Location = new System.Drawing.Point(144, 71);
            this.textBoxCost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxCost.Name = "textBoxCost";
            this.textBoxCost.Size = new System.Drawing.Size(148, 23);
            this.textBoxCost.TabIndex = 12;
            // 
            // TarifsFormDlg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 178);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxCost);
            this.Controls.Add(this.label_productName);
            this.Controls.Add(this.textBoxName);
            this.Controls.Add(this.label_id);
            this.Controls.Add(this.textBoxId);
            this.Controls.Add(this.button_action);
            this.Controls.Add(this.button_close);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(348, 217);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(348, 217);
            this.Name = "TarifsFormDlg";
            this.Text = "TarifsFormDlg";
            this.Load += new System.EventHandler(this.TarifsFormDlg_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_productName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.TextBox textBoxId;
        public System.Windows.Forms.Button button_action;
        private System.Windows.Forms.Button button_close;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxCost;
    }
}