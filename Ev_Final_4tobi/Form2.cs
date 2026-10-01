using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ev_Final_4tobi
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void TextVar1_TextChanged(object sender, EventArgs e)
        {

        }

        private void BtnProducto_Click(object sender, EventArgs e)
        {
            Byte Num1 = Byte.Parse(TextVar1.Text);
            byte Num2 = Byte.Parse(TextVar2.Text);
            int suma = Num1 + Num2;
            MessageBOx.show("el resultado es" + suma);

        }

        private void BtnSuma_Click(object sender, EventArgs e)
        {
            Byte Num1 = Byte.Parse(TextVar1.Text);
            byte Num2 = Byte.Parse(TextVar2.Text);
            int producto = Num1 / Num2;
            MessageBOx.show("el resultado es" + Producto);
    }

        private void BtnPotencia_Click(object sender, EventArgs e)
        {
            Byte Num1 = Byte.Parse(TextVar1.Text);
            byte Num2 = Byte.Parse(TextVar2.Text);
            int potencia = Num1 / Num2;
            MessageBOx.show("el resultado es" + Potencia);
        }

        private void BtnDivision_Click(object sender, EventArgs e)
        {
            float Num1 = float.Parse(TextVar1.Text);
            float Num2 = float.Parse(TextVar2.Text);
            if (Num2 )
    }
