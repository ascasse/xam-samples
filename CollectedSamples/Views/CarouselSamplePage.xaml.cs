using CollectedSamples.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectedSamples.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class CarouselSamplePage : ContentPage
    {
        CategoryViewModel _viewModel;

        public CarouselSamplePage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new CategoryViewModel();
        }

    }
}