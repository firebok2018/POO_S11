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
using System.Configuration;

namespace Mantenimientto_cliente
{
    public partial class Form1 : Form
    {

        //SqlConnection cn = new SqlConnection("server=.;database=Negocios2018;uid=sa;pwd=sql");
        SqlConnection cn = new SqlConnection(
              ConfigurationManager.ConnectionStrings["cnx"].ConnectionString);
        public Form1()
        {
            InitializeComponent();
           
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            cn.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("usp_addCliente", cn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("idcli",txtCodigo.Text);
                cmd.Parameters.AddWithValue("@nombre",txtNOmbre.Text);
                cmd.Parameters.AddWithValue("@direccion",txtDirrecion.Text);
                cmd.Parameters.AddWithValue("@pais", cboPais.SelectedValue.ToString());
                cmd.Parameters.AddWithValue("@fono", txttefono.Text);

                cmd.ExecuteNonQuery();
                MessageBox.Show("cliente agregado");

            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                cn.Close();
            }

            dglista.DataSource = null;
            dglista.DataSource = clientes();
        }

      /*  public ComboBox paises()
        {
            SqlDataAdapter da = new SqlDataAdapter("usp_paises", cn);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            
            
            return (ComboBox)cboPais;
        }*/

        private void Form1_Load(object sender, EventArgs e)
        {
            //cboPais.a() = paises();
            cboPais.DataSource = Paises();
            cboPais.DisplayMember = "nombrePais";
            cboPais.ValueMember = "idpais";

            dglista.DataSource = clientes();
        }
        private DataTable Paises()
        {
            SqlDataAdapter da = new SqlDataAdapter("usp_paises",cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
        private DataTable clientes()
        {
            SqlDataAdapter da = new SqlDataAdapter("usp_listClientes", cn);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
