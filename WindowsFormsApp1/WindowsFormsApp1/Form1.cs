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

namespace WindowsFormsApp1
{

   
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection("server=.;database=Negocios2018;uid=sa;pwd=sql");
        public Form1()
        {
            InitializeComponent();
        }

        private void btnconsultar_Click(object sender, EventArgs e)
        {
            string nombre = txtnom.Text;
            SqlDataAdapter da = new SqlDataAdapter("usp_clientes",cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            da.SelectCommand.Parameters.AddWithValue("@nom", nombre);

            DataTable dt = new DataTable();
            da.Fill(dt);

            dglista.DataSource = null;
            dglista.DataSource = dt;
        }
    }
}
