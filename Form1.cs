using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImplementarDll
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Invocando nuestra clase principal
            //y despues a los datos
           cnbd.Class1 clase = new cnbd.Class1();
            cnbd.Class1.infoEmpleado datos = clase.empleado(textBox1.Text);

            if (datos != null)
            {
                label1.Text = datos.nom;
                label2.Text = datos.ape;
                label3.Text = datos.num;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
