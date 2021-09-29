using CiudadaniaDigital2.ViewModels;
using CiudadaniaDigital2.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace CiudadaniaDigital2
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
