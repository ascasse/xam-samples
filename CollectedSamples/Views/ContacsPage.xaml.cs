using CollectedSamples.ViewModels;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectedSamples.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ContactsPage : ContentPage
    {
        ItemsViewModel _viewModel;

        public ContactsPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new ItemsViewModel();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }

        private void ContactsCollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}