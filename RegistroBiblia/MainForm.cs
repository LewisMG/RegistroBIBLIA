using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using RegistroBiblia.UI.Registros;

namespace RegistroBiblia
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void libroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarLibro view = new RegistrarLibro();
            view.Show();
        }
    }
}
