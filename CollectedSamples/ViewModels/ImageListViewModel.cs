using CollectedSamples.Models;
using System.Collections.ObjectModel;

namespace CollectedSamples.ViewModels
{
    public class ImageListViewModel : BaseViewModel
    {
        public ObservableCollection<Book> Books { get; set; }

        public ImageListViewModel()
        {
            Title = "Books";
            Books = new ObservableCollection<Book>
            {
                new Book
                {
                    Id = 1,
                    Title = "High heat",
                    ImagePath = "/sdcard/Download/High_heat.jpg"
                },
                new Book
                {
                    Id = 2,
                    Title = "Nothing to loose",
                    ImagePath = "/storage/emulated/0/Download/Nothing_to_loose.jpg"
                },
                new Book
                {
                    Id = 1,
                    Title = "Make me",
                    ImagePath = "/sdcard/Download/Make_me.jpg"
                }
            };

        }
    }
}
