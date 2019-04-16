namespace SessionLogger
{
    partial class mainForm
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
            BunifuAnimatorNS.Animation animation1 = new BunifuAnimatorNS.Animation();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.backPanel = new System.Windows.Forms.Panel();
            this.mainButtonPanel = new System.Windows.Forms.Panel();
            this.adminButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.adviserButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.adviseeButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.adminGenerateReportButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.adminEditCoursesButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.adminEditAccountButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.adminEditCoursePanel = new System.Windows.Forms.Panel();
            this.deleteCourseButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.editCourseButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.createCourseButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.coursesDataGridView = new System.Windows.Forms.DataGridView();
            this.searchCoursesTextBox = new Bunifu.Framework.UI.BunifuTextbox();
            this.editAccountPanel = new System.Windows.Forms.Panel();
            this.deleteAccountButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.editAccountButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.createAccountButton = new Bunifu.Framework.UI.BunifuThinButton2();
            this.accountsDataGridView = new System.Windows.Forms.DataGridView();
            this.searchAccountTextBox = new Bunifu.Framework.UI.BunifuTextbox();
            this.adviseePanel = new System.Windows.Forms.Panel();
            this.adviseeRegisterButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.endButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.adviseeActiveSessionListBox = new System.Windows.Forms.ListBox();
            this.adviseeActiveSessionLabel = new System.Windows.Forms.Label();
            this.startButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.adviseePeerAdviserListBox = new System.Windows.Forms.ListBox();
            this.adviseePeerAdviserLabel = new System.Windows.Forms.Label();
            this.adviseeCourseCodeComboBox = new System.Windows.Forms.ComboBox();
            this.adviseeCourseCodeLabel = new System.Windows.Forms.Label();
            this.professionalRadioButton = new System.Windows.Forms.RadioButton();
            this.chemistryRadioButton = new System.Windows.Forms.RadioButton();
            this.physicsRadioButton = new System.Windows.Forms.RadioButton();
            this.mathRadioButton = new System.Windows.Forms.RadioButton();
            this.adviseeProgramTextBox = new System.Windows.Forms.TextBox();
            this.adviseeProgramLabel = new System.Windows.Forms.Label();
            this.adviseeSnTextBox = new System.Windows.Forms.TextBox();
            this.adviseeSnLabel = new System.Windows.Forms.Label();
            this.adviseeNameTextBox = new System.Windows.Forms.TextBox();
            this.adviseeNameLabel = new System.Windows.Forms.Label();
            this.adviserPanel = new System.Windows.Forms.Panel();
            this.adviserLogoutButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.activePeerAdviserListBox = new System.Windows.Forms.ListBox();
            this.activePeerAdviserLabel = new System.Windows.Forms.Label();
            this.adviserLoginButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.bunifuTransition1 = new BunifuAnimatorNS.BunifuTransition(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.backPanel.SuspendLayout();
            this.mainButtonPanel.SuspendLayout();
            this.adminPanel.SuspendLayout();
            this.adminEditCoursePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataGridView)).BeginInit();
            this.editAccountPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataGridView)).BeginInit();
            this.adviseePanel.SuspendLayout();
            this.adviserPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // backPanel
            // 
            this.backPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.backPanel.Controls.Add(this.mainButtonPanel);
            this.backPanel.Controls.Add(this.adminPanel);
            this.backPanel.Controls.Add(this.adviseePanel);
            this.backPanel.Controls.Add(this.adviserPanel);
            this.bunifuTransition1.SetDecoration(this.backPanel, BunifuAnimatorNS.DecorationType.None);
            this.backPanel.Location = new System.Drawing.Point(48, 41);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(1094, 512);
            this.backPanel.TabIndex = 0;
            // 
            // mainButtonPanel
            // 
            this.mainButtonPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainButtonPanel.BackColor = System.Drawing.Color.Maroon;
            this.mainButtonPanel.Controls.Add(this.adminButton);
            this.mainButtonPanel.Controls.Add(this.adviserButton);
            this.mainButtonPanel.Controls.Add(this.adviseeButton);
            this.bunifuTransition1.SetDecoration(this.mainButtonPanel, BunifuAnimatorNS.DecorationType.None);
            this.mainButtonPanel.Location = new System.Drawing.Point(3, 3);
            this.mainButtonPanel.Name = "mainButtonPanel";
            this.mainButtonPanel.Size = new System.Drawing.Size(1088, 61);
            this.mainButtonPanel.TabIndex = 1;
            // 
            // adminButton
            // 
            this.adminButton.Activecolor = System.Drawing.Color.LightCoral;
            this.adminButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adminButton.BackColor = System.Drawing.Color.Maroon;
            this.adminButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adminButton.BorderRadius = 0;
            this.adminButton.ButtonText = "ADMIN";
            this.adminButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.adminButton, BunifuAnimatorNS.DecorationType.None);
            this.adminButton.DisabledColor = System.Drawing.Color.Gray;
            this.adminButton.Iconcolor = System.Drawing.Color.Transparent;
            this.adminButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("adminButton.Iconimage")));
            this.adminButton.Iconimage_right = null;
            this.adminButton.Iconimage_right_Selected = null;
            this.adminButton.Iconimage_Selected = null;
            this.adminButton.IconMarginLeft = 0;
            this.adminButton.IconMarginRight = 0;
            this.adminButton.IconRightVisible = true;
            this.adminButton.IconRightZoom = 0D;
            this.adminButton.IconVisible = false;
            this.adminButton.IconZoom = 90D;
            this.adminButton.IsTab = false;
            this.adminButton.Location = new System.Drawing.Point(843, 3);
            this.adminButton.Name = "adminButton";
            this.adminButton.Normalcolor = System.Drawing.Color.Maroon;
            this.adminButton.OnHovercolor = System.Drawing.Color.LightCoral;
            this.adminButton.OnHoverTextColor = System.Drawing.Color.White;
            this.adminButton.selected = false;
            this.adminButton.Size = new System.Drawing.Size(241, 55);
            this.adminButton.TabIndex = 2;
            this.adminButton.Text = "ADMIN";
            this.adminButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.adminButton.Textcolor = System.Drawing.Color.White;
            this.adminButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminButton.Click += new System.EventHandler(this.adminButton_Click);
            // 
            // adviserButton
            // 
            this.adviserButton.Activecolor = System.Drawing.Color.LightCoral;
            this.adviserButton.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.adviserButton.BackColor = System.Drawing.Color.Maroon;
            this.adviserButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adviserButton.BorderRadius = 0;
            this.adviserButton.ButtonText = "PEER ADVISER";
            this.adviserButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.adviserButton, BunifuAnimatorNS.DecorationType.None);
            this.adviserButton.DisabledColor = System.Drawing.Color.Gray;
            this.adviserButton.Iconcolor = System.Drawing.Color.Transparent;
            this.adviserButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("adviserButton.Iconimage")));
            this.adviserButton.Iconimage_right = null;
            this.adviserButton.Iconimage_right_Selected = null;
            this.adviserButton.Iconimage_Selected = null;
            this.adviserButton.IconMarginLeft = 0;
            this.adviserButton.IconMarginRight = 0;
            this.adviserButton.IconRightVisible = true;
            this.adviserButton.IconRightZoom = 0D;
            this.adviserButton.IconVisible = false;
            this.adviserButton.IconZoom = 90D;
            this.adviserButton.IsTab = false;
            this.adviserButton.Location = new System.Drawing.Point(423, 3);
            this.adviserButton.Name = "adviserButton";
            this.adviserButton.Normalcolor = System.Drawing.Color.Maroon;
            this.adviserButton.OnHovercolor = System.Drawing.Color.LightCoral;
            this.adviserButton.OnHoverTextColor = System.Drawing.Color.White;
            this.adviserButton.selected = false;
            this.adviserButton.Size = new System.Drawing.Size(241, 55);
            this.adviserButton.TabIndex = 1;
            this.adviserButton.Text = "PEER ADVISER";
            this.adviserButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.adviserButton.Textcolor = System.Drawing.Color.White;
            this.adviserButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adviserButton.Click += new System.EventHandler(this.adviserButton_Click);
            // 
            // adviseeButton
            // 
            this.adviseeButton.Activecolor = System.Drawing.Color.LightCoral;
            this.adviseeButton.BackColor = System.Drawing.Color.Maroon;
            this.adviseeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adviseeButton.BorderRadius = 0;
            this.adviseeButton.ButtonText = "ADVISEE";
            this.adviseeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.adviseeButton, BunifuAnimatorNS.DecorationType.None);
            this.adviseeButton.DisabledColor = System.Drawing.Color.Gray;
            this.adviseeButton.Iconcolor = System.Drawing.Color.Transparent;
            this.adviseeButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("adviseeButton.Iconimage")));
            this.adviseeButton.Iconimage_right = null;
            this.adviseeButton.Iconimage_right_Selected = null;
            this.adviseeButton.Iconimage_Selected = null;
            this.adviseeButton.IconMarginLeft = 0;
            this.adviseeButton.IconMarginRight = 0;
            this.adviseeButton.IconRightVisible = true;
            this.adviseeButton.IconRightZoom = 0D;
            this.adviseeButton.IconVisible = false;
            this.adviseeButton.IconZoom = 90D;
            this.adviseeButton.IsTab = false;
            this.adviseeButton.Location = new System.Drawing.Point(3, 3);
            this.adviseeButton.Name = "adviseeButton";
            this.adviseeButton.Normalcolor = System.Drawing.Color.Maroon;
            this.adviseeButton.OnHovercolor = System.Drawing.Color.LightCoral;
            this.adviseeButton.OnHoverTextColor = System.Drawing.Color.White;
            this.adviseeButton.selected = false;
            this.adviseeButton.Size = new System.Drawing.Size(241, 55);
            this.adviseeButton.TabIndex = 0;
            this.adviseeButton.Text = "ADVISEE";
            this.adviseeButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.adviseeButton.Textcolor = System.Drawing.Color.White;
            this.adviseeButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adviseeButton.Click += new System.EventHandler(this.adviseeButton_Click);
            // 
            // adminPanel
            // 
            this.adminPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adminPanel.BackColor = System.Drawing.Color.Transparent;
            this.adminPanel.Controls.Add(this.adminGenerateReportButton);
            this.adminPanel.Controls.Add(this.adminEditCoursesButton);
            this.adminPanel.Controls.Add(this.adminEditAccountButton);
            this.adminPanel.Controls.Add(this.editAccountPanel);
            this.adminPanel.Controls.Add(this.adminEditCoursePanel);
            this.bunifuTransition1.SetDecoration(this.adminPanel, BunifuAnimatorNS.DecorationType.None);
            this.adminPanel.Location = new System.Drawing.Point(7, 74);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(1081, 427);
            this.adminPanel.TabIndex = 18;
            // 
            // adminGenerateReportButton
            // 
            this.adminGenerateReportButton.Activecolor = System.Drawing.Color.LightCoral;
            this.adminGenerateReportButton.BackColor = System.Drawing.Color.Maroon;
            this.adminGenerateReportButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adminGenerateReportButton.BorderRadius = 0;
            this.adminGenerateReportButton.ButtonText = "GENERATE REPORT";
            this.adminGenerateReportButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.adminGenerateReportButton, BunifuAnimatorNS.DecorationType.None);
            this.adminGenerateReportButton.DisabledColor = System.Drawing.Color.Gray;
            this.adminGenerateReportButton.Iconcolor = System.Drawing.Color.Transparent;
            this.adminGenerateReportButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("adminGenerateReportButton.Iconimage")));
            this.adminGenerateReportButton.Iconimage_right = null;
            this.adminGenerateReportButton.Iconimage_right_Selected = null;
            this.adminGenerateReportButton.Iconimage_Selected = null;
            this.adminGenerateReportButton.IconMarginLeft = 0;
            this.adminGenerateReportButton.IconMarginRight = 0;
            this.adminGenerateReportButton.IconRightVisible = true;
            this.adminGenerateReportButton.IconRightZoom = 0D;
            this.adminGenerateReportButton.IconVisible = false;
            this.adminGenerateReportButton.IconZoom = 90D;
            this.adminGenerateReportButton.IsTab = false;
            this.adminGenerateReportButton.Location = new System.Drawing.Point(20, 125);
            this.adminGenerateReportButton.Name = "adminGenerateReportButton";
            this.adminGenerateReportButton.Normalcolor = System.Drawing.Color.Maroon;
            this.adminGenerateReportButton.OnHovercolor = System.Drawing.Color.LightCoral;
            this.adminGenerateReportButton.OnHoverTextColor = System.Drawing.Color.White;
            this.adminGenerateReportButton.selected = false;
            this.adminGenerateReportButton.Size = new System.Drawing.Size(257, 36);
            this.adminGenerateReportButton.TabIndex = 17;
            this.adminGenerateReportButton.Text = "GENERATE REPORT";
            this.adminGenerateReportButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.adminGenerateReportButton.Textcolor = System.Drawing.Color.White;
            this.adminGenerateReportButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // adminEditCoursesButton
            // 
            this.adminEditCoursesButton.Activecolor = System.Drawing.Color.LightCoral;
            this.adminEditCoursesButton.BackColor = System.Drawing.Color.Maroon;
            this.adminEditCoursesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adminEditCoursesButton.BorderRadius = 0;
            this.adminEditCoursesButton.ButtonText = "EDIT COURSES";
            this.adminEditCoursesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.adminEditCoursesButton, BunifuAnimatorNS.DecorationType.None);
            this.adminEditCoursesButton.DisabledColor = System.Drawing.Color.Gray;
            this.adminEditCoursesButton.Iconcolor = System.Drawing.Color.Transparent;
            this.adminEditCoursesButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("adminEditCoursesButton.Iconimage")));
            this.adminEditCoursesButton.Iconimage_right = null;
            this.adminEditCoursesButton.Iconimage_right_Selected = null;
            this.adminEditCoursesButton.Iconimage_Selected = null;
            this.adminEditCoursesButton.IconMarginLeft = 0;
            this.adminEditCoursesButton.IconMarginRight = 0;
            this.adminEditCoursesButton.IconRightVisible = true;
            this.adminEditCoursesButton.IconRightZoom = 0D;
            this.adminEditCoursesButton.IconVisible = false;
            this.adminEditCoursesButton.IconZoom = 90D;
            this.adminEditCoursesButton.IsTab = false;
            this.adminEditCoursesButton.Location = new System.Drawing.Point(20, 73);
            this.adminEditCoursesButton.Name = "adminEditCoursesButton";
            this.adminEditCoursesButton.Normalcolor = System.Drawing.Color.Maroon;
            this.adminEditCoursesButton.OnHovercolor = System.Drawing.Color.LightCoral;
            this.adminEditCoursesButton.OnHoverTextColor = System.Drawing.Color.White;
            this.adminEditCoursesButton.selected = false;
            this.adminEditCoursesButton.Size = new System.Drawing.Size(257, 36);
            this.adminEditCoursesButton.TabIndex = 16;
            this.adminEditCoursesButton.Text = "EDIT COURSES";
            this.adminEditCoursesButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.adminEditCoursesButton.Textcolor = System.Drawing.Color.White;
            this.adminEditCoursesButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminEditCoursesButton.Click += new System.EventHandler(this.adminEditCoursesButton_Click);
            // 
            // adminEditAccountButton
            // 
            this.adminEditAccountButton.Activecolor = System.Drawing.Color.LightCoral;
            this.adminEditAccountButton.BackColor = System.Drawing.Color.Maroon;
            this.adminEditAccountButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adminEditAccountButton.BorderRadius = 0;
            this.adminEditAccountButton.ButtonText = "EDIT ACCOUNTS";
            this.adminEditAccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.adminEditAccountButton, BunifuAnimatorNS.DecorationType.None);
            this.adminEditAccountButton.DisabledColor = System.Drawing.Color.Gray;
            this.adminEditAccountButton.Iconcolor = System.Drawing.Color.Transparent;
            this.adminEditAccountButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("adminEditAccountButton.Iconimage")));
            this.adminEditAccountButton.Iconimage_right = null;
            this.adminEditAccountButton.Iconimage_right_Selected = null;
            this.adminEditAccountButton.Iconimage_Selected = null;
            this.adminEditAccountButton.IconMarginLeft = 0;
            this.adminEditAccountButton.IconMarginRight = 0;
            this.adminEditAccountButton.IconRightVisible = true;
            this.adminEditAccountButton.IconRightZoom = 0D;
            this.adminEditAccountButton.IconVisible = false;
            this.adminEditAccountButton.IconZoom = 90D;
            this.adminEditAccountButton.IsTab = false;
            this.adminEditAccountButton.Location = new System.Drawing.Point(20, 21);
            this.adminEditAccountButton.Name = "adminEditAccountButton";
            this.adminEditAccountButton.Normalcolor = System.Drawing.Color.Maroon;
            this.adminEditAccountButton.OnHovercolor = System.Drawing.Color.LightCoral;
            this.adminEditAccountButton.OnHoverTextColor = System.Drawing.Color.White;
            this.adminEditAccountButton.selected = false;
            this.adminEditAccountButton.Size = new System.Drawing.Size(257, 36);
            this.adminEditAccountButton.TabIndex = 3;
            this.adminEditAccountButton.Text = "EDIT ACCOUNTS";
            this.adminEditAccountButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.adminEditAccountButton.Textcolor = System.Drawing.Color.White;
            this.adminEditAccountButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminEditAccountButton.Click += new System.EventHandler(this.adminEditAccountButton_Click);
            // 
            // adminEditCoursePanel
            // 
            this.adminEditCoursePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adminEditCoursePanel.Controls.Add(this.deleteCourseButton);
            this.adminEditCoursePanel.Controls.Add(this.editCourseButton);
            this.adminEditCoursePanel.Controls.Add(this.createCourseButton);
            this.adminEditCoursePanel.Controls.Add(this.coursesDataGridView);
            this.adminEditCoursePanel.Controls.Add(this.searchCoursesTextBox);
            this.bunifuTransition1.SetDecoration(this.adminEditCoursePanel, BunifuAnimatorNS.DecorationType.None);
            this.adminEditCoursePanel.Location = new System.Drawing.Point(311, 22);
            this.adminEditCoursePanel.Name = "adminEditCoursePanel";
            this.adminEditCoursePanel.Size = new System.Drawing.Size(767, 402);
            this.adminEditCoursePanel.TabIndex = 19;
            // 
            // deleteCourseButton
            // 
            this.deleteCourseButton.ActiveBorderThickness = 1;
            this.deleteCourseButton.ActiveCornerRadius = 20;
            this.deleteCourseButton.ActiveFillColor = System.Drawing.Color.LightCoral;
            this.deleteCourseButton.ActiveForecolor = System.Drawing.Color.White;
            this.deleteCourseButton.ActiveLineColor = System.Drawing.Color.LightCoral;
            this.deleteCourseButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteCourseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteCourseButton.BackgroundImage")));
            this.deleteCourseButton.ButtonText = "Delete";
            this.deleteCourseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.deleteCourseButton, BunifuAnimatorNS.DecorationType.None);
            this.deleteCourseButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteCourseButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.deleteCourseButton.IdleBorderThickness = 1;
            this.deleteCourseButton.IdleCornerRadius = 20;
            this.deleteCourseButton.IdleFillColor = System.Drawing.Color.White;
            this.deleteCourseButton.IdleForecolor = System.Drawing.Color.Maroon;
            this.deleteCourseButton.IdleLineColor = System.Drawing.Color.Maroon;
            this.deleteCourseButton.Location = new System.Drawing.Point(561, 14);
            this.deleteCourseButton.Margin = new System.Windows.Forms.Padding(5);
            this.deleteCourseButton.Name = "deleteCourseButton";
            this.deleteCourseButton.Size = new System.Drawing.Size(181, 41);
            this.deleteCourseButton.TabIndex = 4;
            this.deleteCourseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editCourseButton
            // 
            this.editCourseButton.ActiveBorderThickness = 1;
            this.editCourseButton.ActiveCornerRadius = 20;
            this.editCourseButton.ActiveFillColor = System.Drawing.Color.LightCoral;
            this.editCourseButton.ActiveForecolor = System.Drawing.Color.White;
            this.editCourseButton.ActiveLineColor = System.Drawing.Color.LightCoral;
            this.editCourseButton.BackColor = System.Drawing.Color.Transparent;
            this.editCourseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editCourseButton.BackgroundImage")));
            this.editCourseButton.ButtonText = "Edit";
            this.editCourseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.editCourseButton, BunifuAnimatorNS.DecorationType.None);
            this.editCourseButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editCourseButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.editCourseButton.IdleBorderThickness = 1;
            this.editCourseButton.IdleCornerRadius = 20;
            this.editCourseButton.IdleFillColor = System.Drawing.Color.White;
            this.editCourseButton.IdleForecolor = System.Drawing.Color.Maroon;
            this.editCourseButton.IdleLineColor = System.Drawing.Color.Maroon;
            this.editCourseButton.Location = new System.Drawing.Point(299, 14);
            this.editCourseButton.Margin = new System.Windows.Forms.Padding(5);
            this.editCourseButton.Name = "editCourseButton";
            this.editCourseButton.Size = new System.Drawing.Size(181, 41);
            this.editCourseButton.TabIndex = 3;
            this.editCourseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createCourseButton
            // 
            this.createCourseButton.ActiveBorderThickness = 1;
            this.createCourseButton.ActiveCornerRadius = 20;
            this.createCourseButton.ActiveFillColor = System.Drawing.Color.LightCoral;
            this.createCourseButton.ActiveForecolor = System.Drawing.Color.White;
            this.createCourseButton.ActiveLineColor = System.Drawing.Color.LightCoral;
            this.createCourseButton.BackColor = System.Drawing.Color.Transparent;
            this.createCourseButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("createCourseButton.BackgroundImage")));
            this.createCourseButton.ButtonText = "Create";
            this.createCourseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.createCourseButton, BunifuAnimatorNS.DecorationType.None);
            this.createCourseButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createCourseButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.createCourseButton.IdleBorderThickness = 1;
            this.createCourseButton.IdleCornerRadius = 20;
            this.createCourseButton.IdleFillColor = System.Drawing.Color.White;
            this.createCourseButton.IdleForecolor = System.Drawing.Color.Maroon;
            this.createCourseButton.IdleLineColor = System.Drawing.Color.Maroon;
            this.createCourseButton.Location = new System.Drawing.Point(37, 14);
            this.createCourseButton.Margin = new System.Windows.Forms.Padding(5);
            this.createCourseButton.Name = "createCourseButton";
            this.createCourseButton.Size = new System.Drawing.Size(181, 41);
            this.createCourseButton.TabIndex = 2;
            this.createCourseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // coursesDataGridView
            // 
            this.coursesDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.coursesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuTransition1.SetDecoration(this.coursesDataGridView, BunifuAnimatorNS.DecorationType.None);
            this.coursesDataGridView.Location = new System.Drawing.Point(37, 114);
            this.coursesDataGridView.Name = "coursesDataGridView";
            this.coursesDataGridView.Size = new System.Drawing.Size(705, 275);
            this.coursesDataGridView.TabIndex = 1;
            // 
            // searchCoursesTextBox
            // 
            this.searchCoursesTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchCoursesTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchCoursesTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchCoursesTextBox.BackgroundImage")));
            this.searchCoursesTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.searchCoursesTextBox, BunifuAnimatorNS.DecorationType.None);
            this.searchCoursesTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.searchCoursesTextBox.Icon = ((System.Drawing.Image)(resources.GetObject("searchCoursesTextBox.Icon")));
            this.searchCoursesTextBox.Location = new System.Drawing.Point(37, 70);
            this.searchCoursesTextBox.Name = "searchCoursesTextBox";
            this.searchCoursesTextBox.Size = new System.Drawing.Size(705, 28);
            this.searchCoursesTextBox.TabIndex = 0;
            this.searchCoursesTextBox.text = "";
            // 
            // editAccountPanel
            // 
            this.editAccountPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.editAccountPanel.Controls.Add(this.deleteAccountButton);
            this.editAccountPanel.Controls.Add(this.editAccountButton);
            this.editAccountPanel.Controls.Add(this.createAccountButton);
            this.editAccountPanel.Controls.Add(this.accountsDataGridView);
            this.editAccountPanel.Controls.Add(this.searchAccountTextBox);
            this.bunifuTransition1.SetDecoration(this.editAccountPanel, BunifuAnimatorNS.DecorationType.None);
            this.editAccountPanel.Location = new System.Drawing.Point(310, 21);
            this.editAccountPanel.Name = "editAccountPanel";
            this.editAccountPanel.Size = new System.Drawing.Size(767, 402);
            this.editAccountPanel.TabIndex = 18;
            // 
            // deleteAccountButton
            // 
            this.deleteAccountButton.ActiveBorderThickness = 1;
            this.deleteAccountButton.ActiveCornerRadius = 20;
            this.deleteAccountButton.ActiveFillColor = System.Drawing.Color.LightCoral;
            this.deleteAccountButton.ActiveForecolor = System.Drawing.Color.White;
            this.deleteAccountButton.ActiveLineColor = System.Drawing.Color.LightCoral;
            this.deleteAccountButton.BackColor = System.Drawing.Color.Transparent;
            this.deleteAccountButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deleteAccountButton.BackgroundImage")));
            this.deleteAccountButton.ButtonText = "Delete";
            this.deleteAccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.deleteAccountButton, BunifuAnimatorNS.DecorationType.None);
            this.deleteAccountButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteAccountButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.deleteAccountButton.IdleBorderThickness = 1;
            this.deleteAccountButton.IdleCornerRadius = 20;
            this.deleteAccountButton.IdleFillColor = System.Drawing.Color.White;
            this.deleteAccountButton.IdleForecolor = System.Drawing.Color.Maroon;
            this.deleteAccountButton.IdleLineColor = System.Drawing.Color.Maroon;
            this.deleteAccountButton.Location = new System.Drawing.Point(561, 14);
            this.deleteAccountButton.Margin = new System.Windows.Forms.Padding(5);
            this.deleteAccountButton.Name = "deleteAccountButton";
            this.deleteAccountButton.Size = new System.Drawing.Size(181, 41);
            this.deleteAccountButton.TabIndex = 4;
            this.deleteAccountButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // editAccountButton
            // 
            this.editAccountButton.ActiveBorderThickness = 1;
            this.editAccountButton.ActiveCornerRadius = 20;
            this.editAccountButton.ActiveFillColor = System.Drawing.Color.LightCoral;
            this.editAccountButton.ActiveForecolor = System.Drawing.Color.White;
            this.editAccountButton.ActiveLineColor = System.Drawing.Color.LightCoral;
            this.editAccountButton.BackColor = System.Drawing.Color.Transparent;
            this.editAccountButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("editAccountButton.BackgroundImage")));
            this.editAccountButton.ButtonText = "Edit";
            this.editAccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.editAccountButton, BunifuAnimatorNS.DecorationType.None);
            this.editAccountButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editAccountButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.editAccountButton.IdleBorderThickness = 1;
            this.editAccountButton.IdleCornerRadius = 20;
            this.editAccountButton.IdleFillColor = System.Drawing.Color.White;
            this.editAccountButton.IdleForecolor = System.Drawing.Color.Maroon;
            this.editAccountButton.IdleLineColor = System.Drawing.Color.Maroon;
            this.editAccountButton.Location = new System.Drawing.Point(299, 14);
            this.editAccountButton.Margin = new System.Windows.Forms.Padding(5);
            this.editAccountButton.Name = "editAccountButton";
            this.editAccountButton.Size = new System.Drawing.Size(181, 41);
            this.editAccountButton.TabIndex = 3;
            this.editAccountButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // createAccountButton
            // 
            this.createAccountButton.ActiveBorderThickness = 1;
            this.createAccountButton.ActiveCornerRadius = 20;
            this.createAccountButton.ActiveFillColor = System.Drawing.Color.LightCoral;
            this.createAccountButton.ActiveForecolor = System.Drawing.Color.White;
            this.createAccountButton.ActiveLineColor = System.Drawing.Color.LightCoral;
            this.createAccountButton.BackColor = System.Drawing.Color.Transparent;
            this.createAccountButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("createAccountButton.BackgroundImage")));
            this.createAccountButton.ButtonText = "Create";
            this.createAccountButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.createAccountButton, BunifuAnimatorNS.DecorationType.None);
            this.createAccountButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createAccountButton.ForeColor = System.Drawing.Color.SeaGreen;
            this.createAccountButton.IdleBorderThickness = 1;
            this.createAccountButton.IdleCornerRadius = 20;
            this.createAccountButton.IdleFillColor = System.Drawing.Color.White;
            this.createAccountButton.IdleForecolor = System.Drawing.Color.Maroon;
            this.createAccountButton.IdleLineColor = System.Drawing.Color.Maroon;
            this.createAccountButton.Location = new System.Drawing.Point(37, 14);
            this.createAccountButton.Margin = new System.Windows.Forms.Padding(5);
            this.createAccountButton.Name = "createAccountButton";
            this.createAccountButton.Size = new System.Drawing.Size(181, 41);
            this.createAccountButton.TabIndex = 2;
            this.createAccountButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.createAccountButton.Click += new System.EventHandler(this.createAccountButton_Click);
            // 
            // accountsDataGridView
            // 
            this.accountsDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.accountsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bunifuTransition1.SetDecoration(this.accountsDataGridView, BunifuAnimatorNS.DecorationType.None);
            this.accountsDataGridView.Location = new System.Drawing.Point(37, 114);
            this.accountsDataGridView.Name = "accountsDataGridView";
            this.accountsDataGridView.Size = new System.Drawing.Size(705, 275);
            this.accountsDataGridView.TabIndex = 1;
            // 
            // searchAccountTextBox
            // 
            this.searchAccountTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.searchAccountTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.searchAccountTextBox.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("searchAccountTextBox.BackgroundImage")));
            this.searchAccountTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuTransition1.SetDecoration(this.searchAccountTextBox, BunifuAnimatorNS.DecorationType.None);
            this.searchAccountTextBox.ForeColor = System.Drawing.Color.Maroon;
            this.searchAccountTextBox.Icon = ((System.Drawing.Image)(resources.GetObject("searchAccountTextBox.Icon")));
            this.searchAccountTextBox.Location = new System.Drawing.Point(37, 70);
            this.searchAccountTextBox.Name = "searchAccountTextBox";
            this.searchAccountTextBox.Size = new System.Drawing.Size(705, 28);
            this.searchAccountTextBox.TabIndex = 0;
            this.searchAccountTextBox.text = "";
            // 
            // adviseePanel
            // 
            this.adviseePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adviseePanel.BackColor = System.Drawing.Color.Transparent;
            this.adviseePanel.Controls.Add(this.adviseeRegisterButton);
            this.adviseePanel.Controls.Add(this.endButton);
            this.adviseePanel.Controls.Add(this.adviseeActiveSessionListBox);
            this.adviseePanel.Controls.Add(this.adviseeActiveSessionLabel);
            this.adviseePanel.Controls.Add(this.startButton);
            this.adviseePanel.Controls.Add(this.adviseePeerAdviserListBox);
            this.adviseePanel.Controls.Add(this.adviseePeerAdviserLabel);
            this.adviseePanel.Controls.Add(this.adviseeCourseCodeComboBox);
            this.adviseePanel.Controls.Add(this.adviseeCourseCodeLabel);
            this.adviseePanel.Controls.Add(this.professionalRadioButton);
            this.adviseePanel.Controls.Add(this.chemistryRadioButton);
            this.adviseePanel.Controls.Add(this.physicsRadioButton);
            this.adviseePanel.Controls.Add(this.mathRadioButton);
            this.adviseePanel.Controls.Add(this.adviseeProgramTextBox);
            this.adviseePanel.Controls.Add(this.adviseeProgramLabel);
            this.adviseePanel.Controls.Add(this.adviseeSnTextBox);
            this.adviseePanel.Controls.Add(this.adviseeSnLabel);
            this.adviseePanel.Controls.Add(this.adviseeNameTextBox);
            this.adviseePanel.Controls.Add(this.adviseeNameLabel);
            this.bunifuTransition1.SetDecoration(this.adviseePanel, BunifuAnimatorNS.DecorationType.None);
            this.adviseePanel.Location = new System.Drawing.Point(6, 73);
            this.adviseePanel.Name = "adviseePanel";
            this.adviseePanel.Size = new System.Drawing.Size(1081, 427);
            this.adviseePanel.TabIndex = 2;
            // 
            // adviseeRegisterButton
            // 
            this.adviseeRegisterButton.Activecolor = System.Drawing.Color.LightCoral;
            this.adviseeRegisterButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adviseeRegisterButton.BackColor = System.Drawing.Color.Maroon;
            this.adviseeRegisterButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adviseeRegisterButton.BorderRadius = 0;
            this.adviseeRegisterButton.ButtonText = "REGISTER";
            this.adviseeRegisterButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.adviseeRegisterButton, BunifuAnimatorNS.DecorationType.None);
            this.adviseeRegisterButton.DisabledColor = System.Drawing.Color.Gray;
            this.adviseeRegisterButton.Iconcolor = System.Drawing.Color.Transparent;
            this.adviseeRegisterButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("adviseeRegisterButton.Iconimage")));
            this.adviseeRegisterButton.Iconimage_right = null;
            this.adviseeRegisterButton.Iconimage_right_Selected = null;
            this.adviseeRegisterButton.Iconimage_Selected = null;
            this.adviseeRegisterButton.IconMarginLeft = 0;
            this.adviseeRegisterButton.IconMarginRight = 0;
            this.adviseeRegisterButton.IconRightVisible = true;
            this.adviseeRegisterButton.IconRightZoom = 0D;
            this.adviseeRegisterButton.IconVisible = true;
            this.adviseeRegisterButton.IconZoom = 90D;
            this.adviseeRegisterButton.IsTab = false;
            this.adviseeRegisterButton.Location = new System.Drawing.Point(897, 10);
            this.adviseeRegisterButton.Name = "adviseeRegisterButton";
            this.adviseeRegisterButton.Normalcolor = System.Drawing.Color.Maroon;
            this.adviseeRegisterButton.OnHovercolor = System.Drawing.Color.LightCoral;
            this.adviseeRegisterButton.OnHoverTextColor = System.Drawing.Color.White;
            this.adviseeRegisterButton.selected = false;
            this.adviseeRegisterButton.Size = new System.Drawing.Size(168, 32);
            this.adviseeRegisterButton.TabIndex = 17;
            this.adviseeRegisterButton.Text = "REGISTER";
            this.adviseeRegisterButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.adviseeRegisterButton.Textcolor = System.Drawing.Color.White;
            this.adviseeRegisterButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adviseeRegisterButton.Click += new System.EventHandler(this.adviseeRegisterButton_Click);
            // 
            // endButton
            // 
            this.endButton.Activecolor = System.Drawing.Color.LightCoral;
            this.endButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.endButton.BackColor = System.Drawing.Color.Maroon;
            this.endButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.endButton.BorderRadius = 0;
            this.endButton.ButtonText = "END SESSION";
            this.endButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.endButton, BunifuAnimatorNS.DecorationType.None);
            this.endButton.DisabledColor = System.Drawing.Color.Gray;
            this.endButton.Iconcolor = System.Drawing.Color.Transparent;
            this.endButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("endButton.Iconimage")));
            this.endButton.Iconimage_right = null;
            this.endButton.Iconimage_right_Selected = null;
            this.endButton.Iconimage_Selected = null;
            this.endButton.IconMarginLeft = 0;
            this.endButton.IconMarginRight = 0;
            this.endButton.IconRightVisible = true;
            this.endButton.IconRightZoom = 0D;
            this.endButton.IconVisible = false;
            this.endButton.IconZoom = 90D;
            this.endButton.IsTab = false;
            this.endButton.Location = new System.Drawing.Point(463, 375);
            this.endButton.Name = "endButton";
            this.endButton.Normalcolor = System.Drawing.Color.Maroon;
            this.endButton.OnHovercolor = System.Drawing.Color.LightCoral;
            this.endButton.OnHoverTextColor = System.Drawing.Color.White;
            this.endButton.selected = false;
            this.endButton.Size = new System.Drawing.Size(602, 36);
            this.endButton.TabIndex = 16;
            this.endButton.Text = "END SESSION";
            this.endButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.endButton.Textcolor = System.Drawing.Color.White;
            this.endButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.endButton.Click += new System.EventHandler(this.endButton_Click);
            // 
            // adviseeActiveSessionListBox
            // 
            this.adviseeActiveSessionListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTransition1.SetDecoration(this.adviseeActiveSessionListBox, BunifuAnimatorNS.DecorationType.None);
            this.adviseeActiveSessionListBox.FormattingEnabled = true;
            this.adviseeActiveSessionListBox.Location = new System.Drawing.Point(463, 53);
            this.adviseeActiveSessionListBox.Name = "adviseeActiveSessionListBox";
            this.adviseeActiveSessionListBox.Size = new System.Drawing.Size(602, 316);
            this.adviseeActiveSessionListBox.TabIndex = 15;
            // 
            // adviseeActiveSessionLabel
            // 
            this.adviseeActiveSessionLabel.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.adviseeActiveSessionLabel, BunifuAnimatorNS.DecorationType.None);
            this.adviseeActiveSessionLabel.Location = new System.Drawing.Point(460, 26);
            this.adviseeActiveSessionLabel.Name = "adviseeActiveSessionLabel";
            this.adviseeActiveSessionLabel.Size = new System.Drawing.Size(85, 13);
            this.adviseeActiveSessionLabel.TabIndex = 14;
            this.adviseeActiveSessionLabel.Text = "Active Sessions:";
            // 
            // startButton
            // 
            this.startButton.Activecolor = System.Drawing.Color.LightCoral;
            this.startButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.startButton.BackColor = System.Drawing.Color.Maroon;
            this.startButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.startButton.BorderRadius = 0;
            this.startButton.ButtonText = "START SESSION";
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.startButton, BunifuAnimatorNS.DecorationType.None);
            this.startButton.DisabledColor = System.Drawing.Color.Gray;
            this.startButton.Iconcolor = System.Drawing.Color.Transparent;
            this.startButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("startButton.Iconimage")));
            this.startButton.Iconimage_right = null;
            this.startButton.Iconimage_right_Selected = null;
            this.startButton.Iconimage_Selected = null;
            this.startButton.IconMarginLeft = 0;
            this.startButton.IconMarginRight = 0;
            this.startButton.IconRightVisible = true;
            this.startButton.IconRightZoom = 0D;
            this.startButton.IconVisible = false;
            this.startButton.IconZoom = 90D;
            this.startButton.IsTab = false;
            this.startButton.Location = new System.Drawing.Point(31, 376);
            this.startButton.Name = "startButton";
            this.startButton.Normalcolor = System.Drawing.Color.Maroon;
            this.startButton.OnHovercolor = System.Drawing.Color.LightCoral;
            this.startButton.OnHoverTextColor = System.Drawing.Color.White;
            this.startButton.selected = false;
            this.startButton.Size = new System.Drawing.Size(399, 36);
            this.startButton.TabIndex = 3;
            this.startButton.Text = "START SESSION";
            this.startButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.startButton.Textcolor = System.Drawing.Color.White;
            this.startButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // adviseePeerAdviserListBox
            // 
            this.adviseePeerAdviserListBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.bunifuTransition1.SetDecoration(this.adviseePeerAdviserListBox, BunifuAnimatorNS.DecorationType.None);
            this.adviseePeerAdviserListBox.FormattingEnabled = true;
            this.adviseePeerAdviserListBox.Location = new System.Drawing.Point(31, 185);
            this.adviseePeerAdviserListBox.Name = "adviseePeerAdviserListBox";
            this.adviseePeerAdviserListBox.Size = new System.Drawing.Size(399, 186);
            this.adviseePeerAdviserListBox.TabIndex = 13;
            // 
            // adviseePeerAdviserLabel
            // 
            this.adviseePeerAdviserLabel.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.adviseePeerAdviserLabel, BunifuAnimatorNS.DecorationType.None);
            this.adviseePeerAdviserLabel.Location = new System.Drawing.Point(28, 160);
            this.adviseePeerAdviserLabel.Name = "adviseePeerAdviserLabel";
            this.adviseePeerAdviserLabel.Size = new System.Drawing.Size(116, 13);
            this.adviseePeerAdviserLabel.TabIndex = 12;
            this.adviseePeerAdviserLabel.Text = "Peer Adviser Available:";
            // 
            // adviseeCourseCodeComboBox
            // 
            this.bunifuTransition1.SetDecoration(this.adviseeCourseCodeComboBox, BunifuAnimatorNS.DecorationType.None);
            this.adviseeCourseCodeComboBox.FormattingEnabled = true;
            this.adviseeCourseCodeComboBox.Location = new System.Drawing.Point(105, 126);
            this.adviseeCourseCodeComboBox.Name = "adviseeCourseCodeComboBox";
            this.adviseeCourseCodeComboBox.Size = new System.Drawing.Size(68, 21);
            this.adviseeCourseCodeComboBox.TabIndex = 11;
            // 
            // adviseeCourseCodeLabel
            // 
            this.adviseeCourseCodeLabel.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.adviseeCourseCodeLabel, BunifuAnimatorNS.DecorationType.None);
            this.adviseeCourseCodeLabel.Location = new System.Drawing.Point(28, 130);
            this.adviseeCourseCodeLabel.Name = "adviseeCourseCodeLabel";
            this.adviseeCourseCodeLabel.Size = new System.Drawing.Size(71, 13);
            this.adviseeCourseCodeLabel.TabIndex = 10;
            this.adviseeCourseCodeLabel.Text = "Course Code:";
            // 
            // professionalRadioButton
            // 
            this.professionalRadioButton.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.professionalRadioButton, BunifuAnimatorNS.DecorationType.None);
            this.professionalRadioButton.Location = new System.Drawing.Point(348, 92);
            this.professionalRadioButton.Name = "professionalRadioButton";
            this.professionalRadioButton.Size = new System.Drawing.Size(82, 17);
            this.professionalRadioButton.TabIndex = 9;
            this.professionalRadioButton.TabStop = true;
            this.professionalRadioButton.Text = "Professional";
            this.professionalRadioButton.UseVisualStyleBackColor = true;
            // 
            // chemistryRadioButton
            // 
            this.chemistryRadioButton.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.chemistryRadioButton, BunifuAnimatorNS.DecorationType.None);
            this.chemistryRadioButton.Location = new System.Drawing.Point(245, 92);
            this.chemistryRadioButton.Name = "chemistryRadioButton";
            this.chemistryRadioButton.Size = new System.Drawing.Size(70, 17);
            this.chemistryRadioButton.TabIndex = 8;
            this.chemistryRadioButton.TabStop = true;
            this.chemistryRadioButton.Text = "Chemistry";
            this.chemistryRadioButton.UseVisualStyleBackColor = true;
            // 
            // physicsRadioButton
            // 
            this.physicsRadioButton.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.physicsRadioButton, BunifuAnimatorNS.DecorationType.None);
            this.physicsRadioButton.Location = new System.Drawing.Point(151, 92);
            this.physicsRadioButton.Name = "physicsRadioButton";
            this.physicsRadioButton.Size = new System.Drawing.Size(61, 17);
            this.physicsRadioButton.TabIndex = 7;
            this.physicsRadioButton.TabStop = true;
            this.physicsRadioButton.Text = "Physics";
            this.physicsRadioButton.UseVisualStyleBackColor = true;
            // 
            // mathRadioButton
            // 
            this.mathRadioButton.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.mathRadioButton, BunifuAnimatorNS.DecorationType.None);
            this.mathRadioButton.Location = new System.Drawing.Point(33, 92);
            this.mathRadioButton.Name = "mathRadioButton";
            this.mathRadioButton.Size = new System.Drawing.Size(85, 17);
            this.mathRadioButton.TabIndex = 6;
            this.mathRadioButton.TabStop = true;
            this.mathRadioButton.Text = "Mathematics";
            this.mathRadioButton.UseVisualStyleBackColor = true;
            // 
            // adviseeProgramTextBox
            // 
            this.adviseeProgramTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTransition1.SetDecoration(this.adviseeProgramTextBox, BunifuAnimatorNS.DecorationType.None);
            this.adviseeProgramTextBox.Location = new System.Drawing.Point(369, 53);
            this.adviseeProgramTextBox.Name = "adviseeProgramTextBox";
            this.adviseeProgramTextBox.ReadOnly = true;
            this.adviseeProgramTextBox.Size = new System.Drawing.Size(61, 20);
            this.adviseeProgramTextBox.TabIndex = 5;
            // 
            // adviseeProgramLabel
            // 
            this.adviseeProgramLabel.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.adviseeProgramLabel, BunifuAnimatorNS.DecorationType.None);
            this.adviseeProgramLabel.Location = new System.Drawing.Point(307, 57);
            this.adviseeProgramLabel.Name = "adviseeProgramLabel";
            this.adviseeProgramLabel.Size = new System.Drawing.Size(49, 13);
            this.adviseeProgramLabel.TabIndex = 4;
            this.adviseeProgramLabel.Text = "Program:";
            // 
            // adviseeSnTextBox
            // 
            this.bunifuTransition1.SetDecoration(this.adviseeSnTextBox, BunifuAnimatorNS.DecorationType.None);
            this.adviseeSnTextBox.Location = new System.Drawing.Point(128, 53);
            this.adviseeSnTextBox.Name = "adviseeSnTextBox";
            this.adviseeSnTextBox.Size = new System.Drawing.Size(166, 20);
            this.adviseeSnTextBox.TabIndex = 3;
            // 
            // adviseeSnLabel
            // 
            this.adviseeSnLabel.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.adviseeSnLabel, BunifuAnimatorNS.DecorationType.None);
            this.adviseeSnLabel.Location = new System.Drawing.Point(28, 57);
            this.adviseeSnLabel.Name = "adviseeSnLabel";
            this.adviseeSnLabel.Size = new System.Drawing.Size(87, 13);
            this.adviseeSnLabel.TabIndex = 2;
            this.adviseeSnLabel.Text = "Student Number:";
            // 
            // adviseeNameTextBox
            // 
            this.adviseeNameTextBox.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuTransition1.SetDecoration(this.adviseeNameTextBox, BunifuAnimatorNS.DecorationType.None);
            this.adviseeNameTextBox.Location = new System.Drawing.Point(72, 22);
            this.adviseeNameTextBox.Name = "adviseeNameTextBox";
            this.adviseeNameTextBox.ReadOnly = true;
            this.adviseeNameTextBox.Size = new System.Drawing.Size(358, 20);
            this.adviseeNameTextBox.TabIndex = 1;
            // 
            // adviseeNameLabel
            // 
            this.adviseeNameLabel.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.adviseeNameLabel, BunifuAnimatorNS.DecorationType.None);
            this.adviseeNameLabel.Location = new System.Drawing.Point(28, 26);
            this.adviseeNameLabel.Name = "adviseeNameLabel";
            this.adviseeNameLabel.Size = new System.Drawing.Size(38, 13);
            this.adviseeNameLabel.TabIndex = 0;
            this.adviseeNameLabel.Text = "Name:";
            // 
            // adviserPanel
            // 
            this.adviserPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.adviserPanel.BackColor = System.Drawing.Color.Transparent;
            this.adviserPanel.Controls.Add(this.panel1);
            this.adviserPanel.Controls.Add(this.activePeerAdviserListBox);
            this.adviserPanel.Controls.Add(this.activePeerAdviserLabel);
            this.bunifuTransition1.SetDecoration(this.adviserPanel, BunifuAnimatorNS.DecorationType.None);
            this.adviserPanel.Location = new System.Drawing.Point(7, 73);
            this.adviserPanel.Name = "adviserPanel";
            this.adviserPanel.Size = new System.Drawing.Size(1081, 427);
            this.adviserPanel.TabIndex = 17;
            // 
            // adviserLogoutButton
            // 
            this.adviserLogoutButton.Activecolor = System.Drawing.Color.LightCoral;
            this.adviserLogoutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.adviserLogoutButton.BackColor = System.Drawing.Color.Maroon;
            this.adviserLogoutButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adviserLogoutButton.BorderRadius = 0;
            this.adviserLogoutButton.ButtonText = "LOGOUT";
            this.adviserLogoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.adviserLogoutButton, BunifuAnimatorNS.DecorationType.None);
            this.adviserLogoutButton.DisabledColor = System.Drawing.Color.Gray;
            this.adviserLogoutButton.Iconcolor = System.Drawing.Color.Transparent;
            this.adviserLogoutButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("adviserLogoutButton.Iconimage")));
            this.adviserLogoutButton.Iconimage_right = null;
            this.adviserLogoutButton.Iconimage_right_Selected = null;
            this.adviserLogoutButton.Iconimage_Selected = null;
            this.adviserLogoutButton.IconMarginLeft = 0;
            this.adviserLogoutButton.IconMarginRight = 0;
            this.adviserLogoutButton.IconRightVisible = true;
            this.adviserLogoutButton.IconRightZoom = 0D;
            this.adviserLogoutButton.IconVisible = false;
            this.adviserLogoutButton.IconZoom = 90D;
            this.adviserLogoutButton.IsTab = false;
            this.adviserLogoutButton.Location = new System.Drawing.Point(619, 0);
            this.adviserLogoutButton.Name = "adviserLogoutButton";
            this.adviserLogoutButton.Normalcolor = System.Drawing.Color.Maroon;
            this.adviserLogoutButton.OnHovercolor = System.Drawing.Color.LightCoral;
            this.adviserLogoutButton.OnHoverTextColor = System.Drawing.Color.White;
            this.adviserLogoutButton.selected = false;
            this.adviserLogoutButton.Size = new System.Drawing.Size(399, 36);
            this.adviserLogoutButton.TabIndex = 16;
            this.adviserLogoutButton.Text = "LOGOUT";
            this.adviserLogoutButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.adviserLogoutButton.Textcolor = System.Drawing.Color.White;
            this.adviserLogoutButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adviserLogoutButton.Click += new System.EventHandler(this.adviserLogoutButton_Click);
            // 
            // activePeerAdviserListBox
            // 
            this.activePeerAdviserListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bunifuTransition1.SetDecoration(this.activePeerAdviserListBox, BunifuAnimatorNS.DecorationType.None);
            this.activePeerAdviserListBox.FormattingEnabled = true;
            this.activePeerAdviserListBox.Location = new System.Drawing.Point(46, 48);
            this.activePeerAdviserListBox.Name = "activePeerAdviserListBox";
            this.activePeerAdviserListBox.Size = new System.Drawing.Size(1019, 316);
            this.activePeerAdviserListBox.TabIndex = 15;
            // 
            // activePeerAdviserLabel
            // 
            this.activePeerAdviserLabel.AutoSize = true;
            this.bunifuTransition1.SetDecoration(this.activePeerAdviserLabel, BunifuAnimatorNS.DecorationType.None);
            this.activePeerAdviserLabel.Location = new System.Drawing.Point(43, 21);
            this.activePeerAdviserLabel.Name = "activePeerAdviserLabel";
            this.activePeerAdviserLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.activePeerAdviserLabel.Size = new System.Drawing.Size(108, 13);
            this.activePeerAdviserLabel.TabIndex = 14;
            this.activePeerAdviserLabel.Text = "Active Peer Advisers:";
            // 
            // adviserLoginButton
            // 
            this.adviserLoginButton.Activecolor = System.Drawing.Color.LightCoral;
            this.adviserLoginButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.adviserLoginButton.BackColor = System.Drawing.Color.Maroon;
            this.adviserLoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.adviserLoginButton.BorderRadius = 0;
            this.adviserLoginButton.ButtonText = "LOGIN";
            this.adviserLoginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuTransition1.SetDecoration(this.adviserLoginButton, BunifuAnimatorNS.DecorationType.None);
            this.adviserLoginButton.DisabledColor = System.Drawing.Color.Gray;
            this.adviserLoginButton.Iconcolor = System.Drawing.Color.Transparent;
            this.adviserLoginButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("adviserLoginButton.Iconimage")));
            this.adviserLoginButton.Iconimage_right = null;
            this.adviserLoginButton.Iconimage_right_Selected = null;
            this.adviserLoginButton.Iconimage_Selected = null;
            this.adviserLoginButton.IconMarginLeft = 0;
            this.adviserLoginButton.IconMarginRight = 0;
            this.adviserLoginButton.IconRightVisible = true;
            this.adviserLoginButton.IconRightZoom = 0D;
            this.adviserLoginButton.IconVisible = false;
            this.adviserLoginButton.IconZoom = 90D;
            this.adviserLoginButton.IsTab = false;
            this.adviserLoginButton.Location = new System.Drawing.Point(0, -1);
            this.adviserLoginButton.Name = "adviserLoginButton";
            this.adviserLoginButton.Normalcolor = System.Drawing.Color.Maroon;
            this.adviserLoginButton.OnHovercolor = System.Drawing.Color.LightCoral;
            this.adviserLoginButton.OnHoverTextColor = System.Drawing.Color.White;
            this.adviserLoginButton.selected = false;
            this.adviserLoginButton.Size = new System.Drawing.Size(399, 36);
            this.adviserLoginButton.TabIndex = 3;
            this.adviserLoginButton.Text = "LOGIN";
            this.adviserLoginButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.adviserLoginButton.Textcolor = System.Drawing.Color.White;
            this.adviserLoginButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adviserLoginButton.Click += new System.EventHandler(this.adviserLoginButton_Click);
            // 
            // bunifuTransition1
            // 
            this.bunifuTransition1.AnimationType = BunifuAnimatorNS.AnimationType.Transparent;
            this.bunifuTransition1.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.BlindCoeff")));
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicCoeff")));
            animation1.MosaicShift = ((System.Drawing.PointF)(resources.GetObject("animation1.MosaicShift")));
            animation1.MosaicSize = 0;
            animation1.Padding = new System.Windows.Forms.Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.ScaleCoeff")));
            animation1.SlideCoeff = ((System.Drawing.PointF)(resources.GetObject("animation1.SlideCoeff")));
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 1F;
            this.bunifuTransition1.DefaultAnimation = animation1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.adviserLogoutButton);
            this.panel1.Controls.Add(this.adviserLoginButton);
            this.bunifuTransition1.SetDecoration(this.panel1, BunifuAnimatorNS.DecorationType.None);
            this.panel1.Location = new System.Drawing.Point(46, 377);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1018, 35);
            this.panel1.TabIndex = 3;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1196, 586);
            this.Controls.Add(this.backPanel);
            this.bunifuTransition1.SetDecoration(this, BunifuAnimatorNS.DecorationType.None);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Session Logger";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.backPanel.ResumeLayout(false);
            this.mainButtonPanel.ResumeLayout(false);
            this.adminPanel.ResumeLayout(false);
            this.adminEditCoursePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.coursesDataGridView)).EndInit();
            this.editAccountPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.accountsDataGridView)).EndInit();
            this.adviseePanel.ResumeLayout(false);
            this.adviseePanel.PerformLayout();
            this.adviserPanel.ResumeLayout(false);
            this.adviserPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.Panel mainButtonPanel;
        private Bunifu.Framework.UI.BunifuFlatButton adminButton;
        private Bunifu.Framework.UI.BunifuFlatButton adviserButton;
        private Bunifu.Framework.UI.BunifuFlatButton adviseeButton;
        private System.Windows.Forms.Panel adviseePanel;
        private BunifuAnimatorNS.BunifuTransition bunifuTransition1;
        private System.Windows.Forms.TextBox adviseeSnTextBox;
        private System.Windows.Forms.Label adviseeSnLabel;
        private System.Windows.Forms.TextBox adviseeNameTextBox;
        private System.Windows.Forms.Label adviseeNameLabel;
        private Bunifu.Framework.UI.BunifuFlatButton startButton;
        private System.Windows.Forms.ListBox adviseePeerAdviserListBox;
        private System.Windows.Forms.Label adviseePeerAdviserLabel;
        private System.Windows.Forms.ComboBox adviseeCourseCodeComboBox;
        private System.Windows.Forms.Label adviseeCourseCodeLabel;
        private System.Windows.Forms.RadioButton professionalRadioButton;
        private System.Windows.Forms.RadioButton chemistryRadioButton;
        private System.Windows.Forms.RadioButton physicsRadioButton;
        private System.Windows.Forms.RadioButton mathRadioButton;
        private System.Windows.Forms.TextBox adviseeProgramTextBox;
        private System.Windows.Forms.Label adviseeProgramLabel;
        private Bunifu.Framework.UI.BunifuFlatButton endButton;
        private System.Windows.Forms.ListBox adviseeActiveSessionListBox;
        private System.Windows.Forms.Label adviseeActiveSessionLabel;
        private System.Windows.Forms.Panel adviserPanel;
        private Bunifu.Framework.UI.BunifuFlatButton adviserLogoutButton;
        private System.Windows.Forms.ListBox activePeerAdviserListBox;
        private System.Windows.Forms.Label activePeerAdviserLabel;
        private Bunifu.Framework.UI.BunifuFlatButton adviserLoginButton;
        private Bunifu.Framework.UI.BunifuFlatButton adviseeRegisterButton;
        private System.Windows.Forms.Panel adminPanel;
        private Bunifu.Framework.UI.BunifuFlatButton adminGenerateReportButton;
        private Bunifu.Framework.UI.BunifuFlatButton adminEditCoursesButton;
        private Bunifu.Framework.UI.BunifuFlatButton adminEditAccountButton;
        private System.Windows.Forms.Panel editAccountPanel;
        private System.Windows.Forms.Panel adminEditCoursePanel;
        private Bunifu.Framework.UI.BunifuThinButton2 deleteCourseButton;
        private Bunifu.Framework.UI.BunifuThinButton2 editCourseButton;
        private Bunifu.Framework.UI.BunifuThinButton2 createCourseButton;
        private System.Windows.Forms.DataGridView coursesDataGridView;
        private Bunifu.Framework.UI.BunifuTextbox searchCoursesTextBox;
        private Bunifu.Framework.UI.BunifuThinButton2 deleteAccountButton;
        private Bunifu.Framework.UI.BunifuThinButton2 editAccountButton;
        private Bunifu.Framework.UI.BunifuThinButton2 createAccountButton;
        private System.Windows.Forms.DataGridView accountsDataGridView;
        private Bunifu.Framework.UI.BunifuTextbox searchAccountTextBox;
        private System.Windows.Forms.Panel panel1;
    }
}

