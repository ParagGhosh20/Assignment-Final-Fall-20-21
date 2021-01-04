using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Threading.Tasks;
using BookInfo.Models;

namespace BookInfo.Models
{
    
    class books
    {
        public int c;
        
        public string textbox;
       public DataTable dtTable = new DataTable();
        database objdatabase = new database();
        public void Show()
        {
            string query = "Select * from Books";
            objdatabase.readDatathroughAdapter(query,dtTable);
        }
        public void Close()
        {
            objdatabase.closeConn();
        }

        public void performOperation()
        {
            string query = "Select * from Books";
             c = objdatabase.executeDataAdapter(dtTable,query);
            
        }

        public void searchOpen()
        {

            string query = "Select * from Books where Name='"+textbox+"'";
            objdatabase.readDatathroughAdapter(query, dtTable);
        }
        public void earchClose()
        {
            objdatabase.closeConn();
        }
       public void information()
        {
            
        }



    }
}
