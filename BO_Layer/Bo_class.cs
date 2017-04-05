using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entity_Layer;
using Data_Layer;
using System.Data;

namespace BO_Layer
{
    public class Bo_class
    {
        Data_class dallayer = new Data_class();
        public string mainname = "";
        public int current_customer_id;
        public string invoice = "";
        public string dbconnect()
        {
            return dallayer.dbconnect();
        }

        public string add_member(string fullname, string username, string password,string contactno,string type,string gender,string email,string address, string admin_name, string admin_pass)
        {
            return dallayer.add_member( fullname,  username,  password, contactno,type,gender,email,address, admin_name, admin_pass);
        }

        
        
        public int sign_in(string name, string password)
        {
            return (dallayer.sign_in(name,password));
        }

        //public string add_invoice(string customer_name, string customer_contact, string description, double amount, string employee_username, double service, double product_sell, double extra_sell)
        //{
        //    return dallayer.add_invoice(customer_name, customer_contact, description, amount, employee_username, service, product_sell, extra_sell);
        //}
        public string add_customer(string customer_name, string customer_contactno, string customer_address, string employee_username)
        {
            return dallayer.add_customer(customer_name, customer_contactno, customer_address,employee_username);
        }

        public string add_product(string serial_no, string product_no, string model_no, string brand, string importer, string warrenty, string short_description, string long_description, double unit_price, double sell_price, string name)
        {
            return dallayer.add_product(serial_no, product_no, model_no, brand, importer, warrenty, short_description, long_description, unit_price, sell_price, name);
        }

        public DataSet all_product()
        {
            return dallayer.all_product();
        }
        public DataSet advance_search(string m1, string m2, string m3)
        {
            return dallayer.advance_search(m1, m2, m3);
        }

        public DataSet advance_search2(string m1, string m2, string m3, string m4, string m5)
        {
            return dallayer.advance_search2(m1, m2, m3, m4, m5);
        }
        public string update_product(string serial_no, string product_no, string model_no, string brand, string importer, string warrenty, string short_description, string long_description, double unit_price, double sell_price, string name)
        {
            return dallayer.update_product(serial_no, product_no, model_no, brand, importer, warrenty, short_description, long_description, unit_price, sell_price, name);
        }
        public string delete_product(string serial_no)
        {
            return dallayer.delete_product(serial_no);
        }
        public DataSet all_member()
        {
            return dallayer.all_member();
        }

        public string update_employee(string fullname, string contactno, string email, string address, string type, string gender, int id)
        {
            return dallayer.update_employee(fullname, contactno, email, address, type, gender, id);
        }
        public DataSet all_customer()
        {
            return dallayer.all_customer();
        }
        public DataSet advance_search3(string m1, string m2, string m3)
        {
            return dallayer.advance_search3(m1, m2, m3);
        }
        public string delete_employee(string username)
        {
            return dallayer.delete_employee(username);
        }
        public string update_customer(int customer_id, string customer_name, string customer_contactno, string customer_address)
        {
            return dallayer.update_customer(customer_id, customer_name, customer_contactno, customer_address);
        }
        public string invoice_no_creator()
        {
            return dallayer.invoice_no_creator();
        }
        public string datetime()
        {
            return dallayer.datetime();
        }

        public DataSet current_customer_name(int id)
        {
            return dallayer.current_customer_name(id);
        }

        public DataSet advance_search4(string m1, string m2, string m3, string m4)
        {
            return dallayer.advance_search4(m1, m2, m3, m4);
        }

        public string add_temp_cart(string serial_no, string product_description, string warrenty, double unit_price)
        {
            return dallayer.add_temp_cart(serial_no, product_description, warrenty, unit_price);
        }

        public DataSet all_temp_cart()
        {
            return dallayer.all_temp_cart();
        }

        public string update_product_for_curt(string serial_no, int sold_status)
        {
            return dallayer.update_product_for_curt(serial_no,sold_status);
        }
        public string delete_all_temp_cart()
        {
            return dallayer.delete_all_temp_cart();
        }
        public string delete_temp_cart(string serial_no)
        {
            return dallayer.delete_temp_cart(serial_no);
        }
        public double calculate_ammount()
        {
            return dallayer.calculate_ammount();
        }

        public string add_invoice(string invoice_no, string date_time, double ammount, double sub_total, double discount, double grand_total, int customer_id, string name)
        {
            return dallayer.add_invoice(invoice_no, date_time, ammount, sub_total, discount, grand_total, customer_id, name);
        }

        public string add_income(double service, double product_sell, double extra_sell, string date_time, string invoice_no)
        {
            return dallayer.add_income(service, product_sell, extra_sell, date_time, invoice_no);
        }
        public DataSet all_invoice()
        {
            return dallayer.all_invoice();
        }

        public DataSet all_income()
        {
            return dallayer.all_income();
        }
        public int is_admin_or_member(string mainname)
        {
            return dallayer.is_admin_or_member(mainname);
        }

        public DataSet advance_search_invoice(string m1, string m2, string m3)
        {
            return dallayer.advance_search_invoice(m1, m2, m3);
        }
        public double calculate_ammount_for_income()
        {
            return dallayer.calculate_ammount_for_income();
        }

        public string change_password(string user_name, string password, string new_password)
        {
            return dallayer.change_password(user_name, password, new_password);
        }
        public double count_temp_cart()
        {
            return dallayer.count_temp_cart();
        }
        public string add_report(int cid, string name, string ename, string cname, string ccontact, string caddress, string invno, string datetime, double ammount, double service, double others, double grandtotal, double discount)
        {
            return dallayer.add_report(cid, name, ename, cname, ccontact, caddress, invno, datetime, ammount, service, others, grandtotal, discount);
        }
        public string delete_all_report_table()
        {
            return dallayer.delete_all_report_table();
        }
        public DataSet all_income_today(string today)
        {
            return dallayer.all_income_today(today);
        }
        public DataSet all_income_week(string today)
        {
            return dallayer.all_income_week(today);
        }
        public DataSet all_income_thismonth(string today)
        {
            return dallayer.all_income_thismonth(today);
        }

         public DataSet all_income_value_thismonth(string today)
         {
             return dallayer.all_income_value_thismonth(today);
         }
        public DataSet all_income_value_week(string today)
         {
            return dallayer.all_income_value_week(today);
         }
        public DataSet all_income_value_today(string today)
         {
             return dallayer.all_income_value_today(today);
         }
        public DataSet all_income_value()
        {
            return dallayer.all_income_value();
        }

   }
}
