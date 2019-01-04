namespace VBUI
   
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewUsersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstSkills = new System.Windows.Forms.ListBox();
            this.btnAddSkillocal = new System.Windows.Forms.Button();
            this.txtFname = new System.Windows.Forms.TextBox();
            this.cboSkills = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtLname = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCreateUser = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDBUserName = new System.Windows.Forms.TextBox();
            this.txtDB = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlLogin = new System.Windows.Forms.Panel();
            this.txtDBPassword = new System.Windows.Forms.TextBox();
            this.pnlUsers = new System.Windows.Forms.Panel();
            this.lstUser = new System.Windows.Forms.ListBox();
            this.lblConnectedDatabase = new System.Windows.Forms.Label();
            this.pnlConnectStatus = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnSkillAdd = new System.Windows.Forms.Button();
            this.txtSkillName = new System.Windows.Forms.TextBox();
            this.txtSkillDesc = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.pnlLogin.SuspendLayout();
            this.pnlUsers.SuspendLayout();
            this.pnlConnectStatus.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "notifyIcon1";
            this.notifyIcon1.Visible = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Location = new System.Drawing.Point(0, 1092);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(2068, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.viewUsersToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(2068, 33);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewUserToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(50, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // createNewUserToolStripMenuItem
            // 
            this.createNewUserToolStripMenuItem.Name = "createNewUserToolStripMenuItem";
            this.createNewUserToolStripMenuItem.Size = new System.Drawing.Size(226, 30);
            this.createNewUserToolStripMenuItem.Text = "Create New User";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // viewUsersToolStripMenuItem
            // 
            this.viewUsersToolStripMenuItem.Name = "viewUsersToolStripMenuItem";
            this.viewUsersToolStripMenuItem.Size = new System.Drawing.Size(109, 29);
            this.viewUsersToolStripMenuItem.Text = "View Users";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lstSkills);
            this.groupBox1.Controls.Add(this.btnAddSkillocal);
            this.groupBox1.Controls.Add(this.txtFname);
            this.groupBox1.Controls.Add(this.cboSkills);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.txtLname);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnCreateUser);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Location = new System.Drawing.Point(24, 81);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(594, 259);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Create User";
            // 
            // lstSkills
            // 
            this.lstSkills.FormattingEnabled = true;
            this.lstSkills.ItemHeight = 20;
            this.lstSkills.Location = new System.Drawing.Point(300, 98);
            this.lstSkills.Name = "lstSkills";
            this.lstSkills.Size = new System.Drawing.Size(279, 84);
            this.lstSkills.TabIndex = 11;
            // 
            // btnAddSkillocal
            // 
            this.btnAddSkillocal.Location = new System.Drawing.Point(508, 47);
            this.btnAddSkillocal.Name = "btnAddSkillocal";
            this.btnAddSkillocal.Size = new System.Drawing.Size(71, 33);
            this.btnAddSkillocal.TabIndex = 10;
            this.btnAddSkillocal.Text = "Add";
            this.btnAddSkillocal.UseVisualStyleBackColor = true;
            this.btnAddSkillocal.Click += new System.EventHandler(this.btnAddSkillocal_Click);
            // 
            // txtFname
            // 
            this.txtFname.Location = new System.Drawing.Point(118, 53);
            this.txtFname.Name = "txtFname";
            this.txtFname.Size = new System.Drawing.Size(100, 26);
            this.txtFname.TabIndex = 2;
            // 
            // cboSkills
            // 
            this.cboSkills.AllowDrop = true;
            this.cboSkills.DisplayMember = "Magis";
            this.cboSkills.FormattingEnabled = true;
            this.cboSkills.Items.AddRange(new object[] {
            "Magic ",
            "Science",
            "C++"});
            this.cboSkills.Location = new System.Drawing.Point(300, 50);
            this.cboSkills.Name = "cboSkills";
            this.cboSkills.Size = new System.Drawing.Size(198, 28);
            this.cboSkills.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(248, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Skills";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(120, 143);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(21, 26);
            this.textBox1.TabIndex = 7;
            // 
            // txtLname
            // 
            this.txtLname.Location = new System.Drawing.Point(118, 95);
            this.txtLname.Name = "txtLname";
            this.txtLname.Size = new System.Drawing.Size(100, 26);
            this.txtLname.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Middle Initial";
            // 
            // btnCreateUser
            // 
            this.btnCreateUser.Location = new System.Drawing.Point(195, 214);
            this.btnCreateUser.Name = "btnCreateUser";
            this.btnCreateUser.Size = new System.Drawing.Size(98, 39);
            this.btnCreateUser.TabIndex = 5;
            this.btnCreateUser.Text = "Submit";
            this.btnCreateUser.UseVisualStyleBackColor = true;
            this.btnCreateUser.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 101);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(86, 20);
            this.label7.TabIndex = 3;
            this.label7.Text = "Last Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(86, 20);
            this.label8.TabIndex = 1;
            this.label8.Text = "First Name";
            // 
            // txtDBUserName
            // 
            this.txtDBUserName.Location = new System.Drawing.Point(183, 66);
            this.txtDBUserName.Name = "txtDBUserName";
            this.txtDBUserName.Size = new System.Drawing.Size(315, 26);
            this.txtDBUserName.TabIndex = 4;
            // 
            // txtDB
            // 
            this.txtDB.Location = new System.Drawing.Point(183, 18);
            this.txtDB.Name = "txtDB";
            this.txtDB.Size = new System.Drawing.Size(315, 26);
            this.txtDB.TabIndex = 2;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(219, 187);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(98, 39);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnCreateUser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "DB User Name";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Database Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "DB Password";
            // 
            // pnlLogin
            // 
            this.pnlLogin.Controls.Add(this.label3);
            this.pnlLogin.Controls.Add(this.label1);
            this.pnlLogin.Controls.Add(this.label2);
            this.pnlLogin.Controls.Add(this.txtDBPassword);
            this.pnlLogin.Controls.Add(this.btnConnect);
            this.pnlLogin.Controls.Add(this.txtDB);
            this.pnlLogin.Controls.Add(this.txtDBUserName);
            this.pnlLogin.Location = new System.Drawing.Point(24, 433);
            this.pnlLogin.Name = "pnlLogin";
            this.pnlLogin.Size = new System.Drawing.Size(528, 265);
            this.pnlLogin.TabIndex = 6;
            // 
            // txtDBPassword
            // 
            this.txtDBPassword.Location = new System.Drawing.Point(183, 124);
            this.txtDBPassword.Name = "txtDBPassword";
            this.txtDBPassword.Size = new System.Drawing.Size(315, 26);
            this.txtDBPassword.TabIndex = 7;
            // 
            // pnlUsers
            // 
            this.pnlUsers.Controls.Add(this.lstUser);
            this.pnlUsers.Location = new System.Drawing.Point(671, 81);
            this.pnlUsers.Name = "pnlUsers";
            this.pnlUsers.Size = new System.Drawing.Size(1014, 723);
            this.pnlUsers.TabIndex = 7;
            // 
            // lstUser
            // 
            this.lstUser.FormattingEnabled = true;
            this.lstUser.ItemHeight = 20;
            this.lstUser.Location = new System.Drawing.Point(45, 32);
            this.lstUser.Name = "lstUser";
            this.lstUser.Size = new System.Drawing.Size(939, 664);
            this.lstUser.TabIndex = 0;
            // 
            // lblConnectedDatabase
            // 
            this.lblConnectedDatabase.AutoSize = true;
            this.lblConnectedDatabase.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConnectedDatabase.Location = new System.Drawing.Point(831, 11);
            this.lblConnectedDatabase.Name = "lblConnectedDatabase";
            this.lblConnectedDatabase.Size = new System.Drawing.Size(52, 26);
            this.lblConnectedDatabase.TabIndex = 9;
            this.lblConnectedDatabase.Text = "N/A";
            // 
            // pnlConnectStatus
            // 
            this.pnlConnectStatus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.pnlConnectStatus.Controls.Add(this.lblConnectedDatabase);
            this.pnlConnectStatus.Location = new System.Drawing.Point(0, 1028);
            this.pnlConnectStatus.Name = "pnlConnectStatus";
            this.pnlConnectStatus.Size = new System.Drawing.Size(2056, 48);
            this.pnlConnectStatus.TabIndex = 10;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.btnSkillAdd);
            this.panel1.Controls.Add(this.txtSkillName);
            this.panel1.Controls.Add(this.txtSkillDesc);
            this.panel1.Location = new System.Drawing.Point(24, 744);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 256);
            this.panel1.TabIndex = 11;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Skill Name";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(27, 72);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(121, 20);
            this.label10.TabIndex = 3;
            this.label10.Text = "Skill Description";
            // 
            // btnSkillAdd
            // 
            this.btnSkillAdd.Location = new System.Drawing.Point(219, 187);
            this.btnSkillAdd.Name = "btnSkillAdd";
            this.btnSkillAdd.Size = new System.Drawing.Size(98, 39);
            this.btnSkillAdd.TabIndex = 5;
            this.btnSkillAdd.Text = "Add Skill";
            this.btnSkillAdd.UseVisualStyleBackColor = true;
            this.btnSkillAdd.Click += new System.EventHandler(this.btnSkillAdd_Click);
            // 
            // txtSkillName
            // 
            this.txtSkillName.Location = new System.Drawing.Point(183, 18);
            this.txtSkillName.Name = "txtSkillName";
            this.txtSkillName.Size = new System.Drawing.Size(315, 26);
            this.txtSkillName.TabIndex = 2;
            // 
            // txtSkillDesc
            // 
            this.txtSkillDesc.Location = new System.Drawing.Point(183, 66);
            this.txtSkillDesc.Name = "txtSkillDesc";
            this.txtSkillDesc.Size = new System.Drawing.Size(315, 26);
            this.txtSkillDesc.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2068, 1114);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnlConnectStatus);
            this.Controls.Add(this.pnlUsers);
            this.Controls.Add(this.pnlLogin);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Virtual Brick";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.pnlLogin.ResumeLayout(false);
            this.pnlLogin.PerformLayout();
            this.pnlUsers.ResumeLayout(false);
            this.pnlConnectStatus.ResumeLayout(false);
            this.pnlConnectStatus.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem createNewUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox lstSkills;
        private System.Windows.Forms.Button btnAddSkillocal;
        private System.Windows.Forms.ComboBox cboSkills;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCreateUser;
        private System.Windows.Forms.TextBox txtDBUserName;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtDB;
        private System.Windows.Forms.ToolStripMenuItem viewUsersToolStripMenuItem;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.TextBox txtLname;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFname;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlLogin;
        private System.Windows.Forms.TextBox txtDBPassword;
        private System.Windows.Forms.Panel pnlUsers;
        private System.Windows.Forms.Label lblConnectedDatabase;
        private System.Windows.Forms.Panel pnlConnectStatus;
        private System.Windows.Forms.ListBox lstUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSkillAdd;
        private System.Windows.Forms.TextBox txtSkillName;
        private System.Windows.Forms.TextBox txtSkillDesc;
    }
}

