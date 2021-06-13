
namespace Taxi
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.buttonCalls = new System.Windows.Forms.Button();
            this.buttonClients = new System.Windows.Forms.Button();
            this.buttonTarifs = new System.Windows.Forms.Button();
            this.buttonCarPark = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCalls
            // 
            this.buttonCalls.Image = ((System.Drawing.Image)(resources.GetObject("buttonCalls.Image")));
            this.buttonCalls.Location = new System.Drawing.Point(9, 36);
            this.buttonCalls.Name = "buttonCalls";
            this.buttonCalls.Size = new System.Drawing.Size(160, 42);
            this.buttonCalls.TabIndex = 0;
            this.buttonCalls.Text = "Виклики";
            this.buttonCalls.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCalls.UseVisualStyleBackColor = true;
            this.buttonCalls.Click += new System.EventHandler(this.buttonCalls_Click);
            // 
            // buttonClients
            // 
            this.buttonClients.Image = ((System.Drawing.Image)(resources.GetObject("buttonClients.Image")));
            this.buttonClients.Location = new System.Drawing.Point(9, 95);
            this.buttonClients.Name = "buttonClients";
            this.buttonClients.Size = new System.Drawing.Size(160, 42);
            this.buttonClients.TabIndex = 1;
            this.buttonClients.Text = "Клієнти";
            this.buttonClients.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonClients.UseVisualStyleBackColor = true;
            this.buttonClients.Click += new System.EventHandler(this.buttonClients_Click);
            // 
            // buttonTarifs
            // 
            this.buttonTarifs.Image = ((System.Drawing.Image)(resources.GetObject("buttonTarifs.Image")));
            this.buttonTarifs.Location = new System.Drawing.Point(9, 153);
            this.buttonTarifs.Name = "buttonTarifs";
            this.buttonTarifs.Size = new System.Drawing.Size(160, 42);
            this.buttonTarifs.TabIndex = 2;
            this.buttonTarifs.Text = "Тарифи";
            this.buttonTarifs.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonTarifs.UseVisualStyleBackColor = true;
            this.buttonTarifs.Click += new System.EventHandler(this.buttonTarifs_Click);
            // 
            // buttonCarPark
            // 
            this.buttonCarPark.Image = ((System.Drawing.Image)(resources.GetObject("buttonCarPark.Image")));
            this.buttonCarPark.Location = new System.Drawing.Point(9, 209);
            this.buttonCarPark.Name = "buttonCarPark";
            this.buttonCarPark.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonCarPark.Size = new System.Drawing.Size(160, 42);
            this.buttonCarPark.TabIndex = 3;
            this.buttonCarPark.Text = "Автопарк";
            this.buttonCarPark.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonCarPark.UseVisualStyleBackColor = true;
            this.buttonCarPark.Click += new System.EventHandler(this.buttonCarPark_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(185, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(370, 215);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(567, 263);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.buttonCarPark);
            this.Controls.Add(this.buttonTarifs);
            this.Controls.Add(this.buttonClients);
            this.Controls.Add(this.buttonCalls);
            this.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Таксі";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCalls;
        private System.Windows.Forms.Button buttonClients;
        private System.Windows.Forms.Button buttonTarifs;
        private System.Windows.Forms.Button buttonCarPark;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

