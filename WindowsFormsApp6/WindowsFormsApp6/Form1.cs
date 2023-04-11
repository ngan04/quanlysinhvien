using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void txtLogin_Click(object sender, EventArgs e)
        {
            if (txtPass.Text != string.Empty && txtUser.Text != string.Empty)
            {
                if (txtUser.Text == "student" && txtPass.Text == "8888")
                {
                    this.Hide();
                    Form2 f = new Form2();
                    f.ShowDialog();

                    //MessageBox.Show(this, "Login success", "Result", MessageBoxButtons.OK, MessageBoxIcon.None);
                    //this.Hide();
                    //Form2 f = new Form2();
                    //f.ShowDialog();
                    //this.Dispose();
                }
                else
                {
                    MessageBox.Show("Incorrect", "Notification");
                }
            }
            else
            {
                MessageBox.Show("Please enter information", "Notification");
            }
            
               
            
        }
    }
}
