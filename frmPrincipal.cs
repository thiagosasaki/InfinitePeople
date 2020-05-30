using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using Microsoft.Graph;
using AngleSharp.Io;
using Ubiety.Dns.Core;

namespace InfinitePeople
{
    public partial class frmPrincipal : Form
    {
        internal class NoHighlightRenderer : ToolStripProfessionalRenderer
        {
            protected override void OnRenderMenuItemBackground(ToolStripItemRenderEventArgs e)
            {
                if (e.Item.OwnerItem != null)
                {
                    base.OnRenderMenuItemBackground(e);
                }
            }
        }

        public frmPrincipal()
        {
            InitializeComponent();
            //menuStrip1.Renderer = new NoHighlightRenderer();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var confirma = MessageBox.Show("Deseja encerrar o programa?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (confirma == DialogResult.Yes)
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void consultaPorDocumentoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form f = new frmConsultaDoc();
            f.Show();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmSobre();
            f.Show();
        }

        private void cadastrarPessoaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmCadastro();
            f.Show();
        }

        private void excluirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmEditarExcluir();
            f.Show();
        }

        private void consultaPorDocumentoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form f = new frmConsultaGeral();
            f.Show();
        }
    }
}
