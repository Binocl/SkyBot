﻿namespace SkyBot
{
    partial class MainForm
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
            this.enableSkype = new System.Windows.Forms.CheckBox();
            this.enableVK = new System.Windows.Forms.CheckBox();
            this.enableTelegram = new System.Windows.Forms.CheckBox();
            this.enableTest = new System.Windows.Forms.CheckBox();
            this.vkLogin = new System.Windows.Forms.TextBox();
            this.vkPassword = new System.Windows.Forms.TextBox();
            this.vkAppID = new System.Windows.Forms.TextBox();
            this.vkSave = new System.Windows.Forms.Button();
            this.l1 = new System.Windows.Forms.Label();
            this.l2 = new System.Windows.Forms.Label();
            this.l3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vkStatus = new System.Windows.Forms.Label();
            this.moduleList = new System.Windows.Forms.ListBox();
            this.l4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.l5 = new System.Windows.Forms.Label();
            this.tgSave = new System.Windows.Forms.Button();
            this.tgToken = new System.Windows.Forms.TextBox();
            this.tgStatus = new System.Windows.Forms.Label();
            this.debugText = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.discordSave = new System.Windows.Forms.Button();
            this.discordToken = new System.Windows.Forms.TextBox();
            this.discordStatus = new System.Windows.Forms.Label();
            this.enableDiscord = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // enableSkype
            // 
            this.enableSkype.AutoSize = true;
            this.enableSkype.Enabled = false;
            this.enableSkype.Location = new System.Drawing.Point(12, 9);
            this.enableSkype.Name = "enableSkype";
            this.enableSkype.Size = new System.Drawing.Size(56, 17);
            this.enableSkype.TabIndex = 0;
            this.enableSkype.Text = "Skype";
            this.enableSkype.UseVisualStyleBackColor = true;
            this.enableSkype.CheckedChanged += new System.EventHandler(this.enableSkype_CheckedChanged);
            // 
            // enableVK
            // 
            this.enableVK.AutoSize = true;
            this.enableVK.Location = new System.Drawing.Point(6, 19);
            this.enableVK.Name = "enableVK";
            this.enableVK.Size = new System.Drawing.Size(59, 17);
            this.enableVK.TabIndex = 1;
            this.enableVK.Text = "Enable";
            this.enableVK.UseVisualStyleBackColor = true;
            this.enableVK.CheckedChanged += new System.EventHandler(this.enableVK_CheckedChanged);
            // 
            // enableTelegram
            // 
            this.enableTelegram.AutoSize = true;
            this.enableTelegram.Location = new System.Drawing.Point(6, 19);
            this.enableTelegram.Name = "enableTelegram";
            this.enableTelegram.Size = new System.Drawing.Size(59, 17);
            this.enableTelegram.TabIndex = 2;
            this.enableTelegram.Text = "Enable";
            this.enableTelegram.UseVisualStyleBackColor = true;
            this.enableTelegram.CheckedChanged += new System.EventHandler(this.enableTelegram_CheckedChanged);
            // 
            // enableTest
            // 
            this.enableTest.AutoSize = true;
            this.enableTest.Location = new System.Drawing.Point(74, 9);
            this.enableTest.Name = "enableTest";
            this.enableTest.Size = new System.Drawing.Size(43, 17);
            this.enableTest.TabIndex = 3;
            this.enableTest.Text = "test";
            this.enableTest.UseVisualStyleBackColor = true;
            this.enableTest.CheckedChanged += new System.EventHandler(this.enableTest_CheckedChanged);
            // 
            // vkLogin
            // 
            this.vkLogin.Location = new System.Drawing.Point(71, 35);
            this.vkLogin.Name = "vkLogin";
            this.vkLogin.Size = new System.Drawing.Size(85, 20);
            this.vkLogin.TabIndex = 4;
            this.vkLogin.Text = "login";
            // 
            // vkPassword
            // 
            this.vkPassword.Location = new System.Drawing.Point(162, 35);
            this.vkPassword.Name = "vkPassword";
            this.vkPassword.Size = new System.Drawing.Size(79, 20);
            this.vkPassword.TabIndex = 5;
            this.vkPassword.Text = "password";
            this.vkPassword.UseSystemPasswordChar = true;
            // 
            // vkAppID
            // 
            this.vkAppID.Location = new System.Drawing.Point(247, 35);
            this.vkAppID.Name = "vkAppID";
            this.vkAppID.Size = new System.Drawing.Size(56, 20);
            this.vkAppID.TabIndex = 6;
            this.vkAppID.Text = "appID";
            // 
            // vkSave
            // 
            this.vkSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.vkSave.Location = new System.Drawing.Point(309, 33);
            this.vkSave.Name = "vkSave";
            this.vkSave.Size = new System.Drawing.Size(59, 23);
            this.vkSave.TabIndex = 7;
            this.vkSave.Text = "Save";
            this.vkSave.UseVisualStyleBackColor = true;
            this.vkSave.Click += new System.EventHandler(this.vkSave_Click);
            // 
            // l1
            // 
            this.l1.AutoSize = true;
            this.l1.Location = new System.Drawing.Point(71, 19);
            this.l1.Name = "l1";
            this.l1.Size = new System.Drawing.Size(33, 13);
            this.l1.TabIndex = 8;
            this.l1.Text = "Login";
            // 
            // l2
            // 
            this.l2.AutoSize = true;
            this.l2.Location = new System.Drawing.Point(159, 19);
            this.l2.Name = "l2";
            this.l2.Size = new System.Drawing.Size(53, 13);
            this.l2.TabIndex = 9;
            this.l2.Text = "Password";
            // 
            // l3
            // 
            this.l3.AutoSize = true;
            this.l3.Location = new System.Drawing.Point(244, 19);
            this.l3.Name = "l3";
            this.l3.Size = new System.Drawing.Size(36, 13);
            this.l3.TabIndex = 10;
            this.l3.Text = "appID";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.vkStatus);
            this.groupBox1.Controls.Add(this.enableVK);
            this.groupBox1.Controls.Add(this.l3);
            this.groupBox1.Controls.Add(this.vkLogin);
            this.groupBox1.Controls.Add(this.l2);
            this.groupBox1.Controls.Add(this.vkPassword);
            this.groupBox1.Controls.Add(this.l1);
            this.groupBox1.Controls.Add(this.vkAppID);
            this.groupBox1.Controls.Add(this.vkSave);
            this.groupBox1.Location = new System.Drawing.Point(13, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(384, 68);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VK";
            // 
            // vkStatus
            // 
            this.vkStatus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.vkStatus.AutoSize = true;
            this.vkStatus.ForeColor = System.Drawing.Color.Red;
            this.vkStatus.Location = new System.Drawing.Point(3, 39);
            this.vkStatus.Name = "vkStatus";
            this.vkStatus.Size = new System.Drawing.Size(48, 13);
            this.vkStatus.TabIndex = 11;
            this.vkStatus.Text = "Disabled";
            this.vkStatus.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // moduleList
            // 
            this.moduleList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.moduleList.FormattingEnabled = true;
            this.moduleList.Location = new System.Drawing.Point(403, 25);
            this.moduleList.Name = "moduleList";
            this.moduleList.Size = new System.Drawing.Size(120, 225);
            this.moduleList.Sorted = true;
            this.moduleList.TabIndex = 12;
            this.moduleList.DoubleClick += new System.EventHandler(this.moduleList_DoubleClick);
            // 
            // l4
            // 
            this.l4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l4.AutoSize = true;
            this.l4.Location = new System.Drawing.Point(400, 9);
            this.l4.Name = "l4";
            this.l4.Size = new System.Drawing.Size(66, 13);
            this.l4.TabIndex = 13;
            this.l4.Text = "Modules List";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.l5);
            this.groupBox2.Controls.Add(this.tgSave);
            this.groupBox2.Controls.Add(this.tgToken);
            this.groupBox2.Controls.Add(this.tgStatus);
            this.groupBox2.Controls.Add(this.enableTelegram);
            this.groupBox2.Location = new System.Drawing.Point(13, 111);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(384, 68);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Telegram";
            // 
            // l5
            // 
            this.l5.AutoSize = true;
            this.l5.Location = new System.Drawing.Point(71, 20);
            this.l5.Name = "l5";
            this.l5.Size = new System.Drawing.Size(76, 13);
            this.l5.TabIndex = 6;
            this.l5.Text = "Access Token";
            // 
            // tgSave
            // 
            this.tgSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tgSave.Location = new System.Drawing.Point(309, 34);
            this.tgSave.Name = "tgSave";
            this.tgSave.Size = new System.Drawing.Size(59, 23);
            this.tgSave.TabIndex = 5;
            this.tgSave.Text = "Save";
            this.tgSave.UseVisualStyleBackColor = true;
            this.tgSave.Click += new System.EventHandler(this.tgSave_Click);
            // 
            // tgToken
            // 
            this.tgToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tgToken.Location = new System.Drawing.Point(71, 36);
            this.tgToken.Name = "tgToken";
            this.tgToken.Size = new System.Drawing.Size(232, 20);
            this.tgToken.TabIndex = 4;
            // 
            // tgStatus
            // 
            this.tgStatus.AutoSize = true;
            this.tgStatus.ForeColor = System.Drawing.Color.Red;
            this.tgStatus.Location = new System.Drawing.Point(3, 39);
            this.tgStatus.Name = "tgStatus";
            this.tgStatus.Size = new System.Drawing.Size(48, 13);
            this.tgStatus.TabIndex = 3;
            this.tgStatus.Text = "Disabled";
            // 
            // debugText
            // 
            this.debugText.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.debugText.Location = new System.Drawing.Point(13, 259);
            this.debugText.MaxLength = 65534;
            this.debugText.Multiline = true;
            this.debugText.Name = "debugText";
            this.debugText.ReadOnly = true;
            this.debugText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.debugText.Size = new System.Drawing.Size(510, 115);
            this.debugText.TabIndex = 16;
            this.debugText.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.discordSave);
            this.groupBox3.Controls.Add(this.discordToken);
            this.groupBox3.Controls.Add(this.discordStatus);
            this.groupBox3.Controls.Add(this.enableDiscord);
            this.groupBox3.Location = new System.Drawing.Point(13, 185);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(384, 68);
            this.groupBox3.TabIndex = 17;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Discord";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(71, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Access Token";
            // 
            // discordSave
            // 
            this.discordSave.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.discordSave.Location = new System.Drawing.Point(309, 34);
            this.discordSave.Name = "discordSave";
            this.discordSave.Size = new System.Drawing.Size(59, 23);
            this.discordSave.TabIndex = 5;
            this.discordSave.Text = "Save";
            this.discordSave.UseVisualStyleBackColor = true;
            this.discordSave.Click += new System.EventHandler(this.discordSave_Click);
            // 
            // discordToken
            // 
            this.discordToken.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.discordToken.Location = new System.Drawing.Point(71, 36);
            this.discordToken.Name = "discordToken";
            this.discordToken.Size = new System.Drawing.Size(232, 20);
            this.discordToken.TabIndex = 4;
            // 
            // discordStatus
            // 
            this.discordStatus.AutoSize = true;
            this.discordStatus.ForeColor = System.Drawing.Color.Red;
            this.discordStatus.Location = new System.Drawing.Point(3, 39);
            this.discordStatus.Name = "discordStatus";
            this.discordStatus.Size = new System.Drawing.Size(48, 13);
            this.discordStatus.TabIndex = 3;
            this.discordStatus.Text = "Disabled";
            // 
            // enableDiscord
            // 
            this.enableDiscord.AutoSize = true;
            this.enableDiscord.Location = new System.Drawing.Point(6, 19);
            this.enableDiscord.Name = "enableDiscord";
            this.enableDiscord.Size = new System.Drawing.Size(59, 17);
            this.enableDiscord.TabIndex = 2;
            this.enableDiscord.Text = "Enable";
            this.enableDiscord.UseVisualStyleBackColor = true;
            this.enableDiscord.CheckedChanged += new System.EventHandler(this.enableDiscord_CheckedChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 386);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.debugText);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.l4);
            this.Controls.Add(this.moduleList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.enableTest);
            this.Controls.Add(this.enableSkype);
            this.Name = "MainForm";
            this.Text = "SkyBot";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox enableSkype;
        private System.Windows.Forms.CheckBox enableVK;
        private System.Windows.Forms.CheckBox enableTelegram;
        private System.Windows.Forms.CheckBox enableTest;
        private System.Windows.Forms.TextBox vkLogin;
        private System.Windows.Forms.TextBox vkPassword;
        private System.Windows.Forms.TextBox vkAppID;
        private System.Windows.Forms.Button vkSave;
        private System.Windows.Forms.Label l1;
        private System.Windows.Forms.Label l2;
        private System.Windows.Forms.Label l3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox moduleList;
        private System.Windows.Forms.Label l4;
        public System.Windows.Forms.Label vkStatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label l5;
        private System.Windows.Forms.Button tgSave;
        private System.Windows.Forms.TextBox tgToken;
        public System.Windows.Forms.Label tgStatus;
        public System.Windows.Forms.TextBox debugText;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button discordSave;
        private System.Windows.Forms.TextBox discordToken;
        public System.Windows.Forms.Label discordStatus;
        private System.Windows.Forms.CheckBox enableDiscord;
    }
}

