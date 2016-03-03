using System;
using System.Windows.Forms;

/// <summary>
/// Patrick Pissurno - 27 - 3003 @ 2016 - NAVE
/// </summary>
namespace _2015_3003_1BIM_ListaEncadeada
{
    public partial class Form1 : Form
    {
        private Lista lista;

        public Form1()
        {
            InitializeComponent();
        }

        private void CarregarPrograma(object sender, EventArgs e)
        {
            lista = new Lista();
        }

        private void InicializarLista(object sender, EventArgs e)
        {
            lista = new Lista();
            Elemento elemento = new Elemento(lista.Count);
            lista.Adiciona(elemento);
            AtualizarLista(null, null);
        }

        private void AdicionaElemento(object sender, EventArgs e)
        {
            Elemento elemento = new Elemento(lista.Count);
            lista.Adiciona(elemento);
            AtualizarLista(null, null);
        }

        private void AtualizarLista(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Elemento el = lista.Primeiro;
            while(el != null)
            {
                listView1.Items.Add(el.ToString());
                el = el.Proximo;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Posição a ser adicionado", "Mensagem", "0", -1, -1);
            try
            {
                int p = int.Parse(input);
                Elemento elemento = new Elemento(lista.Count);
                lista.Adiciona(elemento, p);
            }
            catch {
                MessageBox.Show("Please type a valid number");
            }
            AtualizarLista(null, null);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Valor para adicionar após", "Mensagem", "1", -1, -1);
            try
            {
                int p = int.Parse(input);
                Elemento elemento = new Elemento(lista.Count);
                lista.AdicionarApos(elemento, p);
            }
            catch
            {
                MessageBox.Show("Please type a valid number");
            }
            AtualizarLista(null, null);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Posição do elemento 1", "Mensagem", "0", -1, -1);
            string input2 = Microsoft.VisualBasic.Interaction.InputBox("Posição do elemento 2", "Mensagem", "0", -1, -1);
            try
            {
                int p = int.Parse(input);
                int p2 = int.Parse(input2);
                lista.SwapByPosition(p, p2);
            }
            catch
            {
                MessageBox.Show("Please type a valid number");
            }
            AtualizarLista(null, null);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Posição do elemento a ser removido", "Mensagem", "1", -1, -1);
            try
            {
                int p = int.Parse(input);
                lista.RemoveAtPos(p);
            }
            catch
            {
                MessageBox.Show("Please type a valid number");
            }
            AtualizarLista(null, null);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string input = Microsoft.VisualBasic.Interaction.InputBox("Valor do elemento a ser removido", "Mensagem", "1", -1, -1);
            try
            {
                int p = int.Parse(input);
                lista.RemoveByValue(p);
            }
            catch
            {
                MessageBox.Show("Please type a valid number");
            }
            AtualizarLista(null, null);
        }
    }
}
