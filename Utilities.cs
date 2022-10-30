using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    internal class Utilities
    {
        private static SqlConnection con;

        public static bool ValidateTextBoxes(Form form)
        {
            bool isValid = true;
            foreach (Control control in form.Controls)
            {
                if (control.GetType() == typeof(TextBox) &&
                String.IsNullOrWhiteSpace(control.Text))
                {
                    isValid = false;

                    break;
                }
            }
            return isValid;
        }
        public static void ClearTextBoxes(Form form)
        {
            foreach (Control control in form.Controls)
            {
                if (control.GetType() == typeof(TextBox))
                {
                    control.Text = "";
                }
            }
        }
        public static void ShowErrorMessage()
        {
            MessageBox.Show("Introduceți date în toate câmpurile!",
            "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Exclamation,
            MessageBoxDefaultButton.Button1); ;
        }
        public static DialogResult ShowConfirmationDialog()
        {
            DialogResult result = MessageBox.Show("Ești sigur că vrei să continui ștergerea ? ",
            "Șterge", MessageBoxButtons.YesNo);
            return result;
        }
        public static SqlConnection OpenDbConnection()
        {
            // informatii despre conexiune si interogare
            String connectionString = "Data Source=localhost;Initial Catalog = project_tv; Integrated Security = True";

            // initializari ale comexiunii, comenzii SQL si adaptoruluiSqlConnection con = new SqlConnection(connectionString);

            return con;
        }
        public static void WriteDataToDb(SqlConnection con, SqlCommand cmd)
        {
            con.Open();
            cmd.ExecuteReader();
            con.Close();
            cmd.Dispose();
            con.Dispose();
        }
        public static DataTable GetDataFromDb(SqlConnection con, SqlCommand cmd)
        {
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            // preluarea datelor
            con.Open();
            adapter.Fill(dt);
            con.Close();
            // curatarea memoriei alocate obiectelor care nu mai sunt folosite
            adapter.Dispose();

            cmd.Dispose();
            con.Dispose();
            return dt;
        }
        public static int ParseNumericValue(TextBox textbox)
        {
            int val;
            bool result = int.TryParse(textbox.Text, out val);
            if (!result)
                return -1;
            return val;
        }
        public static void AllowOnlyNumbers(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
       
