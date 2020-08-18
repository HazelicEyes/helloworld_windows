using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace helloworld_windows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
            /* 
            dadadad
            adadad
            adadad
            adadada
            */

            /* Outro teste de comentarios
             * sfsfsfsf
             * sfsfsfsf */

            MessageBox.Show("YEEEEEET", "yeeted box", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);

            if (true) // Se verdadeiro = mostrar mensagem
            {
                MessageBox.Show("=D"); // Carinha feliz
            }
            else
            {
                MessageBox.Show("=("); //Carinha triste
            }
           
            
            // so this code is pretty much messed, come here again when you learn how to code
        }
    }
}
