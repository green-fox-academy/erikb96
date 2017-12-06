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

namespace CenteredSquare
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
            SquareDrawer(foxDraw);
        }
        public static void SquareDrawer(FoxDraw foxDraw)
        {
            var points = new List<Point>();
            points.Add(new Point(145, 155));
            points.Add(new Point(155, 155));
            points.Add(new Point(155, 145));
            points.Add(new Point(145, 145));

            foxDraw.FillColor(Colors.Green);
            foxDraw.DrawPolygon(points);
        }
    }
}
// draw a green 10x10 square to the canvas' center.
