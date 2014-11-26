using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TeamSelector
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

        private void teams_MouseHover(object sender, EventArgs e)
        {
            allPrice.Visible = true;
        }

        private void teams_MouseLeave(object sender, EventArgs e)
        {
            allPrice.Visible = false;
        }

        private void teams_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void teams_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            
            allPrice.Visible = false;
            string curItem = teams.SelectedItem.ToString();
            if (curItem.Equals("Minnesota Vikings"))
            {
                    Vikings.Visible = true;
                    Twins.Visible = false;
                    Giants.Visible = false;
                    Bulldogs.Visible = false;

                    this.BackColor = System.Drawing.Color.Blue;
                }

                else if (curItem.Equals("Minnesota Twins"))
                {

                    Vikings.Visible = false;
                    Twins.Visible = true;
                    Giants.Visible = false;
                    Bulldogs.Visible = false;
                    
                    this.BackColor = System.Drawing.Color.Red;
                }

                else if (curItem.Equals("New York Giants"))
                {

                    Vikings.Visible = false;
                    Twins.Visible = false;
                    Giants.Visible = true;
                    Bulldogs.Visible = false;
                    

                    this.BackColor = System.Drawing.Color.Gray;
                }

                else if (curItem.Equals("UMD Bulldogs"))
                {

                    Vikings.Visible = false;
                    Twins.Visible = false;
                    Giants.Visible = false;
                    Bulldogs.Visible = true;

                    this.BackColor = System.Drawing.Color.Orange;
                }
            
        }

        

    }
}
