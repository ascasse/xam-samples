using CollectedSamples.Models;
using CollectedSamples.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace CollectedSamples.ViewModels
{
    public class CategoryViewModel : BaseViewModel
    {
        public Category Category { get; set; }

        public Command LoadItemCommand { get; }

        private IDataStore<Category> categoryDataStore;

        public CategoryViewModel()
        {
            categoryDataStore = DependencyService.Get<IDataStore<Category>>();
            LoadItemCommand = new Command(async () => await LoadItems());
            LoadItemCommand.Execute(null);
            //Task.Run(async () => await LoadItems());
        }

        async Task LoadItems()
        {
            try
            {
                IsBusy = true;
                Category = await categoryDataStore.GetItemAsync(1);
            }
            catch(Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
