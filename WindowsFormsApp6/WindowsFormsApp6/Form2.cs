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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        private void removeinterface()
        {
            textBox1.Text = "";
            textBox2.Text = "";
           comboBox1.Text = "";
            dateTimePicker1.Text = "";
            textBox4.Text = "";
        }
        private void removeinterface1()
        {
            textBox6.Text = "";
            textBox7.Text = "";
            comboBox2.Text = "";
            dateTimePicker2.Text = "";
            textBox8.Text = "";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }


        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView2.SelectedCells.Count > 0)
            {
                DataGridViewRow row = dataGridView2.Rows[dataGridView2.CurrentCell.RowIndex];
                textBox1.Text = row.Cells[0].Value.ToString();
                textBox2.Text = row.Cells[1].Value.ToString();
                comboBox1.Text = row.Cells[2].Value.ToString();
                dateTimePicker1.Text = row.Cells[3].Value.ToString();
                textBox4.Text = row.Cells[4].Value.ToString();
            }
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {

           if(textBox1.Text !="")
            {
                if(textBox2.Text != "")
                {
                    if(comboBox1.Text !="")
                    {
                        if(dateTimePicker1.Text != "")
                        {
                            if(textBox4.Text != "")
                            {
                                dataGridView2.Rows.Add(textBox1, textBox2, comboBox1, dateTimePicker1, textBox4);
                                MessageBox.Show("complete the information");
                                removeinterface();
                            }
                            else
                            {
                                MessageBox.Show("did not enter marthscore");
                            }
                        }
                        else
                        {
                            MessageBox.Show("did not enter birthday");
                        }
                    }
                    else
                    {
                        MessageBox.Show("did not enter gender");
                    }
                }
                else
                {
                    MessageBox.Show("did not enter the code ");
                }
            }
            else
            {
                MessageBox.Show("did not enter name");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedCells.Count > 0)
            {
                int vitri = dataGridView2.CurrentCell.RowIndex;
                dataGridView2[0, vitri].Value = textBox1.Text;
                dataGridView2[1, vitri].Value = textBox2.Text;
                dataGridView2[2, vitri].Value = comboBox1.Text;
                dataGridView2[3, vitri].Value = dateTimePicker1.Text;
                dataGridView2[4, vitri].Value = textBox4.Text;
                removeinterface();
            }
            else
            {
                MessageBox.Show("Nothing to fix", "Notification");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to delete?","Notification",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
            {
                int index = dataGridView2.CurrentCell.RowIndex;
                dataGridView2.Rows.RemoveAt(index);
            }
        }

        private void txtSearch_Click(object sender, EventArgs e)
        {
            if (radName.Checked)
            {
               dataGridView1.Rows.Clear();
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (textBox1.Text == dataGridView2[0, i].Value.ToString())
                    {
                        dataGridView1.Rows.Add(dataGridView2[0, i].Value, dataGridView2[1, i].Value, dataGridView2[2, i].Value, dataGridView2[3, i].Value, dataGridView2[4, i].Value);
                        removeinterface1();
                    }
                }
            }
            else if (radBirthday.Checked)
            {
                dataGridView1.Rows.Clear();
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dateTimePicker1.Text == dataGridView2[0, i].Value.ToString())
                    {
                        dataGridView1.Rows.Add(dataGridView2[0, i].Value, dataGridView2[1, i].Value, dataGridView2[2, i].Value, dataGridView2[3, i].Value, dataGridView2[4, i].Value);
                        removeinterface1();
                    }
                }
            }
            else if (radGender.Checked)
            {
                dataGridView1.Rows.Clear();
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (comboBox1.Text == dataGridView2[0, i].Value.ToString())
                    {
                        dataGridView1.Rows.Add(dataGridView2[0, i].Value, dataGridView2[1, i].Value, dataGridView2[2, i].Value, dataGridView2[3, i].Value, dataGridView2[4, i].Value);
                        removeinterface1();
                    }
                }
            }
            else if (radStudentID.Checked)
            {
                dataGridView1.Rows.Clear();
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (textBox2.Text == dataGridView2[0, i].Value.ToString())
                    {
                        dataGridView1.Rows.Add(dataGridView2[0, i].Value, dataGridView2[1, i].Value, dataGridView2[2, i].Value, dataGridView2[3, i].Value, dataGridView2[4, i].Value);
                        removeinterface1();
                    }
                }
            }
            else if (radMarthscore.Checked)
            {
                dataGridView1.Rows.Clear();
                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (textBox4.Text == dataGridView2[0, i].Value.ToString())
                    {
                        dataGridView1.Rows.Add(dataGridView2[0, i].Value, dataGridView2[1, i].Value, dataGridView2[2, i].Value, dataGridView2[3, i].Value, dataGridView2[4, i].Value);
                        removeinterface1();
                    }
                }
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
