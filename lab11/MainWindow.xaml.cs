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
using lab11.Models;

namespace lab11
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 



    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

        }

        private bool rendering = false;
        private void cmdStart_Clicked(object sender, RoutedEventArgs e)
        {


            if (!rendering)
            {
                Star_list.Clear();
                canvas.Children.Clear();

                CompositionTarget.Rendering += RenderFrame;
                rendering = true;
            }
        }
        private void cmdStop_Clicked(object sender, RoutedEventArgs e)
        {
            StopRendering();
        }

        private void StopRendering()
        {
            CompositionTarget.Rendering -= RenderFrame;
            rendering = false;
        }


        public double a;
        List<Star> Star_list = new List<Star>();
        private void RenderFrame(object sender, EventArgs e)
        {
            if (Star_list.Count == 0)
            {
                int ellipseCount = 5;
                for (int i = 0; i < ellipseCount; i++)
                {
                    //квадрат
                    Polygon polygon = new Polygon();
                    polygon.Points = PointCollection.Parse("126, 126, 174, 126, 174, 174, 126,174");
                    polygon.Fill = Brushes.Black;
                    canvas.Children.Add(polygon);


                    //звездочка
                    Star star = new Star();
                    canvas.Children.Add(star.Polygon0);
                    Star_list.Add(star);

                }
            }
            else
            {
                for (int i = Star_list.Count - 1; i >= 0; i--)
                {

                    Star_list[i].Next();
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            foreach (var l in Star_list)
            {
                l.Speed1();
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            
           foreach (var l in Star_list)
            {
                    l.Speed2();
                
 
            }
        }
    }


}


