using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;

namespace FilmotecaNovo
{
    public partial class Filmoteca : Form
    {
        public Filmoteca()
        {
            InitializeComponent();
        }

        private void btPipoca_Click(object sender, EventArgs e)
        {
            Cadastro c1 = new Cadastro(this);

            c1.MdiParent = this;

            this.btCinema.Visible = false;
            this.btPipoca.Visible = false;
            this.pictureBox1.Visible = false;
            
            c1.Show();
        }

        private void btCinema_Click(object sender, EventArgs e)
        {
            Registro c1 = new Registro(this);

            c1.MdiParent = this;

            this.btCinema.Visible = false;
            this.btPipoca.Visible = false;
            this.pictureBox1.Visible = false;

            c1.Show();
        }
    }
}
