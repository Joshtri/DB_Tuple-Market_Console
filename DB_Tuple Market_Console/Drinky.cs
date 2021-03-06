using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace DB_Tuple_Market_Console
{
    internal class Drinky : Foodie
    {


        public Drinky()
        {

        }

        //public Drinky(string n, string desc, int quanti, int price, int id_e) : base(n,desc,quanti,price,id_e)
        //{
            
        //}

        public new void InsertData(SqlConnection con)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO t_drink VALUES(@name_drink,@description,@quantity,@price,@id_drink)", con);
            cmd.Parameters.AddWithValue("@name_drink", Name);
            cmd.Parameters.AddWithValue("@description", Description);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@id_drink", id);


            cmd.ExecuteNonQuery();
        }

        public new void DeleteData(SqlConnection con)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE t_drink WHERE id_drink=@id_drink", con);
            cmd.Parameters.AddWithValue("@id_drink", id);
            cmd.ExecuteNonQuery();

            MessageBox.Show("your data already deleted.");
        }

        public new void UpdateData(SqlConnection con)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE t_drink SET name_drink=@name_drink, description=@description, quantity=@quantity, price=@price WHERE id_drink=@id_drink ");
            cmd.Parameters.AddWithValue("@name_drink", Name);
            cmd.Parameters.AddWithValue("@description", Description);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@id_drink", id);

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Anda Telah merubah Data");



        }

        public new void ShowData(SqlConnection con)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM t_drink",con);
            SqlDataReader readers = cmd.ExecuteReader();

            while (readers.Read())
            {
                Console.WriteLine(readers[0] + " -- " + readers[1] + " -- " + readers[2] + "--" + readers[3] + "--" + readers[4]);
            }
            readers.Close();

            con.Close();
         
        }


    }
}
