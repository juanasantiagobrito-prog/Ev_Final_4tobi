using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ev_Final_4tobi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textUsuaio_TextChanged(object sender, EventArgs e)
        {
           if (TextUsuario.Text == "Juana" && Textcontraseña. Text == "53")
        }

        private void textContraseña_TextChanged(object sender, EventArgs e)
        {
            this.Hide();
            Form2 app = new Form2();
            app.Show();
        }
        EventLogSession
       EventLogSession
        
        private void BtnIngesar_Click(object sender, EventArgs e)
        {
         
        }

        private void LBL1_Click(object sender, EventArgs e)
        {

        }
    }
}
