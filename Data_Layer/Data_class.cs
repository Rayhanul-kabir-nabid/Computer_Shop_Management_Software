using Entity_Layer;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
namespace Data_Layer
{
    public class Data_class
    {
       // public string connection_string = "server = 127.0.0.1; port = 3306; database = `shop_management`; username = root; password = 1234";
        Entity_class entitylayer = new Entity_class();
        MySqlConnection conn;
        public string dbconnect()
        {
            string message = null;
            string connstring = "SERVER =" + entitylayer.server + ";PORT = " + entitylayer.port + ";USERID = " + entitylayer.username + ";PASSWORD = " + entitylayer.password;
            try
            {

                conn = new MySqlConnection();
                conn.ConnectionString = connstring;
                conn.Open();
                message = "Connect";

            }
            catch (Exception ex)
            {

                message = ex.ToString();
                Console.WriteLine(message);
            }
            return message;
        }
        
        //...................... checking admin or member ..........................//
        public DataSet get_login_type(string username)
        {

            DataSet ds = new DataSet();
            try
            {

                MySqlDataAdapter msdp = new MySqlDataAdapter();
                DataTable dt = new DataTable();
                string query = "SELECT * FROM " + entitylayer.schema + "." + entitylayer.employee_table + " where user_name = '" + username + "';";
                dbconnect();
                MySqlCommand cmd = new MySqlCommand(query, conn);

                msdp.SelectCommand = cmd;
                msdp.Fill(ds, "employee");
                dt = ds.Tables["employee"];
                conn.Close();

            }
            catch (Exception e)
            {

                return null;
            }
            return ds;

        }

        //.......................log in the system.................................//
        public int sign_in(string name, string password)
        {
            dbconnect();
            int t=100;
            string query = "SELECT * FROM `" + entitylayer.schema + "`.`" + entitylayer.employee_table + "` where `" + entitylayer.employee_table + "`.user_name = '" + name + "' && `" + entitylayer.employee_table + "`.password = md5('" + password + "');";
            MySqlCommand cmd = new MySqlCommand(query, conn);
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            //return reader.RecordsAffected.ToString();
            int count = 0;
            while (reader.Read())
            {
                count += 1;
            }
            
            if (count != 0)
            {

                DataSet ds = new DataSet() ;
                ds = get_login_type(name);
              
                DataTable dt = new DataTable();
                dt = ds.Tables["employee"];
                string type = null;
                type = dt.Rows[0]["type"].ToString();
                
                if (type == "Admin")
                {
                    t = 1;
                }
                else if (type == "Member")
                {
                    t = 2;
                }
                count = 0;
            }
            else
            {
                t = 0;
            }
            return t;
        }
        
        //.......................Check admin username password before sign up................//
        bool check_admin (string name,string password)
        {
            bool b = false;
            string message = dbconnect();
            try
            {
                string query = "SELECT * FROM `"+ entitylayer.schema +"`.`"+ entitylayer.employee_table +"` where `"+ entitylayer.employee_table +"`.user_name = '"+ name +"' && `" +entitylayer.employee_table+"`.password = md5('" + password + "') && `"+entitylayer.employee_table+"`.type = 'Admin';";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                //return reader.RecordsAffected.ToString();
                int count = 0;
                while (reader.Read())
                {
                    count += 1;
                }
                if (count > 0)
                {
                    b = true;
                }
            }
            catch (Exception e)
            {
               // Console.WriteLine(e.ToString());
                b = false;

            }
            conn.Close();
            return b;
        }

