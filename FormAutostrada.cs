using System.Data;
using System.Data.SqlClient;

namespace Autostrazi
{
    public partial class FormAutostrada : Form
    {
        public FormAutostrada()
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

        public class MyAutostrada
        { 
            public int id;
        public string name;
        public override string ToString()
        {
            return name;
        }
    }

        public void ShowAutostrada()
        {
            int i;
            for (i = 0; i < dt.Rows.Count; i++)
            {
                MyAutostrada autostrada = new MyAutostrada();
                autostrada.id = Convert.ToInt32(dt.Rows[i]["autostrada_id"]);
                autostrada.name = Convert.ToString(dt.Rows[i]["autostrada_nume"]);
                listBox1.Items.Add(autostrada);
            }
        }


            private void listBox1_SelectedChanged(object sender, EventArgs e)
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
            textBox1.Text = info;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadData();
            ShowAutostrada();
        }

        public void ClearAll()
        {
            dt = new DataTable();
            listBox1.Items.Clear();
            textBox1.Text = "";
        }
        public void RefreshData()
        {
            ClearAll();
            LoadData();
            ShowAutostrada();
        }

        private void cmdAdd_Click_Click(object sender, EventArgs e)
        {
            FormAddAutostrada form2 = new FormAddAutostrada();
            form2.ShowDialog();
            if (form2.isUpdated) RefreshData();
        }

        private void cmdRemove_Click_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            if (i < 0) return;
            else
            {
                String autostradaId = dt.Rows[i][dt.Columns[0].ColumnName].ToString();

                String connectionString = "Data Source=localhost;Initial Catalog = project_tv; Integrated Security = True";
                String query = "DELETE FROM autostrada WHERE autostrada_id=@autostradaId";

                SqlConnection con = new SqlConnection(connectionString);
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@autostradaId", autostradaId);


                con.Open();
                cmd.ExecuteReader();
                con.Close();
                // curatarea memoriei alocate obiectelor care nu mai sunt folosite
                cmd.Dispose();
                con.Dispose();
                RefreshData();
            }
        }
    }
}