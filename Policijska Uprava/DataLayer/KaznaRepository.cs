using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
   
    public class KaznaRepository
    {
        private static string myconnection = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PolicijskaUprava;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static private SqlConnection conn = new SqlConnection(myconnection);


        // Uzimanje kazni iz baze i smestanje u listu

        public List<Kazna> Selektovanje()
        {
            List<Kazna> listToReturn = new List<Kazna>();
            try
            {
                
                string sql = "SELECT * FROM Kazne ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Kazna k = new Kazna();
                    k.Id = sqlDataReader.GetInt32(0);
                    k.TipKazne = sqlDataReader.GetString(1);
                    k.Iznos = sqlDataReader.GetInt32(2);
                    k.Zatvor = sqlDataReader.GetInt32(3);
                    k.Poeni = sqlDataReader.GetInt32(4);
                    listToReturn.Add(k);
                }

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
          

            return listToReturn;


            
        }

        // Unos kazni u bazu

        public bool UnosKazni(Kazna k)
        {

            bool isSucces = false;



            try
            {
                
                string sql = "INSERT INTO Kazne (TipKazne,Iznos,Zatvor,Poeni) VALUES(@TipKazne,@Iznos,@Zatvor,@Poeni)";
                
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@TipKazne", k.TipKazne);
                cmd.Parameters.AddWithValue("@Iznos", k.Iznos);
                cmd.Parameters.AddWithValue("@Zatvor", k.Zatvor);
                cmd.Parameters.AddWithValue("@Poeni", k.Poeni);


                conn.Open();
                int rows = cmd.ExecuteNonQuery();
                
                if (rows > 0)
                {
                    isSucces = true;
                }
                else
                {
                    isSucces = false;
                }

            }

            catch (Exception ex)
            {
            }

            finally
            {
                conn.Close();
            }
            return isSucces;
        }

        // Updejtovanje podataka o kazni u bazi

        public bool UpdejtovanjeKazne( Kazna k)
        {
            bool isSucces = false;

            try
            {

                string sql = "UPDATE Kazne SET TipKazne=@TipKazne,Iznos=@Iznos,Zatvor=@Zatvor,Poeni=@Poeni WHERE Id=@Id";
       
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Id", k.Id);
                cmd.Parameters.AddWithValue("@TipKazne", k.TipKazne);
                cmd.Parameters.AddWithValue("@Iznos", k.Iznos);
                cmd.Parameters.AddWithValue("@Zatvor", k.Zatvor);
                cmd.Parameters.AddWithValue("@Poeni", k.Poeni);

                conn.Open();
                int rows = cmd.ExecuteNonQuery();
              
                if (rows > 0)
                {
                    isSucces = true;
                }
                else
                {
                    isSucces = false;
                }

            }

            catch (Exception ex)
            {
               
            }

            finally
            {
                conn.Close();
            }
            return isSucces;
        }

        // Brisanje kazni

        public bool BrisanjeKazne(int id)
        {
            bool isSucces = false;


            try
            {
                
                string sql = "DELETE FROM Kazne WHERE Id=@Id";
                
                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@Id", id);
                
                conn.Open();
                int rows = cmd.ExecuteNonQuery();
               
                if (rows > 0)
                {
                    isSucces = true;
                }
                else
                {
                    isSucces = false;
                }

            }

            catch (Exception ex)
            {
            }

            finally
            {
                conn.Close();
            }
            return isSucces;
        }
        }
    }
