using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfinitePeople
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            pbLoad.Increment(2);
            if (pbLoad.Value == 100)
            {
                timer1.Stop();
                this.Hide();
                Form f = new frmPrincipal();
                f.Show();
            }
        }
    }
}
