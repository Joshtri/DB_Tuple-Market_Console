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
    internal class ShowerTools : Foodie
    {
         public new void  InsertData(SqlConnection con)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO t_toys VALUES(@name_toys,@description,@quantity,@price,@id_food)", con);

            cmd.Parameters.AddWithValue(@"name_toys", Name);
            cmd.Parameters.AddWithValue(@"description", Description);
            cmd.Parameters.AddWithValue(@"quantity", quantity);
            cmd.Parameters.AddWithValue(@"price", price);
            cmd.Parameters.AddWithValue(@"id_food", id);

            cmd.ExecuteNonQuery();

            //con.Close();
        }

        public new void DeleteData(SqlConnection con)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE t_toys WHERE id_toy=@id_toy", con);
            cmd.Parameters.AddWithValue("@id_toy", id);
            cmd.ExecuteNonQuery();

            MessageBox.Show("your data already deleted.");
        }


        //not yet. 
        public new void UpdateData(SqlConnection con)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE t_drink SET name_toys=@name_toys, description=@description, quantity=@quantity, price=@price WHERE id_toy=@id_toy ");
            cmd.Parameters.AddWithValue("@name_toys", Name);
            cmd.Parameters.AddWithValue("@description", Description);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@id_toy", id);

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Anda Telah merubah Data");

        }

        public new void ShowData(SqlConnection con)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM t_toys", con);
            SqlDataReader readers = cmd.ExecuteReader();

            while (readers.Read())
            {
                Console.WriteLine(readers[0] + " -- " + readers[1] + " -- " + readers[2] + "--" + readers[3] + "--" + readers[4]);
            }
            readers.Close();


            //AdapterDate.Fill(dt);

            //Console.WriteLine(dt);

        }
    }
}
