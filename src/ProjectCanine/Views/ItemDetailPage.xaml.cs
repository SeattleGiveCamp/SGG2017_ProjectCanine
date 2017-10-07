﻿using System;

using Xamarin.Forms;

namespace ProjectCanine
{
    public partial class ItemDetailPage : ContentPage
    {
        ItemDetailViewModel viewModel;

        // Note - The Xamarin.Forms Previewer requires a default, parameterless constructor to render a page.
        public ItemDetailPage()
        {
            InitializeComponent();

            var item = new Test
            {
                ShortName = "Item 1",
                Name = "This is an item description."
            };

            viewModel = new ItemDetailViewModel(item);
            BindingContext = viewModel;

        }

        public ItemDetailPage(ItemDetailViewModel viewModel)
        {
            InitializeComponent();

            BindingContext = this.viewModel = viewModel;
        }

        void HandleContinue_Clicked(object sender, System.EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
