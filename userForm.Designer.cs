namespace Renter
{
    partial class UserForm
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
            this.dateRentStart = new System.Windows.Forms.DateTimePicker();
            this.labelRentStart = new System.Windows.Forms.Label();
            this.labelRentDays = new System.Windows.Forms.Label();
            this.labelFlatsList = new System.Windows.Forms.Label();
            this.groupRent = new System.Windows.Forms.GroupBox();
            this.numRentLength = new System.Windows.Forms.NumericUpDown();
            this.btnRent = new System.Windows.Forms.Button();
            this.labelClientsList = new System.Windows.Forms.Label();
            this.listClients = new System.Windows.Forms.ListBox();
            this.listFlats = new System.Windows.Forms.ListBox();
            this.groupRent.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRentLength)).BeginInit();
            this.SuspendLayout();
            // 
            // dateRentStart
            // 
            this.dateRentStart.Location = new System.Drawing.Point(8, 31);
            this.dateRentStart.Margin = new System.Windows.Forms.Padding(2);
            this.dateRentStart.Name = "dateRentStart";
            this.dateRentStart.Size = new System.Drawing.Size(187, 20);
            this.dateRentStart.TabIndex = 7;
            // 
            // labelRentStart
            // 
            this.labelRentStart.AutoSize = true;
            this.labelRentStart.Location = new System.Drawing.Point(5, 16);
            this.labelRentStart.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRentStart.Name = "labelRentStart";
            this.labelRentStart.Size = new System.Drawing.Size(112, 13);
            this.labelRentStart.TabIndex = 8;
            this.labelRentStart.Text = "Дата начала аренды";
            // 
            // labelRentDays
            // 
            this.labelRentDays.AutoSize = true;
            this.labelRentDays.Location = new System.Drawing.Point(5, 63);
            this.labelRentDays.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRentDays.Name = "labelRentDays";
            this.labelRentDays.Size = new System.Drawing.Size(103, 13);
            this.labelRentDays.TabIndex = 10;
            this.labelRentDays.Text = "Срок аренды, дней";
            // 
            // labelFlatsList
            // 
            this.labelFlatsList.AutoSize = true;
            this.labelFlatsList.Location = new System.Drawing.Point(217, 9);
            this.labelFlatsList.Name = "labelFlatsList";
            this.labelFlatsList.Size = new System.Drawing.Size(88, 13);
            this.labelFlatsList.TabIndex = 11;
            this.labelFlatsList.Text = "Список квартир";
            // 
            // groupRent
            // 
            this.groupRent.Controls.Add(this.numRentLength);
            this.groupRent.Controls.Add(this.btnRent);
            this.groupRent.Controls.Add(this.labelRentStart);
            this.groupRent.Controls.Add(this.dateRentStart);
            this.groupRent.Controls.Add(this.labelRentDays);
            this.groupRent.Location = new System.Drawing.Point(425, 25);
            this.groupRent.Name = "groupRent";
            this.groupRent.Size = new System.Drawing.Size(200, 139);
            this.groupRent.TabIndex = 12;
            this.groupRent.TabStop = false;
            this.groupRent.Text = "Оформление аренды";
            // 
            // numRentLength
            // 
            this.numRentLength.Location = new System.Drawing.Point(8, 80);
            this.numRentLength.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numRentLength.Name = "numRentLength";
            this.numRentLength.Size = new System.Drawing.Size(186, 20);
            this.numRentLength.TabIndex = 12;
            this.numRentLength.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnRent
            // 
            this.btnRent.AutoSize = true;
            this.btnRent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRent.Enabled = false;
            this.btnRent.Location = new System.Drawing.Point(8, 110);
            this.btnRent.Name = "btnRent";
            this.btnRent.Size = new System.Drawing.Size(70, 23);
            this.btnRent.TabIndex = 11;
            this.btnRent.Text = "Оформить";
            this.btnRent.UseVisualStyleBackColor = true;
            this.btnRent.Click += new System.EventHandler(this.btnRent_Click);
            // 
            // labelClientsList
            // 
            this.labelClientsList.AutoSize = true;
            this.labelClientsList.Location = new System.Drawing.Point(12, 9);
            this.labelClientsList.Name = "labelClientsList";
            this.labelClientsList.Size = new System.Drawing.Size(118, 13);
            this.labelClientsList.TabIndex = 14;
            this.labelClientsList.Text = "Оформить от клиента";
            // 
            // listClients
            // 
            this.listClients.FormattingEnabled = true;
            this.listClients.Location = new System.Drawing.Point(15, 25);
            this.listClients.Name = "listClients";
            this.listClients.Size = new System.Drawing.Size(199, 134);
            this.listClients.TabIndex = 15;
            // 
            // listFlats
            // 
            this.listFlats.FormattingEnabled = true;
            this.listFlats.Location = new System.Drawing.Point(220, 25);
            this.listFlats.Name = "listFlats";
            this.listFlats.Size = new System.Drawing.Size(199, 134);
            this.listFlats.TabIndex = 16;
            this.listFlats.SelectedIndexChanged += new System.EventHandler(this.listFlats_SelectedIndexChanged);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 176);
            this.Controls.Add(this.listFlats);
            this.Controls.Add(this.listClients);
            this.Controls.Add(this.labelClientsList);
            this.Controls.Add(this.groupRent);
            this.Controls.Add(this.labelFlatsList);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Аренда квартиры - Режим клиента";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.userForm_FormClosing);
            this.Load += new System.EventHandler(this.userForm_Load);
            this.groupRent.ResumeLayout(false);
            this.groupRent.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRentLength)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateRentStart;
        private System.Windows.Forms.Label labelRentStart;
        private System.Windows.Forms.Label labelRentDays;
        private System.Windows.Forms.Label labelFlatsList;
        private System.Windows.Forms.GroupBox groupRent;
        private System.Windows.Forms.Button btnRent;
        private System.Windows.Forms.Label labelClientsList;
        private System.Windows.Forms.NumericUpDown numRentLength;
        private System.Windows.Forms.ListBox listClients;
        private System.Windows.Forms.ListBox listFlats;
    }
}