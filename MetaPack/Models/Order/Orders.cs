using MetaPack.Common;
using System.Data.SqlClient;
using System.Data.SqlServerCe;

namespace MetaPack.Models
{
    public class Orders : BaseList<Order>
    {
            
        public override bool DoRead()
        {
            
            if (Database.Query(string.Format("SELECT * FROM orders")))
            {
                while (Database.Read())
                {
                    SqlCeDataReader SqlCeDataReader = Database.GetRow();
                    Order Ptr = new Order();
                    Ptr.Id = SqlCeDataReader.GetInt32((int)Order.Columns.id);
                    Ptr.Name = SqlCeDataReader.GetString((int)Order.Columns.name);
                    Add(Ptr);  
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
