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
    public partial class EditableCollectionPage : ContentPage
    {
        public EditableCollectionPage()
        {
            InitializeComponent();
        }

        private async void Delete_Tapped(object sender, EventArgs e)
        {
            var args = ((TappedEventArgs)e).Parameter.ToString();
            if (!string.IsNullOrEmpty(args))
            {
                bool result = await DisplayAlert("Confirm", "Are you sure?", "Yes", "No");
                if (result)
                {
                    ((EditableCollectionViewModel)BindingContext).DeleteItem(args);
                }
            }            
        }

        private async void Edit_Tapped(object sender, EventArgs e)
        {
            var args = ((TappedEventArgs)e).Parameter.ToString();
            if (!string.IsNullOrEmpty(args))
            {
                string result = await DisplayPromptAsync("Edit", "", placeholder:args);
                if (!string.IsNullOrEmpty(result))
                {
                    if (!result.Equals(args))
                    {
                        ((EditableCollectionViewModel)BindingContext).UpdateItem(args, result);
                    }
                }
            }
        }

        private async void Add_Tapped(object sender, EventArgs args)
        {
            string result = await DisplayPromptAsync("Add", "Type the new element");
            if (!string.IsNullOrEmpty(result))
            {
                if (!result.Equals(args))
                {
                    ((EditableCollectionViewModel)BindingContext).AddItem(result);
                }
            }
        }
    }
}