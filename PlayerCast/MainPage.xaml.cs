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

            contentFrame.Navigate(typeof(Subscriptions));
        }


        #region NavigationView events handlers
        private void NavView_Loaded(object sender, RoutedEventArgs e)
        {
            foreach(NavigationViewItemBase item in NavView.MenuItems)
            {
                if(item is NavigationViewItem && item.Tag.ToString() == "Subscriptions_Page")
                {
                    NavView.SelectedItem = item;
                    break;
                }
            }
            contentFrame.Navigate(typeof(Subscriptions));
        }


        private void NavView_ItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
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
       

        private void NavView_SelectionChanged(NavigationView sender, NavigationViewSelectionChangedEventArgs args)
        {
            if (args.IsSettingsSelected)
                contentFrame.Navigate(typeof(Settings));
            else
            {
                NavigationViewItemBase item = args.SelectedItemContainer;
                switch(item.Tag.ToString())
                {
                    case "Subscriptions_Page":
                        contentFrame.Navigate(typeof(Subscriptions)); break;
                    case "Catalog_Page":
                        contentFrame.Navigate(typeof(Catalog)); break;
                    case "Loaded_Page":
                        contentFrame.Navigate(typeof(Downloads)); break;
                    case "Favorites_Page":
                        contentFrame.Navigate(typeof(Favourites)); break;
                    case "NewIssue_Page":
                        contentFrame.Navigate(typeof(NewEpisodes)); break;
                    case "Playlist_Page":
                        contentFrame.Navigate(typeof(Playlist)); break;
                }
            }
        }
        #endregion
    }
}