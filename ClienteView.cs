using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JSON
{
    public partial class ClienteView : Form
    {
        List<ClienteModel> listaClientes = new List<ClienteModel>();
        public ClienteView()
        {
            InitializeComponent();
        }

        private void btnSerializar_Click(object sender, EventArgs e)
        {
            ClienteModel cliente = new ClienteModel();

            cliente.Nome = txtNome.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Cpf = txtCpf.Text;

            if (cliente.JsonSerializar(cliente, @"D:\Json\arquivo.json"))
            {
                MessageBox.Show("Arquivo Salvo!");
            }
            else {
                MessageBox.Show("Erro ao Salvar o Arquivo!");
            }
            
        }

        private void btnDesserializar_Click(object sender, EventArgs e)
        {
            ClienteModel cliente = ClienteModel.JsonDesserializar(@"D:\Json\arquivo.json");

            txtNome.Text = cliente.Nome;
            txtTelefone.Text = cliente.Telefone;
            txtCpf.Text = cliente.Cpf;                        
        }

        private void btnInserirDado_Click(object sender, EventArgs e)
        {
            var cliente = new ClienteModel();
            cliente.Nome = txtNome.Text;
            cliente.Telefone = txtTelefone.Text;
            cliente.Cpf = txtCpf.Text;

            listaClientes.Add(cliente);

            dataGridViewListaClientes.DataSource = null;
            dataGridViewListaClientes.DataSource = listaClientes;
        }

        private void btnSerializarLista_Click(object sender, EventArgs e)
        {
            var cliente = new ClienteModel();
            if (cliente.JsonSerializarLista(listaClientes, @"D:\Json\arquivoLista.json"))
            {
                MessageBox.Show("Salvo arquivo na Lista");
            }
            else {
                MessageBox.Show("Erro ao salvar o arquivo na Lista");
            }
        }

        private void btnDesserializarLista_Click(object sender, EventArgs e)
        {
            listaClientes =  ClienteModel.JsonDesserializarLista(@"D:\Json\arquivoLista.json");

            dataGridViewListaClientes.DataSource = listaClientes;
        }
    }
}
