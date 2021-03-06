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
    internal class Ingredients : Foodie
    {

        public new void InsertData(SqlConnection con)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand("INSERT INTO t_food VALUES(@name_food,@description,@quantity,@price,@id_food)", con);

            cmd.Parameters.AddWithValue(@"name_food", Name);
            cmd.Parameters.AddWithValue(@"description", Description);
            cmd.Parameters.AddWithValue(@"quantity", quantity);
            cmd.Parameters.AddWithValue(@"price", price);
            cmd.Parameters.AddWithValue(@"id_food", id);

            cmd.ExecuteNonQuery();
            MessageBox.Show("Anda Telah menambah Data");
            //con.Close();
        }

        public new void DeleteData(SqlConnection con)
        {

            con.Open();
            SqlCommand cmd = new SqlCommand("DELETE t_food WHERE id_food=@id_food", con);
            cmd.Parameters.AddWithValue("@id_food", id);
            cmd.ExecuteNonQuery();

            MessageBox.Show("your data already deleted.");


        }


        //not yet. 
        public new void UpdateData(SqlConnection con)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("UPDATE t_food SET name_food=@name_food, description=@description, quantity=@quantity, price=@price WHERE id_food=@id_food ");
            cmd.Parameters.AddWithValue("@name_food", Name);
            cmd.Parameters.AddWithValue("@description", Description);
            cmd.Parameters.AddWithValue("@quantity", quantity);
            cmd.Parameters.AddWithValue("@price", price);
            cmd.Parameters.AddWithValue("@id_food", id);

            cmd.ExecuteNonQuery();

            con.Close();

            MessageBox.Show("Anda Telah merubah Data");

        }

        public new void ShowData(SqlConnection con)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("SELECT * FROM t_food", con);
            SqlDataReader readers = cmd.ExecuteReader();

            while (readers.Read())
            {
                Console.WriteLine(readers[0] + " -- " + readers[1] + " -- " + readers[2] + "--" + readers[3] + "--" + readers[4]);
            }
            readers.Close();


            con.Close();
            //AdapterDate.Fill(dt);

            //Console.WriteLine(dt);

        }
    }
}
