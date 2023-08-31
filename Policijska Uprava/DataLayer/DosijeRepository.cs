using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer
{
    public class DosijeRepository
    {
        private static string myconnection = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PolicijskaUprava;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static private SqlConnection conn = new SqlConnection(myconnection);

        // Uzimanje dosijea iz baze i smestanje u listu

        public List<Dosije> Selektovanje()
        {
            List<Dosije> listToReturn = new List<Dosije>();
            try
            {

                string sql = "SELECT * FROM Dosije ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Dosije d = new Dosije();
                    d.Id = sqlDataReader.GetInt32(0);
                    d.IdOsobe = sqlDataReader.GetInt32(1);
                    d.IdKazne = sqlDataReader.GetInt32(2);
                    d.BrojZnacke = sqlDataReader.GetInt32(3);
                    d.Datum = sqlDataReader.GetString(4);
                    listToReturn.Add(d);
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


        // Unos dosijea u bazu

        public bool UnosDosijea(Dosije d)
        {

            bool isSucces = false;



            try
            {

                string sql = "INSERT INTO Dosije (IdOsobe,IdKazne,BrojZnacke,Datum) VALUES(@IdOsobe,@IdKazne,@BrojZnacke,@Datum)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@IdOsobe", d.IdOsobe);
                cmd.Parameters.AddWithValue("@IdKazne", d.IdKazne);
                cmd.Parameters.AddWithValue("@BrojZnacke", d.BrojZnacke);
                cmd.Parameters.AddWithValue("@Datum", d.Datum);


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
