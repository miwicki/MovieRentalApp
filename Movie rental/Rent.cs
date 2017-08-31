using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Movie_rental
{
    class Rent
    {
        string nic;


        int movieNo;
        int rentId;
        DateTime rentedDate;
        DateTime returnDate;
        double billVal;
        char status;

        public string Nic
        {
          get { return nic; }
          set { nic = value; }
        }

        public char Status
        {
            get { return status; }
            set { status = value; }
        }

        public int RentId
        {
            get { return rentId; }
            set { rentId = value; }
        }
        

        public DateTime RentedDate
        {
            get { return rentedDate; }
            set { rentedDate = value; }
        }
        

        public DateTime ReturnDate
        {
            get { return returnDate; }
            set { returnDate = value; }
        }
        

        public double BillVal
        {
            get { return billVal; }
            set { billVal = value; }
        }
                   
                      
        public int MovieNo
        {
            get { return movieNo; }
            set { movieNo = value; }
        }

        public int addRent()
        {
            DBconnection db = new DBconnection();
            int ret = db.addRent(this);
            return ret;
        }

        public int getfines(int movn, string nic)
        {
            DBconnection db = new DBconnection();
            int ret = db.getfines(movn, nic);
            return ret;
        }

        public int addReturn()
        {
            DBconnection db = new DBconnection();
            int ret = db.addReturn(this);
            return ret;
        }
        
                
    }
}
