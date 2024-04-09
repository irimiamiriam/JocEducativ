using JocEducativ.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JocEducativ.SqlDataAccess
{
    public class DatabaseHelper
    {
        private static readonly string _connectionstring = DataAccess.GetConnectionString();
        private static readonly string _utilizatoripath = DataAccess.GetUtilizatoriPath();
        private static readonly string _rezultatepath = DataAccess.GetRezultatePath();
        private static readonly string _itemipath = DataAccess.GetItemiPath();
        private static readonly string _cuvintepath = DataAccess.GetCuvintePath();
        public static void Initialisation()
        {
            DeleteData();
            InsertUtilizatori();
            InsertRezultate();
            InsertItemi();
        }

        public static void InsertItemi()
        {
            using (SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string cmdText = "Insert into Itemi (EnuntItem, Raspuns1,Raspuns2,Raspuns3, RaspunsCorect, PunctajItem) values (@enunt,@r1, @r2,@r3,@rc,@punctaj)";
                using (StreamReader reader = new StreamReader(_itemipath))
                {
                    while (reader.Peek() >= 0)
                    {
                        string line = reader.ReadLine();
                        string[] split = line.Split(';');
                        using (SqlCommand cmd = new SqlCommand(cmdText, con))
                        {
                            cmd.Parameters.AddWithValue("@enunt", split[1]);
                            cmd.Parameters.AddWithValue("@r1", split[2]);
                            cmd.Parameters.AddWithValue("@r2", split[3]);
                            cmd.Parameters.AddWithValue("@r3", split[4]);
                            cmd.Parameters.AddWithValue("@rc", Convert.ToInt32(split[5]));
                            cmd.Parameters.AddWithValue("@punctaj", Convert.ToInt32(split[6].Trim()));
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        public static void InsertRezultate()
        {
            using (SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string cmdText = " Insert into Rezultate (TipJoc, EmailUtilizator,PunctajJoc) values (@tip,@email,@punctaj)";
                using (StreamReader reader = new StreamReader(_rezultatepath))
                {
                    while (reader.Peek() >= 0)
                    {
                        string line = reader.ReadLine();
                        string[] split = line.Split(';');
                        using (SqlCommand cmd = new SqlCommand(cmdText, con))
                        {
                            cmd.Parameters.AddWithValue("@tip", Convert.ToInt32(split[1]));
                            cmd.Parameters.AddWithValue("@email", split[2]);
                            cmd.Parameters.AddWithValue("@punctaj", Convert.ToInt32(split[3].Trim()));
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        public static void InsertUtilizatori()
        {
           using(SqlConnection con = new SqlConnection(_connectionstring)) 
            {
                con.Open();
                string cmdText = " Insert into Utilizatori values (@email,@nume,@parola)";
                using(StreamReader reader = new StreamReader(_utilizatoripath))
                {
                    while (reader.Peek() >= 0)
                    {
                        string line = reader.ReadLine();
                        string[] split = line.Split(';');
                        using(SqlCommand cmd= new SqlCommand(cmdText, con)) 
                        {
                            cmd.Parameters.AddWithValue("@email", split[0]);
                            cmd.Parameters.AddWithValue("@nume", split[1]);
                            cmd.Parameters.AddWithValue("@parola", split[2].Trim());
                            cmd.ExecuteNonQuery();
                        }
                    }
                }
            }
        }

        public static void DeleteData()
        {
            ExecuteCommand("Rezultate");
            ExecuteCommand("Itemi");
            ExecuteCommand("Utilizatori");
        }
        public static void ExecuteCommand(string Table)
        {
            string deleteText = "Delete from " + Table;
            string reseedText = " DBCC CHECKIDENT ( " + Table + " , RESEED,0)";
            using (SqlConnection con = new SqlConnection(_connectionstring))
            { con.Open();
                using (SqlCommand cmdDelete = new SqlCommand(deleteText, con)) 
                {
                    cmdDelete.ExecuteNonQuery();
                }
                if (Table != "Utilizatori")
                {
                    using (SqlCommand cmdReseed = new SqlCommand(reseedText, con))
                    {
                        cmdReseed.ExecuteNonQuery();
                    }
                }
            }
        }

        public static UtilizatorModel GetUtilizator(string email, string pass)
        {
           UtilizatorModel utilizator = new UtilizatorModel();
            using(SqlConnection con = new SqlConnection(_connectionstring)) 
            {
                con.Open();
                string cmdText = "Select * from Utilizatori where EmailUtilizator= @email and Parola = @parola";
                using(SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@parola", pass);
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        reader.Read();
                        if (reader.HasRows)
                        {
                            utilizator.Email = email;
                            utilizator.Password = pass;
                            utilizator.Name = reader[1].ToString();
                        }
                    }
                }
            }
            return utilizator;
        }

        public static List<PunctajUtilizator> GetScoruriGhiceste()
        {
           List<PunctajUtilizator> scoruri = new List<PunctajUtilizator>();
            using (SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string cmdText = "Select u.EmailUtilizator, u.NumeUtilizator, r.PunctajJoc from Utilizatori u, Rezultate r where u.EmailUtilizator= r.EmailUtilizator and r.TipJoc = @tip";
                using(SqlCommand cmd= new SqlCommand(cmdText, con))
                {
                    cmd.Parameters.AddWithValue("@tip", 0);
                    using(SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            PunctajUtilizator utilizator= new PunctajUtilizator();
                            {
                                utilizator.Name = reader[1].ToString();
                                utilizator.Email= reader[0].ToString();
                                utilizator.Punctaj = Convert.ToInt32(reader[2]);
                            }
                            scoruri.Add(utilizator);
                        }
                    }
                }
            }
            
            return scoruri;
        }
        public static List<PunctajUtilizator> GetScoruriSarpe()
        {
            List<PunctajUtilizator> scoruri = new List<PunctajUtilizator>();
            using (SqlConnection con = new SqlConnection(_connectionstring))
            {
                con.Open();
                string cmdText = "Select u.EmailUtilizator, u.NumeUtilizator, r.PunctajJoc from Utilizatori u, Rezultate r where u.EmailUtilizator= r.EmailUtilizator and r.TipJoc = @tip";
                using (SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    cmd.Parameters.AddWithValue("@tip", 1);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            PunctajUtilizator utilizator = new PunctajUtilizator();
                            {
                                utilizator.Name = reader[1].ToString();
                                utilizator.Email = reader[0].ToString();
                                utilizator.Punctaj = Convert.ToInt32(reader[2]);
                            }
                            scoruri.Add(utilizator);
                        }
                    }
                }
            }

            return scoruri;
        }

        public static List<string> GetCuvinte()
        {
            List<string> cuvinte = new List<string>();
            using(StreamReader reader= new StreamReader(_cuvintepath))
            {
                while (reader.Peek() >= 0)
                {
                    cuvinte.Add(reader.ReadLine().Trim());
                }
            }
            
            return cuvinte;
        }

        public static void RezultatUser(UtilizatorModel utilizator, int punctaj, int tip)
        {
            using(SqlConnection con = new SqlConnection(_connectionstring)) 
            {
                con.Open();
                string cmdText = "Insert into Rezultate (TipJoc, EmailUtilizator, PunctajJoc) values (@tip, @email, @punctaj)";
                using(SqlCommand cmd = new SqlCommand(cmdText, con))
                {
                    cmd.Parameters.AddWithValue("@tip", tip);
                    cmd.Parameters.AddWithValue("@email", utilizator.Email);
                    cmd.Parameters.AddWithValue("@punctaj", punctaj);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static ItemModel GetItem(int id)
        {
            ItemModel item = new ItemModel();
            using(SqlConnection conn = new SqlConnection(_connectionstring)) 
            {
                conn.Open();
                string cmdText = "Select * from Itemi where idItem = @id";
                using(SqlCommand cmd = new SqlCommand(cmdText, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using(SqlDataReader  reader = cmd.ExecuteReader()) 
                    {
                        reader.Read();
                        item.Enunt= reader[1].ToString();
                        item.Raspuns1 = reader[2].ToString();
                        item.Raspuns2= reader[3].ToString();
                        item.Raspuns3 = reader[4].ToString();
                        item.RaspunsCorect= Convert.ToInt32(reader[5]);
                        item.Punctaj = Convert.ToInt32(reader[6]);
                    }
                }
            }
            return item;
        }
    }
}
