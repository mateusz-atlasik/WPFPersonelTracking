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

namespace WPFPersonelTracking.Views
{
    /// <summary>
    /// Logika interakcji dla klasy PositionList.xaml
    /// </summary>
    public partial class PositionList : UserControl
    {
        public PositionList()
        {
            InitializeComponent();
        }
        PersonelTrackingContext db = new PersonelTrackingContext();
        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            var list = db.Positions
                .Include(x => x.Department)
                .Select(a => new 
                { 
                    positionId=a.Id, PositionName=a.PositionName, 
                    DepartmentId=a.DepartmentId, DepartmentName=a.Department.DepartmentName
                })
                .OrderBy(x=>x.PositionName)
                .ToList();
        }
    }
}
