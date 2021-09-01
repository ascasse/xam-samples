using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace CollectedSamples.ViewModels
{
    public class HorizontalListViewModel
    {
        public ObservableCollection<string> Employees { get; set; }

        public string SelectedEmployee { get; set; }

        public HorizontalListViewModel()
        {
            Employees = new ObservableCollection<string>
            {
                "Cierra Vega", "Alden Cantrell", "Kierra Gentry", "Pierre Cox", "Thomas Crane",
                "Miranda Shaffer", "Bradyn Kramer", "Alvaro Mcgee"
            };
        }


    }
}
