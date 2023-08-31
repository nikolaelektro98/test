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
    public class OsobaRepository
    {
        private static string myconnection = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PolicijskaUprava;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static private SqlConnection conn = new SqlConnection(myconnection);

        public List<Osoba> SelektovanjeLista()
        {
            List<Osoba> listToReturn = new List<Osoba>();
            try
            {

                string sql = "SELECT * FROM Osobe ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Osoba o = new Osoba();
                    o.Id = sqlDataReader.GetInt32(0);
                    o.Ime = sqlDataReader.GetString(1);
                    o.Prezime = sqlDataReader.GetString(2);
                    o.Jmbg = sqlDataReader.GetString(3);
                    o.Pol = sqlDataReader.GetString(4);
                    o.DatumRodjenja = sqlDataReader.GetString(5);
                    o.Dozvola = sqlDataReader.GetInt32(6);
                    listToReturn.Add(o);
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
        public DataTable Selektovanje()
        {

            DataTable dt = new DataTable();

            try
            {
                string sql = "SELECT * FROM Osobe ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                conn.Open();
                adapter.Fill(dt);

            }
            catch (Exception ex)
            {

            }
            finally
            {
                conn.Close();
            }
            return dt;
        }
        public bool UnosOsoba(Osoba o)
        {

            bool isSucces = false;



            try
            {

                string sql = "INSERT INTO Osobe (Ime,Prezime,JMBG,Pol,DatumRodjenja,Dozvola) VALUES(@Ime,@Prezime,@JMBG,@Pol,@DatumRodjenja,@Dozvola)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@Ime", o.Ime);
                cmd.Parameters.AddWithValue("@Prezime", o.Prezime);
                cmd.Parameters.AddWithValue("@JMBG", o.Jmbg);
                cmd.Parameters.AddWithValue("@Pol", o.Pol);
                cmd.Parameters.AddWithValue("@DatumRodjenja", o.DatumRodjenja);
                cmd.Parameters.AddWithValue("@Dozvola", o.Dozvola);


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
        public bool BrisanjeOsoba(string jmbg)
        {
            bool isSucces = false;


            try
            {

                string sql = "DELETE FROM Osobe WHERE JMBG=@JMBG";


                SqlCommand cmd = new SqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@JMBG", jmbg);


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
