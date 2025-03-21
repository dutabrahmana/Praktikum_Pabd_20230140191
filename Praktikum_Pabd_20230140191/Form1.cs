using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Praktikum_Pabd_20230140191
{
    public partial class Form1 : Form
    {
        private string connectionString = "Data Source=LAPTOP-KJQI23G9\\DUTA;Initial Catalog=OrganisasiMahasiswa;Integrated Security=True";


        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void ClearForm()
        {
            txtNIM.Clear();
            txtNama.Clear();
            txtEmail.Clear();
            txtTelepon.Clear();
            txtAlamat.Clear();


            txtNIM.Focus();
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void Refresh_Click(object sender, EventArgs e)
        {

        }

        private void Tambah_Click(object sender, EventArgs e)
        {

        }

        private void Hapus_Click(object sender, EventArgs e)
        {

        }

        private void Ubah_Click(object sender, EventArgs e)
        {

        }

       
    }
}






