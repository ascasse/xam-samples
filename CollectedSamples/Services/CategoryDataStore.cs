using CollectedSamples.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectedSamples.Services
{
    public class CategoryDataStore : IDataStore<Category>
    {
        private List<Category> categories;

        public CategoryDataStore()
        {
            categories = LoadCategories();
        }

        public Task<bool> AddItemAsync(Category item)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteItemAsync(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Category> GetItemAsync(int id)
        {
            return await Task.FromResult(categories.Where(category => category.Id == id).FirstOrDefault());
        }

        public async Task<IEnumerable<Category>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(categories);
        }

        public Task<bool> UpdateItemAsync(Category item)
        {
            throw new NotImplementedException();
        }

        private List<Category> LoadCategories()
        {
            categories = new List<Category>();
            try
            {
                using (StreamReader file = File.OpenText("/sdcard/Download/Learning/categories.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    categories = (List<Category>)serializer.Deserialize(file, typeof(List<Category>));
                }
            }
            catch (Exception e)
            {
                Debug.WriteLine(e.Message);
            }
            return categories;
        }
    }
}
