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

namespace RainbowBoxFunction
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
        public static void SquareDrawer(FoxDraw foxDrawer)
        {
           
            double x = 250;

            Random rnd = new Random();
            for (int i = 0; i < 7; i++)
            {
                
                foxDrawer.FillColor(Color.FromRgb((byte)rnd.Next(), (byte)rnd.Next(), (byte)rnd.Next()));
                foxDrawer.DrawRectangle(300 - x/2 , 300 - x/2 , x, x);
                x = x - i * 10;
            }
        }
    }
}
// create a square drawing function that takes 2 parameters:
// the square size, and the fill color,
// and draws a square of that size and color to the center of the canvas.
// create a loop that fills the canvas with rainbow colored squares.