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

namespace Fashion_House
{
    public partial class VKLADKIForm : Form
    {
        //Database database= new Database();
        public VKLADKIForm()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage5_Click(object sender, EventArgs e)
        {

        }

        private void GLaVbutton_Click(object sender, EventArgs e)
        {
            FormGlav f121 = new FormGlav();
            this.Close();
            f121.Show();
        }

        private void VKLADKIForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_FASHION_HOUSEDataSet1.Agency". При необходимости она может быть перемещена или удалена.
            this.agencyTableAdapter.Fill(this._FASHION_HOUSEDataSet1.Agency);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_FASHION_HOUSEDataSet.Agents". При необходимости она может быть перемещена или удалена.
            this.agentsTableAdapter.Fill(this._FASHION_HOUSEDataSet.Agents);

        }
    }
}
