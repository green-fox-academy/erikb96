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

namespace CenterBoxFunction
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
            SquareDrawing(foxDraw);
        }
        public static void SquareDrawing(FoxDraw foxDraw) 
        {
            double x = 350;
            Random rnd = new Random();
            for (int i = 0; i < 4; i++)
            {
                foxDraw.FillColor(Color.FromRgb((byte)rnd.Next(), (byte)rnd.Next(), (byte)rnd.Next()));
                foxDraw.DrawRectangle(262 - x / 2, 175 - x / 2, x, x);
                x = x - i * 50;
            }
            
        }
    }
}
// create a square drawing function that takes 1 parameter:
// the square size
// and draws a square of that size to the center of the canvas.
// draw 3 squares with that function.
