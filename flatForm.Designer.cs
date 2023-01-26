namespace Renter
{
    partial class FlatForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.boxFlatAddress = new System.Windows.Forms.TextBox();
            this.btnAddFlat = new System.Windows.Forms.Button();
            this.listFlats = new System.Windows.Forms.ListBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.labelArea = new System.Windows.Forms.Label();
            this.labelRooms = new System.Windows.Forms.Label();
            this.labelRentDaily = new System.Windows.Forms.Label();
            this.groupFlat = new System.Windows.Forms.GroupBox();
            this.numRentDaily = new System.Windows.Forms.NumericUpDown();
            this.numRooms = new System.Windows.Forms.NumericUpDown();
            this.numArea = new System.Windows.Forms.NumericUpDown();
            this.labelFlatsList = new System.Windows.Forms.Label();
            this.groupFlat.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRentDaily)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRooms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArea)).BeginInit();
            this.SuspendLayout();
            // 
            // boxFlatAddress
            // 
            this.boxFlatAddress.Location = new System.Drawing.Point(8, 31);
            this.boxFlatAddress.Margin = new System.Windows.Forms.Padding(2);
            this.boxFlatAddress.Name = "boxFlatAddress";
            this.boxFlatAddress.Size = new System.Drawing.Size(187, 20);
            this.boxFlatAddress.TabIndex = 0;
            // 
            // btnAddFlat
            // 
            this.btnAddFlat.AutoSize = true;
            this.btnAddFlat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddFlat.Location = new System.Drawing.Point(8, 173);
            this.btnAddFlat.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddFlat.Name = "btnAddFlat";
            this.btnAddFlat.Size = new System.Drawing.Size(67, 23);
            this.btnAddFlat.TabIndex = 4;
            this.btnAddFlat.Text = "Добавить";
            this.btnAddFlat.UseVisualStyleBackColor = true;
            this.btnAddFlat.Click += new System.EventHandler(this.btnAddFlat_Click);
            // 
            // listFlats
            // 
            this.listFlats.FormattingEnabled = true;
            this.listFlats.Location = new System.Drawing.Point(221, 27);
            this.listFlats.Margin = new System.Windows.Forms.Padding(2);
            this.listFlats.Name = "listFlats";
            this.listFlats.Size = new System.Drawing.Size(200, 186);
            this.listFlats.TabIndex = 5;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Location = new System.Drawing.Point(5, 16);
            this.labelAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(38, 13);
            this.labelAddress.TabIndex = 6;
            this.labelAddress.Text = "Адрес";
            // 
            // labelArea
            // 
            this.labelArea.AutoSize = true;
            this.labelArea.Location = new System.Drawing.Point(5, 53);
            this.labelArea.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelArea.Name = "labelArea";
            this.labelArea.Size = new System.Drawing.Size(54, 13);
            this.labelArea.TabIndex = 7;
            this.labelArea.Text = "Площадь";
            // 
            // labelRooms
            // 
            this.labelRooms.AutoSize = true;
            this.labelRooms.Location = new System.Drawing.Point(5, 92);
            this.labelRooms.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRooms.Name = "labelRooms";
            this.labelRooms.Size = new System.Drawing.Size(53, 13);
            this.labelRooms.TabIndex = 8;
            this.labelRooms.Text = "Комнаты";
            // 
            // labelRentDaily
            // 
            this.labelRentDaily.AutoSize = true;
            this.labelRentDaily.Location = new System.Drawing.Point(5, 131);
            this.labelRentDaily.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelRentDaily.Name = "labelRentDaily";
            this.labelRentDaily.Size = new System.Drawing.Size(102, 13);
            this.labelRentDaily.TabIndex = 9;
            this.labelRentDaily.Text = "Стоимость в сутки";
            // 
            // groupFlat
            // 
            this.groupFlat.Controls.Add(this.numRentDaily);
            this.groupFlat.Controls.Add(this.numRooms);
            this.groupFlat.Controls.Add(this.numArea);
            this.groupFlat.Controls.Add(this.labelAddress);
            this.groupFlat.Controls.Add(this.labelRentDaily);
            this.groupFlat.Controls.Add(this.btnAddFlat);
            this.groupFlat.Controls.Add(this.boxFlatAddress);
            this.groupFlat.Controls.Add(this.labelRooms);
            this.groupFlat.Controls.Add(this.labelArea);
            this.groupFlat.Location = new System.Drawing.Point(12, 12);
            this.groupFlat.Name = "groupFlat";
            this.groupFlat.Size = new System.Drawing.Size(200, 201);
            this.groupFlat.TabIndex = 10;
            this.groupFlat.TabStop = false;
            this.groupFlat.Text = "Данные квартиры";
            // 
            // numRentDaily
            // 
            this.numRentDaily.Location = new System.Drawing.Point(8, 147);
            this.numRentDaily.Name = "numRentDaily";
            this.numRentDaily.Size = new System.Drawing.Size(184, 20);
            this.numRentDaily.TabIndex = 12;
            // 
            // numRooms
            // 
            this.numRooms.Location = new System.Drawing.Point(8, 108);
            this.numRooms.Name = "numRooms";
            this.numRooms.Size = new System.Drawing.Size(184, 20);
            this.numRooms.TabIndex = 11;
            // 
            // numArea
            // 
            this.numArea.Location = new System.Drawing.Point(8, 69);
            this.numArea.Name = "numArea";
            this.numArea.Size = new System.Drawing.Size(184, 20);
            this.numArea.TabIndex = 10;
            // 
            // labelFlatsList
            // 
            this.labelFlatsList.AutoSize = true;
            this.labelFlatsList.Location = new System.Drawing.Point(218, 12);
            this.labelFlatsList.Name = "labelFlatsList";
            this.labelFlatsList.Size = new System.Drawing.Size(88, 13);
            this.labelFlatsList.TabIndex = 11;
            this.labelFlatsList.Text = "Список квартир";
            // 
            // FlatForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 225);
            this.Controls.Add(this.labelFlatsList);
            this.Controls.Add(this.groupFlat);
            this.Controls.Add(this.listFlats);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FlatForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Аренда квартиры - Добавление квартиры";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.flatForm_FormClosing);
            this.Load += new System.EventHandler(this.FlatForm_Load);
            this.groupFlat.ResumeLayout(false);
            this.groupFlat.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numRentDaily)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numRooms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numArea)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox boxFlatAddress;
        private System.Windows.Forms.Button btnAddFlat;
        private System.Windows.Forms.ListBox listFlats;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.Label labelArea;
        private System.Windows.Forms.Label labelRooms;
        private System.Windows.Forms.Label labelRentDaily;
        private System.Windows.Forms.GroupBox groupFlat;
        private System.Windows.Forms.Label labelFlatsList;
        private System.Windows.Forms.NumericUpDown numRentDaily;
        private System.Windows.Forms.NumericUpDown numRooms;
        private System.Windows.Forms.NumericUpDown numArea;
    }
}

