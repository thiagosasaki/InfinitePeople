using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfinitePeople
{
    public partial class frmConsultaGeral : Form
    {
        public frmConsultaGeral()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            doGetAll();
        }

        void doGetAll()
        {
            string URL = "https://api-projetointegrador.herokuapp.com/api/pessoas";
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
                request.Method = "GET";
                request.Accept = "application/json";

                WebResponse response = request.GetResponse();
                Stream rebut = response.GetResponseStream();
                StreamReader readStream = new StreamReader(rebut, Encoding.UTF8);
                string info = readStream.ReadToEnd();

                response.Close();
                readStream.Close();

                var listaPessoas = JsonConvert.DeserializeObject<List<Pessoa>>(info);

                foreach (Pessoa P in listaPessoas)
                {
                    ListViewItem item = new ListViewItem(P.doc);
                    item.SubItems.Add(P.nome.ToString());

                    if (P.sexo == "M")
                    {
                        item.SubItems.Add("Masculino");
                    }
                    else if (P.sexo == "F")
                    {
                        item.SubItems.Add("Feminino");
                    }
                    else item.SubItems.Add("Outro");

                    item.SubItems.Add(P.email.ToString());
                    item.SubItems.Add(P.telefone.ToString());
                    listaConsulta.Items.Add(item);
                }

            }
            catch
            {
                MessageBox.Show("Erro ao consultar cadastros.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
