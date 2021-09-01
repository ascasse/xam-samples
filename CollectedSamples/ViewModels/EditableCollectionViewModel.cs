using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CollectedSamples.ViewModels
{
    public class EditableCollectionViewModel : BaseViewModel
    {
        public ObservableCollection<string> Data { get; set; }

        public EditableCollectionViewModel()
        {
            Title = "Editable collection";
            Data = new ObservableCollection<string>
            {
                "Pearl S. Buck", "Doris Lessing", "José Saramago", "William Golding", 
                "Mikhail Sholokhov", "Ernest Hemingway", "Rudyard Kipling"
            };
        }

        public void AddItem(string item)
        {
            Data.Add(item);
        }

        public void DeleteItem(string item)
        {
            Data.Remove(item);
        }

        public void UpdateItem(string oldValue, string newValue)
        {
            if (string.IsNullOrEmpty(newValue))
                return;
            int pos = Data.IndexOf(oldValue);
            if (pos == -1)
                return;
            Data.RemoveAt(pos);
            Data.Insert(pos, newValue);
        }
    }
}
