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
    public partial class Form1 : Form
    {
        private object Form2;
        Thread nt;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {


            string km = textBox1.Text;
            string nome = textBox2.Text;
            string cidade_origem = textBox3.Text;
            string cidade_destino = textBox4.Text;
            DateTime data_saida = dateTimePicker1.Value;
            DateTime data_retorno = dateTimePicker2.Value;
            int status = 0;
            double valor_fretamento = 2.50000;
            double convert_valor = 0.00;


            if (km == "")
            {
                label1.ForeColor = Color.Red;
                label1.Text = "Campo Quilometragem vazio.";
                status += 1;
            }
            else
            {
                label1.ForeColor = Color.Black;
                label1.Text = "Quilometragem preencida.";

            }

            if (nome == "")
            {
                label3.ForeColor = Color.Red;
                label3.Text = "Campo nome completo vazio.";
                status += 1;
            }
            else
            {
                label3.ForeColor = Color.Black;
                label3.Text = "Nome preencido.";
            }

            if (cidade_origem == "")
            {
                label4.ForeColor = Color.Red;
                label4.Text = "Campo cidade origem vazio.";
                status += 1;
            }
            else
            {
                label4.ForeColor = Color.Black;
                label4.Text = "Cidade origem preencido.";
            }

            if (cidade_destino == "")
            {
                label5.ForeColor = Color.Red;
                label5.Text = "Campo cidade destino vazio.";
                status += 1;
            }
            else
            {
                label5.ForeColor = Color.Black;
                label4.Text = "Cidade destino preencido.";
            }
            if (status == 0)
            {

                convert_valor = (Convert.ToInt16(km)) * valor_fretamento;
                textBox5.Text = Convert.ToString(convert_valor);

                if (convert_valor <= 100)
                {
                    label9.ForeColor = Color.Green;
                    label9.Text = "Preço ótimo";
                }
                else if (convert_valor > 100)
                {
                    label9.ForeColor = Color.Green;
                    label9.Text = "Preço Razoável";
                }
                else
                {
                    label9.ForeColor = Color.Green;
                    label9.Text = "Muito Ruim";
                }
                richTextBox1.Text = (" Quilometragem: " + km + ", Nome contratante: " + nome + " Cidade Origem: " + cidade_origem + " Cidade Destino: " + cidade_destino + "Data saida: " + data_saida + "Data retorno: " + data_retorno);
            }
            else
            {
                richTextBox1.Text = "Preencha todos os campos para obter resposta.";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
     
        }

        private void form2()
        {
            Application.Run(new Form2());
        }

        private void veiculosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            nt = new Thread(form2);
            nt.SetApartmentState(ApartmentState.STA);
            nt.Start();
        }
    }
}
