
namespace LFPeasy.src.Forms
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pbProfile = new AboutUsFormDemo.CircularPictureBox();
            this.pbProfileBottom = new System.Windows.Forms.PictureBox();
            this.lblUsername = new WindowsUI.Controls.WinLabel();
            this.pbLevel = new WindowsUI.Controls.WinProgressbar();
            this.cbAutoAccept = new WindowsUI.Controls.WinCheckbox();
            this.lblAutoAccept = new WindowsUI.Controls.WinLabel();
            this.btnAramBoost = new WindowsUI.WinButton();
            this.pbRP = new System.Windows.Forms.PictureBox();
            this.pbBE = new System.Windows.Forms.PictureBox();
            this.lblRP = new WindowsUI.Controls.WinLabel();
            this.lblBE = new WindowsUI.Controls.WinLabel();
            this.btnCreateCustomLobby = new WindowsUI.WinButton();
            this.btnGithub = new WindowsUI.Controls.WinTileButton();
            this.tbStatus = new WindowsUI.Controls.WinTextbox();
            this.btnChangeStatus = new WindowsUI.WinButton();
            this.lblTimeStatus = new WindowsUI.Controls.WinLabel();
            this.cbTimeStatus = new WindowsUI.Controls.WinCheckbox();
            this.tUpdateProfile = new System.Windows.Forms.Timer(this.components);
            this.tCore = new System.Windows.Forms.Timer(this.components);
            this.pnlTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfileBottom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBE)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnMinimaze);
            this.pnlTop.Controls.Add(this.btnMaximize);
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Size = new System.Drawing.Size(636, 30);
            this.pnlTop.Controls.SetChildIndex(this.btnClose, 0);
            this.pnlTop.Controls.SetChildIndex(this.btnMaximize, 0);
            this.pnlTop.Controls.SetChildIndex(this.btnMinimaze, 0);
            // 
            // btnMinimaze
            // 
            this.btnMinimaze.BackColor = System.Drawing.Color.Black;
            this.btnMinimaze.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimaze.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimaze.FlatAppearance.BorderSize = 0;
            this.btnMinimaze.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnMinimaze.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnMinimaze.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimaze.Font = new System.Drawing.Font("Segoe UI Symbol", 9F);
            this.btnMinimaze.ForeColor = System.Drawing.Color.White;
            this.btnMinimaze.Location = new System.Drawing.Point(532, 0);
            this.btnMinimaze.Size = new System.Drawing.Size(52, 30);
            this.btnMinimaze.Text = "─";
            this.btnMinimaze.UseVisualStyleBackColor = false;
            // 
            // btnMaximize
            // 
            this.btnMaximize.BackColor = System.Drawing.Color.Black;
            this.btnMaximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMaximize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.btnMaximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Font = new System.Drawing.Font("Segoe UI Symbol", 9F);
            this.btnMaximize.ForeColor = System.Drawing.Color.White;
            this.btnMaximize.Location = new System.Drawing.Point(532, 0);
            this.btnMaximize.Size = new System.Drawing.Size(52, 30);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.Text = "◻";
            this.btnMaximize.UseVisualStyleBackColor = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Black;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkRed;
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI Symbol", 9F);
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(584, 0);
            this.btnClose.Size = new System.Drawing.Size(52, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "✕";
            this.btnClose.UseVisualStyleBackColor = false;
            // 
            // pbProfile
            // 
            this.pbProfile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.pbProfile.Location = new System.Drawing.Point(12, 42);
            this.pbProfile.Name = "pbProfile";
            this.pbProfile.Size = new System.Drawing.Size(64, 64);
            this.pbProfile.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbProfile.TabIndex = 2;
            this.pbProfile.TabStop = false;
            // 
            // pbProfileBottom
            // 
            this.pbProfileBottom.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(53)))), ((int)(((byte)(53)))));
            this.pbProfileBottom.Location = new System.Drawing.Point(38, 72);
            this.pbProfileBottom.Name = "pbProfileBottom";
            this.pbProfileBottom.Size = new System.Drawing.Size(586, 33);
            this.pbProfileBottom.TabIndex = 3;
            this.pbProfileBottom.TabStop = false;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblUsername.ForeColor = System.Drawing.Color.White;
            this.lblUsername.Location = new System.Drawing.Point(77, 48);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(78, 20);
            this.lblUsername.TabIndex = 4;
            this.lblUsername.Text = "Username";
            // 
            // pbLevel
            // 
            this.pbLevel.BackColor = System.Drawing.Color.Transparent;
            this.pbLevel.Border = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.pbLevel.Content = "";
            this.pbLevel.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.pbLevel.ForeColor = System.Drawing.Color.White;
            this.pbLevel.Location = new System.Drawing.Point(51, 77);
            this.pbLevel.Name = "pbLevel";
            this.pbLevel.Normal = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pbLevel.Progress1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.pbLevel.Progress2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.pbLevel.Size = new System.Drawing.Size(568, 23);
            this.pbLevel.TabIndex = 5;
            // 
            // cbAutoAccept
            // 
            this.cbAutoAccept.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.cbAutoAccept.BorderColor = System.Drawing.Color.Gray;
            this.cbAutoAccept.Checked = false;
            this.cbAutoAccept.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbAutoAccept.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.cbAutoAccept.ForeColor = System.Drawing.Color.White;
            this.cbAutoAccept.Location = new System.Drawing.Point(183, 116);
            this.cbAutoAccept.Name = "cbAutoAccept";
            this.cbAutoAccept.Size = new System.Drawing.Size(16, 16);
            this.cbAutoAccept.SizeMode = WindowsUI.Enums.SizeMode.Normal;
            this.cbAutoAccept.TabIndex = 6;
            this.cbAutoAccept.CheckedChanged += new WindowsUI.Controls.WinCheckbox.checkedChanged(this.cbAutoAccept_CheckedChanged);
            // 
            // lblAutoAccept
            // 
            this.lblAutoAccept.AutoSize = true;
            this.lblAutoAccept.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblAutoAccept.ForeColor = System.Drawing.Color.White;
            this.lblAutoAccept.Location = new System.Drawing.Point(201, 116);
            this.lblAutoAccept.Name = "lblAutoAccept";
            this.lblAutoAccept.Size = new System.Drawing.Size(73, 15);
            this.lblAutoAccept.TabIndex = 7;
            this.lblAutoAccept.Text = "Auto Accept";
            // 
            // btnAramBoost
            // 
            this.btnAramBoost.Border = System.Drawing.Color.Gray;
            this.btnAramBoost.BorderSize = 1F;
            this.btnAramBoost.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAramBoost.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnAramBoost.ForeColor = System.Drawing.Color.White;
            this.btnAramBoost.Image = null;
            this.btnAramBoost.ImageAnchor = WindowsUI.Enums.ButtonImageAnchor.Left;
            this.btnAramBoost.Location = new System.Drawing.Point(51, 112);
            this.btnAramBoost.Name = "btnAramBoost";
            this.btnAramBoost.Normal = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnAramBoost.Press = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnAramBoost.Selected = false;
            this.btnAramBoost.SelectedBorderSize = 2;
            this.btnAramBoost.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnAramBoost.SelectedStyle = WindowsUI.Enums.SelectedStyle.Left;
            this.btnAramBoost.Size = new System.Drawing.Size(126, 23);
            this.btnAramBoost.TabIndex = 8;
            this.btnAramBoost.Text = "ARAM/Urf Skin Boost";
            this.btnAramBoost.UseVisualStyleBackColor = true;
            this.btnAramBoost.Click += new System.EventHandler(this.btnAramBoost_Click);
            // 
            // pbRP
            // 
            this.pbRP.Image = ((System.Drawing.Image)(resources.GetObject("pbRP.Image")));
            this.pbRP.Location = new System.Drawing.Point(502, 44);
            this.pbRP.Name = "pbRP";
            this.pbRP.Size = new System.Drawing.Size(24, 24);
            this.pbRP.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbRP.TabIndex = 9;
            this.pbRP.TabStop = false;
            // 
            // pbBE
            // 
            this.pbBE.Image = ((System.Drawing.Image)(resources.GetObject("pbBE.Image")));
            this.pbBE.Location = new System.Drawing.Point(360, 42);
            this.pbBE.Name = "pbBE";
            this.pbBE.Size = new System.Drawing.Size(24, 24);
            this.pbBE.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbBE.TabIndex = 10;
            this.pbBE.TabStop = false;
            // 
            // lblRP
            // 
            this.lblRP.AutoSize = true;
            this.lblRP.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblRP.ForeColor = System.Drawing.Color.White;
            this.lblRP.Location = new System.Drawing.Point(528, 46);
            this.lblRP.Name = "lblRP";
            this.lblRP.Size = new System.Drawing.Size(17, 20);
            this.lblRP.TabIndex = 11;
            this.lblRP.Text = "0";
            // 
            // lblBE
            // 
            this.lblBE.AutoSize = true;
            this.lblBE.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.lblBE.ForeColor = System.Drawing.Color.White;
            this.lblBE.Location = new System.Drawing.Point(386, 44);
            this.lblBE.Name = "lblBE";
            this.lblBE.Size = new System.Drawing.Size(17, 20);
            this.lblBE.TabIndex = 12;
            this.lblBE.Text = "0";
            // 
            // btnCreateCustomLobby
            // 
            this.btnCreateCustomLobby.Border = System.Drawing.Color.Gray;
            this.btnCreateCustomLobby.BorderSize = 1F;
            this.btnCreateCustomLobby.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCreateCustomLobby.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnCreateCustomLobby.ForeColor = System.Drawing.Color.White;
            this.btnCreateCustomLobby.Image = null;
            this.btnCreateCustomLobby.ImageAnchor = WindowsUI.Enums.ButtonImageAnchor.Left;
            this.btnCreateCustomLobby.Location = new System.Drawing.Point(51, 141);
            this.btnCreateCustomLobby.Name = "btnCreateCustomLobby";
            this.btnCreateCustomLobby.Normal = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnCreateCustomLobby.Press = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnCreateCustomLobby.Selected = false;
            this.btnCreateCustomLobby.SelectedBorderSize = 2;
            this.btnCreateCustomLobby.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnCreateCustomLobby.SelectedStyle = WindowsUI.Enums.SelectedStyle.Left;
            this.btnCreateCustomLobby.Size = new System.Drawing.Size(126, 23);
            this.btnCreateCustomLobby.TabIndex = 13;
            this.btnCreateCustomLobby.Text = "Create 5v5 Bot Lobby";
            this.btnCreateCustomLobby.UseVisualStyleBackColor = true;
            this.btnCreateCustomLobby.Click += new System.EventHandler(this.btnCreateCustomLobby_Click);
            // 
            // btnGithub
            // 
            this.btnGithub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnGithub.CenterStyle = WindowsUI.Enums.CenterStyle.BelowImage;
            this.btnGithub.Content = "Github";
            this.btnGithub.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnGithub.ForeColor = System.Drawing.Color.White;
            this.btnGithub.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(33)))), ((int)(((byte)(59)))));
            this.btnGithub.Image = ((System.Drawing.Image)(resources.GetObject("btnGithub.Image")));
            this.btnGithub.Location = new System.Drawing.Point(564, 111);
            this.btnGithub.Name = "btnGithub";
            this.btnGithub.Normal = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnGithub.Press = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(66)))), ((int)(((byte)(118)))));
            this.btnGithub.Size = new System.Drawing.Size(60, 53);
            this.btnGithub.TabIndex = 14;
            this.btnGithub.Text = "winTileButton1";
            this.btnGithub.TextAnchor = WindowsUI.Enums.AdvancedTextAnchor.Center;
            this.btnGithub.OnTileButtonMouseClick += new WindowsUI.Controls.WinTileButton.WindowDeletgate(this.btnGithub_OnTileButtonMouseClick);
            // 
            // tbStatus
            // 
            this.tbStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.tbStatus.Content = "";
            this.tbStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.tbStatus.ForeColor = System.Drawing.Color.White;
            this.tbStatus.Image = null;
            this.tbStatus.Location = new System.Drawing.Point(288, 112);
            this.tbStatus.MaxLength = 32767;
            this.tbStatus.Name = "tbStatus";
            this.tbStatus.Normal = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.tbStatus.OnlyNumbers = false;
            this.tbStatus.PassChar = '\0';
            this.tbStatus.ReadOnlyText = false;
            this.tbStatus.Size = new System.Drawing.Size(270, 25);
            this.tbStatus.TabIndex = 15;
            this.tbStatus.Text = "winTextbox1";
            // 
            // btnChangeStatus
            // 
            this.btnChangeStatus.Border = System.Drawing.Color.Gray;
            this.btnChangeStatus.BorderSize = 1F;
            this.btnChangeStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnChangeStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.btnChangeStatus.ForeColor = System.Drawing.Color.White;
            this.btnChangeStatus.Image = ((System.Drawing.Image)(resources.GetObject("btnChangeStatus.Image")));
            this.btnChangeStatus.ImageAnchor = WindowsUI.Enums.ButtonImageAnchor.CenterRight;
            this.btnChangeStatus.Location = new System.Drawing.Point(288, 141);
            this.btnChangeStatus.Name = "btnChangeStatus";
            this.btnChangeStatus.Normal = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnChangeStatus.Press = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.btnChangeStatus.Selected = false;
            this.btnChangeStatus.SelectedBorderSize = 2;
            this.btnChangeStatus.SelectedColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(99)))), ((int)(((byte)(177)))));
            this.btnChangeStatus.SelectedStyle = WindowsUI.Enums.SelectedStyle.Left;
            this.btnChangeStatus.Size = new System.Drawing.Size(270, 23);
            this.btnChangeStatus.TabIndex = 16;
            this.btnChangeStatus.Text = "Change Chat Status";
            this.btnChangeStatus.UseVisualStyleBackColor = true;
            this.btnChangeStatus.Click += new System.EventHandler(this.btnChangeStatus_Click);
            // 
            // lblTimeStatus
            // 
            this.lblTimeStatus.AutoSize = true;
            this.lblTimeStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 9F);
            this.lblTimeStatus.ForeColor = System.Drawing.Color.White;
            this.lblTimeStatus.Location = new System.Drawing.Point(201, 145);
            this.lblTimeStatus.Name = "lblTimeStatus";
            this.lblTimeStatus.Size = new System.Drawing.Size(68, 15);
            this.lblTimeStatus.TabIndex = 18;
            this.lblTimeStatus.Text = "Time status";
            // 
            // cbTimeStatus
            // 
            this.cbTimeStatus.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.cbTimeStatus.BorderColor = System.Drawing.Color.Gray;
            this.cbTimeStatus.Checked = false;
            this.cbTimeStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbTimeStatus.Font = new System.Drawing.Font("Segoe UI Semibold", 11F);
            this.cbTimeStatus.ForeColor = System.Drawing.Color.White;
            this.cbTimeStatus.Location = new System.Drawing.Point(183, 145);
            this.cbTimeStatus.Name = "cbTimeStatus";
            this.cbTimeStatus.Size = new System.Drawing.Size(16, 16);
            this.cbTimeStatus.SizeMode = WindowsUI.Enums.SizeMode.Normal;
            this.cbTimeStatus.TabIndex = 17;
            this.cbTimeStatus.CheckedChanged += new WindowsUI.Controls.WinCheckbox.checkedChanged(this.cbTimeStatus_CheckedChanged);
            // 
            // tUpdateProfile
            // 
            this.tUpdateProfile.Enabled = true;
            this.tUpdateProfile.Interval = 2500;
            this.tUpdateProfile.Tick += new System.EventHandler(this.tUpdateProfile_Tick);
            // 
            // tCore
            // 
            this.tCore.Enabled = true;
            this.tCore.Interval = 1000;
            this.tCore.Tick += new System.EventHandler(this.tCore_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 177);
            this.Controls.Add(this.lblTimeStatus);
            this.Controls.Add(this.cbTimeStatus);
            this.Controls.Add(this.btnChangeStatus);
            this.Controls.Add(this.tbStatus);
            this.Controls.Add(this.btnGithub);
            this.Controls.Add(this.btnCreateCustomLobby);
            this.Controls.Add(this.lblBE);
            this.Controls.Add(this.lblRP);
            this.Controls.Add(this.pbBE);
            this.Controls.Add(this.pbRP);
            this.Controls.Add(this.btnAramBoost);
            this.Controls.Add(this.lblAutoAccept);
            this.Controls.Add(this.cbAutoAccept);
            this.Controls.Add(this.pbProfile);
            this.Controls.Add(this.pbLevel);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.pbProfileBottom);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximizeButton = false;
            this.Name = "MainForm";
            this.Resizer = false;
            this.Text = "MainForm";
            this.TextAnchor = WindowsUI.Enums.TextAnchor.Center;
            this.Title = "[LF] Peasy - League of Legends Tool";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.Controls.SetChildIndex(this.pnlTop, 0);
            this.Controls.SetChildIndex(this.pbProfileBottom, 0);
            this.Controls.SetChildIndex(this.lblUsername, 0);
            this.Controls.SetChildIndex(this.pbLevel, 0);
            this.Controls.SetChildIndex(this.pbProfile, 0);
            this.Controls.SetChildIndex(this.cbAutoAccept, 0);
            this.Controls.SetChildIndex(this.lblAutoAccept, 0);
            this.Controls.SetChildIndex(this.btnAramBoost, 0);
            this.Controls.SetChildIndex(this.pbRP, 0);
            this.Controls.SetChildIndex(this.pbBE, 0);
            this.Controls.SetChildIndex(this.lblRP, 0);
            this.Controls.SetChildIndex(this.lblBE, 0);
            this.Controls.SetChildIndex(this.btnCreateCustomLobby, 0);
            this.Controls.SetChildIndex(this.btnGithub, 0);
            this.Controls.SetChildIndex(this.tbStatus, 0);
            this.Controls.SetChildIndex(this.btnChangeStatus, 0);
            this.Controls.SetChildIndex(this.cbTimeStatus, 0);
            this.Controls.SetChildIndex(this.lblTimeStatus, 0);
            this.pnlTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbProfile)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbProfileBottom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbRP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBE)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AboutUsFormDemo.CircularPictureBox pbProfile;
        private System.Windows.Forms.PictureBox pbProfileBottom;
        private WindowsUI.Controls.WinLabel lblUsername;
        private WindowsUI.Controls.WinProgressbar pbLevel;
        private WindowsUI.Controls.WinCheckbox cbAutoAccept;
        private WindowsUI.Controls.WinLabel lblAutoAccept;
        private WindowsUI.WinButton btnAramBoost;
        private System.Windows.Forms.PictureBox pbRP;
        private System.Windows.Forms.PictureBox pbBE;
        private WindowsUI.Controls.WinLabel lblRP;
        private WindowsUI.Controls.WinLabel lblBE;
        private WindowsUI.WinButton btnCreateCustomLobby;
        private WindowsUI.Controls.WinTileButton btnGithub;
        private WindowsUI.Controls.WinTextbox tbStatus;
        private WindowsUI.WinButton btnChangeStatus;
        private WindowsUI.Controls.WinLabel lblTimeStatus;
        private WindowsUI.Controls.WinCheckbox cbTimeStatus;
        private System.Windows.Forms.Timer tUpdateProfile;
        private System.Windows.Forms.Timer tCore;
    }
}