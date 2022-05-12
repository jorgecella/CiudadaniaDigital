using CiudadaniaDigital2.Models;
using CiudadaniaDigital2.ViewModels;
using CiudadaniaDigital2.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CiudadaniaDigital2.Views
{
    public partial class ItemsPage : ContentPage
    {
        ItemsViewModel _viewModel;

        public ItemsPage()
        {
            InitializeComponent();

            BindingContext = _viewModel = new ItemsViewModel();
            
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            _viewModel.OnAppearing();
        }

       

        private void ItemsListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            string current = (e.CurrentSelection.FirstOrDefault() as Item)?.CapituloPage;

            switch (current)
            {
                case "Page1":
                    Navigation.PushAsync(new Page1(), false);
                    ItemsListView.SelectedItems = null;
                    break;

                case "Page2":
                    Navigation.PushAsync(new Page2(), false);
                    
                    break;
                case "Page3":
                    Navigation.PushAsync(new Page3(), false);

                    break;
                case "Page4":
                    Navigation.PushAsync(new Page4(), false);

                    break;
                case "Page5":
                    Navigation.PushAsync(new Page5(), false);

                    break;
              


            }

            ItemsListView.SelectedItem = null;

        }
        
    }
}