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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
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

                doPost(psexo);

                limparTela();
            }
        }

        private void doPost(String sexo)
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
            request.Method = "POST";
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
                MessageBox.Show("Cadastro concluído com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
