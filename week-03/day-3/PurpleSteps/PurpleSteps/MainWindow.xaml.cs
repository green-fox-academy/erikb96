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

namespace PurpleSteps
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var FoxDraw = new FoxDraw(canvas);
            Stepper(FoxDraw);
        }
        public static void Stepper(FoxDraw foxDraw)
        {
            int x = 10;
            int y = 10;
            for (int i = 1; i < 20; i++)
            {
                foxDraw.FillColor(Colors.MediumPurple);
                foxDraw.DrawRectangle(x, y, 25, 25);
                x = x + 25;
                y = y + 25;
            }
        }
    }
}
