using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetaPack.Common;

namespace MetaPack.Models
{

    public class BaseModel: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public int Id { get; set; }
        public bool Exists { get; set; }
        public int Index { get; set; }
       
        public void RaisePropertyChanged(string name)
        {
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }

}
