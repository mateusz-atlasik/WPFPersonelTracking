using Microsoft.EntityFrameworkCore;
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
using WPFPersonelTracking.DB;
using WPFPersonelTracking.ViewModels;

namespace WPFPersonelTracking
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

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            using (PersonelTrackingContext db = new PersonelTrackingContext())
            { 
                
            }
        }

        private void btnDepartment_Click(object sender, RoutedEventArgs e)
        {
            lblWindowName.Content = "Lista Działów";
            DataContext = new DepartmentViewModel();
        }

        private void btnPosition_Click(object sender, RoutedEventArgs e)
        {
            lblWindowName.Content = "Lista Stanowisk";
            DataContext = new PositionViewModel();
        }
    }
}
