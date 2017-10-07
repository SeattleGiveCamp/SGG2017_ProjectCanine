﻿using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace ProjectCanine
{
    public class TestItemsViewModel : ViewModelBase
    {
        public ObservableCollection<CanineTest> Items { get; set; }
        public Command LoadItemsCommand { get; set; }

        public TestItemsViewModel()
        {
            Title = "Select Test";
            Items = new ObservableCollection<CanineTest>();
            LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());

            MessagingCenter.Subscribe<NewItemPage, CanineTest>(this, "AddItem", async (obj, item) =>
            {
                var _item = item as CanineTest;
                Items.Add(_item);
                await DataStore.AddItemAsync(_item);
            });
        }

        async Task ExecuteLoadItemsCommand()
        {
            if (IsBusy)
                return;

            IsBusy = true;

            try
            {
                Items.Clear();
                var items = await DataStore.GetItemsAsync(true);
                foreach (var item in items)
                {
                    Items.Add(item);
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
