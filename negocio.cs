using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;


namespace WindowsFormsApplication1.Clases
{
    class negocio
    {
        //String STRCONEXION = "";
        //public negocio()
        //{
        //    try
        //    {
        //        STRCONEXION = System.Configuration.ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
        //    }
        //    catch
        //    {
        //    }
        //}

        public DataTable consultar(string p_desc, string p_min, string p_max, string p_codigo, string p_var)
        {
            DataTable d_respuesta = new DataTable();

            try 
            {
                //using (SqlConnection __CONEXION = new SqlConnection(STRCONEXION))
                using (SqlConnection __CONEXION = new SqlConnection(Properties.Settings.Default.conectar))
                {
                    __CONEXION.Open();
                    SqlCommand _QUERY = new SqlCommand();
                    
                        _QUERY.CommandText = "sp_Consultar";
                        _QUERY.CommandType = CommandType.StoredProcedure;
                        _QUERY.Connection = __CONEXION;
                                    //Evalua min y max


                        if (p_desc.ToString() == "" || p_desc.ToString() == null)
                        {
                            _QUERY.Parameters.AddWithValue("@Descripcion", Convert.DBNull);
                        }
                        else
                        {
                            _QUERY.Parameters.AddWithValue("@Descripcion", p_desc);
                        }
                        
                        if (p_min.ToString() == "" || p_min.ToString() == null)
                        {
                            _QUERY.Parameters.AddWithValue("@CostoMinimo", Convert.DBNull);
                        }
                        else
                        {
                            _QUERY.Parameters.AddWithValue("@CostoMinimo", Convert.ToInt64(p_min));
                        }
                        //---------------------
                        if (p_max.ToString() == "" || p_max.ToString() == null)
                        {
                            _QUERY.Parameters.AddWithValue("@CostoMaximo", Convert.DBNull);
                        }
                        else
                        {
                            _QUERY.Parameters.AddWithValue("@CostoMaximo", Convert.ToInt64(p_max));
                        }
                        //-------------------------------------
                        if (p_codigo.ToString() == "" || p_codigo.ToString() == null)
                        {
                            _QUERY.Parameters.AddWithValue("@Codigo", Convert.DBNull);
                        }
                        else
                        {
                            _QUERY.Parameters.AddWithValue("@Codigo", p_codigo);
                        }

                        _QUERY.Parameters.AddWithValue("@var", p_var); 

                        SqlDataAdapter __DA_EJECUCION = new SqlDataAdapter(_QUERY);
                            __DA_EJECUCION.Fill(d_respuesta);
                    
                }

                return d_respuesta;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al ejecutar negocios.consultar: " + ex.Message);
                return null;
            }
        }
    }
}
