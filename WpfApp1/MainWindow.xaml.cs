using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
using WpfApp1.Models;

namespace WpfApp1
{

    public partial class MainWindow : Window
    {
        public ObservableCollection<Car>? Cars { get; set; }
        public MainWindow()
        {
            Cars = new ObservableCollection<Car>();
            Cars.Add(new Car() { Model = "Tesla", Vendor = "ModelS", Year = "2020" });
            Cars.Add(new Car() { Model = "Hunday", Vendor = "Elantra", Year = "2016" });
            Cars.Add(new Car() { Model = "BMW", Vendor = "x5", Year = "2022" });
            InitializeComponent();
            DataContext = this;
        }

        private void ListView_PreviewMouseDoubleClick(object sender, System.Windows.Input.MouseButtonEventArgs e)
        {
            UpdateWindows update_AddWindow = new UpdateWindows();
            update_AddWindow.Car = (sender as ListView).SelectedItem as Car;
            update_AddWindow.Text = "Update";
            update_AddWindow.ShowDialog();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            UpdateWindows update_AddWindow = new UpdateWindows();
            update_AddWindow.Text = "Add";
            update_AddWindow.ShowDialog();
            Cars.Add(update_AddWindow.Car);
        }
    }
}