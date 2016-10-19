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
using System.Windows.Navigation;
using System.Windows.Shapes;
using GMap.NET;
using GMap;
using GMap.NET.WindowsPresentation;
using GMap.NET.MapProviders;

namespace Travel_tips
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Open_Panel_Click(object sender, RoutedEventArgs e)
        {
            if (main_grid.ColumnDefinitions[1].Width.Value!=0)
            main_grid.ColumnDefinitions[1].Width= new GridLength(0, GridUnitType.Pixel);
            else
            {
                main_grid.ColumnDefinitions[1].Width = new GridLength(300, GridUnitType.Pixel);
           
            }
        }

        private void GMapControl_Loaded(object sender, RoutedEventArgs e)   
        {
            gmap.MapProvider = BingMapProvider.Instance;
            gmap.SetPositionByKeywords("Украина,Одесса");
        }
        
    }
}
