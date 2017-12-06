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
namespace ColoredBox
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
            DrawRectangle(foxDraw);
        }
        public static void DrawRectangle(FoxDraw foxDraw)
        {
            foxDraw.StrokeColor(Colors.Aquamarine);
            foxDraw.DrawLine(10, 0, 100, 0);

            foxDraw.StrokeColor(Colors.SeaGreen);
            foxDraw.DrawLine(100, 0, 100, 100);

            foxDraw.StrokeColor(Colors.Salmon);
            foxDraw.DrawLine(100, 100, 10, 100);

            foxDraw.StrokeColor(Colors.Navy);
            foxDraw.DrawLine(10, 0, 10, 100);
        }
    }
}
