using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows;
using System.Windows.Forms;

//codes by yostry lenggu

namespace DB_Tuple_Market_Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string datsource = @"Data Source=(LocalDB)\MSSQLLocalDB;Initial Catalog=DB_TupleMarket;Integrated Security=True";
            SqlConnection con = new SqlConnection(datsource);

            Console.WriteLine("\t\t\tWelcome The Tuple Market");
            //SqlCommand cmd = new SqlCommand()

            //menu. 

            MainMenu:
            Console.WriteLine("Login as :\n");
            Console.WriteLine("1. Admin");
            Console.WriteLine("9. Just want to Shooping\n");

            Console.Write("Input : ");
            int SelectLogin = int.Parse(Console.ReadLine());

            if (SelectLogin == 1 )
            {
                Console.WriteLine();
                Console.WriteLine("Input your identity.");
                loginpage:
                //Console.Write("Username : ");
                string username = "aryo";
                

                //Console.Write("Password : ");
                int password = 200608;

                
                    String querry = "SELECT * FROM T_admin WHERE username= '"+username+"'AND password = '"+password+"'";
                    SqlDataAdapter sda = new SqlDataAdapter(querry,con);
                    
                    DataTable  dtable = new DataTable();
                    sda.Fill(dtable);

                    if (dtable.Rows.Count > 0 )
                    {
                        Console.WriteLine($"Welcome {username}, what's gonna you do in here ? ");
                        
                        ProductMenu: 

                        Console.WriteLine("All stuff we had here : \n");

                        Console.WriteLine("1. Food");
                        Console.WriteLine("2. Drinks");
                        Console.WriteLine("3. Toys ");
                        Console.WriteLine("4. School Accessories");
                        Console.WriteLine("5. Ingredients");
                        Console.WriteLine("6. Fruits");
                        Console.WriteLine("7. ShowerTools");
                        Console.WriteLine("8. Others ");


                    Console.WriteLine("9. Back\n");

                        Console.Write("Input : ");
                        int select = int.Parse(Console.ReadLine());
                        var Features = 0; 
                        switch (select)
                        {
                            //Food  
                            case 1:

                                Foodie fd = new Foodie();

                                DatabaseMenu();

                                Console.Write("Input your option features : ");
                                Features = int.Parse(Console.ReadLine());

                                if (Features == 1)
                                {
                                    Console.WriteLine("Insert the data : \n");

                                    Console.Write("name food : ");
                                    fd.Name = Console.ReadLine();

                                    Console.Write("description : ");
                                    fd.Description = Console.ReadLine();

                                    Console.Write("quantity : ");
                                    fd.quantity = int.Parse(Console.ReadLine());

                                    Console.Write("price : ");
                                    fd.price = int.Parse(Console.ReadLine());

                                    Console.Write("id food : ");
                                    fd.id = int.Parse(Console.ReadLine());

                                    fd.InsertData(con);


                                }

                                else if (Features == 2)
                                {
                                    Console.WriteLine("delete the data by input the \'id\' : \n");

                                    Console.Write("id : ");
                                    fd.id = int.Parse(Console.ReadLine());

                                    fd.DeleteData(con);
                                }

                                else if (Features == 3)
                                {
                                    Console.WriteLine("update the data by input the \'id\' as an primary key : \n");
                                   
                                    Console.Write("id food : ");
                                    fd.id = int.Parse(Console.ReadLine());

                                    Console.Write("name food : ");
                                    fd.Name = Console.ReadLine();

                                    Console.Write("description : ");
                                    fd.Description = Console.ReadLine();

                                    Console.Write("quantity : ");
                                    fd.quantity = int.Parse(Console.ReadLine());

                                    Console.Write("price : ");
                                    fd.price = int.Parse(Console.ReadLine());

                                }

                                else if (Features == 4)
                                {
                                    fd.ShowData(con);
                                }

                                goto ProductMenu;

                            //Drinks
                            case 2:
                                DatabaseMenu();

                                Drinky drink1 = new Drinky();

                                Console.Write("Input your option features : ");
                                Features = int.Parse(Console.ReadLine());

                                if (Features == 1)
                                {
                                    Console.WriteLine("Insert the data : \n");

                                    Console.Write("name drink : ");
                                    drink1.Name = Console.ReadLine();

                                    Console.Write("description : ");
                                    drink1.Description = Console.ReadLine();

                                    Console.Write("quantity : ");
                                    drink1.quantity = int.Parse(Console.ReadLine());

                                    Console.Write("price : ");
                                    drink1.price = int.Parse(Console.ReadLine());

                                    Console.Write("id food : ");
                                    drink1.id = int.Parse(Console.ReadLine());

                                    drink1.InsertData(con);
                                }

                                else if (Features == 2)
                                {
                                    Console.WriteLine("delete the data by input the \'id\' : \n");

                                    Console.Write("id : ");
                                    drink1.id = int.Parse(Console.ReadLine());

                                    //drink1.DeleteData(con);

                                }

                                else if (Features == 3)
                                {
                                    Console.WriteLine("update the data by input the \'id\' as an primary key : \n");

                                    Console.Write("id drink : ");
                                    drink1.id = int.Parse(Console.ReadLine());

                                    Console.Write("name food : ");
                                    drink1.Name = Console.ReadLine();

                                    Console.Write("description : ");
                                    drink1.Description = Console.ReadLine();

                                    Console.Write("quantity : ");
                                    drink1.quantity = int.Parse(Console.ReadLine());

                                    Console.Write("price : ");
                                    drink1.price = int.Parse(Console.ReadLine());


                                }

                                else if (Features == 4)
                                {
                                    drink1.ShowData(con);

                                }
                                goto ProductMenu;
                            case 3:
                            Toys ty = new Toys();

                            DatabaseMenu();

                            Console.Write("Input your option features : ");
                            Features = int.Parse(Console.ReadLine());

                            if (Features == 1)
                            {
                                Console.WriteLine("Insert the data : \n");

                                Console.Write("name toy : ");
                                ty.Name = Console.ReadLine();

                                Console.Write("description : ");
                                ty.Description = Console.ReadLine();

                                Console.Write("quantity : ");
                                ty.quantity = int.Parse(Console.ReadLine());

                                Console.Write("price : ");
                                ty.price = int.Parse(Console.ReadLine());

                                Console.Write("id toy : ");
                                ty.id = int.Parse(Console.ReadLine());

                                ty.InsertData(con);


                            }

                            else if (Features == 2)
                            {
                                Console.WriteLine("delete the data by input the \'id\' : \n");

                                Console.Write("id : ");
                                ty.id = int.Parse(Console.ReadLine());

                                ty.DeleteData(con);
                            }

                            else if (Features == 3)
                            {
                                Console.WriteLine("update the data by input the \'id\' as an primary key : \n");

                                Console.Write("id toy : ");
                                ty.id = int.Parse(Console.ReadLine());

                                Console.Write("name toy : ");
                                ty.Name = Console.ReadLine();

                                Console.Write("description : ");
                                ty.Description = Console.ReadLine();

                                Console.Write("quantity : ");
                                ty.quantity = int.Parse(Console.ReadLine());

                                Console.Write("price : ");
                                ty.price = int.Parse(Console.ReadLine());
                            }

                            else if (Features == 4)
                            {
                                ty.ShowData(con);
                            }

                            goto ProductMenu;

                            case 4:
                            School_Accessories sc_accesories = new School_Accessories();
                            DatabaseMenu();

                            Console.Write("Input your option features : ");
                            Features = int.Parse(Console.ReadLine());

                            if (Features == 1)
                            {
                                Console.WriteLine("Insert the data : \n");

                                Console.Write("name accesories : ");
                                sc_accesories.Name = Console.ReadLine();

                                Console.Write("description : ");
                                sc_accesories.Description = Console.ReadLine();

                                Console.Write("quantity : ");
                                sc_accesories.quantity = int.Parse(Console.ReadLine());

                                Console.Write("price : ");
                                sc_accesories.price = int.Parse(Console.ReadLine());

                                Console.Write("id school accesories : ");
                                sc_accesories.id = int.Parse(Console.ReadLine());

                                sc_accesories.InsertData(con);


                            }

                            else if (Features == 2)
                            {
                                Console.WriteLine("delete the data by input the \'id\' : \n");

                                Console.Write("id : ");
                                sc_accesories.id = int.Parse(Console.ReadLine());

                                sc_accesories.DeleteData(con);
                            }

                            else if (Features == 3)
                            {
                                Console.WriteLine("update the data by input the \'id\' as an primary key : \n");

                                Console.Write("id school accesories : ");
                                sc_accesories.id = int.Parse(Console.ReadLine());

                                Console.Write("name school accesories : ");
                                sc_accesories.Name = Console.ReadLine();

                                Console.Write("description : ");
                                sc_accesories.Description = Console.ReadLine();

                                Console.Write("quantity : ");
                                sc_accesories.quantity = int.Parse(Console.ReadLine());

                                Console.Write("price : ");
                                sc_accesories.price = int.Parse(Console.ReadLine());

                            }

                            else if (Features == 4)
                            {
                                sc_accesories.ShowData(con);
                            }

                            goto ProductMenu;

                            //Ingredients.
                            case 5:

                            Ingredients ingred = new Ingredients();

                            Console.Write("Input your option features : ");
                            Features = int.Parse(Console.ReadLine());

                            if (Features == 1)
                            {
                                Console.WriteLine("Insert the data : \n");

                                Console.Write("name Ingredients : ");
                                ingred.Name = Console.ReadLine();

                                Console.Write("description : ");
                                ingred.Description = Console.ReadLine();

                                Console.Write("quantity : ");
                                ingred.quantity = int.Parse(Console.ReadLine());

                                Console.Write("price : ");
                                ingred.price = int.Parse(Console.ReadLine());

                                Console.Write("id school ingredients : ");
                                ingred.id = int.Parse(Console.ReadLine());

                                ingred.InsertData(con);


                            }

                            else if (Features == 2)
                            {
                                Console.WriteLine("delete the data by input the \'id\' : \n");

                                Console.Write("id : ");
                                ingred.id = int.Parse(Console.ReadLine());

                                ingred.DeleteData(con);
                            }

                            else if (Features == 3)
                            {
                                Console.WriteLine("update the data by input the \'id\' as an primary key : \n");

                                Console.Write("id school accesories : ");
                                ingred.id = int.Parse(Console.ReadLine());

                                Console.Write("name school accesories : ");
                                ingred.Name = Console.ReadLine();

                                Console.Write("description : ");
                                ingred.Description = Console.ReadLine();

                                Console.Write("quantity : ");
                                ingred.quantity = int.Parse(Console.ReadLine());

                                Console.Write("price : ");
                                ingred.price = int.Parse(Console.ReadLine());

                            }

                            else if (Features == 4)
                            {
                                ingred.ShowData(con);
                            }


                            break;

                           
                            case 6:
                            Fruits frt = new Fruits();
                            Console.Write("Input your option features : ");
                            Features = int.Parse(Console.ReadLine());

                            if (Features == 1)
                            {
                                Console.WriteLine("Insert the data : \n");

                                Console.Write("name accesories : ");
                                frt.Name = Console.ReadLine();

                                Console.Write("description : ");
                                frt.Description = Console.ReadLine();

                                Console.Write("quantity : ");
                                frt.quantity = int.Parse(Console.ReadLine());

                                Console.Write("price : ");
                                frt.price = int.Parse(Console.ReadLine());

                                Console.Write("id school accesories : ");
                                frt.id = int.Parse(Console.ReadLine());

                                frt.InsertData(con);


                            }

                            else if (Features == 2)
                            {
                                Console.WriteLine("delete the data by input the \'id\' : \n");

                                Console.Write("id : ");
                                frt.id = int.Parse(Console.ReadLine());

                                frt.DeleteData(con);
                            }

                            else if (Features == 3)
                            {
                                Console.WriteLine("update the data by input the \'id\' as an primary key : \n");

                                Console.Write("id school accesories : ");
                                frt.id = int.Parse(Console.ReadLine());

                                Console.Write("name school accesories : ");
                                frt.Name = Console.ReadLine();

                                Console.Write("description : ");
                                frt.Description = Console.ReadLine();

                                Console.Write("quantity : ");
                                frt.quantity = int.Parse(Console.ReadLine());

                                Console.Write("price : ");
                                frt.price = int.Parse(Console.ReadLine());

                            }

                            else if (Features == 4)
                            {
                                frt.ShowData(con);
                            }

                            break;

                            case 7:

                            ShowerTools shwrtool = new ShowerTools();

                            Console.Write("Input your option features : ");
                            Features = int.Parse(Console.ReadLine());

                            if (Features == 1)
                            {
                                Console.WriteLine("Insert the data : \n");

                                Console.Write("name accesories : ");
                                shwrtool.Name = Console.ReadLine();

                                Console.Write("description : ");
                                shwrtool.Description = Console.ReadLine();

                                Console.Write("quantity : ");
                                shwrtool.quantity = int.Parse(Console.ReadLine());

                                Console.Write("price : ");
                                shwrtool.price = int.Parse(Console.ReadLine());

                                Console.Write("id school accesories : ");
                                shwrtool.id = int.Parse(Console.ReadLine());

                                shwrtool.InsertData(con);
                            }

                            else if (Features == 2)
                            {
                                Console.WriteLine("delete the data by input the \'id\' : \n");

                                Console.Write("id : ");
                                shwrtool.id = int.Parse(Console.ReadLine());

                                shwrtool.DeleteData(con);
                            }

                            else if (Features == 3)
                            {
                                Console.WriteLine("update the data by input the \'id\' as an primary key : \n");

                                Console.Write("id school accesories : ");
                                shwrtool.id = int.Parse(Console.ReadLine());

                                Console.Write("name school accesories : ");
                                shwrtool.Name = Console.ReadLine();

                                Console.Write("description : ");
                                shwrtool.Description = Console.ReadLine();

                                Console.Write("quantity : ");
                                shwrtool.quantity = int.Parse(Console.ReadLine());

                                Console.Write("price : ");
                                shwrtool.price = int.Parse(Console.ReadLine());

                            }

                            else if (Features == 4)
                            {
                                shwrtool.ShowData(con);
                            }

                            break;

                            case 8:
                           
                            break;

                            case 9:

                                goto MainMenu;

                           

                            default:
                                break;
                        }
                    }

                    else
                    {
                        MessageBox.Show("Fill the correct Data !", ":)", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        Console.WriteLine("\n\n");
                        goto loginpage; 
                    }
            }
            else if (SelectLogin == 9)
            {
                goto MainMenu;
            }
        }

        private static void DatabaseMenu()
        {
            Console.WriteLine("1. INSERT data");
            Console.WriteLine("2. DELETE data");
            Console.WriteLine("3. UPDATE data");
            Console.WriteLine("4. SHOW   data\n");
        }

        

    }
}
