using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Proiect
{
    public partial class FormInLucru : Form
    {
        public FormInLucru()
        {
            InitializeComponent();
        }
        DataTable dt = new DataTable();
        public void LoadData()
        {
            // informatii despre conexiune si interogare
            String connectionString = "Data Source=localhost;Initial Catalog = project_tv; Integrated Security = True";
            String query = "SELECT autostrazi.* FROM autostrazi";
            // initializari ale comexiunii, comenzii SQL si adaptorului
            SqlConnection con = new SqlConnection(connectionString);
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            // preluarea datelor
            con.Open();
            adapter.Fill(dt);
            con.Close();
            // curatarea memoriei alocate obiectelor care nu mai sunt folosite
            adapter.Dispose();
            cmd.Dispose();
            con.Dispose();
        }

        public class MyInLucru
        {
            public int id;
            public string name;
            public override string ToString()
            {
                return name;
            }
        }

        public void ShowInLucru()
        {
            int i;
            for (i = 0; i < dt.Rows.Count; i++)
            {
                MyInLucru autostrada = new MyInLucru();
                autostrada.id = Convert.ToInt32(dt.Rows[i]["autostrada_id"]);
                autostrada.name = Convert.ToString(dt.Rows[i]["autostrada_nume"]);
                listBox1.Items.Add(autostrada);
            }
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string info = "";
            int i;
            if (dt.Rows.Count > 0 && index >= 0)
            {
                for (i = 0; i < dt.Columns.Count; i++)
                {
                    info += dt.Columns[i].ColumnName + ": " +
                    dt.Rows[index][dt.Columns[i].ColumnName] + "\r\n";
                }
            }
            textBox2.Text = info;
        }

        private void FormInLucru_Load(object sender, EventArgs e)
        {
            LoadData();
            ShowInLucru();
        }

        public void ClearAll()
        {
            dt = new DataTable();
            listBox1.Items.Clear();
            textBox2.Text = "";
        }
        public void RefreshData()
        {
            ClearAll();
            LoadData();
            ShowInLucru();
        }

    }
}
