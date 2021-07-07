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

namespace Choices
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

        private void btn_Click(object sender, RoutedEventArgs e)
        {
            if (pen.IsChecked == true)
            {
                lbl.Content = "Pen";
                penimg.Opacity = 1.0;
            }
            if (pen.IsChecked == false)
            {
                penimg.Opacity = 0.0;
            }
            if (pencil.IsChecked == true)
            {
                lbl.Content = "Pencil";
                pencil1.Opacity = 1.0;
            }
            if (pencil.IsChecked == false)
            {
                pencil1.Opacity = 0.0;
            }
            if (phone.IsChecked == true)
            {
                lbl.Content = "Phone";
                phone1.Opacity = 1.0;
            }
            if (phone.IsChecked == false)
            {
                phone1.Opacity = 0.0;
            }
            if (tablet.IsChecked == true)
            {
                lbl.Content = "Tablet";
                tablet1.Opacity = 1.0;
            }
            if (tablet.IsChecked == false)
            {
                tablet1.Opacity = 0.0;
            }
        }

        private void phone_Checked(object sender, RoutedEventArgs e)
        {
        }
        }
    }
