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
using System.Threading;
namespace Travel_tips
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 
    public enum State
        {
        Edit,
        Look
    }
    public partial class MainWindow : Window
    {
        State ProgramState;
        delegate void Simpled();
        delegate void gmappathd(GMapRoute gmr);
        List<UIElement> MenuPanels = new List<UIElement>();
        void EneblePfL()
        {
            PFLb.Visibility = Visibility.Visible;
        }
        void DisablePfl()
        {
            PFLb.Visibility = Visibility.Hidden;
        }
        void GmapSetPath(GMapRoute mRoute)
        {
            gmap.Markers.Clear();
            gmap.Markers.Add(mRoute);
            gmap.ZoomAndCenterMarkers(null);
            gmap.Zoom -= 1;
            gmap.Zoom += 1;
        }
        List<PointLatLng> CurPath = new List<PointLatLng>();
        public MainWindow()
        {
            InitializeComponent();
            MenuPanels.Add((UIElement)Points);
            MenuPanels.Add((UIElement)User);
            MenuPanels.Add((UIElement)Serch);
            MenuPanels.Add((UIElement)CreatePath);
            MenuPanels[0].Visibility = Visibility.Hidden;
            MenuPanels[1].Visibility = Visibility.Hidden;
            MenuPanels[2].Visibility = Visibility.Visible;
            MenuPanels[3].Visibility = Visibility.Hidden;

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

        void DrowPath(object rpo)
        {
            gmap.Dispatcher.BeginInvoke(new Simpled(EneblePfL));
            RoutingProvider rp = (RoutingProvider)rpo;
            List<PointLatLng> pointsLL2 = new List<PointLatLng>();
            for (int i = 0; i < CurPath.Count-1; i++)
            {
                MapRoute route = rp.GetRoute(CurPath[i], CurPath[i + 1], false, true, 1);
                if (route == null)
                {
                    pointsLL2.AddRange(new PointLatLng[] { CurPath[i] , CurPath[i + 1] });
                }
                else
                pointsLL2.AddRange(route.Points);
            }
        
            GMapRoute mRoute = new GMapRoute(pointsLL2);
            gmap.Dispatcher.BeginInvoke(new gmappathd(GmapSetPath),mRoute);
            gmap.Dispatcher.BeginInvoke(new Simpled(DisablePfl));


        }
        private void gmap_MouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
           

        
            Point localPoint = e.GetPosition(gmap);
            PointLatLng point = gmap.FromLocalToLatLng((int)localPoint.X, (int)localPoint.Y);

            CurPath.Add(point);

            GMapMarker marker = new GMapMarker(point);
            marker.Shape = new Ellipse
            {
                Width = 10,
                Height = 10,
                Fill = Brushes.Red
            };
            gmap.Markers.Add(marker);
        
        }
        private void GMapControl_Loaded(object sender, RoutedEventArgs e)   
        {
            gmap.MapProvider = BingMapProvider.Instance;
            gmap.SetPositionByKeywords("Ukrain, Odessa");
            gmap.Zoom = 10.0;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Thread PathThreed = new Thread(new ParameterizedThreadStart(DrowPath));
            PathThreed.IsBackground = true;
            PathThreed.Start(gmap.MapProvider);
            
        }

        private void Canvas_SizeChanged(object sender, SizeChangedEventArgs e)
        {
            double left = (canv.ActualWidth - PFLb.ActualWidth) / 2;
            Canvas.SetLeft(PFLb, left);

            double top = (canv.ActualHeight - PFLb.ActualHeight) / 2;
            Canvas.SetTop(PFLb, top);
        }

        private void SerchB_Click(object sender, RoutedEventArgs e)
        {
            ProgramState = State.Look;
            foreach (var p in MenuPanels)
            {
                p.Visibility = Visibility.Hidden;
            }
            MenuPanels[2].Visibility = Visibility.Visible;
        }
        private void UserB_Click(object sender, RoutedEventArgs e)
        {
            ProgramState = State.Look;
            foreach (var p in MenuPanels)
            {
                p.Visibility = Visibility.Hidden;
            }
            MenuPanels[1].Visibility = Visibility.Visible;
        }
        private void PathB_Click(object sender, RoutedEventArgs e)
        {
            ProgramState = State.Look;
            foreach (var p in MenuPanels)
            {
                p.Visibility = Visibility.Hidden;
            }
            MenuPanels[0].Visibility = Visibility.Visible;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            ProgramState = State.Edit;
            foreach (var p in MenuPanels)
            {
                p.Visibility = Visibility.Hidden;
            }
            MenuPanels[3].Visibility = Visibility.Visible;
        }
    }
}
