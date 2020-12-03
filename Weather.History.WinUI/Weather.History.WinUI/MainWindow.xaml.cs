using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;

using Weather.History.WinUI.Pages;


// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace Weather.History.WinUI
{
    /// <summary>
    /// An empty window that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainWindow : Window
    {
        public MainWindow()
        {
            this.InitializeComponent();
        }

        public static Type AboutPage => typeof(AboutPage);

        public static Type WelcomePage => typeof(WelcomePage);

        public void OnNewTab(object sender, RoutedEventArgs e)
        {
            var newTab = new TabViewItem
            {
                IconSource = new SymbolIconSource() { Symbol = Symbol.Document },
                Header = "New Document"
            };

            newTab.Content = new Frame();

            (newTab.Content as Frame).Navigate((sender as FrameworkElement).Tag as Type);

            MainTabView.TabItems.Add(newTab);
        }


    }
}
