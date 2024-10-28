﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.Mvc;

namespace SitioWebdeAM240104.Models
{
    public class Conexion
    {
        private String cadenaConexion;
        private SqlConnection conexionSQL;

        public Conexion() // Método constructor
        {
            // Extrae las credenciales del webconfig
            cadenaConexion = @"Data source = (local);Initial Catalog=Bolsa_Trabajo;Integrated Security=True";
        }

        // Función para realizar conexión a base de datos SQL Server
        public bool conectar()
        {
            try
            {
                // Crea objeto SQLConnection y enviar como parámetros las credenciales de conexión
                this.conexionSQL = new SqlConnection(this.cadenaConexion);
                // Abre la conexión a la base de datos SQL Server
                this.conexionSQL.Open();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        // Método que verifica si el estado de la conexión es abierta o cerrada en la aplicación.
        public bool estadoConexion()
        {
            switch (this.conexionSQL.State)
            {
                case ConnectionState.Broken:
                case ConnectionState.Open:
                    return true;
                default:
                    return false;
            }
        }

        public void desconectar()
        {
            this.conexionSQL.Close(); // Cierra la conexión a la base de datos
        }

        // Datos para dropdown Categorías
        public List<SelectListItem> getCategorias()
        {
            conectar();
            List<SelectListItem> items = new List<SelectListItem>();
            // Crea objetos para ejecutar los comandos SQL
            SqlCommand comando = new SqlCommand();
            // Crea objeto para leer datos de una consulta SQL
            SqlDataReader lector;
            // Consulta a la tabla categorias
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM categorias ORDER BY sNombreCategoria";
            // Agrega los parámetros para conexión al objeto comando
            comando.Connection = this.conexionSQL;

            try
            {
                // Ejecuta la instrucción select
                lector = comando.ExecuteReader();
                // Verifica si se encuentran resultados
                if (lector.HasRows)
                {
                    // Verifica que se pueden leer registros
                    while (lector.Read())
                    {
                        // Agrega datos de datareader al Dropdownlist.
                        items.Add(new SelectListItem
                        {
                            Text = lector["sNombreCategoria"].ToString(),
                            Value = lector["nIdCategoria"].ToString()
                        });
                    }
                    lector.Close();
                }
                desconectar();
                return items;
            }
            catch (SqlException error)
            {
                return null;
            }
        }

        // Datos para dropdown Localidades
        public List<SelectListItem> getLocalidades()
        {
            try
            {
                conectar();
                List<SelectListItem> items = new List<SelectListItem>();
                // Crea objetos para comandos SQL
                SqlCommand comando = new SqlCommand();
                SqlDataReader lector; // Crea objeto para leer datos de consulta SQL
                // Consulta a la tabla de municipios
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM municipios ORDER BY sNombreMunicipio";
                comando.Connection = this.conexionSQL; // Agrega los parámetros para conexión al objeto comando

                // Ejecuta la instrucción Select
                lector = comando.ExecuteReader();
                // Verifica si se encuentran resultados
                if (lector.HasRows)
                {
                    // Verifica que se pueden leer registros
                    while (lector.Read())
                    {
                        // Agrega datos de datareader al Dropdownlist
                        items.Add(new SelectListItem
                        {
                            Text = lector["sNombreMunicipio"].ToString(),
                            Value = lector["nIdMunicipio"].ToString()
                        });
                    }
                    lector.Close();
                }
                desconectar();
                return items;
            }
            catch (SqlException error)
            {
                return null;
            }
        }

        // Datos para dropdown Empresas
        public List<SelectListItem> getEmpresas()
        {
            try
            {
                conectar();
                List<SelectListItem> items = new List<SelectListItem>();
                // Crea objetos para comandos SQL
                SqlCommand comando = new SqlCommand();
                // Crea objeto para leer datos de consulta SQL
                SqlDataReader lector;
                // Consulta a la tabla empresa
                comando.CommandType = CommandType.Text;
                comando.CommandText = "SELECT * FROM empresas ORDER BY sNombreEmpresa";
                // Agrega los parámetros para conexión al objeto comando
                comando.Connection = this.conexionSQL;

                // Ejecuta la instrucción Select
                lector = comando.ExecuteReader();
                if (lector.HasRows) // VERIFICA SI SE ENCUENTRAN RESULTADOS
                {
                    // Verifica que se pueden leer registros
                    while (lector.Read())
                    {
                        // Agrega datos de datareader al dropdownlist
                        items.Add(new SelectListItem
                        {
                            Text = lector["sNombreEmpresa"].ToString(),
                            Value = lector["nIdEmpresa"].ToString()
                        });
                    }
                    lector.Close();
                }
                desconectar();
                return items;
            }
            catch (SqlException error)
            {
                return null;
            }
        }

        public List<Datos> CargarDatos(int categoria = 1, int municipio = 1, int empresa = 1)
        {
            string SQL;
            // Crea un DataTable para almacenar todos los registros de la consulta SQL.
            DataTable t = new DataTable();
            // Realiza consulta a varias tablas de base de datos Bolsa de Trabajo.
            SQL = "SELECT categorias.sNombreCategoria, ofertas.nIdOferta, ofertas.sTituloOferta, " +
                  "nTipoContrato = CASE ofertas.nTipoContrato WHEN 1 THEN 'Permanente' WHEN 2 THEN 'Por proyecto' END, " +
                  "NTipoJornada = CASE ofertas.nTipoJornada WHEN 1 THEN 'Tiempo Completo' WHEN 2 THEN 'Por horas' END, " +
                  "ofertas.fSalario, ofertas.dFechaPublicacion, empresas.sNombreEmpresa, municipios.sNombreMunicipio " +
                  "FROM municipios " +
                  "INNER JOIN ofertas ON municipios.nIdMunicipio = ofertas.nIdLocalidad " +
                  "INNER JOIN empresas ON ofertas.nIdEmpresa = empresas.nIdEmpresa " +
                  "INNER JOIN categorias ON ofertas.nIdCategoria = categorias.nIdCategoria " +
                  "WHERE categorias.nIdCategoria = @nIdCategoria AND municipios.nIdMunicipio = @nIdMunicipio AND empresas.nIdEmpresa = @nIdEmpresa";

            SqlCommand comando = new SqlCommand(SQL, conexionSQL);
            // Asigna los valores a los parámetros utilizados en la consulta.
            comando.Parameters.Clear();
            comando.Parameters.AddWithValue("@nIdCategoria", categoria);
            comando.Parameters.AddWithValue("@nIdMunicipio", municipio);
            comando.Parameters.AddWithValue("@nIdEmpresa", empresa);
            // Se almacena los datos de la tabla Ofertas en el DataTable
            SqlDataAdapter dataAdaptador = new SqlDataAdapter(comando);
            dataAdaptador.Fill(t);
            // Se modifican los nombres de la columna del DataTable
            List<Datos> items = new List<Datos>();
            foreach (DataRow fila in t.Rows)
            {
                items.Add(new Datos
                {
                    sNombreCategoria = Convert.ToString(fila["sNombreCategoria"]),
                    nIdOferta = Convert.ToString(fila["nIdOferta"]),
                    sTituloOferta = Convert.ToString(fila["sTituloOferta"]),
                    nTipoJornada = Convert.ToString(fila["nTipoJornada"]),
                    fSalario = Convert.ToString(fila["fSalario"]),
                    dFechaPublicacion = Convert.ToString(fila["dFechaPublicacion"]),
                    sNombreEmpresa = Convert.ToString(fila["sNombreEmpresa"]),
                    sNombreMunicipio = Convert.ToString(fila["sNombreMunicipio"])
                });
            }
            return items;
        }

        // Método que muestra datos de una oferta en controles de Editar Oferta
        public Datos mostraroferta(int idOferta)
        {
            conectar();
            // Objetos comando
            SqlCommand comando = new SqlCommand(); // Tabla oferta
            SqlDataReader lector;
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM ofertas WHERE nIdOferta=" + idOferta;
            comando.Connection = this.conexionSQL;

            try
            {
                // Extrae datos de la tabla ofertas a controles ASP y variables string
                lector = comando.ExecuteReader();
                Datos items = new Datos();
                if (lector.HasRows)
                {
                    while (lector.Read())
                    {
                        items.nIdCategoria = Convert.ToString(lector["nIdCategoria"]);
                        items.nIdOferta = Convert.ToString(lector["nIdOferta"]);
                        items.sTituloOferta = Convert.ToString(lector["sTituloOferta"]);
                        items.nTipoJornada = Convert.ToString(lector["nTipoJornada"]);
                        items.fSalario = Convert.ToString(lector["fSalario"]);
                        items.nIdLocalidad = Convert.ToString(lector["nIdLocalidad"]);
                        items.nTipoContrato = Convert.ToString(lector["nTipoContrato"]);
                        items.dFechaPublicacion = Convert.ToString(lector["dFechaPublicacion"]);
                        items.dFechaContratacion = Convert.ToString(lector["FechaContratacion"]);
                        items.nIdEmpresa = Convert.ToString(lector["nIdEmpresa"]);
                        items.nTipolocalidad = Convert.ToString(lector["nTipoLocalidad"]);
                        items.sDescripcion = Convert.ToString(lector["sDescripcion"]);
                        items.nVacantes = Convert.ToString(lector["nVacantes"]);
                    }
                }
                lector.Close();
                desconectar();
                return items;
            }
            catch (SqlException error)
            {
                return null;
            }
        }

        // Método que inserta nueva oferta a base de datos
        public int nuevaOferta(int nIdEmpresa, String sTituloOferta, int nTipoJornada, int nTipoContrato,
                               double fSalario, int nIdLocalidad, int nTipoLocalidad, int nIdCategoria,
                               String dFechaPublicacion, String sDescripcion, String fechaContratacion, int nVacantes)
        {
            // Consulta Insert SQL a tabla ofertas
            String queryInsert = "INSERT INTO ofertas(nIdEmpresa, sTituloOferta, nTipoJornada, nTipoContrato, " +
                                 "fSalario, nIdLocalidad, nTipoLocalidad, nIdCategoria, dFechaPublicacion, " +
                                 "sDescripcion, fechaContratacion, nVacantes) " +
                                 "VALUES(@p1, @p2, @p3, @p4, @p5, @p6, @p7, @p8, @p9, @p10, @p11, @p12)";

            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = queryInsert;
            comando.Connection = this.conexionSQL;

            try
            {
                // Asigna los valores a los parámetros utilizados en la consulta.
                comando.Parameters.AddWithValue("@p1", nIdEmpresa);
                comando.Parameters.AddWithValue("@p2", sTituloOferta);
                comando.Parameters.AddWithValue("@p3", nTipoJornada);
                comando.Parameters.AddWithValue("@p4", nTipoContrato);
                comando.Parameters.AddWithValue("@p5", fSalario);
                comando.Parameters.AddWithValue("@p6", nIdLocalidad);
                comando.Parameters.AddWithValue("@p7", nTipoLocalidad);
                comando.Parameters.AddWithValue("@p8", nIdCategoria);
                comando.Parameters.AddWithValue("@p9", Convert.ToDateTime(dFechaPublicacion));
                comando.Parameters.AddWithValue("@p10", sDescripcion);
                comando.Parameters.AddWithValue("@p11", Convert.ToDateTime(fechaContratacion));
                comando.Parameters.AddWithValue("@p12", nVacantes);

                // Ejecuta la consulta SQL en la base de datos de la aplicación.
                return comando.ExecuteNonQuery();
            }
            catch (SqlException error)
            {
                return 0;
            }
        }

        public int actualizarOferta(int idOferta, int nIdEmpresa, String sTituloOferta, int nTipoJornada,
                                    int nTipoContrato, double fSalario, int nIdLocalidad, int nTipoLocalidad,
                                    int nIdCategoria, String sDescripcion, String fechaContratacion,
                                    int nVacantes)
        {
            // Consulta Update SQL a tabla ofertas
            String queryUpdate = "UPDATE ofertas SET nIdEmpresa = @p1, sTituloOferta = @p2, nTipoJornada = @p3, " +
                                 "nTipoContrato = @p4, fSalario = @p5, nIdLocalidad = @p6, nTipoLocalidad = @p7, " +
                                 "nIdCategoria = @p8, sDescripcion = @p9, fechaContratacion = @p10, nVacantes = @p11 " +
                                 "WHERE nIdOferta = " + idOferta;

            SqlCommand comando = new SqlCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = queryUpdate;
            comando.Connection = this.conexionSQL;

            try
            {
                // Asigna los valores a los parámetros utilizados en la consulta.
                comando.Parameters.AddWithValue("@p1", nIdEmpresa);
                comando.Parameters.AddWithValue("@p2", sTituloOferta);
                comando.Parameters.AddWithValue("@p3", nTipoJornada);
                comando.Parameters.AddWithValue("@p4", nTipoContrato);
                comando.Parameters.AddWithValue("@p5", fSalario);
                comando.Parameters.AddWithValue("@p6", nIdLocalidad);
                comando.Parameters.AddWithValue("@p7", nTipoLocalidad);
                comando.Parameters.AddWithValue("@p8", nIdCategoria);
                comando.Parameters.AddWithValue("@p9", sDescripcion);
                comando.Parameters.AddWithValue("@p10", Convert.ToDateTime(fechaContratacion));
                comando.Parameters.AddWithValue("@p11", nVacantes);

                // Realiza la actualización a la tabla ofertas desde la aplicación.
                return comando.ExecuteNonQuery();
            }
            catch (SqlException error)
            {
                return 0;
            }
        }

        public int EliminarDatos(int idOferta)
        {
            try
            {
                // Consulta SQL para eliminar registro de tabla Ofertas
                String queryDelete = "DELETE FROM ofertas WHERE nIdOferta = @nIdOferta";
                SqlCommand comando = new SqlCommand();
                comando.Parameters.Clear();
                // Asigna los valores a los parámetros utilizados en la consulta.
                comando.Parameters.AddWithValue("@nIdOferta", idOferta);
                comando.CommandType = CommandType.Text;
                comando.CommandText = queryDelete;
                comando.Connection = this.conexionSQL;

                // Eliminar registro de la tabla oferta desde la aplicación.
                return comando.ExecuteNonQuery();
            }
            catch (SqlException error)
            {
                return 0;
            }
        }
    }
}
