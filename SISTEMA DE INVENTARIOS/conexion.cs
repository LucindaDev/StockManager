using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using SISTEMA_DE_INVENTARIOS;


namespace SISTEMA_DE_INVENTARIOS
{
    class Conexion
    {
        public SqlConnection CrearConexion()
        {
            try
            {
                SqlConnection conexion = new SqlConnection("server=DESKTOP-CT1DDED; database=StockManager; integrated security=true;");
                conexion.Open();
                return conexion;
            }
            catch (Exception e)
            {
                MessageBox.Show("ERROR DE CONEXIÓN" + e.Message, "Error", MessageBoxButtons.OK);
                return null;
            }
        }
    }
}