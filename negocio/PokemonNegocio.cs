using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Windows.Forms;
using dominio;

// 
namespace negocio
{
    public class PokemonNegocio
    {

        public List<Pokemon> Listar()
        {
            List<Pokemon> lista = new List<Pokemon>();
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("Select Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion as Tipo, D.Descripcion as Debilidad, P.IdTipo, P.IdDebilidad, P.Id from POKEMONS P, ELEMENTOS E, ELEMENTOS D where E.Id = P.IdTipo and D.Id = P.IdDebilidad And P.Activo = 1");
                datos.ejecutarLectura();

                while (datos.Lector.Read()) 
                {
                    Pokemon aux = new Pokemon();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Numero = (int)datos.Lector["Numero"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    if (!(datos.Lector["Descripcion"] is DBNull))
                        aux.Descripcion = (string)datos.Lector["Descripcion"];
                    //Para validar una columna NULL
                    //if(!(datos.Lector.IsDBNull(datos.Lector.GetOrdinal("UrlImagen"))))
                    //    aux.UrlImagen = (string)datos.Lector["UrlImagen"];
                    if (!(datos.Lector["UrlImagen"] is DBNull))
                        aux.UrlImagen = (string)datos.Lector["UrlImagen"];
                    
                    aux.Tipo.Descripcion = (string)datos.Lector["Tipo"];
                    aux.Tipo.Id = (int)datos.Lector["IdTipo"];
                    aux.Debilidad.Descripcion = (string)datos.Lector["Debilidad"];
                    aux.Debilidad.Id = (int)datos.Lector["IdDebilidad"];
                    
                    lista.Add(aux);
                }
            }
            catch (Exception ex) 
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

            return lista;

        //    SqlConnection conexion = new SqlConnection();
        //    SqlCommand comando = new SqlCommand();
        //    SqlDataReader lector;

        //    try
        //    {
        //        //Accedo a datos
        //        conexion.ConnectionString = "server=.\\SQLEXPRESS; database=POKEDEX_DB; integrated security=true;";
        //        //Seteo consulta
        //        comando.CommandType = System.Data.CommandType.Text;
        //        comando.CommandText = "Select Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion as Tipo, D.Descripcion as Debilidad from POKEMONS P, ELEMENTOS E, ELEMENTOS D where E.Id = P.IdTipo and D.Id = P.IdDebilidad";
        //        //Ejecuto la lectura
        //        comando.Connection = conexion;
        //        conexion.Open();
        //        lector = comando.ExecuteReader();

        //        while (lector.Read())
        //        {
        //            Pokemon aux = new Pokemon();
        //            //aux.Numero = lector.GetInt32(0);
        //            aux.Numero = (int)lector["Numero"];
        //            aux.Nombre = lector.GetString(1);
        //            aux.Descripcion = (string)lector["Descripcion"];//otra forma de leer un string de la DB
        //            aux.UrlImagen = (string)lector["UrlImagen"];
        //            aux.Tipo.Descripcion = (string)lector["Tipo"];
        //            aux.Debilidad.Descripcion = (string)lector["Debilidad"];

        //            lista.Add(aux);
        //        }

                
        //    }
        //    catch (Exception ex)
        //    {
        //        //MessageBox.Show(ex.ToString());
        //    }
        //    finally 
        //    {
        //        conexion.Close();
                
        //    }
            
        //    return lista;
        }

        public void agregar(Pokemon nuevo)
        {
            //Creo el objeto datos, para trabajar con la base de datos 
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setearConsulta("insert into POKEMONS(Numero, Nombre, Descripcion, UrlImagen, IdTipo, IdDebilidad, Activo) values (" + nuevo.Numero + ", '" + nuevo.Nombre + "', '" + nuevo.Descripcion + "','" + nuevo.UrlImagen + "',"+ nuevo.Tipo.Id + ", "+ nuevo.Debilidad.Id +", 1)");
                //Otra forma de hacerlo es modificar la consulta y crear un metodo en Accesos a datos
                //datos.setearConsulta("insert into POKEMONS(Numero, Nombre, Descripcion, UrlImagen, Activo, IdTipo, IdDebilidad) values (" + nuevo.Numero + ", '" + nuevo.Nombre + "', '" + nuevo.Descripcion + "','" + nuevo.UrlImagen + ", 1, @IdTipo, @IdDebilidad)");
                //datos.setearParametro("@IdTipo", nuevo.Tipo.Id);
                //datos.setearParametro("@IdDebilidad", nuevo.Debilidad.Id);


                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificar(Pokemon modificar) 
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update POKEMONS set Numero = @Numero, Nombre = @Nombre, Descripcion = @Descripcion, UrlImagen = @UrlImagen, IdTipo = @IdTipo, IdDebilidad = @IdDebilidad Where Id = @Id");

                datos.setearParametro("@Numero", modificar.Numero);
                datos.setearParametro("@Nombre", modificar.Nombre);
                datos.setearParametro("@Descripcion", modificar.Descripcion);
                datos.setearParametro("@UrlImagen", modificar.UrlImagen);
                datos.setearParametro("@IdTipo", modificar.Tipo.Id);
                datos.setearParametro("@IdDebilidad", modificar.Debilidad.Id);
                datos.setearParametro("@Id", modificar.Id);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally 
            {
                datos.cerrarConexion();
            }
        }


