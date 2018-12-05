using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using Telerik.Windows.Controls;

namespace Visitors.View
{
    /// <summary>
    /// Interaction logic for TelerikMainMenu.xaml
    /// </summary>
    public partial class TelerikMainMenu : Window
    {
        public TelerikMainMenu()
        {
            StyleManager.ApplicationTheme = new VistaTheme();
       
            InitializeComponent();
            //InitializeComponent();
            //Windows8 Resources 
            Windows8Palette.Palette.FontSizeXS = 10;
            Windows8Palette.Palette.FontSizeS = 11;
            Windows8Palette.Palette.FontSize = 12;
            Windows8Palette.Palette.FontSizeL = 14;
            Windows8Palette.Palette.FontSizeXL = 16;
            Windows8Palette.Palette.FontSizeXXL = 19;
            Windows8Palette.Palette.FontSizeXXXL = 24;
            Windows8Palette.Palette.FontFamily = new FontFamily("Segoe UI");
            Windows8Palette.Palette.FontFamilyLight = new FontFamily("Segoe UI Light");
            Windows8Palette.Palette.FontFamilyStrong = new FontFamily("Segoe UI Semibold");

        }

        private void MenuBtn_Click(object sender, RoutedEventArgs e)
        {
            Radmenu.Visibility = Visibility.Visible;
            outermenu.Visibility = Visibility.Visible;
        }

        private void BtnChangeFontSize_Click_1(object sender, RoutedEventArgs e)
        {
         //   StyleManager.SetTheme(MenuBtn, new VistaTheme());
            Windows8Palette.Palette.FontSize = 22;
            Windows8Palette.Palette.FontFamily = new FontFamily("Calibri");
        }
    }
}
