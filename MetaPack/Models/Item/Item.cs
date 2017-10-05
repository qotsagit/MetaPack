using System;
using MetaPack.Common;
using System.Collections.Generic;
using System.Data.SqlServerCe;

namespace MetaPack.Models
{
    public class Item : BaseModel
    {

        private int _id_parent;
        public int IdParent 
        {
            get { return _id_parent; }
            set { _id_parent = value; }
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

        public enum Columns { id = 0 , id_parent = 1, name = 2 ,price = 3 }

        public Item() 
        {
            IdParent = 0;
            Price = 0;
        }

        public bool Insert()
        {
            bool result = false;

            Database DB = new Database();

            //string a = Price.ToString("");
            result = DB.NonQuery(string.Format("INSERT INTO items (id_parent,name,price) VALUES ('{0}','{1}','{2}')", IdParent, Name, Price));
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
