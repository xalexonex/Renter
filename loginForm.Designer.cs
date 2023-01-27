namespace Renter
{
    partial class LoginForm
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
            this.btnLoginClient = new System.Windows.Forms.Button();
            this.groupLoginButtons = new System.Windows.Forms.GroupBox();
            this.btnLoginManager = new System.Windows.Forms.Button();
            this.btnGitHub = new System.Windows.Forms.Button();
            this.groupLoginButtons.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoginClient
            // 
            this.btnLoginClient.AutoSize = true;
            this.btnLoginClient.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLoginClient.Location = new System.Drawing.Point(6, 19);
            this.btnLoginClient.Name = "btnLoginClient";
            this.btnLoginClient.Size = new System.Drawing.Size(106, 23);
            this.btnLoginClient.TabIndex = 0;
            this.btnLoginClient.Text = "Войти как клиент";
            this.btnLoginClient.UseVisualStyleBackColor = true;
            this.btnLoginClient.Click += new System.EventHandler(this.btnLoginClient_Click);
            // 
            // groupLoginButtons
            // 
            this.groupLoginButtons.Controls.Add(this.btnLoginManager);
            this.groupLoginButtons.Controls.Add(this.btnLoginClient);
            this.groupLoginButtons.Location = new System.Drawing.Point(12, 12);
            this.groupLoginButtons.Name = "groupLoginButtons";
            this.groupLoginButtons.Size = new System.Drawing.Size(254, 55);
            this.groupLoginButtons.TabIndex = 1;
            this.groupLoginButtons.TabStop = false;
            this.groupLoginButtons.Text = "Выберите режим работы";
            // 
            // btnLoginManager
            // 
            this.btnLoginManager.AutoSize = true;
            this.btnLoginManager.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnLoginManager.Location = new System.Drawing.Point(118, 19);
            this.btnLoginManager.Name = "btnLoginManager";
            this.btnLoginManager.Size = new System.Drawing.Size(123, 23);
            this.btnLoginManager.TabIndex = 1;
            this.btnLoginManager.Text = "Войти как менеджер";
            this.btnLoginManager.UseVisualStyleBackColor = true;
            this.btnLoginManager.Click += new System.EventHandler(this.btnLoginManager_Click);
            // 
            // btnGitHub
            // 
            this.btnGitHub.Image = global::Renter.Properties.Resources.github;
            this.btnGitHub.Location = new System.Drawing.Point(242, 73);
            this.btnGitHub.Name = "btnGitHub";
            this.btnGitHub.Size = new System.Drawing.Size(24, 24);
            this.btnGitHub.TabIndex = 2;
            this.btnGitHub.UseVisualStyleBackColor = true;
            this.btnGitHub.Click += new System.EventHandler(this.btnGitHub_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 108);
            this.Controls.Add(this.btnGitHub);
            this.Controls.Add(this.groupLoginButtons);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Аренда квартиры";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.groupLoginButtons.ResumeLayout(false);
            this.groupLoginButtons.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoginClient;
        private System.Windows.Forms.GroupBox groupLoginButtons;
        private System.Windows.Forms.Button btnLoginManager;
        private System.Windows.Forms.Button btnGitHub;
    }
}