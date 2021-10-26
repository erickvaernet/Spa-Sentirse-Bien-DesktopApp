using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team_Dev
{
    public partial class Form2 : Form
    {
        private Form padre;

        public Form2(Form padre)
        {
            InitializeComponent();
            personalizar();
            this.padre = padre;
            panelsubmenu.Visible = true;
        }
        private void personalizar()
        {
            panelsubmenu.Visible = false;
        }
        private void ocultarsubmenu()
        {
            if (panelsubmenu.Visible == true)
            {
                panelsubmenu.Visible = false;
            }
        }
        private void mostrarsubmenu(Panel submenu)
        {
            submenu.Enabled = true;
            //submenu.Visible = true;
            
            if (submenu.Visible == false)
            {
                submenu.Visible=true;
            }
            else
            {
                submenu.Visible=false;
            }

        }


       /* private void btnmenu_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelsubmenu);
        }*/
        
        private void btnpagos_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
        }

        private void btnclientes_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
        }

        private void btnpersonal_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
        }

        private void btnaddpersonal_Click(object sender, EventArgs e)
        {
            ocultarsubmenu();
        }

        private void panelsubmenu_Paint(object sender, PaintEventArgs e)
        {
            //ocultarsubmenu();
        }

        private void panelmenu_Paint(object sender, PaintEventArgs e)
        {
            ocultarsubmenu();
        }

        private void buttonmenu_Click(object sender, EventArgs e)
        {
            mostrarsubmenu(panelsubmenu);
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.padre.Dispose();
        }
    }
}
