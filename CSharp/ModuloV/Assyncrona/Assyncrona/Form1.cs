using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assyncrona
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sincrona();
        }


        public void Sincrona()
        {
            List<string> lista = new List<string>();
            for (int i = 0; i <= 1000000; i++)
            {
                lista.Add(i.ToString());

            }
            foreach(var item in lista)
            {
                var t = item+1;
                richTextBox1.Text = item + "" +t;
            }
    
        }

        public  async void Asincrona()
        {
            IList tarefa = As;
            foreach (var item in As)
            {
                var t = await item + 1;
                richTextBox1.Text = item + "" + t;
            }
        }

        public async Task<List<int>> As()
        {

            List<int> lista =  new List<int>();
            for (int i = 0; i <= 1000000; i++)
            {
                lista.Add(i);

            }

            return  lista;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Asincrona();
        }
    }
}
