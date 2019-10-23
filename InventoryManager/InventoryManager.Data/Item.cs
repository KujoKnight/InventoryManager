using System.ComponentModel;
using System.Collections.Generic;
using System.Text;

namespace InventoryManager.Data
{
    public class Item : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Name { get; set; }
        public int Value { get; set; }
    }
}
