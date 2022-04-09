using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RetreavingData_066
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'prodiTIDataSet.Mahasiswa' table. You can move, or remove it, as needed.
            this.mahasiswaTableAdapter.Fill(this.prodiTIDataSet.Mahasiswa);
            // TODO: This line of code loads data into the 'adventureWorksDataSet.Employee' table. You can move, or remove it, as needed.
            this.employeeTableAdapter.Fill(this.adventureWorksDataSet.Employee);
            this.dataGridView1.Columns[0].DefaultCellStyle.ForeColor = Color.YellowGreen;
            this.dataGridView1.Columns[1].DefaultCellStyle.ForeColor = Color.Black;
            this.dataGridView1.Columns[2].DefaultCellStyle.ForeColor = Color.RosyBrown;
            this.dataGridView1.Columns[3].DefaultCellStyle.ForeColor = Color.DarkRed;
            this.dataGridView1.Columns[4].DefaultCellStyle.ForeColor = Color.Yellow;
            this.dataGridView1.Columns[0].DefaultCellStyle.SelectionBackColor = Color.Pink;
            this.dataGridView1.Columns[1].DefaultCellStyle.SelectionBackColor = Color.Orange;
            this.dataGridView1.Columns[2].DefaultCellStyle.SelectionBackColor = Color.Green;
            this.dataGridView1.Columns[3].DefaultCellStyle.SelectionBackColor = Color.Blue;
            this.dataGridView1.Columns[4].DefaultCellStyle.SelectionBackColor = Color.Maroon;

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
