using MetaPack.Common;
using System.Data.SqlClient;
using System.Data.SqlServerCe;

namespace MetaPack.Models
{
    public class Items : BaseList<Item>
    {

        public int IdParent = 0;
        public override bool DoRead()
        {
                                
            if (Database.Query(string.Format("SELECT * FROM items WHERE (name LIKE '%{0}%' AND id_parent='{1}') ORDER BY name", SearchText,IdParent)))
            {

                while (Database.Read())
                {
                    SqlCeDataReader SqlCeDataReader = Database.GetRow();
                    Item Item = new Item();
                    Item.id = SqlCeDataReader.GetInt32((int)Item.Columns.id);
                    Item.IdParent = SqlCeDataReader.GetInt32((int)Item.Columns.id_parent);
                    Item.Name = SqlCeDataReader.GetString((int)Item.Columns.name);
                    Item.Price = SqlCeDataReader.GetDouble(3);
                    Add(Item);
                   
                }

                Database.FreeResult();
            }
            else
            {
                return false;
            }
                        
            return true;
        }
        
        public void Generate()
        {
            Item Item = new Item();
            int counter = 10000;
            while(counter-- > 0)
            {
                Item.Name = counter.ToString();
                Item.Price = counter;
                Item.Insert();
            }
        }

       
    }

}
