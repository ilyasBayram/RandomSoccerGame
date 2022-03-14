using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomLig
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text=="admin" && textBox2.Text=="1234")
            {
                //if entered values are correct it opens second form and close this one.
                Form2 game = new Form2();
                game.Show();
                this.Hide();
            }
            else
            {
                //if textboxes are empty it request to be filled.
                if (textBox1.Text==""||textBox2.Text=="")
                {
                    MessageBox.Show("Please fill in the required fields");

                }
                else
                {
                    //if textboxes ae not empty but the values are not correct
                    //it request correct values and clears the textboxes
                    MessageBox.Show("User name or password is incorrect");
                    textBox1.Clear();
                    textBox2.Clear();
                }
                
            }

           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
