using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form2 : Form
    {

        Thread tela;
        string[] codveiculos = new string[6];
        string[] nomeveiculo = new string[6];
        string[] imgveiculo = new string[6];
        string[] descricaoveiculo = new string[6];
        string[] categoriaveiculo = new string[6];
        string[] valorveiculo = new string[6];
 
        public Form2()
        {
            InitializeComponent();
        }

        public void load_veiculos()
        {

            for (int i=1;i<3;i++)
            {
                codveiculos[i] = "0000" + i;
            }

            nomeveiculo[1] = "Marcopolo G7 1200";
            nomeveiculo[2] = "Marcopolo G7 1050";

            imgveiculo[1] = "https://i.pinimg.com/originals/cb/f7/e3/cbf7e311e9698cf9a3b3fb485d04bfa6.jpg";
            imgveiculo[2] = "https://img.olx.com.br/images/05/055801098005744.jpg";

            descricaoveiculo[1] = "Conheça o modelo de carroceria Marcopolo Paradiso G7 1200 navegando por mais de 546.270 fotos em nosso acervo colaborativo.";
            descricaoveiculo[2] = "Paradiso G7 1200 2010 Executivo Mercedes 0500rs Marcopolo";

            categoriaveiculo[1] = "Rodoviário";
            categoriaveiculo[2] = "Rodoviário";

            valorveiculo[1] = "1200";
            valorveiculo[2] = "1200";

        }
    
        private void simularFretemantoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            tela = new Thread(form1);
            tela.SetApartmentState(ApartmentState.STA);
            tela.Start();
        }

        private void form1()
        {
            Application.Run(new Form1());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            load_veiculos();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Length == 5)
            {
                int index = 0;

                for (int cod = 1; cod <  5;cod++)
                {
                    if (textBox1.Text == codveiculos[cod])
                    {
                        index = cod;
                    }
                }
                if (index > 0)
                {
                    textBox1.Text = "";
                    listBox1.Items.Add(String.Format(nomeveiculo[index]));
                    pictureBox1.ImageLocation = imgveiculo[index];
;                   richTextBox1.Text = descricaoveiculo[index];
                    textBox2.Text = nomeveiculo[index];
                    textBox3.Text = categoriaveiculo[index];
                    textBox4.Text = valorveiculo[index];
                }else
                {
                    textBox1.Text = "";
                    richTextBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    MessageBox.Show("Veiculo não encontrado");
                }
            }
        }
    }
}
