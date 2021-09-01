using CollectedSamples.Models;
using CollectedSamples.Services;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CollectedSamples.ViewModels
{
    public class CategoriesViewModel : BaseViewModel
    {
        public ObservableCollection<Group> Groups { get; set; }
        public ObservableCollection<Category> Categories { get; set; }

        public Command LoadItemsCommand { get; }

        private IDataStore<Category> categoryDataStore;

        public CategoriesViewModel()
        {
            Title = "Categories";
            categoryDataStore = DependencyService.Get<IDataStore<Category>>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
            //Categories = new ObservableCollection<Category>
            //{
            //    new Category
            //    {
            //        Name = "Birds",
            //        Items = new List<Item>
            //        {
            //            new Item
            //            {
            //                Id = 1,
            //                Text = "House sparrow",
            //                ImageLocation = "https://commons.wikimedia.org/wiki/Category:Aves#/media/File:Female_house_sparrow_at_Kodai.jpg"
            //            },
            //            new Item
            //            {
            //                Id = 2,
            //                Text = "2.  Common grackle",
            //                ImageLocation = "https://upload.wikimedia.org/wikipedia/commons/f/fd/Quiscalus-quiscula-001.jpg"
            //            }
            //        }
            //    },

            //};

            //Groups = new ObservableCollection<Group>
            //{
            //    new Group ("Birds", new List<Item>
            //    {
            //        new Item
            //        {
            //            Id = 3,
            //            Text = "3. House sparrow",
            //            ImageLocation = "https://commons.wikimedia.org/wiki/Category:Aves#/media/File:Female_house_sparrow_at_Kodai.jpg"
            //        },
            //        new Item
            //        {
            //            Id = 4,
            //            Text = "4. Common grackle",
            //            ImageLocation = "https://upload.wikimedia.org/wikipedia/commons/f/fd/Quiscalus-quiscula-001.jpg"
            //        },
            //        new Item
            //        {
            //            Id = 5,
            //            Text = "House sparrow",
            //            ImageLocation = "https://commons.wikimedia.org/wiki/Category:Aves#/media/File:Female_house_sparrow_at_Kodai.jpg"
            //        },
            //        new Item
            //        {
            //            Id = 2,
            //            Text = "Common grackle",
            //            ImageLocation = "https://upload.wikimedia.org/wikipedia/commons/f/fd/Quiscalus-quiscula-001.jpg"
            //        }
            //    }),
            //    new Group ("Food", new List<Item>
            //    {
            //        new Item
            //        {
            //            Text = "Chicken"
            //        },
            //        new Item
            //        {
            //            Text = "Potatoes"
            //        }
            //    })
            //};
        }

        async Task ExecuteLoadItemsCommand()
        {
            IsBusy = true;

            try
            {
                Categories.Clear();
                var categories = await categoryDataStore.GetItemsAsync(true);
                foreach (var category in categories)
                {
                    Categories.Add(category);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex);
            }
            finally
            {
                IsBusy = false;
            }
        }
    }
}
