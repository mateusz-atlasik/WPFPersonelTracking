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
using System.Windows.Shapes;
using WPFPersonelTracking.DB;

namespace WPFPersonelTracking
{
    /// <summary>
    /// Logika interakcji dla klasy DepartmentPage.xaml
    /// </summary>
    public partial class DepartmentPage : Window
    {
        public DepartmentPage()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
        public Department department;
        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            if(txtDepartmentName.Text.Trim()=="")
            {
                MessageBox.Show("Nazwa działu nie może być pusta");
            }
            else
            {
                using (PersonelTrackingContext db = new PersonelTrackingContext())
                {
                    if(department!=null && department.Id != 0)
                    {
                        Department updateDpt = new Department();
                        updateDpt.DepartmentName = txtDepartmentName.Text;
                        updateDpt.Id = department.Id;
                        db.Departments.Update(updateDpt);
                        db.SaveChanges();
                        MessageBox.Show("Aktualizacja danych przebiegła pomyślnie");
                    }
                    else
                    {
                        Department department = new Department();
                        department.DepartmentName = txtDepartmentName.Text;
                        db.Departments.Add(department);
                        db.SaveChanges();
                        MessageBox.Show("Dział dodany");
                        txtDepartmentName.Text = "";
                    } 
                }
            }
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            if(department!=null && department.Id != 0)
            {
                txtDepartmentName.Text = department.DepartmentName;
            }
        }
    }
}
