using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace AccesDades_BC
{
    /// <summary>
    /// Data Access
    /// </summary>
    public class DataAccess
    {
        private string connectionString;
        DataSet taula;
        SqlDataAdapter da;

        private SqlConnection conectarBD = new SqlConnection();

        /// <summary>
        /// Creem la ConnectionString
        /// </summary>
        public DataAccess()
        {
            connectionString = ConfigurationManager.ConnectionStrings["SecureCore"].ConnectionString;
            //connectionString = "Server=thegungansalesians.database.windows.net; Database=SecureCoreDB; User Id=gungan; Password=12345aA12345aA";
        }

        /// <summary>
        /// CONNECTAR --> Funció que connecta amb la Base de Dades
        /// </summary>
        private void Connectar()
        {
            try
            { 
                conectarBD.ConnectionString = connectionString;

                conectarBD.Open();
                Console.WriteLine("Connexio Oberta");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al connectar-se amb la Base de Dades: " + ex.Message);
            }
        }

        private void TancarBD()
        {
            conectarBD.Close();
        }
        
        /// <summary>
        /// PORTAR TAULA --> Funció que retorna un DataSet amb tots els registre de la taula que rep
        /// </summary>
        /// <param name="nomTaula">Taula que rep i de la que fa la Select</param>
        /// <returns>Retorna un DataSet</returns>
        public DataSet PortarTaula (string nomTaula)
        {
            try
            {
                da = new SqlDataAdapter();
                taula = new DataSet();

                Connectar();

                string query = "SELECT * FROM " + nomTaula;

                da = new SqlDataAdapter(query, conectarBD);
                da.Fill(taula);

                TancarBD();
            }
            catch
            {
                MessageBox.Show("Error al connectar-se amb la Base de Dades, si us plau, reiniciï el programa.");
            }
            return taula;
        }

        /// <summary>
        /// PORTAR PER CONSULTA --> Funció que rep una query i retorna un DataSet
        /// </summary>
        /// <param name="query">Query que rep per perametre</param>
        /// <returns>Retorna un DataSet</returns>
        public DataSet PortarPerConsulta(string query)
        {
            try
            {
                da = new SqlDataAdapter();
                taula = new DataSet();

                Connectar();

                da = new SqlDataAdapter(query, conectarBD);
                da.Fill(taula);

                TancarBD();
            }
            catch
            {
                MessageBox.Show("Error al connectar-se amb la Base de Dades, si us plau, reiniciï el programa.");
            }
            return taula;
        }

        /// <summary>
        /// PORTAR PER ID --> A través d'un ID, retornem un DataSet
        /// </summary>
        /// <param name="id">ID de la taula que rep per parametre</param>
        /// <param name="valor">Valor de la taula que rep per parametre. L'igualem amb el ID dins del WHERE</param>
        /// <param name="nomTaula">Nom de la taula que rep per parametre</param>
        /// <returns>Retorna un DataSet</returns>
        public DataSet PortarPerId(string id, string valor, string nomTaula)
        {
            da = new SqlDataAdapter();
            taula = new DataSet();

            try
            {
                Connectar();

                string query = "SELECT * FROM " + nomTaula + " WHERE '" + id + "' = '" + valor + "'";

                da = new SqlDataAdapter(query, conectarBD);
                da.Fill(taula);

                TancarBD();
            }
            catch
            {
                MessageBox.Show("Error al connectar-se amb la Base de Dades, si us plau, reiniciï el programa.");
            }
            return taula;
        }

        /// <summary>
        /// ACTUALITZAR --> Rep una consulta SQL d'un DataSet i el DataSet Original. 
        /// Ha d'actualitzar la Base de Dades amb les noves dades. 
        /// </summary>
        /// <param name="query">Consulta SQL que rep</param>
        /// <param name="dsOriginal">DataSet Original, el que després modifica i actualitza</param>
        /// <returns>Retorna el nou DataSet ja actualitzat</returns>
        public DataSet Actualitzar(string query, DataSet dsOriginal)
        {
            da = new SqlDataAdapter();
            da.SelectCommand = new SqlCommand(query, conectarBD);
            SqlCommandBuilder builder = new SqlCommandBuilder(da);

            try
            {
                Connectar();

                da.Fill(dsOriginal.Tables[0]);

                builder.GetUpdateCommand();

                da.Update(dsOriginal.Tables[0]);
            }
            catch(SqlException)
            {
                MessageBox.Show("No es pot actualitzar el camp modificat, ja que altres camps depenen d'aquest.");
            }
            return dsOriginal;
        }

        /// <summary>
        /// EXECUTA --> Modifica, inserta o elimina directament sobre la Base de Dades
        /// </summary>
        /// <param name="query">Consulta SQL que rep</param>
        public void Executa(string query)
        {
            SqlCommand sqlCommand = new SqlCommand(query);
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                MessageBox.Show("Error al connectar-se amb la Base de Dades, si us plau, reiniciï el programa.");
            }
        }
    }
}
