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

namespace consultaPais
{
    public partial class Form1 : Form
    {
        SqlConnection cn = new SqlConnection("server=.;database=Negocios2018;uid=sa;pwd=sql");
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            string pais = txtPais.Text;

            SqlCommand cmd = new SqlCommand("usp_addpais", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idpais", id);
            cmd.Parameters.AddWithValue("@nompais", pais);

            DataTable dt = new DataTable();

            cn.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                MessageBox.Show(i.ToString() + "Registrado");
                dgPais.DataSource = null;
                dgPais.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }
            dgPais.DataSource = paise();
        }
        public DataTable paise()
        {
            SqlDataAdapter da = new SqlDataAdapter("usp_pais", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;

            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgPais.DataSource = null;
            dgPais.DataSource = paise();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            string pais = txtPais.Text;

            SqlCommand cmd = new SqlCommand("usp_updatepais", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@idpais", id);
            cmd.Parameters.AddWithValue("@nompais", pais);

            DataTable dt = new DataTable();
            cn.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                MessageBox.Show(i.ToString() + "Actulizado");
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();

                
            }
            dgPais.DataSource = paise();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = int.Parse(txtID.Text);
            string pais = txtPais.Text;

            SqlCommand cmd = new SqlCommand("usp_delete", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", id);
            

            DataTable dt = new DataTable();
            cn.Open();
            try
            {
                int i = cmd.ExecuteNonQuery();
                MessageBox.Show(i.ToString() + "Eliminado");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();


            }
            dgPais.DataSource = paise();
        }
    }
}
