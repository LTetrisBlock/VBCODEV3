using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UserDefs.DBManager;
using VBCORE3;
using VBUser.UserDefs;

namespace VBUI
{
    public partial class Form1 : Form
    {
        VBSession session = new VBSession(-1); //Create a new Session. 
        bool connected = false;

        string _dbPass = "";
        string _dbuserName = "";
        string _db = "";

        public Form1()
        {
            InitializeComponent();

            txtDB.Text = "dbIconTest";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

   
        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            con();

        }

        private void con()
        {
            using (DbUtitlity dbUtil = new DbUtitlity())
            {

                dbUtil.InputCreds(txtDBUserName.Text, txtDBPassword.Text, txtDB.Text);
                bool connectAtt = dbUtil.VerifyLogin();
                if (connectAtt)
                {
                    connected = true;
                    _dbPass = txtDBPassword.Text;
                    _dbuserName = txtDBUserName.Text;
                    _db = txtDB.Text;
                    lblConnectedDatabase.Text = _db;
                    pnlConnectStatus.BackColor = Color.FromArgb(128, 255, 128);

                    lstUser.Items.Clear();

                    foreach (string[] lItem in dbUtil.CollectDataFromDb())
                    {
                        string g = $"{lItem[0]}  ---  {lItem[1]}  ---  {lItem[2]}";
                        lstUser.Items.Add(g);
                    }
                }
                else
                {
                    lblConnectedDatabase.Text = "N/A";
                    pnlConnectStatus.BackColor = Color.FromArgb(255, 128, 128);
                }
            }
        }

        private void grpCreateUser_Enter(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        List<string> _items = new List<string>(); // <-- Add this

        private void btnAddSkill_Click(object sender, EventArgs e)
        {
            _items.Add(cboSkills.Text);

            lstSkills.DataSource = _items;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (connected)
            {
                using (UserCreator uc = new UserCreator())
                {
                    uc.SetFirstName(txtFname.Text);
                    uc.SetLastName(txtLname.Text);
                    uc.SetMiddleInit(txtDBPassword.Text);

                    uc.SetDbPass(_dbPass);
                    uc.SetDbUser(_dbuserName);
                    uc.Setdb(_db);

                    uc.AddNewUserToDatabase();


                    lstUser.Items.Clear();
                    con();
                }
            }          
            else
            {
                //Todo: write warning message. 
            }
        }
    }
}
