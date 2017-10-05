using System;
using MetaPack.Common;
using System.Collections.Generic;
using System.Data.SqlServerCe;

namespace MetaPack.Models
{
    public class Order : BaseModel
    {

        private OrderItems _orderItems;
        public OrderItems OrderItems
        {
            get { return _orderItems; }
            set { _orderItems = value; }
        }


        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public override string ToString()
        {
            return Name;
        }

        public enum Columns { id = 0 , name = 1  }

        public Order() 
        {
            OrderItems = new OrderItems();
        }

        public int GetMax()
        {
            int value = 0;

            Database Database = new Database();
            Database.Query("SELECT MAX(id) AS Expr1 FROM Orders");
            
            if (Database.Read())
            {
                SqlCeDataReader SqlCeDataReader = Database.GetRow();
                value = SqlCeDataReader.GetInt32(0);
            }

            Database.Close();

            return value;
        }  

        public bool Insert()
        {
            bool result = false;

            Database DB = new Database();
            result = DB.NonQuery(string.Format("INSERT INTO Orders (name) VALUES ('{0}')", Name));
            DB.Close();

            return result;
        }

        public bool Update()
        {
            return true;
        }

        public bool Delete()
        {
            return true;
        }

    }
    
   
}
