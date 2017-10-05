using System;
using MetaPack.Common;
using System.Collections.Generic;
using System.Data.SqlServerCe;

namespace MetaPack.Models
{
    public class OrderItem : BaseModel
    {

        private int _id_order;
        public int IdOrder 
        {
            get { return _id_order;}
            set { _id_order = value; }
        }
        
        private string _name;
        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        private double _price;
        public double Price
        {
            get { return _price; }
            set { _price = value; }
        }

        public override string ToString()
        {
            return Name;
        }

        public enum Columns { id = 0, id_order = 1, name = 2 ,price = 3 }

        public OrderItem() 
        {
            Price = 0;
        }

        public bool Insert()
        {
            bool result = false;

            Database DB = new Database();
            result = DB.NonQuery(string.Format("INSERT INTO OrderItems (id_order,name,price) VALUES ('{0}','{1}','{2}')",IdOrder, Name, Price));
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
