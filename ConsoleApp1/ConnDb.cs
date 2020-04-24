using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using Npgsql; 
using System.Linq;
using System.Data.SqlClient;

namespace ConsoleApp1 {
    
    class ConnDb {

    public static NpgsqlConnection conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=cavalo200;Database=aprendizado;");

        public void abrirPostgress() {

            if (conn.State != ConnectionState.Open) {

                Console.WriteLine("----------------Abre  Conexão Postgres: " +conn.State+ "---------------------");                 
                conn.Open();
                Console.WriteLine("----------------Abre  Conexão Postgres: " +conn.State+ "-----------------------");

            }
            
        }

        public void fecharPostgress() {

            if (conn.State == ConnectionState.Open) {

                Console.WriteLine("----------------Fecha Conexão Postgres: " + conn.State + "-----------------------");
                conn.Close();
                Console.WriteLine("----------------Fecha Conexão Postgres: " + conn.State + "---------------------");
            }


            
        }


/*
        private static void CreateCommand(string queryString, string connectionString) {
            
            using ( SqlConnection connection = new SqlConnection(connectionString) ) {

                SqlCommand command = new SqlCommand(queryString, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }
        }
*/

        /*

                public static void ExecutarComando(string textoComando) {

                    SqlCommand comando = new SqlCommand();
                    comando.CommandText = textoComando;
                    comando.Connection = conn;
                    int registrosAfetados = comando.ExecuteNonQuery();
                }
        */


    }
}
