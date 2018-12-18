using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VBUser.UserDefs;
using VBUser.UserDefs.UserCreatePushHelper;


namespace VBUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            UserCreator uc = new UserCreator();
            uc.SetFirstName (txtFname.Text);
            uc.SetLastName(txtLname.Text);
            uc.SetMiddleInit(txtMname.Text);


            PushToXMLHelper ptx = new PushToXMLHelper(uc);
            ptx.CreateUser();
            uc = null;


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
    }
}
