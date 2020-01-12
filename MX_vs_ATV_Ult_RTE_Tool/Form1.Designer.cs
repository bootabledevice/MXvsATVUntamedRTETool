namespace MX_vs_ATV_Ult_RTE_Tool
{
    partial class Form1
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
            this.connectConsole = new MetroFramework.Controls.MetroButton();
            this.comboFive = new MetroFramework.Controls.MetroButton();
            this.comboEight = new MetroFramework.Controls.MetroButton();
            this.comboTen = new MetroFramework.Controls.MetroButton();
            this.setMoney = new MetroFramework.Controls.MetroButton();
            this.moneyValue = new MetroFramework.Controls.MetroTextBox();
            this.setFreestyle = new MetroFramework.Controls.MetroButton();
            this.freestyleValue = new MetroFramework.Controls.MetroTextBox();
            this.consoleStatus = new MetroFramework.Controls.MetroLabel();
            this.comboFiveStatus = new MetroFramework.Controls.MetroLabel();
            this.comboEightStatus = new MetroFramework.Controls.MetroLabel();
            this.comboTenStatus = new MetroFramework.Controls.MetroLabel();
            this.comboFiveTimer = new System.Windows.Forms.Timer(this.components);
            this.comboEightTimer = new System.Windows.Forms.Timer(this.components);
            this.comboTenTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // connectConsole
            // 
            this.connectConsole.Location = new System.Drawing.Point(24, 64);
            this.connectConsole.Name = "connectConsole";
            this.connectConsole.Size = new System.Drawing.Size(131, 32);
            this.connectConsole.TabIndex = 0;
            this.connectConsole.Text = "Connect To Console";
            this.connectConsole.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.connectConsole.UseSelectable = true;
            this.connectConsole.Click += new System.EventHandler(this.connectConsole_Click);
            // 
            // comboFive
            // 
            this.comboFive.Location = new System.Drawing.Point(24, 102);
            this.comboFive.Name = "comboFive";
            this.comboFive.Size = new System.Drawing.Size(131, 32);
            this.comboFive.TabIndex = 1;
            this.comboFive.Text = "Always 5x Combo";
            this.comboFive.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.comboFive.UseSelectable = true;
            this.comboFive.Click += new System.EventHandler(this.comboFive_Click);
            // 
            // comboEight
            // 
            this.comboEight.Location = new System.Drawing.Point(24, 140);
            this.comboEight.Name = "comboEight";
            this.comboEight.Size = new System.Drawing.Size(131, 32);
            this.comboEight.TabIndex = 2;
            this.comboEight.Text = "Always 8x Combo";
            this.comboEight.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.comboEight.UseSelectable = true;
            this.comboEight.Click += new System.EventHandler(this.comboEight_Click);
            // 
            // comboTen
            // 
            this.comboTen.Location = new System.Drawing.Point(24, 178);
            this.comboTen.Name = "comboTen";
            this.comboTen.Size = new System.Drawing.Size(131, 31);
            this.comboTen.TabIndex = 3;
            this.comboTen.Text = "Always 10x Combo";
            this.comboTen.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.comboTen.UseSelectable = true;
            this.comboTen.Click += new System.EventHandler(this.comboTen_Click);
            // 
            // setMoney
            // 
            this.setMoney.Location = new System.Drawing.Point(245, 63);
            this.setMoney.Name = "setMoney";
            this.setMoney.Size = new System.Drawing.Size(131, 32);
            this.setMoney.TabIndex = 4;
            this.setMoney.Text = "Set Money";
            this.setMoney.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.setMoney.UseSelectable = true;
            this.setMoney.Click += new System.EventHandler(this.setMoney_Click);
            // 
            // moneyValue
            // 
            // 
            // 
            // 
            this.moneyValue.CustomButton.Image = null;
            this.moneyValue.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.moneyValue.CustomButton.Name = "";
            this.moneyValue.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.moneyValue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.moneyValue.CustomButton.TabIndex = 1;
            this.moneyValue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.moneyValue.CustomButton.UseSelectable = true;
            this.moneyValue.CustomButton.Visible = false;
            this.moneyValue.Lines = new string[0];
            this.moneyValue.Location = new System.Drawing.Point(245, 101);
            this.moneyValue.MaxLength = 32767;
            this.moneyValue.Name = "moneyValue";
            this.moneyValue.PasswordChar = '\0';
            this.moneyValue.PromptText = "Enter $ Amount";
            this.moneyValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.moneyValue.SelectedText = "";
            this.moneyValue.SelectionLength = 0;
            this.moneyValue.SelectionStart = 0;
            this.moneyValue.ShortcutsEnabled = true;
            this.moneyValue.Size = new System.Drawing.Size(131, 23);
            this.moneyValue.TabIndex = 5;
            this.moneyValue.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.moneyValue.UseSelectable = true;
            this.moneyValue.WaterMark = "Enter $ Amount";
            this.moneyValue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.moneyValue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.moneyValue.Click += new System.EventHandler(this.moneyValue_Click);
            // 
            // setFreestyle
            // 
            this.setFreestyle.Location = new System.Drawing.Point(245, 130);
            this.setFreestyle.Name = "setFreestyle";
            this.setFreestyle.Size = new System.Drawing.Size(131, 31);
            this.setFreestyle.TabIndex = 6;
            this.setFreestyle.Text = "Set Freestyle Score";
            this.setFreestyle.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.setFreestyle.UseSelectable = true;
            this.setFreestyle.Click += new System.EventHandler(this.setFreestyle_Click);
            // 
            // freestyleValue
            // 
            // 
            // 
            // 
            this.freestyleValue.CustomButton.Image = null;
            this.freestyleValue.CustomButton.Location = new System.Drawing.Point(109, 1);
            this.freestyleValue.CustomButton.Name = "";
            this.freestyleValue.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.freestyleValue.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.freestyleValue.CustomButton.TabIndex = 1;
            this.freestyleValue.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.freestyleValue.CustomButton.UseSelectable = true;
            this.freestyleValue.CustomButton.Visible = false;
            this.freestyleValue.Lines = new string[0];
            this.freestyleValue.Location = new System.Drawing.Point(245, 167);
            this.freestyleValue.MaxLength = 32767;
            this.freestyleValue.Name = "freestyleValue";
            this.freestyleValue.PasswordChar = '\0';
            this.freestyleValue.PromptText = "Enter Freestyle Score";
            this.freestyleValue.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.freestyleValue.SelectedText = "";
            this.freestyleValue.SelectionLength = 0;
            this.freestyleValue.SelectionStart = 0;
            this.freestyleValue.ShortcutsEnabled = true;
            this.freestyleValue.Size = new System.Drawing.Size(131, 23);
            this.freestyleValue.TabIndex = 7;
            this.freestyleValue.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.freestyleValue.UseSelectable = true;
            this.freestyleValue.WaterMark = "Enter Freestyle Score";
            this.freestyleValue.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.freestyleValue.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.freestyleValue.Click += new System.EventHandler(this.freestyleValue_Click);
            // 
            // consoleStatus
            // 
            this.consoleStatus.AutoSize = true;
            this.consoleStatus.Location = new System.Drawing.Point(162, 76);
            this.consoleStatus.Name = "consoleStatus";
            this.consoleStatus.Size = new System.Drawing.Size(0, 0);
            this.consoleStatus.TabIndex = 8;
            this.consoleStatus.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // comboFiveStatus
            // 
            this.comboFiveStatus.AutoSize = true;
            this.comboFiveStatus.Location = new System.Drawing.Point(162, 114);
            this.comboFiveStatus.Name = "comboFiveStatus";
            this.comboFiveStatus.Size = new System.Drawing.Size(0, 0);
            this.comboFiveStatus.TabIndex = 9;
            this.comboFiveStatus.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // comboEightStatus
            // 
            this.comboEightStatus.AutoSize = true;
            this.comboEightStatus.Location = new System.Drawing.Point(162, 152);
            this.comboEightStatus.Name = "comboEightStatus";
            this.comboEightStatus.Size = new System.Drawing.Size(0, 0);
            this.comboEightStatus.TabIndex = 10;
            this.comboEightStatus.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // comboTenStatus
            // 
            this.comboTenStatus.AutoSize = true;
            this.comboTenStatus.Location = new System.Drawing.Point(162, 189);
            this.comboTenStatus.Name = "comboTenStatus";
            this.comboTenStatus.Size = new System.Drawing.Size(0, 0);
            this.comboTenStatus.TabIndex = 11;
            this.comboTenStatus.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // comboFiveTimer
            // 
            this.comboFiveTimer.Tick += new System.EventHandler(this.comboFiveTimer_Tick);
            // 
            // comboEightTimer
            // 
            this.comboEightTimer.Tick += new System.EventHandler(this.comboEightTimer_Tick);
            // 
            // comboTenTimer
            // 
            this.comboTenTimer.Tick += new System.EventHandler(this.comboTenTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CausesValidation = false;
            this.ClientSize = new System.Drawing.Size(466, 297);
            this.Controls.Add(this.comboTenStatus);
            this.Controls.Add(this.comboEightStatus);
            this.Controls.Add(this.comboFiveStatus);
            this.Controls.Add(this.consoleStatus);
            this.Controls.Add(this.freestyleValue);
            this.Controls.Add(this.setFreestyle);
            this.Controls.Add(this.moneyValue);
            this.Controls.Add(this.setMoney);
            this.Controls.Add(this.comboTen);
            this.Controls.Add(this.comboEight);
            this.Controls.Add(this.comboFive);
            this.Controls.Add(this.connectConsole);
            this.Name = "Form1";
            this.Text = "MX vs ATV RTE Tool";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroButton connectConsole;
        private MetroFramework.Controls.MetroButton comboFive;
        private MetroFramework.Controls.MetroButton comboEight;
        private MetroFramework.Controls.MetroButton comboTen;
        private MetroFramework.Controls.MetroButton setMoney;
        private MetroFramework.Controls.MetroTextBox moneyValue;
        private MetroFramework.Controls.MetroButton setFreestyle;
        private MetroFramework.Controls.MetroTextBox freestyleValue;
        private MetroFramework.Controls.MetroLabel consoleStatus;
        private MetroFramework.Controls.MetroLabel comboFiveStatus;
        private MetroFramework.Controls.MetroLabel comboEightStatus;
        private MetroFramework.Controls.MetroLabel comboTenStatus;
        private System.Windows.Forms.Timer comboFiveTimer;
        private System.Windows.Forms.Timer comboEightTimer;
        private System.Windows.Forms.Timer comboTenTimer;
    }
}

