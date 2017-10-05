using MetaPack.Common;
using System.Data.SqlClient;
using System.Data.SqlServerCe;

namespace MetaPack.Models
{
    public class OrderItems : BaseList<OrderItem>
    {

        public int IdOrder {get; set;}
        public double GetPrice() 
        {
            double price = 0;
            foreach(OrderItem OrderItem in this)
            {
                price += OrderItem.Price;
            }

            return price;
        }
        
        public override bool DoRead()
        {
            
            if (Database.Query(string.Format("SELECT * FROM orderitems WHERE id_order = '{0}' ORDER BY name",IdOrder)))
            {
                while (Database.Read())
                {
                    SqlCeDataReader SqlCeDataReader = Database.GetRow();
                    OrderItem OrderItem = new OrderItem();
                    OrderItem.Id = SqlCeDataReader.GetInt32((int)OrderItem.Columns.id);
                    OrderItem.IdOrder = SqlCeDataReader.GetInt32((int)OrderItem.Columns.id_order);
                    OrderItem.Name = SqlCeDataReader.GetString((int)OrderItem.Columns.name);
                    OrderItem.Price = SqlCeDataReader.GetDouble((int)OrderItem.Columns.price);
                    Add(OrderItem);
                   
                }

                Database.FreeResult();
            }
            else
            {
                return false;
            }
                        
            return true;
        }
          
    }

}
