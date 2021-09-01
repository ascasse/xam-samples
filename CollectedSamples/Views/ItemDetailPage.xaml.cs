using CollectedSamples.ViewModels;
using System.ComponentModel;
using Xamarin.Forms;

namespace CollectedSamples.Views
{
    public partial class ItemDetailPage : ContentPage
    {
        public ItemDetailPage()
        {
            InitializeComponent();
            BindingContext = new ItemDetailViewModel();
        }
    }
}