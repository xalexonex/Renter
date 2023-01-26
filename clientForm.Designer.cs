namespace Renter
{
    partial class ClientForm
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
            this.boxClientName = new System.Windows.Forms.TextBox();
            this.labelClientName = new System.Windows.Forms.Label();
            this.labelClientBirthday = new System.Windows.Forms.Label();
            this.labelClientPhone = new System.Windows.Forms.Label();
            this.boxClientPhone = new System.Windows.Forms.TextBox();
            this.btnClientRegister = new System.Windows.Forms.Button();
            this.listClients = new System.Windows.Forms.ListBox();
            this.clientNew = new System.Windows.Forms.GroupBox();
            this.dateClientBirthday = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.clientNew.SuspendLayout();
            this.SuspendLayout();
            // 
            // boxClientName
            // 
            this.boxClientName.Location = new System.Drawing.Point(8, 31);
            this.boxClientName.Margin = new System.Windows.Forms.Padding(2);
            this.boxClientName.Name = "boxClientName";
            this.boxClientName.Size = new System.Drawing.Size(187, 20);
            this.boxClientName.TabIndex = 0;
            // 
            // labelClientName
            // 
            this.labelClientName.AutoSize = true;
            this.labelClientName.Location = new System.Drawing.Point(5, 16);
            this.labelClientName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClientName.Name = "labelClientName";
            this.labelClientName.Size = new System.Drawing.Size(133, 13);
            this.labelClientName.TabIndex = 1;
            this.labelClientName.Text = "Фамилия, имя, отчество";
            // 
            // labelClientBirthday
            // 
            this.labelClientBirthday.AutoSize = true;
            this.labelClientBirthday.Location = new System.Drawing.Point(5, 62);
            this.labelClientBirthday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClientBirthday.Name = "labelClientBirthday";
            this.labelClientBirthday.Size = new System.Drawing.Size(86, 13);
            this.labelClientBirthday.TabIndex = 2;
            this.labelClientBirthday.Text = "Дата рождения";
            // 
            // labelClientPhone
            // 
            this.labelClientPhone.AutoSize = true;
            this.labelClientPhone.Location = new System.Drawing.Point(5, 108);
            this.labelClientPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelClientPhone.Name = "labelClientPhone";
            this.labelClientPhone.Size = new System.Drawing.Size(52, 13);
            this.labelClientPhone.TabIndex = 4;
            this.labelClientPhone.Text = "Телефон";
            // 
            // boxClientPhone
            // 
            this.boxClientPhone.Location = new System.Drawing.Point(8, 123);
            this.boxClientPhone.Margin = new System.Windows.Forms.Padding(2);
            this.boxClientPhone.Name = "boxClientPhone";
            this.boxClientPhone.Size = new System.Drawing.Size(187, 20);
            this.boxClientPhone.TabIndex = 5;
            // 
            // btnClientRegister
            // 
            this.btnClientRegister.AutoSize = true;
            this.btnClientRegister.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnClientRegister.Location = new System.Drawing.Point(8, 156);
            this.btnClientRegister.Margin = new System.Windows.Forms.Padding(2);
            this.btnClientRegister.Name = "btnClientRegister";
            this.btnClientRegister.Size = new System.Drawing.Size(67, 23);
            this.btnClientRegister.TabIndex = 6;
            this.btnClientRegister.Text = "Добавить";
            this.btnClientRegister.UseVisualStyleBackColor = true;
            this.btnClientRegister.Click += new System.EventHandler(this.AddClient_Click);
            // 
            // listClients
            // 
            this.listClients.FormattingEnabled = true;
            this.listClients.Location = new System.Drawing.Point(221, 27);
            this.listClients.Margin = new System.Windows.Forms.Padding(2);
            this.listClients.Name = "listClients";
            this.listClients.Size = new System.Drawing.Size(200, 173);
            this.listClients.TabIndex = 7;
            // 
            // clientNew
            // 
            this.clientNew.Controls.Add(this.dateClientBirthday);
            this.clientNew.Controls.Add(this.labelClientBirthday);
            this.clientNew.Controls.Add(this.boxClientName);
            this.clientNew.Controls.Add(this.btnClientRegister);
            this.clientNew.Controls.Add(this.labelClientName);
            this.clientNew.Controls.Add(this.boxClientPhone);
            this.clientNew.Controls.Add(this.labelClientPhone);
            this.clientNew.Location = new System.Drawing.Point(12, 12);
            this.clientNew.Name = "clientNew";
            this.clientNew.Size = new System.Drawing.Size(200, 191);
            this.clientNew.TabIndex = 9;
            this.clientNew.TabStop = false;
            this.clientNew.Text = "Добавление клиента";
            // 
            // dateClientBirthday
            // 
            this.dateClientBirthday.Location = new System.Drawing.Point(8, 79);
            this.dateClientBirthday.Name = "dateClientBirthday";
            this.dateClientBirthday.Size = new System.Drawing.Size(186, 20);
            this.dateClientBirthday.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(218, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Список клиентов";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 213);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.clientNew);
            this.Controls.Add(this.listClients);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ClientForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Аренда квартиры - Список клиентов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.clientForm_FormClosing);
            this.Load += new System.EventHandler(this.ClientForm_Load);
            this.clientNew.ResumeLayout(false);
            this.clientNew.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxClientName;
        private System.Windows.Forms.Label labelClientName;
        private System.Windows.Forms.Label labelClientBirthday;
        private System.Windows.Forms.Label labelClientPhone;
        private System.Windows.Forms.TextBox boxClientPhone;
        private System.Windows.Forms.Button btnClientRegister;
        private System.Windows.Forms.ListBox listClients;
        private System.Windows.Forms.GroupBox clientNew;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dateClientBirthday;
    }
}