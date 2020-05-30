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
    public partial class frmConsultaDoc : Form
    {
        public frmConsultaDoc()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBusca.Text))
            {
                MessageBox.Show("Campo de busca não preenchido!", "Atenção", MessageBoxButtons.OK);
            }
            else doGetDoc();
        }

        void doGetDoc()
        {
            limparTela();

            string URL = "https://api-projetointegrador.herokuapp.com/api/pessoas/" + txtBusca.Text;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
                request.Method = "GET";
                request.ContentType = "application/json";
                request.Accept = "application/json";

                WebResponse response = request.GetResponse();
                Stream rebut = response.GetResponseStream();
                StreamReader readStream = new StreamReader(rebut, Encoding.UTF8);
                string info = readStream.ReadToEnd();

                response.Close();
                readStream.Close();

                Pessoa pessoa = JsonConvert.DeserializeObject<Pessoa>(info);
                string psexo;

                txtDoc.Text = pessoa.doc;
                txtNome.Text = pessoa.nome;
                psexo = pessoa.sexo;
                txtEmail.Text = pessoa.email;
                txtTelefone.Text = pessoa.telefone;

                if (psexo == "M") {
                    txtSexo.Text = "Masculino";
                } else if (psexo == "F") {
                    txtSexo.Text = "Feminino";
                } else txtSexo.Text = "Outro";

            }
            catch
            {
                MessageBox.Show("Cadastro não encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void limparTela()
        {
            txtDoc.Clear();
            txtNome.Clear();
            txtSexo.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
        }

    }
}
