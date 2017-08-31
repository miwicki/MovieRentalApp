using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Oracle.DataAccess.Client;
using System.Data;

namespace Movie_rental
{
    class Customer
    {
        String cus_nic;
        int cus_tel;
        String cus_name;
        String cus_address;

        public String Cus_nic
        {
            get { return cus_nic; }
            set { cus_nic = value; }
        }
       

        public int Cus_tel
        {
            get { return cus_tel; }
            set { cus_tel = value; }
        }
        

        public String Cus_name
        {
            get { return cus_name; }
            set { cus_name = value; }
        }
        

        public String Cus_address
        {
            get { return cus_address; }
            set { cus_address = value; }
        }

        public int addCustomer()
        {
            DBconnection db = new DBconnection();
            int addReturn= db.addCustomer(this);
            return addReturn;
        }
        public int editCustomer()
        {
            DBconnection db = new DBconnection();
            int editreturn = db.editCustomer(this);
            return editreturn;
        }
        public DataTable searchCustomer(string nic)
        {
            DBconnection db = new DBconnection();
            return (db.seachCustomer(nic));

        }

        
    }
}
