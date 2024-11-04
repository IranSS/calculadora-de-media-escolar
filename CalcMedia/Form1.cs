using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcMedia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float media, valor;
            float soma = 0;

            foreach (Control controle in this.Controls) {
                if (controle is TextBox) {
                    valor = Convert.ToSingle(((TextBox)controle).Text);
                    soma += valor;
                }
                media = soma / 4;
                this.Controls["label7"].Text = media.ToString();
                if (media >= 6)
                {
                    this.Controls["label9"].Text = "Aprovado";
                }
                else {
                    this.Controls["label9"].Text = "Reprovado";
                }
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            foreach (Control controle in this.Controls)
            {
                if (controle is TextBox)
                {
                    ((TextBox)controle).Text = "";
                }
                this.Controls["label7"].Text = "...";
                this.Controls["label9"].Text = "...";
            }
    }   }
}
