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
using System.Web.Script.Serialization;
using System.Windows.Forms;

namespace InfinitePeople
{
    public partial class frmEditarExcluir : Form
    {
        public frmEditarExcluir()
        {
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtBusca.Text))
            {
                MessageBox.Show("Campo de busca não preenchido!", "Atenção", MessageBoxButtons.OK);
            }
            else doGetDoc();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDoc.Text))
            {
                MessageBox.Show("Não existem dados a serem excluídos!", "Erro", MessageBoxButtons.OK);
            }
            else
            {
                var confirma = MessageBox.Show("Prosseguir com a exclusão do cadastro de " + txtNome.Text + "?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirma == DialogResult.Yes)
                {
                    doExcluir();
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(txtDoc.Text))
            {
                MessageBox.Show("Documento deve ser preenchido!", "Atenção", MessageBoxButtons.OK);
            }
            else if (String.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Nome deve ser preenchido!", "Atenção", MessageBoxButtons.OK);
            }
            else if (String.IsNullOrEmpty(comboSexo.Text))
            {
                MessageBox.Show("Sexo deve ser preenchido!", "Atenção", MessageBoxButtons.OK);
            }
            else if (String.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("E-mail deve ser preenchido!", "Atenção", MessageBoxButtons.OK);
            }
            else if (String.IsNullOrEmpty(txtTelefone.Text))
            {
                MessageBox.Show("Telefone deve ser preenchido!", "Atenção", MessageBoxButtons.OK);
            }
            else
            {
                var confirma = MessageBox.Show("Deseja salvar as alterações?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (confirma == DialogResult.Yes)
                {
                    String psexo;
                    if (comboSexo.Text == "Feminino")
                    {
                        psexo = "F";
                    }
                    else if (comboSexo.Text == "Masculino")
                    {
                        psexo = "M";
                    }
                    else psexo = "O";

                    doUpdate(psexo);

                    limparTela();
                }
            }
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

                if (psexo == "M")
                {
                    comboSexo.Text = "Masculino";

                }
                else if (psexo == "F")
                {
                    comboSexo.Text = "Feminino";
                }
                else comboSexo.Text = "Outro";

            }
            catch
            {
                MessageBox.Show("Cadastro não encontrado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void doExcluir()
        {

            string URL = "https://api-projetointegrador.herokuapp.com/api/pessoas/" + txtDoc.Text;
            try
            {
                HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
                request.Method = "DELETE";
                request.ContentType = "application/json";
                request.Accept = "application/json";

                WebResponse response = request.GetResponse();
                Stream rebut = response.GetResponseStream();
                StreamReader readStream = new StreamReader(rebut, Encoding.UTF8);
                string info = readStream.ReadToEnd();

                response.Close();
                readStream.Close();

                MessageBox.Show(txtNome.Text + " excluído com sucesso!", "Atenção");

                limparTela();

            }
            catch
            {
                MessageBox.Show("Erro ao excluir cadastro!", "Atenção");
            }
        }

        void doUpdate(String sexo)
        {
            string URL = "https://api-projetointegrador.herokuapp.com/api/pessoas";

            Pessoa prequest = new Pessoa();

            prequest.doc = txtDoc.Text;
            prequest.nome = txtNome.Text;
            prequest.email = txtEmail.Text;
            prequest.telefone = txtTelefone.Text;
            prequest.sexo = sexo;

            string json = new JavaScriptSerializer().Serialize(prequest);

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(URL);
            request.Method = "PUT";
            request.ContentType = "application/json";
            request.Accept = "application/json";
            request.ContentLength = json.Length;
            StreamWriter requestWriter = new StreamWriter(request.GetRequestStream(), System.Text.Encoding.ASCII);
            requestWriter.Write(json);
            requestWriter.Close();

            try
            {
                WebResponse webResponse = request.GetResponse();
                Stream webStream = webResponse.GetResponseStream();
                StreamReader responseReader = new StreamReader(webStream);
                string response = responseReader.ReadToEnd();
                Console.Out.WriteLine(response);
                responseReader.Close();
                ;
                MessageBox.Show("Alterações concluídas com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Cadastro não concluído!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        void limparTela()
        {
            txtDoc.Clear();
            txtNome.Clear();
            comboSexo.SelectedIndex = -1;
            txtEmail.Clear();
            txtTelefone.Clear();
        }

    }
}
