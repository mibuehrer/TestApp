using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestApp.Models
{
    public class ModelItem
    {
        private string id;
        public string Label { get => id; }
        public ModelItem(string t)
        {
            id = t;
        }
    }
    public class Model
    {
        public ObservableCollection<ModelItem> Items;
        public Model()
        {
            Items = new();
            for(int i= 1; i < 50; i++)
            {
                string t = "Item " + i.ToString();
                Items.Add(new ModelItem(t));
            }
        }
    }
}
