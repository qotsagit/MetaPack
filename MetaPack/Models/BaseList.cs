using MetaPack.Common;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace MetaPack.Models
{
    public class BaseList<T> : ObservableCollection<T> where T: BaseModel
    {
        public bool ReIndex { get; set; }
        public string SearchText { get; set; }
        public Database Database { get; set; }

        public bool Read()
        {
            ReIndex = false;
            bool result = false;
            Database = new Database();
            SetNotExists();
            result = DoRead();
            Remove();
            Database.Close();
            return result;
        }

        public virtual bool DoRead()
        {         
            return true;
        }

        public T Exists(int id, int index)
        {
            int counter = 0;
            foreach (T item in this)
            {        
                if (item.id == id && counter == index)
                {
                    item.exists = true;
                    return item;
                }
                counter++;
            }
            
            return null;
        }

        public void SetNotExists()
        {
            foreach (T item in this)
            {
                item.exists = false;
            }
        }

        public void Remove()
        {
            foreach (T item in this)
            {
                if (!item.exists)
                {
                    //this.Remove(item);
                    //i = 0;
                }
            }
            
             
        }
       

    }

    public class GroupInfoList : List<object>
    {

        public object Key { get; set; }


        public new IEnumerator<object> GetEnumerator()
        {
            return (System.Collections.Generic.IEnumerator<object>)base.GetEnumerator();
        }
    }

}
