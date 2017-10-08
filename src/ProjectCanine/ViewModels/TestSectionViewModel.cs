﻿using System;
using System.Collections.ObjectModel;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

using Xamarin.Forms;

using ProjectCanine.Core.Models;

namespace ProjectCanine
{
	public class TestSectionViewModel : ViewModelBase
	{
        public Test TestItem;
        public ObservableCollection<Test> Items { get; set; }
		public Command LoadItemsCommand { get; set; }

		public TestSectionViewModel()
		{
			Title = "Choose a Section";
			Items = new ObservableCollection<Test>();
			LoadItemsCommand = new Command(async () => await ExecuteLoadItemsCommand());
		}

        public TestSectionViewModel(Test item = null) {
            TestItem = item;
        }

		async Task ExecuteLoadItemsCommand()
		{
			if (IsBusy)
				return;

			IsBusy = true;

			try
			{
				Items.Clear();
				var items = await DataStore.GetItemsAsync();
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
