namespace CrashGame
{
    partial class CrashGame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CrashGame));
            this.labelGitHub = new System.Windows.Forms.Label();
            this.labelAirSoftick = new System.Windows.Forms.Label();
            this.buttonKeyBind = new Guna.UI2.WinForms.Guna2Button();
            this.DragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.panelController = new System.Windows.Forms.Panel();
            this.bttMinimize = new Guna.UI2.WinForms.Guna2Button();
            this.bttClose = new Guna.UI2.WinForms.Guna2Button();
            this.bttStartProcess = new Guna.UI2.WinForms.Guna2Button();
            this.txt = new Guna.UI2.WinForms.Guna2TextBox();
            this.labelNameNotExe = new System.Windows.Forms.Label();
            this.toggleCloseForCrash = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.labelCloseProgramForCrash = new System.Windows.Forms.Label();
            this.labelTopMost = new System.Windows.Forms.Label();
            this.toggleActiveTopMost = new Guna.UI2.WinForms.Guna2ToggleSwitch();
            this.panelController.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelGitHub
            // 
            this.labelGitHub.AutoSize = true;
            this.labelGitHub.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelGitHub.ForeColor = System.Drawing.Color.White;
            this.labelGitHub.Location = new System.Drawing.Point(163, 126);
            this.labelGitHub.Name = "labelGitHub";
            this.labelGitHub.Size = new System.Drawing.Size(61, 18);
            this.labelGitHub.TabIndex = 0;
            this.labelGitHub.Text = "GITHUB";
            // 
            // labelAirSoftick
            // 
            this.labelAirSoftick.AutoSize = true;
            this.labelAirSoftick.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelAirSoftick.ForeColor = System.Drawing.Color.White;
            this.labelAirSoftick.Location = new System.Drawing.Point(230, 126);
            this.labelAirSoftick.Name = "labelAirSoftick";
            this.labelAirSoftick.Size = new System.Drawing.Size(73, 18);
            this.labelAirSoftick.TabIndex = 1;
            this.labelAirSoftick.Text = "AirSoftick";
            // 
            // buttonKeyBind
            // 
            this.buttonKeyBind.Animated = true;
            this.buttonKeyBind.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.buttonKeyBind.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.buttonKeyBind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.buttonKeyBind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.buttonKeyBind.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.buttonKeyBind.ForeColor = System.Drawing.Color.White;
            this.buttonKeyBind.Location = new System.Drawing.Point(0, 171);
            this.buttonKeyBind.Name = "buttonKeyBind";
            this.buttonKeyBind.Size = new System.Drawing.Size(236, 45);
            this.buttonKeyBind.TabIndex = 2;
            this.buttonKeyBind.Text = "2";
            this.buttonKeyBind.Click += new System.EventHandler(this.buttonKeyBind_Click);
            this.buttonKeyBind.KeyUp += new System.Windows.Forms.KeyEventHandler(this.buttonKeyBind_KeyUp);
            // 
            // DragControl
            // 
            this.DragControl.DockIndicatorTransparencyValue = 0.6D;
            this.DragControl.TargetControl = this.panelController;
            this.DragControl.TransparentWhileDrag = false;
            // 
            // panelController
            // 
            this.panelController.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.panelController.Controls.Add(this.bttMinimize);
            this.panelController.Controls.Add(this.bttClose);
            this.panelController.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelController.Location = new System.Drawing.Point(0, 0);
            this.panelController.Name = "panelController";
            this.panelController.Size = new System.Drawing.Size(463, 35);
            this.panelController.TabIndex = 10;
            // 
            // bttMinimize
            // 
            this.bttMinimize.Animated = true;
            this.bttMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttMinimize.CustomBorderColor = System.Drawing.Color.Lime;
            this.bttMinimize.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.bttMinimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bttMinimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bttMinimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bttMinimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bttMinimize.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.bttMinimize.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.bttMinimize.ForeColor = System.Drawing.Color.White;
            this.bttMinimize.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.bttMinimize.Location = new System.Drawing.Point(381, 0);
            this.bttMinimize.Name = "bttMinimize";
            this.bttMinimize.Size = new System.Drawing.Size(38, 35);
            this.bttMinimize.TabIndex = 24;
            this.bttMinimize.Text = "➖";
            this.bttMinimize.Click += new System.EventHandler(this.bttMinimize_Click);
            // 
            // bttClose
            // 
            this.bttClose.Animated = true;
            this.bttClose.BackColor = System.Drawing.Color.Transparent;
            this.bttClose.BorderColor = System.Drawing.Color.Empty;
            this.bttClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttClose.CustomBorderColor = System.Drawing.Color.Red;
            this.bttClose.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 3);
            this.bttClose.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.bttClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bttClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bttClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bttClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.bttClose.Font = new System.Drawing.Font("Comic Sans MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.bttClose.ForeColor = System.Drawing.Color.White;
            this.bttClose.HoverState.CustomBorderColor = System.Drawing.Color.White;
            this.bttClose.Location = new System.Drawing.Point(425, 0);
            this.bttClose.Name = "bttClose";
            this.bttClose.Size = new System.Drawing.Size(38, 35);
            this.bttClose.TabIndex = 22;
            this.bttClose.Text = "✖";
            this.bttClose.Click += new System.EventHandler(this.bttClose_Click);
            // 
            // bttStartProcess
            // 
            this.bttStartProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bttStartProcess.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.bttStartProcess.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.bttStartProcess.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.bttStartProcess.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.bttStartProcess.Font = new System.Drawing.Font("Trebuchet MS", 11.25F, System.Drawing.FontStyle.Bold);
            this.bttStartProcess.ForeColor = System.Drawing.Color.White;
            this.bttStartProcess.Location = new System.Drawing.Point(242, 171);
            this.bttStartProcess.Name = "bttStartProcess";
            this.bttStartProcess.Size = new System.Drawing.Size(221, 45);
            this.bttStartProcess.TabIndex = 3;
            this.bttStartProcess.Text = "START";
            this.bttStartProcess.Click += new System.EventHandler(this.bttStartProcess_Click);
            // 
            // txt
            // 
            this.txt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt.Animated = true;
            this.txt.AutoRoundedCorners = true;
            this.txt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txt.BorderRadius = 17;
            this.txt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt.DefaultText = "";
            this.txt.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txt.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txt.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt.Font = new System.Drawing.Font("Comic Sans MS", 9.75F);
            this.txt.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txt.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.txt.Location = new System.Drawing.Point(138, 60);
            this.txt.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt.Name = "txt";
            this.txt.PasswordChar = '\0';
            this.txt.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.txt.PlaceholderText = "> БЕЗ .ЕХЕ";
            this.txt.SelectedText = "";
            this.txt.Size = new System.Drawing.Size(186, 37);
            this.txt.TabIndex = 4;
            // 
            // labelNameNotExe
            // 
            this.labelNameNotExe.AutoSize = true;
            this.labelNameNotExe.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelNameNotExe.ForeColor = System.Drawing.Color.White;
            this.labelNameNotExe.Location = new System.Drawing.Point(176, 38);
            this.labelNameNotExe.Name = "labelNameNotExe";
            this.labelNameNotExe.Size = new System.Drawing.Size(109, 18);
            this.labelNameNotExe.TabIndex = 5;
            this.labelNameNotExe.Text = "Name || Без .exe";
            // 
            // toggleCloseForCrash
            // 
            this.toggleCloseForCrash.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleCloseForCrash.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleCloseForCrash.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleCloseForCrash.CheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleCloseForCrash.Location = new System.Drawing.Point(103, 101);
            this.toggleCloseForCrash.Name = "toggleCloseForCrash";
            this.toggleCloseForCrash.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.toggleCloseForCrash.Size = new System.Drawing.Size(35, 20);
            this.toggleCloseForCrash.TabIndex = 6;
            this.toggleCloseForCrash.UncheckedState.BorderColor = System.Drawing.Color.Red;
            this.toggleCloseForCrash.UncheckedState.FillColor = System.Drawing.Color.Red;
            this.toggleCloseForCrash.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleCloseForCrash.UncheckedState.InnerColor = System.Drawing.Color.White;
            // 
            // labelCloseProgramForCrash
            // 
            this.labelCloseProgramForCrash.AutoSize = true;
            this.labelCloseProgramForCrash.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCloseProgramForCrash.ForeColor = System.Drawing.Color.White;
            this.labelCloseProgramForCrash.Location = new System.Drawing.Point(144, 101);
            this.labelCloseProgramForCrash.Name = "labelCloseProgramForCrash";
            this.labelCloseProgramForCrash.Size = new System.Drawing.Size(213, 18);
            this.labelCloseProgramForCrash.TabIndex = 7;
            this.labelCloseProgramForCrash.Text = "закрыть программу после краша";
            // 
            // labelTopMost
            // 
            this.labelTopMost.AutoSize = true;
            this.labelTopMost.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelTopMost.ForeColor = System.Drawing.Color.White;
            this.labelTopMost.Location = new System.Drawing.Point(211, 149);
            this.labelTopMost.Name = "labelTopMost";
            this.labelTopMost.Size = new System.Drawing.Size(73, 18);
            this.labelTopMost.TabIndex = 9;
            this.labelTopMost.Text = "TOPMOST";
            // 
            // toggleActiveTopMost
            // 
            this.toggleActiveTopMost.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleActiveTopMost.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.toggleActiveTopMost.CheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleActiveTopMost.CheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleActiveTopMost.Location = new System.Drawing.Point(176, 148);
            this.toggleActiveTopMost.Name = "toggleActiveTopMost";
            this.toggleActiveTopMost.ShadowDecoration.Color = System.Drawing.Color.Red;
            this.toggleActiveTopMost.Size = new System.Drawing.Size(35, 20);
            this.toggleActiveTopMost.TabIndex = 8;
            this.toggleActiveTopMost.UncheckedState.BorderColor = System.Drawing.Color.Red;
            this.toggleActiveTopMost.UncheckedState.FillColor = System.Drawing.Color.Red;
            this.toggleActiveTopMost.UncheckedState.InnerBorderColor = System.Drawing.Color.White;
            this.toggleActiveTopMost.UncheckedState.InnerColor = System.Drawing.Color.White;
            this.toggleActiveTopMost.CheckedChanged += new System.EventHandler(this.toggleActiveTopMost_CheckedChanged);
            // 
            // CrashGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(463, 215);
            this.Controls.Add(this.panelController);
            this.Controls.Add(this.labelTopMost);
            this.Controls.Add(this.toggleActiveTopMost);
            this.Controls.Add(this.labelCloseProgramForCrash);
            this.Controls.Add(this.toggleCloseForCrash);
            this.Controls.Add(this.labelNameNotExe);
            this.Controls.Add(this.txt);
            this.Controls.Add(this.bttStartProcess);
            this.Controls.Add(this.buttonKeyBind);
            this.Controls.Add(this.labelAirSoftick);
            this.Controls.Add(this.labelGitHub);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.HelpButton = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximumSize = new System.Drawing.Size(477, 215);
            this.MinimumSize = new System.Drawing.Size(1, 1);
            this.Name = "CrashGame";
            this.RightToLeftLayout = true;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CrashGame";
            this.panelController.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelGitHub;
        private System.Windows.Forms.Label labelAirSoftick;
        private Guna.UI2.WinForms.Guna2Button buttonKeyBind;
        private Guna.UI2.WinForms.Guna2DragControl DragControl;
        private Guna.UI2.WinForms.Guna2Button bttStartProcess;
        private Guna.UI2.WinForms.Guna2TextBox txt;
        private System.Windows.Forms.Label labelNameNotExe;
        private Guna.UI2.WinForms.Guna2ToggleSwitch toggleCloseForCrash;
        private System.Windows.Forms.Label labelCloseProgramForCrash;
        private System.Windows.Forms.Label labelTopMost;
        private System.Windows.Forms.Panel panelController;
        private Guna.UI2.WinForms.Guna2Button bttMinimize;
        private Guna.UI2.WinForms.Guna2Button bttClose;
        private Guna.UI2.WinForms.Guna2ToggleSwitch toggleActiveTopMost;
    }
}