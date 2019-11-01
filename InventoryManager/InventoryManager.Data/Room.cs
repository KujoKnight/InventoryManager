using System.ComponentModel;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Linq;

namespace InventoryManager.Data
{
    public class Room : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public string Name { get; set; }
        public string Description { get; set; }

        public bool StartingLocation { get; set; }

        [JsonProperty(PropertyName = "Neighbors")]
        public List<string> NeighborNames { get; set; }

        [JsonIgnore]
        public List<Room> Neighbors { get; set; }

        public Room()
        {
            NeighborNames = new List<string>();
            Neighbors = new List<Room>();
        }

        public void BuildNeighborsFromName(List<Room> rooms)
        {
            Neighbors = (from roomName in NeighborNames
                         let room = rooms.Find(i => i.Name.Equals(roomName, System.StringComparison.InvariantCultureIgnoreCase))
                         where room != null
                         select room).ToList();
        }

        public override string ToString() => Name;
    }
}
