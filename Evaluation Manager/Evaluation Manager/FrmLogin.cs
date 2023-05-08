using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_Manager
{
    public partial class FrmLogin : Form
    {
        string username = "teacher";
        string password = "test";
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Nothing in the input!", "Problem",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtPassword.Text == "")
            {
                MessageBox.Show("nothing in the input!", "Problem", MessageBoxButtons.OK,
                MessageBoxIcon.Error);
            }
            else
            {
                if (txtUsername.Text == username && txtPassword.Text == password)
                {
                    FrmStudents frmStudents = new FrmStudents();
                    Hide();
                    frmStudents.ShowDialog();
                    Close();

                }
                else
                {
                    MessageBox.Show("wrong identifier!", "Problem", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                }
            }

        }
    }
}
