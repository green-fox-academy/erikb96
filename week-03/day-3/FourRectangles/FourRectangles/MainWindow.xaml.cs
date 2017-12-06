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
using GreenFox;

namespace FourRectangles
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var foxDraw = new FoxDraw(canvas);
            RectangleDrawer(foxDraw);
        }
        public static void RectangleDrawer(FoxDraw foxDraw)
        {
            var random = new Random();
            for (int i = 0; i < 4; i++)
                {
                foxDraw.FillColor(Color.FromRgb((byte)random.Next(), (byte)random.Next(), (byte)random.Next()));
                foxDraw.DrawRectangle(random.Next(100), random.Next(200), random.Next(300), random.Next(400));
            }
            
        }
    }
}
// draw four different size and color rectangles.
