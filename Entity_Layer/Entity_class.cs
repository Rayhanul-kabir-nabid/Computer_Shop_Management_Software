using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_Layer
{
    public class Entity_class
    {
        public string server = "127.0.0.1";
        public string port = "3306";
        public string schema = "shop_management";
        public string username = "root";
        public string password = "1234";
        public string employee_table = "employee";
        public string invoice_table = "invoice";
        public string income_table = "income";
        public string customer_table = "customer";
        public string product_table = "product";
        public string temp_cart_table = "temp_cart";
        public string report_table = "report";
    }
}
