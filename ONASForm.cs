using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fashion_House
{
    public partial class ONASForm : Form
    {
        public ONASForm()
        {
            InitializeComponent();
        }

        private void Glavbutton2_Click(object sender, EventArgs e)
        {
            FormGlav f121 = new FormGlav();
            this.Close();
            f121.Show();
        }
    }
}