        public void eliminarFisico(int id) 
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("delete from pokemons where Id = " + id );
                //Otra forma de hacerlo es 
                //datos.setearConsulta("delete from pokemons where id = @id "); 
                //datos.setearParametro("@id", id);

                datos.ejecutarAccion();
            }
            catch (Exception ex) 
            { 
                throw ex; 
            }
            finally 
            { 
                datos.cerrarConexion(); 
            }
        }

        public void eliminarLogico(int id) 
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("update POKEMONS set Activo = 0 Where Id = @Id");
                datos.setearParametro("@Id", id);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<Pokemon> filtrar(string campo, string criterio, string filtro)
        {
            List<Pokemon> lista = new List<Pokemon>();
            AccesoDatos datos = new AccesoDatos();
            string consulta = "Select Numero, Nombre, P.Descripcion, UrlImagen, E.Descripcion as Tipo, D.Descripcion as Debilidad, P.IdTipo, P.IdDebilidad, P.Id from POKEMONS P, ELEMENTOS E, ELEMENTOS D where E.Id = P.IdTipo and D.Id = P.IdDebilidad And P.Activo = 1 And ";
            try
            {
                switch (campo)
                {
                    case "Número":
                        switch (criterio)
                        {
                            case "Igual a":
                                consulta += "Numero = " + filtro;
                                break;
                            case "Menor a":
                                consulta += "Numero < " + filtro;
                                break;
                            case "Mayor a":
                                consulta += "Numero > " + filtro;
                                break;
                            default:
                                break;
                        }
                        break;

                    case "Nombre":
                        switch (criterio)
                        {
                            case "Contiene":
                                consulta += "Nombre like '%" + filtro + "%'";
                                break;
                            case "Empieza con":
                                consulta += "Nombre like '" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += "Nombre like '%" + filtro + "'";
                                break;
                            default:
                                break;
                        }
                        break;

                    case "Descripción":
                        switch (criterio)
                        {
                            case "Contiene":
                                consulta += "P.Descripcion like '%" + filtro + "%'";
                                break;
                            case "Empieza con":
                                consulta += "P.Descripcion like '" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += "P.Descripcion like '%" + filtro + "'";
                                break;
                            default:
                                break;
                        }
                        break;

                    case "Tipo":
                        switch (criterio)
                        {
                            case "Contiene":
                                consulta += "E.Descripcion like '%" + filtro + "%'";
                                break;
                            case "Empieza con":
                                consulta += "E.Descripcion like '" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += "E.Descripcion like '%" + filtro + "'";
                                break;
                            default:
                                break;
                        }
                        break;

                    case "Debilidad":
                        switch (criterio)
                        {
                            case "Contiene":
                                consulta += "D.Descripcion like '%" + filtro + "%'";
                                break;
                            case "Empieza con":
                                consulta += "D.Descripcion like '" + filtro + "%'";
                                break;
                            case "Termina con":
                                consulta += "D.Descripcion like '%" + filtro + "'";
                                break;
                            default:
                                break;
                        }
                        break;

                    default:
                        break;
                }

                datos.setearConsulta( consulta );
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    Pokemon aux = new Pokemon();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Numero = (int)datos.Lector["Numero"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    if (!(datos.Lector["Descripcion"] is DBNull))
                        aux.Descripcion = (string)datos.Lector["Descripcion"];
                    if (!(datos.Lector["UrlImagen"] is DBNull))
                        aux.UrlImagen = (string)datos.Lector["UrlImagen"];

                    aux.Tipo.Descripcion = (string)datos.Lector["Tipo"];
                    aux.Tipo.Id = (int)datos.Lector["IdTipo"];
                    aux.Debilidad.Descripcion = (string)datos.Lector["Debilidad"];
                    aux.Debilidad.Id = (int)datos.Lector["IdDebilidad"];

                    lista.Add(aux);
                }

            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

            return lista;
        }
    }
}
