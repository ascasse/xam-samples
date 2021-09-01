using CollectedSamples.Views;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace CollectedSamples.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        public ObservableCollection<string> Samples { get; set; }

        public ICommand SelectionChangedCommand { get; }

        public string SelectedSample { get; set; }

        private readonly Dictionary<string, Page> pages = new Dictionary<string, Page>
        {
            { "List", new EmployeeListPage() },
            { "Fontawesome", new FontawesomePage() },
            { "ImageList", new ImageListPage() },
            { "Horizontal list", new HorizontalList() },
            { "Categories", new CategoriesPage() },
            { "Grid", new GridSample1Page() },
            { "Editable collection", new EditableCollectionPage() },
            { "Activity indicator", new ActivityIndicatorPage() },
            { "Center element", new CenterElementPage() },
            { "Full screen page", new FullScreenPage() },
            { "Carousel page", new CarouselSamplePage() }, 
            { "Carousel2 page", new Carousel2Page() } 
        };

        public AboutViewModel()
        {
            Title = "Collected Samples";
            Samples = new ObservableCollection<string> (pages.Keys);
            
            SelectionChangedCommand = new Command(async () =>
            {
                Page targetPage = pages[SelectedSample];
                await Application.Current.MainPage.Navigation.PushAsync(targetPage);
            });

        }

        public ICommand OpenWebCommand { get; }

    }
}