        //...................Check username if there is already same name exist at the sign up time.........//
        bool check_username(string name)
        {
            bool b = true;
            string message = dbconnect() ;
            try
            {
                string query = "SELECT * FROM `" + entitylayer.schema + "`.`" + entitylayer.employee_table + "` where `"+ entitylayer.employee_table +"`.user_name = '" + name + "';";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                //return reader.RecordsAffected.ToString();
                Console.WriteLine(reader.RecordsAffected.ToString());
                int count = 0;
                while (reader.Read())
                {
                    count += 1;
                }
                if (count > 0)
                {
                    b = false;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                b = false;

            }
            conn.Close();
            return b;
        }
        
        //..................Sign up new member in log in form.................................................//
        public string add_member(string fullname, string username, string password,string contactno,string type,string gender,string email,string address, string admin_name,string admin_pass)
        {
            bool b = true;
            string message = dbconnect();
            b = check_username(username);
            if(b == false)
            {
                message = "Same username exist";
            }
            else
            {
                b = check_admin(admin_name, admin_pass);
                if (b == false)
                {
                    message = "Check admin password combination";
                }
                else
                {
                    try
                    {
                        dbconnect();
                        string query = "INSERT INTO `" + entitylayer.schema + "`.`" + entitylayer.employee_table + "` (`user_name`, `password`, `full_name`, `contact_no`, `type`, `gender`, `email`, `address`) VALUES ('" + username + "',md5('" + password + "'),'" + fullname + "','" + contactno + "','" + type + "','" + gender + "','" + email + "','" + address + "'); ";
                        MySqlCommand cmd = new MySqlCommand(query, conn);
                        MySqlDataReader reader;
                        reader = cmd.ExecuteReader();
                        //return reader.RecordsAffected.ToString();
                        if (reader.RecordsAffected == 1)
                        {
                            message = "Successfull";
                        }
                        else if (reader.RecordsAffected == 0)
                        {
                            message = "Try again";

                        }
                    }
                    catch (Exception e)
                    {
                        message = e.ToString();

                    }
                }

                }
            conn.Close();
            return message;
        }

        // .......................Invoice no creator.........................................................//
        public string invoice_no_creator()
        {
            string invoice;
            DateTime now = DateTime.Now;
            invoice = now.ToString("INV_yyyyMMddHHmmss");
            return invoice;
        }

        //........................Date time of right now.................................................//
        public string datetime()
        {
            string date;
            DateTime now = DateTime.Now;
            date = now.ToString("yyyy/MM/dd HH:mm:ss");
            return date;
        }


        //..........................Finding the id of running employee..............................//
        public int running_employee_id (string name)
        {
            int id = 100;
            try
            {
                dbconnect();
                string t = null;
                
                string query = "SELECT * FROM `" + entitylayer.schema + "`.`" + entitylayer.employee_table + "` where `" + entitylayer.employee_table + "`.user_name = '" + name + "';";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                //return reader.RecordsAffected.ToString();
                Console.WriteLine(reader.RecordsAffected.ToString());
                int count = 0;
                while (reader.Read())
                {
                    count += 1;
                }
                if (count > 0)
                {
                    DataSet ds = new DataSet();
                    ds = get_login_type(name);

                    DataTable dt = new DataTable();
                    dt = ds.Tables["employee"];

                    t = dt.Rows[0]["id"].ToString();
                    id = Convert.ToInt32(t);
                }
                else
                {
                    id = -1;
                }
            }
            catch (Exception ex)
            {

                
            }
            return id;

        }

        // ..........................Invoice insertion................................................//

        //public string add_invoice(string customer_name, string customer_contact, string description, double amount, string employee_username, double service, double product_sell, double extra_sell)
        //{
        //    string invoice_no = invoice_no_creator(); string date_time = datetime();
        //    string message;
        //    try
        //    {
        //        message = dbconnect();
        //        string query = "INSERT INTO `" + entitylayer.schema + "`.`" + entitylayer.invoice_table + "` (`invoice_no`, `date_time`, `customer_name`, `customer_contact`, `description`, `amount`, `employee_username`) VALUES ('" + invoice_no + "','" + date_time + "','" + customer_name + "','" + customer_contact + "','" + description + "','" + amount + "','" + employee_username + "'); ";
        //        MySqlCommand cmd = new MySqlCommand(query, conn);
        //        MySqlDataReader reader;
        //        reader = cmd.ExecuteReader();
        //        return reader.RecordsAffected.ToString();
        //        if (reader.RecordsAffected == 1)
        //        {
        //            message = "Successfull";
        //            add_income(service, product_sell, extra_sell, date_time, invoice_no);
        //        }
        //        else if (reader.RecordsAffected == 0)
        //        {
        //            message = "Try again";

        //        }
        //    }
        //    catch (Exception e)
        //    {

        //        message = e.ToString();
        //    }
        //    return message;
        //}
        // .........................insert customer...................................................//
        public string add_customer(string customer_name, string customer_contactno, string customer_address,string employee_username)
        {
            string message;
            int employee_id = running_employee_id(employee_username);

            try
            {
                message = dbconnect();
                string query = "INSERT INTO `" + entitylayer.schema + "`.`" + entitylayer.customer_table + "` (`customer_name`, `customer_contactno`, `customer_address`, `employee_id`) VALUES ('" + customer_name + "','" + customer_contactno + "','" + customer_address + "','" + employee_id + "'); ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                //return reader.RecordsAffected.ToString();
                if (reader.RecordsAffected == 1)
                {
                    message = "Successfull";
                }
                else if (reader.RecordsAffected == 0)
                {
                    message = "Try again";

                }
            }
            catch (Exception e)
            {

                message = e.ToString();
            }
            return message;
        }
        // insert income
        
        public string add_income(double service, double product_sell, double extra_sell, string date_time, string invoice_no)
        {
            string message;
            try
            {
                message = dbconnect();
                string query = "INSERT INTO `" + entitylayer.schema + "`.`" + entitylayer.income_table + "` (`service`, `product_sell`, `extra_sell`, `date_time`, `invoice_no`) VALUES ('" + service + "','" + product_sell + "','" + extra_sell + "','" + date_time + "','" + invoice_no + "'); ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                //return reader.RecordsAffected.ToString();
                if (reader.RecordsAffected == 1)
                {
                    message = "Successfull";
                }
                else if (reader.RecordsAffected == 0)
                {
                    message = "Try again";

                }
            }
            catch (Exception e)
            {

                message = e.ToString();
            }
            return message;
        }
        //............................All customer...........................................//
        public DataSet all_customer()
        {
            try
            {
                dbconnect();

                string query = "SELECT * FROM `" + entitylayer.schema + "`.`" + entitylayer.customer_table + "`";

                MySqlDataAdapter dataadapter = new MySqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                dataadapter.Fill(ds, "customer");
                conn.Close();
                return ds;
            }
            catch (Exception ex)
            {

                return null;
            }

        }
        // ..............................insert product...............................................//
        public string add_product(string serial_no, string product_no, string model_no, string brand, string importer, string warrenty, string short_description, string long_description, double unit_price, double sell_price, string name)
        {
            string message;
            string entry_date = datetime();
            int sold_status; int employee_id = running_employee_id(name);
            sold_status = 0;
            try
            {
                entry_date = datetime();
                message = dbconnect();
                string query = "INSERT INTO `"+entitylayer.schema+"`.`"+entitylayer.product_table+"` (`serial_no`, `product_no`, `model_no`, `brand`, `importer`, `warrenty`, `short_description`, `long_description`, `entry_date`, `unit_price`, `sell_price`, `sold_status`, `employee_id`) VALUES ('"+serial_no+"', '"+product_no+"', '"+model_no+"', '"+brand+"', '"+importer+"', '"+warrenty+"', '"+short_description+"', '"+long_description+"', '"+entry_date+"', '"+unit_price+"', '"+sell_price+"', '"+sold_status+"', '"+employee_id+"');";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                //return reader.RecordsAffected.ToString();
                if (reader.RecordsAffected == 1)
                {
                    message = "Successfull";
                }
                else if (reader.RecordsAffected == 0)
                {
                    message = "Try again";

                }
            }
            catch (Exception e)
            {

                message = e.ToString();
            }
            return message;
        }
       
        //..............................All product info.............................................//
        public DataSet all_product()
        {
            try
            {
                dbconnect();

                string query = "SELECT * FROM `" + entitylayer.schema + "`.`" + entitylayer.product_table + "`";

                MySqlDataAdapter dataadapter = new MySqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                dataadapter.Fill(ds, "product");
                conn.Close();
                return ds;
            }
            catch (Exception ex)
            {

                return null;   
            }
            
        }
        //......................search for product entry.....................//
        public DataSet advance_search(string m1, string m2, string m3)
        {
            dbconnect();
            DataSet dt = new DataSet();
            try
            {
                if (m1.Length > 0)
                {
                    string query = "select * from `" + entitylayer.schema + "`.`"+entitylayer.product_table+"` where product_no like '" + m1 + "%' ";
                    MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
                    sda.Fill(dt, "product");
                }
                if (m2.Length > 0)
                {
                    string query = "select * from `" + entitylayer.schema + "`.`" + entitylayer.product_table + "` where model_no like '" + m2 + "%' ";
                    MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
                    sda.Fill(dt, "product");
                }
                if (m3.Length > 0)
                {
                    string query = "select * from `" + entitylayer.schema + "`.`" + entitylayer.product_table + "` where brand like '" + m3 + "%' ";
                    MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
                    sda.Fill(dt, "product");
                }
            }
            catch (Exception ex) 
            {
                
                Console.WriteLine(ex.ToString());
            }
            return dt;
        }
        //.....................Search for search and delete...................//
        public DataSet advance_search2(string m1, string m2, string m3, string m4, string m5)
        {
            dbconnect();
            DataSet dt = new DataSet();
            try
            {
                if (m1.Length > 0)
                {
                    string query = "select * from `" + entitylayer.schema + "`.`" + entitylayer.product_table + "` where product_no like '" + m1 + "%' ";
                    MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
                    sda.Fill(dt, "product");
                }
                if (m2.Length > 0)
                {
                    string query = "select * from `" + entitylayer.schema + "`.`" + entitylayer.product_table + "` where model_no like '" + m2 + "%' ";
                    MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
                    sda.Fill(dt, "product");
                }
                if (m3.Length > 0)
                {
                    string query = "select * from `" + entitylayer.schema + "`.`" + entitylayer.product_table + "` where brand like '" + m3 + "%' ";
                    MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
                    sda.Fill(dt, "product");
                }
                if (m4.Length > 0)
                {
                    string query = "select * from `" + entitylayer.schema + "`.`" + entitylayer.product_table + "` where serial_no like '" + m4 + "%' ";
                    MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
                    sda.Fill(dt, "product");
                }
                if (m5.Length > 0)
                {
                    string query = "select * from `" + entitylayer.schema + "`.`" + entitylayer.product_table + "` where importer like '" + m5 + "%' ";
                    MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
                    sda.Fill(dt, "product");
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
            return dt;
        }
        //....................search for customer .......................//
        public DataSet advance_search3(string m1, string m2, string m3)
        {
            dbconnect();
            DataSet dt = new DataSet();
            try
            {
                if (m1.Length > 0)
                {
                    string query = "select * from `" + entitylayer.schema + "`.`" + entitylayer.customer_table + "` where customer_name like '" + m1 + "%' ";
                    MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
                    sda.Fill(dt, "customer");
                }
                if (m2.Length > 0)
                {
                    string query = "select * from `" + entitylayer.schema + "`.`" + entitylayer.customer_table + "` where customer_contactno like '" + m2 + "%' ";
                    MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
                    sda.Fill(dt, "customer");
                }
                if (m3.Length > 0)
                {
                    string query = "select * from `" + entitylayer.schema + "`.`" + entitylayer.customer_table + "` where customer_address like '" + m3 + "%' ";
                    MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
                    sda.Fill(dt, "customer");
                }
                
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
            return dt;
        }
        //....................update product.................................//
        public string update_product(string serial_no, string product_no, string model_no, string brand, string importer, string warrenty, string short_description, string long_description, double unit_price, double sell_price, string name)
        {
            string message;
            string entry_date = datetime();
            int sold_status; int employee_id = running_employee_id(name);
            sold_status = 0;
            try
            {
                entry_date = datetime();
                message = dbconnect();
                string query = "UPDATE `"+entitylayer.schema+"`.`"+entitylayer.product_table+"` SET `product_no`='"+product_no+"', `model_no`='"+model_no+"', `brand`='"+brand+"', `importer`='"+importer+"', `warrenty`='"+warrenty+"', `short_description`='"+short_description+"', `long_description`='"+long_description+"',`entry_date`='"+entry_date+"' ,`unit_price`='"+unit_price+"', `sell_price`='"+sell_price+"', `employee_id`='"+employee_id+"' WHERE `serial_no`='"+serial_no+"';";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                //return reader.RecordsAffected.ToString();
                if (reader.RecordsAffected == 1)
                {
                    message = "Successfull";
                }
                else if (reader.RecordsAffected == 0)
                {
                    message = "Try again";

                }
            }
            catch (Exception e)
            {

                message = e.ToString();
            }
            return message;
        }

        //...............................delete product..........................//
        
        
        public string delete_product(string serial_no)
        {
            string message;
            try{
             message = dbconnect();
                string query = "DELETE FROM `"+entitylayer.schema+"`.`"+entitylayer.product_table+"` WHERE `serial_no`='"+serial_no+"';";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                //return reader.RecordsAffected.ToString();
                if (reader.RecordsAffected == 1)
                {
                    message = "Successfull";
                }
                else if (reader.RecordsAffected == 0)
                {
                    message = "Try again";

                }
            }
            catch (Exception e)
            {

                message = e.ToString();
            }
            return message;
        }
       
       //...............................all member...............................//
        public DataSet all_member()
        {
            try
            {
                dbconnect();

                string query = "SELECT id,user_name,full_name,contact_no,type,gender,email,address FROM `" + entitylayer.schema + "`.`" + entitylayer.employee_table + "`";

                MySqlDataAdapter dataadapter = new MySqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                dataadapter.Fill(ds, "employee");
                conn.Close();
                return ds;
            }
            catch (Exception ex)
            {

                return null;
            }

        }

        //..............................update member...........................//
        public string update_employee(string fullname, string contactno, string email, string address, string type, string gender, int id)
        {
            string message;
            try
            {
                message = dbconnect();
                string query = "UPDATE `" + entitylayer.schema + "`.`" + entitylayer.employee_table + "` SET `full_name`='" + fullname + "', `contact_no`='" + contactno + "', `email`='" + email + "', `address`='" + address + "', `type`='" + type + "', `gender`='" + gender + "' WHERE `id`='" + id + "';";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                //return reader.RecordsAffected.ToString();
                if (reader.RecordsAffected == 1)
                {
                    message = "Successfull";
                }
                else if (reader.RecordsAffected == 0)
                {
                    message = "Try again";

                }
            }
            catch (Exception ex)
            {

                message = ex.ToString();
            }
            return message;
        }
        //..............................Delete member..........................//
        public string delete_employee(string username)
        {
            string message;
            try
            {
                message = dbconnect();
                string query = "DELETE FROM `" + entitylayer.schema + "`.`" + entitylayer.employee_table + "` WHERE `user_name`='" + username + "';";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                //return reader.RecordsAffected.ToString();
                if (reader.RecordsAffected == 1)
                {
                    message = "Successfull";
                }
                else if (reader.RecordsAffected == 0)
                {
                    message = "Try again";

                }
            }
            catch (Exception e)
            {

                message = e.ToString();
            }
            return message;
        }

        //..............................update customer...........................//
        public string update_customer(int customer_id, string customer_name, string customer_contactno, string customer_address)
        {
            string message;
            try
            {
                message = dbconnect();
                string query = "UPDATE `" + entitylayer.schema + "`.`" + entitylayer.customer_table + "` SET `customer_name`='" + customer_name + "', `customer_contactno`='" + customer_contactno + "',`customer_address`='" + customer_address + "' WHERE `customer_id`='" + customer_id + "';";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                //return reader.RecordsAffected.ToString();
                if (reader.RecordsAffected == 1)
                {
                    message = "Successfull";
                }
                else if (reader.RecordsAffected == 0)
                {
                    message = "Try again";

                }
            }
            catch (Exception ex)
            {

                message = ex.ToString();
            }
            return message;
        }
        //............................customer info for individual id............//
        public DataSet current_customer_name(int id)
        {
            
            string message;
            try
            {
                message = dbconnect();
                string query = "SELECT * FROM " + entitylayer.schema + "." + entitylayer.customer_table + " where customer_id = " + id + ";";
                MySqlDataAdapter dataadapter = new MySqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                dataadapter.Fill(ds, "customer");
                conn.Close();
                return ds;
            }
            catch (Exception e)
            {

                return null;
            }

            
        }

        //....................Advance search for bill...............//
        public DataSet advance_search4(string m1, string m2, string m3, string m4)
        {
            dbconnect();
            DataSet dt = new DataSet();
            try
            {
                if (m1.Length > 0)
                {
                    string query = "select * from `" + entitylayer.schema + "`.`" + entitylayer.product_table + "` where serial_no like '" + m1 + "%' ";
                    MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
                    sda.Fill(dt, "product");
                }
                if (m2.Length > 0)
                {
                    string query = "select * from `" + entitylayer.schema + "`.`" + entitylayer.product_table + "` where short_description like '" + m2 + "%' ";
                    MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
                    sda.Fill(dt, "product");
                }
                if (m3.Length > 0)
                {
                    string query = "select * from `" + entitylayer.schema + "`.`" + entitylayer.product_table + "` where model_no like '" + m3 + "%' ";
                    MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
                    sda.Fill(dt, "product");
                }
                if (m4.Length > 0)
                {
                    string query = "select * from `" + entitylayer.schema + "`.`" + entitylayer.product_table + "` where brand like '" + m4 + "%' ";
                    MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
                    sda.Fill(dt, "product");
                }
                
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }
            return dt;
        }

        //...................insert temp_cart.....................//
        public string add_temp_cart(string serial_no, string product_description, string warrenty, double unit_price)
        {
            string message;
            
            try
            {
                message = dbconnect();
                string query = "INSERT INTO `" + entitylayer.schema + "`.`" + entitylayer.temp_cart_table + "` (`serial_no`, `product_description`, `warrenty`, `unit_price`) VALUES ('" + serial_no + "','" + product_description + "','" + warrenty + "','" + unit_price + "'); ";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                //return reader.RecordsAffected.ToString();
                if (reader.RecordsAffected == 1)
                {
                    message = "Successfull";
                }
                else if (reader.RecordsAffected == 0)
                {
                    message = "Try again";

                }
            }
            catch (Exception e)
            {

                message = e.ToString();
            }
            return message;
        }

        //..................all temp cart.................//

        public DataSet all_temp_cart()
        {
            try
            {
                dbconnect();

                string query = "SELECT * FROM `" + entitylayer.schema + "`.`" + entitylayer.temp_cart_table + "`";

                MySqlDataAdapter dataadapter = new MySqlDataAdapter(query, conn);
                DataSet ds = new DataSet();
                dataadapter.Fill(ds, "temp_cart");
                conn.Close();
                return ds;
            }
            catch (Exception ex)
            {

                return null;
            }

        }

        //....................update for sell status..........//
        public string update_product_for_curt(string serial_no, int sold_status)
        {
            string message;
            
            
            
            try
            {
                
                message = dbconnect();
                string query = "UPDATE `" + entitylayer.schema + "`.`" + entitylayer.product_table + "` SET `sold_status`='" + sold_status + "' WHERE `serial_no`='" + serial_no + "';";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                //return reader.RecordsAffected.ToString();
                if (reader.RecordsAffected == 1)
                {
                    message = "Successfull";
                }
                else if (reader.RecordsAffected == 0)
                {
                    message = "Try again";

                }
            }
            catch (Exception e)
            {

                message = e.ToString();
            }
            return message;
        }
        //.....................delete all from temp_cart........//
        public string delete_all_temp_cart()
        {
            string message;
            try
            {
                message = dbconnect();
                string query = "TRUNCATE TABLE `" + entitylayer.schema + "`.`" + entitylayer.temp_cart_table + "`;";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                //return reader.RecordsAffected.ToString();
                if (reader.RecordsAffected == 0)
                {
                    message = "Successfull";
                }
                else if (reader.RecordsAffected != 0)
                {
                    message = "Try again";

                }
            }
            catch (Exception e)
            {

                message = e.ToString();
            }
            return message;
        }
        
        //...................delete single row from temp_cart........//
        public string delete_temp_cart(string serial_no)
        {
            string message;
            try
            {
                message = dbconnect();
                string query = "DELETE FROM `" + entitylayer.schema + "`.`" + entitylayer.temp_cart_table + "` WHERE `serial_no`='" + serial_no + "';";
                MySqlCommand cmd = new MySqlCommand(query, conn);
                MySqlDataReader reader;
                reader = cmd.ExecuteReader();
                //return reader.RecordsAffected.ToString();
                if (reader.RecordsAffected == 1)
                {
                    message = "Successfull";
                }
                else if (reader.RecordsAffected == 0)
                {
                    message = "Try again";

                }
            }
            catch (Exception e)
            {

                message = e.ToString();
            }
            return message;
        }

        //...................calculate total ammount.................//        
         public double calculate_ammount()
        {
            double value = 0;
            try
            {
                dbconnect();
                string query = "SELECT SUM(`" + entitylayer.schema + "`.`" + entitylayer.temp_cart_table + "`.unit_price) as s, sum(`" + entitylayer.schema + "`.`" + entitylayer.product_table + "`.unit_price) as t FROM `" + entitylayer.schema + "`.`" + entitylayer.temp_cart_table + "`, `" + entitylayer.schema + "`.`" + entitylayer.product_table + "` where `" + entitylayer.temp_cart_table + "`.serial_no = `" + entitylayer.product_table + "`.serial_no;";
                //string query = "SELECT SUM(unit_price) from  `" + entitylayer.schema + "`.`" + entitylayer.temp_cart_table + "`;";
                
                
                MySqlCommand cmd;
                cmd = new MySqlCommand(query, conn);
                MySqlDataReader datareader;
                datareader = cmd.ExecuteReader();
                while(datareader.Read())
                {
                    value = Convert.ToDouble( datareader[0].ToString());
                }
                
                conn.Close();
                
            }
            catch (Exception ex)
            {

                
            }
            return value;

        } 
        //....................calculate ammoung for income...............//

         public double calculate_ammount_for_income()
         {
             double value = 0;
             try
             {
                 dbconnect();
                 string query = "SELECT SUM(`" + entitylayer.schema + "`.`" + entitylayer.temp_cart_table + "`.unit_price) as s, sum(`" + entitylayer.schema + "`.`" + entitylayer.product_table + "`.unit_price) as t FROM `" + entitylayer.schema + "`.`" + entitylayer.temp_cart_table + "`, `" + entitylayer.schema + "`.`" + entitylayer.product_table + "` where `" + entitylayer.temp_cart_table + "`.serial_no = `" + entitylayer.product_table + "`.serial_no;";
                 //string query = "SELECT SUM(unit_price) from  `" + entitylayer.schema + "`.`" + entitylayer.temp_cart_table + "`;";


                 MySqlCommand cmd;
                 cmd = new MySqlCommand(query, conn);
                 MySqlDataReader datareader;
                 datareader = cmd.ExecuteReader();
                 while (datareader.Read())
                 {
                     value = Convert.ToDouble(datareader[0].ToString()) - Convert.ToDouble(datareader[1].ToString());
                 }

                 conn.Close();

             }
             catch (Exception ex)
             {


             }
             return value;

         }  
    
        //..................add invoice...............................//

         public string add_invoice(string invoice_no, string date_time, double ammount, double sub_total, double discount, double grand_total, int customer_id, string name)
         {
             string message;
             int id = running_employee_id(name);
             try
             {
                 message = dbconnect();
                 string query = "INSERT INTO `" + entitylayer.schema + "`.`" + entitylayer.invoice_table + "` (`invoice_no`,`date_time`,`ammount`,`sub_total`,`discount`,`grand_total`,`customer_id`,`employee_id`) VALUES ('" + invoice_no + "','" + date_time + "','" + ammount + "','" + sub_total + "','" + discount + "','" + grand_total + "','" + customer_id + "','" + id + "'); ";
                 MySqlCommand cmd = new MySqlCommand(query, conn);
                 MySqlDataReader reader;
                 reader = cmd.ExecuteReader();
                 //return reader.RecordsAffected.ToString();
                 if (reader.RecordsAffected == 1)
                 {
                     message = "Successfull";
                 }
                 else if (reader.RecordsAffected == 0)
                 {
                     message = "Try again";

                 }
             }
             catch (Exception e)
             {

                 message = e.ToString();
             }
             return message;
         }
        
        //................all invoice..............................//
         public DataSet all_invoice()
         {
             try
             {
                 dbconnect();

                 string query = "SELECT invoice_no,date_time,ammount,sub_total,discount,grand_total,invoice.customer_id,customer.customer_name,invoice.employee_id FROM `" + entitylayer.schema + "`.`" + entitylayer.invoice_table + "`, `" + entitylayer.schema + "`.`" + entitylayer.customer_table + "` where invoice.customer_id = customer.customer_id;";

                 MySqlDataAdapter dataadapter = new MySqlDataAdapter(query, conn);
                 DataSet ds = new DataSet();
                 dataadapter.Fill(ds, "invoice");
                 conn.Close();
                 return ds;
             }
             catch (Exception ex)
             {

                 return null;
             }

         }
        //.................all income..........................//
         public DataSet all_income()
         {
             try
             {
                 dbconnect();

                 string query = "SELECT * FROM `" + entitylayer.schema + "`.`" + entitylayer.income_table + "`;";

                 MySqlDataAdapter dataadapter = new MySqlDataAdapter(query, conn);
                 DataSet ds = new DataSet();
                 dataadapter.Fill(ds, "income");
                 conn.Close();
                 return ds;
             }
             catch (Exception ex)
             {

                 return null;
             }

         }
        //....................is admin or member..............//
         public int is_admin_or_member(string mainname)
         {
             int flag = 2;
             string typ = "";
             try
             {
                 dbconnect();
                 string query = "SELECT type from  `" + entitylayer.schema + "`.`" + entitylayer.employee_table + "` where user_name = '"+mainname+"';";


                 MySqlCommand cmd;
                 cmd = new MySqlCommand(query, conn);
                 MySqlDataReader datareader;
                 datareader = cmd.ExecuteReader();
                 while (datareader.Read())
                 {
                     typ = datareader[0].ToString();
                 }

                 conn.Close();
                 if (typ == "Admin")
                 {
                     flag = 1;
                 }
                 else if (typ == "Member")
                 {
                     flag = 0;
                 }

             }
             catch (Exception ex)
             {


             }

             return flag;
         }

        //....................advance search for invoise........//
         public DataSet advance_search_invoice(string m1, string m2, string m3)
         {
             dbconnect();
             DataSet dt = new DataSet();
             try
             {
                 if (m1.Length > 0)
                 {
                     string query = "SELECT invoice_no,date_time,ammount,sub_total,discount,grand_total,invoice.customer_id,customer.customer_name,invoice.employee_id FROM `" + entitylayer.schema + "`.`" + entitylayer.invoice_table + "`, `" + entitylayer.schema + "`.`" + entitylayer.customer_table + "` where invoice.customer_id = customer.customer_id && invoice_no like '" + m1 + "%';"; 
                         //"select * from `" + entitylayer.schema + "`.`" + entitylayer.product_table + "` where product_no like '" + m1 + "%' ";
                     MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
                     sda.Fill(dt, "invoice");
                 }
                 if (m2.Length > 0)
                 {
                     string query = "SELECT invoice_no,date_time,ammount,sub_total,discount,grand_total,invoice.customer_id,customer.customer_name,invoice.employee_id FROM `" + entitylayer.schema + "`.`" + entitylayer.invoice_table + "`, `" + entitylayer.schema + "`.`" + entitylayer.customer_table + "` where invoice.customer_id = customer.customer_id && customer.customer_name like '" + m2 + "%';";
                     MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
                     sda.Fill(dt, "invoice");
                 }
                 if (m3.Length > 0)
                 {
                     string query = "SELECT invoice_no,date_time,ammount,sub_total,discount,grand_total,invoice.customer_id,customer.customer_name,invoice.employee_id FROM `" + entitylayer.schema + "`.`" + entitylayer.invoice_table + "`, `" + entitylayer.schema + "`.`" + entitylayer.customer_table + "` where invoice.customer_id = customer.customer_id && invoice.customer_id like '" + m3 + "%';";
                     MySqlDataAdapter sda = new MySqlDataAdapter(query, conn);
                     sda.Fill(dt, "invoice");
                 }
             }
             catch (Exception ex)
             {

                 Console.WriteLine(ex.ToString());
             }
             return dt;
         }
        //...............change password.............//
         public string change_password(string user_name, string password, string new_password)
         {
             string message;
             try
             {
                 int t = sign_in(user_name, password);
                 if (t==1 || t==2)
                 {
                     message = dbconnect();
                     string query = "UPDATE `" + entitylayer.schema + "`.`" + entitylayer.employee_table + "` SET `password`= md5('" + new_password + "') WHERE `user_name`='" + user_name + "';";
                     MySqlCommand cmd = new MySqlCommand(query, conn);
                     MySqlDataReader reader;
                     reader = cmd.ExecuteReader();
                     //return reader.RecordsAffected.ToString();
                     if (reader.RecordsAffected == 1)
                     {
                         message = "Successfull";
                     }
                     else if (reader.RecordsAffected == 0)
                     {
                         message = "Try again";

                     }
                 }
                 else
                 {
                     message = "Wrong Combination";
                 }
                 
             }
             catch (Exception ex)
             {

                 message = ex.ToString();
             }
             return message;
         }
        //................count temp_cart...........//
         public double count_temp_cart()
         {
             int value = 0;
             try
             {
                 dbconnect();
                 //string query = "SELECT SUM(`" + entitylayer.schema + "`.`" + entitylayer.temp_cart_table + "`.unit_price) as s, sum(`" + entitylayer.schema + "`.`" + entitylayer.product_table + "`.unit_price) as t FROM `" + entitylayer.schema + "`.`" + entitylayer.temp_cart_table + "`, `" + entitylayer.schema + "`.`" + entitylayer.product_table + "` where `" + entitylayer.temp_cart_table + "`.serial_no = `" + entitylayer.product_table + "`.serial_no;";
                 string query = "SELECT count(*) FROM `" + entitylayer.schema + "`.`" + entitylayer.temp_cart_table + "`;";


                 MySqlCommand cmd;
                 cmd = new MySqlCommand(query, conn);
                 MySqlDataReader datareader;
                 datareader = cmd.ExecuteReader();
                 while (datareader.Read())
                 {
                     value = Convert.ToInt32(datareader[0].ToString());
                 }

                 conn.Close();

             }
             catch (Exception ex)
             {


             }
             return value;

         }

        //..................insert report..........//
         public string add_report(int cid,string name,string ename,string cname,string ccontact,string caddress,string invno,string datetime,double ammount,double service,double others,double grandtotal,double discount)
         {
             string message;
             int eid = running_employee_id(name);
             try
             {
                 message = dbconnect();
                 string query = "INSERT INTO `"+entitylayer.schema+"`.`"+entitylayer.report_table+"` (`c_id`, `e_id`, `e_name`, `c_name`, `c_contactno`, `c_address`, `inv_no`, `date_time`, `ammount`, `service`, `others`, `grand_total`, `discount`) VALUES ('"+cid+"','"+eid+"','"+ename+"','"+cname+"','"+ccontact+"','"+caddress+"','"+invno+"','"+datetime+"','"+ammount+"','"+service+"','"+others+"','"+grandtotal+"','"+discount+"');";
                 MySqlCommand cmd = new MySqlCommand(query, conn);
                 MySqlDataReader reader;
                 reader = cmd.ExecuteReader();
                 //return reader.RecordsAffected.ToString();
                 if (reader.RecordsAffected == 1)
                 {
                     message = "Successfull";
                 }
                 else if (reader.RecordsAffected == 0)
                 {
                     message = "Try again";

                 }
             }
             catch (Exception e)
             {

                 message = e.ToString();
             }
             return message;
         }


         //.....................delete all from report table........//
         public string delete_all_report_table()
         {
             string message;
             try
             {
                 message = dbconnect();
                 string query = "TRUNCATE TABLE `" + entitylayer.schema + "`.`" + entitylayer.report_table + "`;";
                 MySqlCommand cmd = new MySqlCommand(query, conn);
                 MySqlDataReader reader;
                 reader = cmd.ExecuteReader();
                 //return reader.RecordsAffected.ToString();
                 if (reader.RecordsAffected == 0)
                 {
                     message = "Successfull";
                 }
                 else if (reader.RecordsAffected != 0)
                 {
                     message = "Try again";

                 }
             }
             catch (Exception e)
             {

                 message = e.ToString();
             }
             return message;
         }
        //.............today's income list.............
         public DataSet all_income_today(string today)
         {
             try
             {
                 dbconnect();

                 string query = "SELECT * FROM `" + entitylayer.schema + "`.`" + entitylayer.income_table + "` where date_time like '"+today+"%';";

                 MySqlDataAdapter dataadapter = new MySqlDataAdapter(query, conn);
                 DataSet ds = new DataSet();
                 dataadapter.Fill(ds, "income");
                 conn.Close();
                 return ds;
             }
             catch (Exception ex)
             {

                 return null;
             }

         }
         //.............weeks income list.............
         public DataSet all_income_week(string today)
         {
             try
             {
                 dbconnect();

                 string query = "SELECT * FROM `" + entitylayer.schema + "`.`" + entitylayer.income_table + "` where date_time >= '" + today + "%';";

                 MySqlDataAdapter dataadapter = new MySqlDataAdapter(query, conn);
                 DataSet ds = new DataSet();
                 dataadapter.Fill(ds, "income");
                 conn.Close();
                 return ds;
             }
             catch (Exception ex)
             {

                 return null;
             }

         }
         //.............months income list.............
         public DataSet all_income_thismonth(string today)
         {
             try
             {
                 dbconnect();

                 string query = "SELECT * FROM `" + entitylayer.schema + "`.`" + entitylayer.income_table + "` where date_time like '" + today + "%';";

                 MySqlDataAdapter dataadapter = new MySqlDataAdapter(query, conn);
                 DataSet ds = new DataSet();
                 dataadapter.Fill(ds, "income");
                 conn.Close();
                 return ds;
             }
             catch (Exception ex)
             {

                 return null;
             }

         }
         //.............values todays income list.............
         public DataSet all_income_value_today(string today)
         {
             try
             {
                 dbconnect();

                 string query = "SELECT sum(service) as s,sum(product_sell) as p, sum(extra_sell) as e FROM `" + entitylayer.schema + "`.`" + entitylayer.income_table + "` where date_time like '" + today + "%';";

                 MySqlDataAdapter dataadapter = new MySqlDataAdapter(query, conn);
                 DataSet ds = new DataSet();
                 dataadapter.Fill(ds, "income");
                 conn.Close();
                 return ds;
             }
             catch (Exception ex)
             {

                 return null;
             }

         }
         //.............values weeks income list.............
         public DataSet all_income_value_week(string today)
         {
             try
             {
                 dbconnect();

                 string query = "SELECT sum(service) as s,sum(product_sell) as p, sum(extra_sell) as e FROM `" + entitylayer.schema + "`.`" + entitylayer.income_table + "` where date_time >= '" + today + "%';";

                 MySqlDataAdapter dataadapter = new MySqlDataAdapter(query, conn);
                 DataSet ds = new DataSet();
                 dataadapter.Fill(ds, "income");
                 conn.Close();
                 return ds;
             }
             catch (Exception ex)
             {

                 return null;
             }

         }
         //.............values months income list.............
         public DataSet all_income_value_thismonth(string today)
         {
             try
             {
                 dbconnect();

                 string query = "SELECT sum(service) as s,sum(product_sell) as p, sum(extra_sell) as e FROM `" + entitylayer.schema + "`.`" + entitylayer.income_table + "` where date_time like '" + today + "%';";

                 MySqlDataAdapter dataadapter = new MySqlDataAdapter(query, conn);
                 DataSet ds = new DataSet();
                 dataadapter.Fill(ds, "income");
                 conn.Close();
                 return ds;
             }
             catch (Exception ex)
             {

                 return null;
             }

         }
         //.............values  income list.............
         public DataSet all_income_value()
         {
             try
             {
                 dbconnect();

                 string query = "SELECT sum(service) as s,sum(product_sell) as p, sum(extra_sell) as e FROM `" + entitylayer.schema + "`.`" + entitylayer.income_table + "` ;";

                 MySqlDataAdapter dataadapter = new MySqlDataAdapter(query, conn);
                 DataSet ds = new DataSet();
                 dataadapter.Fill(ds, "income");
                 conn.Close();
                 return ds;
             }
             catch (Exception ex)
             {

                 return null;
             }

         }
         
    }
}
