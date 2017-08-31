using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Oracle.DataAccess.Client;
using Oracle.DataAccess.Types;
using System.Data;
using System.Collections;
using System.Windows.Forms;

namespace Movie_rental
{
    class DBconnection
    {
        ArrayList setVal { get; set; }
        OracleConnection conn;
        OracleCommand cmd;

        public DBconnection()
        {
            conn = new OracleConnection("Data Source=App08;User ID=ifsapp;Password=ifsapp");
            conn.Open();

        }

        public int addCustomer(Customer c)
        {
            try
            {
                cmd = new OracleCommand("addcus", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("nic", OracleDbType.Varchar2).Value = c.Cus_nic;
                cmd.Parameters.Add("tel", OracleDbType.Int32).Value = c.Cus_tel;
                cmd.Parameters.Add("cus_name", OracleDbType.Varchar2).Value = c.Cus_name;
                cmd.Parameters.Add("cus_adrs", OracleDbType.Varchar2).Value = c.Cus_address;
                int addReturn = cmd.ExecuteNonQuery();
                return addReturn;
            }
            catch (Exception)
            {
                return 0;
            }


        }

        public ArrayList searchCustomerDetails(string searchKey,string procedureN) //customerSearch Form - load the relavent details into labels according to the NIC
        {

            try
            {
                cmd = new OracleCommand(procedureN, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                setVal = new ArrayList();
                cmd.Parameters.Add("nicNo", OracleDbType.Varchar2).Value = searchKey;
                cmd.Parameters.Add("telph", OracleDbType.Int32, ParameterDirection.Output);
                cmd.Parameters.Add("cusN", OracleDbType.Varchar2, ParameterDirection.Output);
                cmd.Parameters["cusN"].Size = 255;
                cmd.Parameters.Add("cusA", OracleDbType.Varchar2, ParameterDirection.Output);
                cmd.Parameters["cusA"].Size = 255;
                cmd.ExecuteNonQuery();

                setVal.Add(1);
                setVal.Add(Convert.ToInt32(cmd.Parameters["telph"].Value.ToString()));
                setVal.Add(cmd.Parameters["cusN"].Value.ToString());
                setVal.Add(cmd.Parameters["cusA"].Value.ToString());

                conn.Close();
                return setVal;
            }
            catch (Exception e)
            {
                setVal = new ArrayList();
                setVal.Add(0);
                return setVal;
            }
        }

        public ArrayList searchMovieDetaills(string searchkey, string procedure)//no need of exceptions--because frontend filter out unregistered movies
        {
                cmd = new OracleCommand(procedure, conn);
                cmd.CommandType = CommandType.StoredProcedure;
                setVal = new ArrayList();
                cmd.Parameters.Add("movieN", OracleDbType.Varchar2).Value = searchkey;
                cmd.Parameters.Add("genre", OracleDbType.Varchar2, ParameterDirection.Output);
                cmd.Parameters["genre"].Size = 255;
                cmd.Parameters.Add("noc", OracleDbType.Int32, ParameterDirection.Output);
                cmd.Parameters.Add("price", OracleDbType.BinaryFloat, ParameterDirection.Output);
                cmd.ExecuteNonQuery();    

                setVal.Add(1);
                setVal.Add(cmd.Parameters["genre"].Value.ToString());
                setVal.Add(Convert.ToInt32(cmd.Parameters["noc"].Value.ToString()));
                setVal.Add(Convert.ToDouble(cmd.Parameters["price"].Value.ToString()));
                return setVal;
        }
        
        public int editMovie(Movie m)
        {
            try
            {
                cmd = new OracleCommand("editMovie", conn);

                cmd.CommandType = CommandType.StoredProcedure;

                MessageBox.Show("" + m.Movie_Id);

                cmd.Parameters.Add("mId", OracleDbType.Int32).Value = m.Movie_Id;
                cmd.Parameters.Add("mName", OracleDbType.Varchar2).Value = m.Movie_Name;
                cmd.Parameters.Add("mGenre", OracleDbType.Varchar2).Value = m.Genre;
                cmd.Parameters.Add("mCopies", OracleDbType.Int32).Value = m.No_Of_Copies;
                cmd.Parameters.Add("mPrice", OracleDbType.Double).Value = m.Price;

                int editReturn = cmd.ExecuteNonQuery();

                //MessageBox.Show("" + editReturn);
                return editReturn;

            }
            catch (Exception)
            {
                return 0;
            }
            finally
            {
                conn.Close();
            }

        }

        public AutoCompleteStringCollection dataLoadToSuggestion(params string[] qryValues) //Auto Load saved values to textboxes(used for multiple functions)
        {
            string qry = "select";
            if (qryValues.Length == 2)
            {               
                if (qryValues[0].Equals("movie_name"))//movie search textBox(movieNamemsgBox class,EditMovie class)
                    qry = "select " + qryValues[0] + " from " + qryValues[1];

                else if (qryValues[0].Equals("nic"))//customer search textbox(customerSearch class)
                    qry = "select " + qryValues[0] + " from " + qryValues[1];
            }
            //else
            //{
            //    if (qryValues[0].Equals("genre"))//load genre when movie name entered(AddMovie class)
            //        qry = "select " + qryValues[0] + " from " + qryValues[1] + " where " + qryValues[2] + "=" + qryValues[3];
            //}

            
            cmd = new OracleCommand(qry, conn);
            OracleDataReader odr1 = cmd.ExecuteReader();
            AutoCompleteStringCollection auto1 = new AutoCompleteStringCollection();
            while (odr1.Read())
            {
                auto1.Add(odr1.GetString(0));
            }
            conn.Close();
            return auto1;

        }
       
        public void deleteCust(string nicNo)
        {
                cmd = new OracleCommand("cusTransactions", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("nicNo", OracleDbType.Varchar2).Value = nicNo;
                cmd.ExecuteNonQuery();

                cmd = new OracleCommand("customer_delete", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("nicNo", OracleDbType.Varchar2).Value = nicNo;
                cmd.ExecuteNonQuery();
           
        }
        
        public int editCustomer(Customer c)
        {
            try
            {
                cmd = new OracleCommand("ediCus", conn);

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("cusnic", OracleDbType.Varchar2).Value = c.Cus_nic;
                cmd.Parameters.Add("telno", OracleDbType.Int32).Value = c.Cus_tel;
                cmd.Parameters.Add("cname", OracleDbType.Varchar2).Value = c.Cus_name;
                cmd.Parameters.Add("cusadd", OracleDbType.Varchar2).Value = c.Cus_address;
                int addReturn = cmd.ExecuteNonQuery();

                return addReturn;

            }
            catch (Exception)
            {
                return 0;
            }
            finally
            {
                conn.Close();
            }

        }

        public void deleteMovie(string movieName)
        {
           cmd = new OracleCommand("movie_delete", conn);
           cmd.CommandType = CommandType.StoredProcedure;
           cmd.Parameters.Add("movieName", OracleDbType.Varchar2).Value = movieName;
           cmd.ExecuteNonQuery();
           MessageBox.Show("Sucessfully deleted details relates to movie "+movieName);
           
        }
        
        public int addMovie(Movie m)
        {
            try
            {
                cmd = new OracleCommand("addmovie", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("mName", OracleDbType.Varchar2).Value = m.Movie_Name;
                cmd.Parameters.Add("mGenre", OracleDbType.Varchar2).Value = m.Genre;
                cmd.Parameters.Add("mPrice", OracleDbType.Double).Value = m.Price;
                cmd.Parameters.Add("mCopies", OracleDbType.Int32).Value = m.No_Of_Copies;
                int addReturn = cmd.ExecuteNonQuery();
                return addReturn;
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public DataTable displayIncome(DateTime from,DateTime to)
        {
            cmd = new OracleCommand("filldataIncome", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter oda = new OracleDataAdapter();
            cmd.Parameters.Add("temp_", OracleDbType.RefCursor, ParameterDirection.ReturnValue);
            cmd.Parameters.Add("fromDate", OracleDbType.Varchar2).Value = from.ToShortDateString();
            cmd.Parameters.Add("toDate", OracleDbType.Varchar2).Value = to.ToShortDateString();
            cmd.ExecuteNonQuery();
            OracleDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            DataTable dt = new DataTable();
            dt.Load(reader);
            return dt;
            
        }
        
        public DataTable seachCustomer(string nic)
        {

            OracleCommand cmd = new OracleCommand("filldata", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            //OracleDataAdapter oda = new OracleDataAdapter();

            OracleParameter output = cmd.Parameters.Add("temp_", OracleDbType.RefCursor);
            output.Direction = ParameterDirection.ReturnValue;

            cmd.Parameters.Add("val1", OracleDbType.Varchar2).Value = nic;

            cmd.ExecuteNonQuery();
            OracleDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);

            DataTable dt = new DataTable();
            dt.Load(reader);

            return dt;

        }

        public List<string> searchByGenre(string mov_genre)
        {
            List<string> movies = new List<string>();
            OracleCommand cmd = new OracleCommand("filldatacombo", conn);
            cmd.CommandType = CommandType.StoredProcedure;

            OracleParameter output = cmd.Parameters.Add("temp_", OracleDbType.RefCursor);
            output.Direction = ParameterDirection.ReturnValue;

            cmd.Parameters.Add("val1", OracleDbType.Varchar2).Value = mov_genre;

            cmd.ExecuteNonQuery();
            OracleDataReader reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            while (reader.Read())
            {
                movies.Add(reader.GetString(0));
            }
            return movies;

        }

        public int takemovid(string movname)
        {
            int movieno = 0;
            cmd = new OracleCommand("select movie_no from movie where movie_name = '" + movname + "'", conn);
            OracleDataReader odr1 = cmd.ExecuteReader();
            while (odr1.Read())
            {
                movieno = Convert.ToInt32(odr1[0]);
            }
            conn.Close();
            return movieno;
        }

        public int addRent(Rent r)
        {
            try
            {
                cmd = new OracleCommand("addrent", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("stat", OracleDbType.Char).Value = r.Status;
                cmd.Parameters.Add("nic", OracleDbType.Varchar2).Value = r.Nic;
                cmd.Parameters.Add("movn", OracleDbType.Int32).Value = r.MovieNo;
                int addReturn = cmd.ExecuteNonQuery();
                return addReturn;
            }
            catch (Exception i)
            {
                System.Windows.Forms.MessageBox.Show(i.Message.ToString());
                return 0;
            }
        }

        public int getfines(int movieno, string nic)
        {
            try
            {
                cmd = new OracleCommand("cal_fines", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("nicNo", OracleDbType.Varchar2).Value = nic;
                cmd.Parameters.Add("movID", OracleDbType.Int32).Value = movieno;
                cmd.Parameters.Add("fines", OracleDbType.Int32, ParameterDirection.Output);
                cmd.ExecuteNonQuery();
                int res = Convert.ToInt32(cmd.Parameters["fines"].Value.ToString());

                return res;
            }
            catch (Exception)
            {
                System.Windows.Forms.MessageBox.Show("Please click on a movie from table", "Select movie", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return 0;
            }
            finally
            {
                conn.Close();

            }
        }

        public Movie searchMovie(String movieNameCurrent)
        {

            OracleCommand com = new OracleCommand("searchMovie", conn);
            com.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter oda = new OracleDataAdapter();

            var source = new BindingSource();



            OracleParameter output = com.Parameters.Add("temp_", OracleDbType.RefCursor);
            output.Direction = ParameterDirection.ReturnValue;

            com.Parameters.Add("val1", OracleDbType.Varchar2).Value = movieNameCurrent;

            com.ExecuteNonQuery();
            OracleDataReader reader = com.ExecuteReader(CommandBehavior.CloseConnection);

            Movie m = new Movie();
            while (reader.Read())
            {
                m.Movie_Id = Convert.ToInt32(reader[0]);
                m.Movie_Name = reader[1].ToString();
                m.Genre = reader[2].ToString();
                m.Price = Convert.ToDouble(reader[4]);
                m.No_Of_Copies = Convert.ToInt32(reader[3]);

            }

            return m;

        }

        public int addReturn(Rent r)
        {
            try
            {
                cmd = new OracleCommand("addreturn", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("billval", OracleDbType.Char).Value = r.BillVal;
                cmd.Parameters.Add("nic", OracleDbType.Varchar2).Value = r.Nic;
                cmd.Parameters.Add("movn", OracleDbType.Int32).Value = r.MovieNo;
                int addReturn = cmd.ExecuteNonQuery();
                return addReturn;
            }
            catch (Exception i)
            {
                System.Windows.Forms.MessageBox.Show(i.Message.ToString());
                return 0;
            }

        }

        public DataTable repcus(int value1, string d1, string d2, string nicval)
        {
            OracleConnection conn = new OracleConnection("Data Source=App08;User ID=ifsapp;Password=ifsapp");
            conn.Open();

            OracleCommand com = new OracleCommand("repcus", conn);
            com.CommandType = CommandType.StoredProcedure;
            OracleDataAdapter oda = new OracleDataAdapter();


            OracleParameter output = com.Parameters.Add("temp_", OracleDbType.RefCursor);
            output.Direction = ParameterDirection.ReturnValue;

            com.Parameters.Add("reportType", OracleDbType.Int32).Value = value1;
            com.Parameters.Add("fromd", OracleDbType.Varchar2).Value = d1;
            com.Parameters.Add("tod", OracleDbType.Varchar2).Value = d2;
            com.Parameters.Add("nic", OracleDbType.Varchar2).Value = nicval;

            com.ExecuteNonQuery();
            OracleDataReader reader = com.ExecuteReader(CommandBehavior.CloseConnection);

            DataTable dt = new DataTable();
            dt.Load(reader);
            return dt;
        
        }

    }
}
