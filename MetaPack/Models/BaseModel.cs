using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaPack.Models
{

    public class BaseModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public int id { get; set; }
        public bool exists { get; set; }
        public int index { get; set; }
       
        public void RaisePropertyChanged(string name)
        {
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

       
    }

}
