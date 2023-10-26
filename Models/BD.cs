using System.Data.SqlClient;
using Dapper;
using System.Collections.Generic;

public static class BD{
    private static string _connectionString=@"Server=.;DataBase=BDSeries;Trusted_Connection=True;";
 
    public static List<Series> ListarSeries(){
        List<Series> ListaSeries = new List<Series>();
        using (SqlConnection db = new SqlConnection(_connectionString)){
            string sql = "SELECT * FROM Series";
            ListaSeries = db.Query<Series>(sql).ToList();
        }
        return ListaSeries;
    }

     public static List<actores> ObtenerActores(int idSerie)
        {
            List<actores> ListaActores = new List<actores>();
            using(SqlConnection db = new SqlConnection(_connectionString)){
                string sql = "SELECT * FROM Actores WHERE IdSerie = @pIdSerie";
                ListaActores = db.Query<actores>(sql, new {pIdSerie = idSerie}).ToList();
                return ListaActores;
            }
        }

        public static List<temporadas> ObtenerTemporadas(int idSerie)
        {   
            List<temporadas> ListaTemporadas = new List<temporadas>();
            using(SqlConnection db = new SqlConnection(_connectionString)){
                string sql = "SELECT * FROM Temporadas WHERE IdSerie = @pIdSerie";
                ListaTemporadas = db.Query<temporadas>(sql, new {pIdSerie = idSerie}).ToList();
                return ListaTemporadas;
            }
        }

        public static Series VerSerie(int idSerie){
            Series s = null;
            using(SqlConnection db = new SqlConnection(_connectionString)){
                string sql = "SELECT * FROM Series WHERE IdSerie = @pIdSerie";
                s = db.QueryFirstOrDefault<Series>(sql, new {pIdSerie = idSerie});
            }
            return s;
        }
    } 