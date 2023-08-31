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
    public class PolicajacRepository
    {
        private static string myconnection = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PolicijskaUprava;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        static private SqlConnection conn = new SqlConnection(myconnection);

        public List<Policajac> SelektovanjeLista()
        {
            List<Policajac> listToReturn = new List<Policajac>();
            try
            {

                string sql = "SELECT * FROM Policajci ";
                SqlCommand cmd = new SqlCommand(sql, conn);
                conn.Open();
                SqlDataReader sqlDataReader = cmd.ExecuteReader();

                while (sqlDataReader.Read())
                {
                    Policajac p = new Policajac();
                    p.BrojZnacke = sqlDataReader.GetInt32(0);
                    p.Ime = sqlDataReader.GetString(1);
                    p.Prezime = sqlDataReader.GetString(2);
                    p.Jmbg = sqlDataReader.GetString(3);
                    p.Pol = sqlDataReader.GetString(4);
                    p.DatumRodjenja = sqlDataReader.GetString(5);
                    listToReturn.Add(p);
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
                string sql = "SELECT * FROM Policajci ";
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
        public bool UnosPolicajaca(Policajac p)
        {

            bool isSucces = false;



            try
            {

                string sql = "INSERT INTO Policajci (BrojZnacke,Ime,Prezime,JMBG,Pol,DatumRodjenja) VALUES(@BrojZnacke,@Ime,@Prezime,@JMBG,@Pol,@DatumRodjenja)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@BrojZnacke", p.BrojZnacke);
                cmd.Parameters.AddWithValue("@Ime", p.Ime);
                cmd.Parameters.AddWithValue("@Prezime", p.Prezime);
                cmd.Parameters.AddWithValue("@JMBG", p.Jmbg);
                cmd.Parameters.AddWithValue("@Pol", p.Pol);
                cmd.Parameters.AddWithValue("@DatumRodjenja", p.DatumRodjenja);



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
        public bool BrisanjePolicajaca(string jmbg)
        {
            bool isSucces = false;


            try
            {

                string sql = "DELETE FROM Policajci WHERE JMBG=@JMBG ";


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
