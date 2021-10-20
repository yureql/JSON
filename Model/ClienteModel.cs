using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;

namespace Model
{
    public class ClienteModel
    {        
        public string Nome { get ; set ; }
        public string Telefone { get ; set ; }
        public string Cpf { get ; set ; }

        public bool JsonSerializar(ClienteModel cliente, string caminho) {
            var strJson = JsonConvert.SerializeObject(cliente);
            return SalvarArquivoCliente(strJson,caminho);
        }

        public static ClienteModel JsonDesserializar(string caminho) {
            var strJson = AbrirArquivoCliente(caminho);
            if (strJson.Substring(0,4) != "Erro") {
                return JsonConvert.DeserializeObject<ClienteModel>(strJson);
            }
            else {
                ClienteModel cliente = new ClienteModel();
                cliente.Nome = strJson;
                return cliente;
            }
            
        }

        public bool SalvarArquivoCliente(string strJson, string caminho){
            try
            {
                using (StreamWriter sw = new StreamWriter(caminho)) {
                    sw.WriteLine(strJson);
                }
                return true;
            }
            catch (Exception ex)
            {   
                MessageBox.Show("Erro: " + ex.Message);
                return false;
            }
        }

        public static string AbrirArquivoCliente(string caminho) {
            try
            {
                var strJson = "";

                using (StreamReader sr = new StreamReader(caminho))
                {
                    strJson = sr.ReadToEnd();
                }
                return strJson;
            }
            catch (Exception ex)
            {
                return "Erro: " + ex.Message;
            }
        }

        //para lista
        public bool JsonSerializarLista(List<ClienteModel> listaCliente, string caminho)
        {
            var strJson = JsonConvert.SerializeObject(listaCliente, Formatting.Indented);
            return SalvarArquivoCliente(strJson, caminho);
        }

        public static List<ClienteModel> JsonDesserializarLista(string caminho)
        {
            var strJson = AbrirArquivoCliente(caminho);
            if (strJson.Substring(0, 4) != "Erro") {
                return JsonConvert.DeserializeObject<List<ClienteModel>>(strJson);
            }
            else {
                List<ClienteModel> listaClientes = new List<ClienteModel>();
                ClienteModel cliente = new ClienteModel();
                cliente.Nome = strJson;
                listaClientes.Add(cliente);
                return listaClientes;
            }
        }
    }    
}

