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
    public partial class CategoriesPage : ContentPage
    {
        private readonly CategoriesViewModel _viewModel;
        public CategoriesPage()
        {
            InitializeComponent();
            BindingContext = _viewModel = new CategoriesViewModel();
        }
    }
}