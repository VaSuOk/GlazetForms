using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GlazetForms
{
    public partial class Glazet : Form
    {
        public Glazet()
        {
            InitializeComponent();
            Material.SelectedIndex = 0;
            OneCamera.Checked = true;
        }

        private void rozrahuvatu_Click(object sender, EventArgs e)
        {
            if (Width.Text != "" && Height.Text != "")
            {
                double Sum = 0, sm2;
                sm2 = Convert.ToDouble(Width.Text) * Convert.ToDouble(Height.Text);
                if(Material.SelectedIndex == 0 && OneCamera.Checked == true)
                {
                    Sum = sm2 * 0.25;
                }
                else if(Material.SelectedIndex == 0 && TwoCamera.Checked == true)
                {
                    Sum = sm2 * 0.30;
                }
                else if(Material.SelectedIndex == 1 && OneCamera.Checked == true)
                {
                    Sum = sm2 * 0.05;
                }
                else if (Material.SelectedIndex == 1 && TwoCamera.Checked == true)
                {
                    Sum = sm2 * 0.10;
                }
                else if(Material.SelectedIndex == 2 && OneCamera.Checked == true)
                {
                    Sum = sm2 * 0.15;
                }
                else if (Material.SelectedIndex == 2 && TwoCamera.Checked == true)
                {
                    Sum = sm2 * 0.20;
                }

                if(Pidvikno.Checked == true)
                {
                    Sum += 35;
                }
                Price.Text = (Convert.ToString(Sum) + " Грн.");
            }
        }

        private void Width_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }

        private void Height_KeyPress(object sender, KeyPressEventArgs e)
        {
            char number = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && number != 8 && number != 44) //цифры, клавиша BackSpace и запятая а ASCII
            {
                e.Handled = true;
            }
        }
    }
}
