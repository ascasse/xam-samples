using CollectedSamples.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CollectedSamples.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Carousel2Page : ContentPage
    {
        CategoryViewModel _viewModel;

        public Carousel2Page()
        {
            InitializeComponent();
            BindingContext = _viewModel = new CategoryViewModel();
        }

        private void CarouselView_PositionChanged(object sender, PositionChangedEventArgs e)
        {
            if (_viewModel.Category.Items.Count - 1 == e.CurrentPosition)
                Console.WriteLine("last item");
        }
    }
}