using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Examen_Web.Models
{
    public class RecetasRepository
    {

        private MySqlConnection Connect()
        {
            string conString = "Server=34.220.190.143;Port=3306;Database=cocina;Uid=examen;Password=examen";
            MySqlConnection con = new MySqlConnection(conString);
            return con;
        }
        internal List<Recetas> Retrieve()
        {
            MySqlConnection con = Connect();
            MySqlCommand command = con.CreateCommand();
            command.CommandText = "select * from recetas";

            try
            {
                con.Open();
                MySqlDataReader res = command.ExecuteReader();
                Recetas eq = null;
                List<Recetas> Recetas = new List<Recetas>();
                while (res.Read())
                {
                    Debug.WriteLine("Recuperado: " + res.GetInt32(0) + " " + res.GetString(1));
                    eq = new Recetas(res.GetInt32(0), res.GetString(1),res.GetString(2),res.GetInt32(3));
                    Recetas.Add(eq);
                }
                con.Close();
                return Recetas;
            }
            catch (MySqlException e)
            {
                return null;
            }
        }

    }
}