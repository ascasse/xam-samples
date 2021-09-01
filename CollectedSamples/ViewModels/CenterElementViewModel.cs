using System.Collections.ObjectModel;

namespace CollectedSamples.ViewModels
{
    public class CenterElementViewModel : BaseViewModel
    {
        public ObservableCollection<string> Data { get; set; }

        public CenterElementViewModel()
        {
            Title = "Center element";

            Data = new ObservableCollection<string>
            {
                "Pearl S. Buck", "Doris Lessing", "José Saramago", "William Golding",
                "Mikhail Sholokhov", "Ernest Hemingway", "Rudyard Kipling"
            };
        }

        
    }
}
