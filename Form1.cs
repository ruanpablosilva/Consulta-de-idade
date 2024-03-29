using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Idade
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerificar_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtIdade.Text, out int idade))
            {
                MessageBox.Show("Por favor, digite uma idade válida.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (idade >= 18)
            {
                MessageBox.Show("Você é maior de idade.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Você é menor de idade.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
// 1  label de instrução e outro nomeando a página, 1 textbox funcional para colocar a idade e um botão de comando