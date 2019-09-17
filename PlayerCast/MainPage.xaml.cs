using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using PlayerCast.Views;
using Microsoft.EntityFrameworkCore;
using PlayerCast.Utilities;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace PlayerCast
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();

            ContentFrame.Navigate(typeof(Subscriptions));

            LoadData();
        }

        public async void LoadData()
        {
            await GetChannelsRepository.GetChannelsList();
        }


        #region NavigationView events handlers
        private void NavigationView_Loaded(object sender, RoutedEventArgs e)
        {
            foreach(NavigationViewItemBase item in NavigationView.MenuItems)
            {
                if(item is NavigationViewItem && item.Tag.ToString() == "Subscriptions_Page")
                {
                    NavigationView.SelectedItem = item;
                    break;
                }
            }
            ContentFrame.Navigate(typeof(Subscriptions));
        }


        private void NavigationView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            //if (args.IsSettingsInvoked)
            //    contentFrame.Navigate(typeof(Settings));
            //else
            //{
            //    NavigationViewItemBase item = args.InvokedItemContainer;

            //    switch(item.Tag.ToString())
            //    {
            //        case "Subscriptions_Page":
            //            contentFrame.Navigate(typeof(Subscriptions));
            //            break;
            //    }
            //}
        }
       

        private void NavigationView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
                ContentFrame.Navigate(typeof(Settings));
            else
            {
                NavigationViewItemBase item = args.SelectedItemContainer;
                switch(item.Tag.ToString())
                {
                    case "Subscriptions_Page":
                        ContentFrame.Navigate(typeof(Subscriptions)); break;
                    case "Catalog_Page":
                        ContentFrame.Navigate(typeof(Catalog)); break;
                    case "Loaded_Page":
                        ContentFrame.Navigate(typeof(Downloads)); break;
                    case "Favorites_Page":
                        ContentFrame.Navigate(typeof(Favourites)); break;
                    case "NewIssue_Page":
                        ContentFrame.Navigate(typeof(NewEpisodes)); break;
                    case "Playlist_Page":
                        ContentFrame.Navigate(typeof(Playlist)); break;
                }
            }
        }
        #endregion
    }
}