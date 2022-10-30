using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Autostrazi
{
    public partial class FormAddAutostrada : Form
    {
        public FormAddAutostrada()
        {
            InitializeComponent();
        }

        private Boolean StringIsEmpty(String text)
        {
            return String.IsNullOrWhiteSpace(text);
        }
        private void AllowOnlyNumbers(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) e.Handled =
            true;
        }
        public Boolean isUpdated = false;

        private void cmdAdd_Click_Click(object sender, EventArgs e)
        {
            String title = txtTitlte.Text;
            String ruta = txtroute.Text;
            String creare = dtpDate.Text;
            String marimea = txtsize.Text;
            String uploaderId = txtUploaderId.Text;

            if (StringIsEmpty(title) || StringIsEmpty(ruta) || StringIsEmpty(marimea) || StringIsEmpty(uploaderId))
            {
                MessageBox.Show("Introduceți date în toate câmpurile!", "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                String connectionString = "Data Source=localhost;Initial Catalog = project_tv; Integrated Security = True";
                String query = "INSERT into autostrada" + " (autostrada_title, autostrada_creare, autostrada_ruta, autostrada_marime, autostrada_uploader_id) " + "VALUES (@title, @creare, @ruta, @marime, @uploaderId)";
               
                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@creare",dtpDate.Value.ToString("yyy-MM-dd"));
                cmd.Parameters.AddWithValue("@ruta", ruta);
                cmd.Parameters.AddWithValue("@marime", marimea);
                cmd.Parameters.AddWithValue("@uploaderId", uploaderId);

                con.Open();
                cmd.ExecuteReader();
                con.Close();

                cmd.Dispose();
                con.Dispose();
                this.Close();
                this.isUpdated = true;


            }
        }

        private void cmdRemove_Click_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtUploaderId_KeyPress(object sender, KeyPressEventArgs e)
        {
            AllowOnlyNumbers(e);
        }
    }
}
