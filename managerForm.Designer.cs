namespace Renter
{
    partial class ManagerForm
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
            this.btnAccept = new System.Windows.Forms.Button();
            this.btnDecline = new System.Windows.Forms.Button();
            this.listRequests = new System.Windows.Forms.ListBox();
            this.groupManagerActions = new System.Windows.Forms.GroupBox();
            this.btnAddFlat = new System.Windows.Forms.Button();
            this.btnAddClient = new System.Windows.Forms.Button();
            this.groupRequestActions = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupManagerActions.SuspendLayout();
            this.groupRequestActions.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAccept
            // 
            this.btnAccept.AutoSize = true;
            this.btnAccept.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAccept.Enabled = false;
            this.btnAccept.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnAccept.Location = new System.Drawing.Point(9, 132);
            this.btnAccept.Margin = new System.Windows.Forms.Padding(2);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(60, 23);
            this.btnAccept.TabIndex = 4;
            this.btnAccept.Text = "Принять";
            this.btnAccept.UseVisualStyleBackColor = true;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // btnDecline
            // 
            this.btnDecline.AutoSize = true;
            this.btnDecline.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnDecline.Enabled = false;
            this.btnDecline.ForeColor = System.Drawing.Color.Red;
            this.btnDecline.Location = new System.Drawing.Point(175, 132);
            this.btnDecline.Margin = new System.Windows.Forms.Padding(2);
            this.btnDecline.Name = "btnDecline";
            this.btnDecline.Size = new System.Drawing.Size(71, 23);
            this.btnDecline.TabIndex = 5;
            this.btnDecline.Text = "Отклонить";
            this.btnDecline.UseVisualStyleBackColor = true;
            this.btnDecline.Click += new System.EventHandler(this.btnDecline_Click);
            // 
            // listRequests
            // 
            this.listRequests.FormattingEnabled = true;
            this.listRequests.Location = new System.Drawing.Point(9, 32);
            this.listRequests.Name = "listRequests";
            this.listRequests.Size = new System.Drawing.Size(237, 95);
            this.listRequests.TabIndex = 6;
            this.listRequests.SelectedIndexChanged += new System.EventHandler(this.listRequests_SelectedIndexChanged);
            // 
            // groupManagerActions
            // 
            this.groupManagerActions.Controls.Add(this.btnAddFlat);
            this.groupManagerActions.Controls.Add(this.btnAddClient);
            this.groupManagerActions.Location = new System.Drawing.Point(12, 12);
            this.groupManagerActions.Name = "groupManagerActions";
            this.groupManagerActions.Size = new System.Drawing.Size(252, 54);
            this.groupManagerActions.TabIndex = 7;
            this.groupManagerActions.TabStop = false;
            this.groupManagerActions.Text = "Действия для менеджера";
            // 
            // btnAddFlat
            // 
            this.btnAddFlat.AutoSize = true;
            this.btnAddFlat.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddFlat.Location = new System.Drawing.Point(123, 19);
            this.btnAddFlat.Name = "btnAddFlat";
            this.btnAddFlat.Size = new System.Drawing.Size(116, 23);
            this.btnAddFlat.TabIndex = 1;
            this.btnAddFlat.Text = "Добавить квартиру";
            this.btnAddFlat.UseVisualStyleBackColor = true;
            this.btnAddFlat.Click += new System.EventHandler(this.btnAddFlat_Click);
            // 
            // btnAddClient
            // 
            this.btnAddClient.AutoSize = true;
            this.btnAddClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnAddClient.Location = new System.Drawing.Point(6, 19);
            this.btnAddClient.Name = "btnAddClient";
            this.btnAddClient.Size = new System.Drawing.Size(111, 23);
            this.btnAddClient.TabIndex = 0;
            this.btnAddClient.Text = "Добавить клиента";
            this.btnAddClient.UseVisualStyleBackColor = true;
            this.btnAddClient.Click += new System.EventHandler(this.btnAddClient_Click);
            // 
            // groupRequestActions
            // 
            this.groupRequestActions.Controls.Add(this.label1);
            this.groupRequestActions.Controls.Add(this.btnDecline);
            this.groupRequestActions.Controls.Add(this.listRequests);
            this.groupRequestActions.Controls.Add(this.btnAccept);
            this.groupRequestActions.Location = new System.Drawing.Point(12, 72);
            this.groupRequestActions.Name = "groupRequestActions";
            this.groupRequestActions.Size = new System.Drawing.Size(252, 168);
            this.groupRequestActions.TabIndex = 8;
            this.groupRequestActions.TabStop = false;
            this.groupRequestActions.Text = "Работа с заявками";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Список заявок";
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 251);
            this.Controls.Add(this.groupRequestActions);
            this.Controls.Add(this.groupManagerActions);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Аренда квартиры - Режим менеджера";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.managerForm_FormClosing);
            this.Load += new System.EventHandler(this.managerForm_Load);
            this.groupManagerActions.ResumeLayout(false);
            this.groupManagerActions.PerformLayout();
            this.groupRequestActions.ResumeLayout(false);
            this.groupRequestActions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnDecline;
        private System.Windows.Forms.ListBox listRequests;
        private System.Windows.Forms.GroupBox groupManagerActions;
        private System.Windows.Forms.Button btnAddFlat;
        private System.Windows.Forms.Button btnAddClient;
        private System.Windows.Forms.GroupBox groupRequestActions;
        private System.Windows.Forms.Label label1;
    }
}