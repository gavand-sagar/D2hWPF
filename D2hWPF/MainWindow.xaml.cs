using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace D2hWPF
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

        private void About_Button_Click(object sender, RoutedEventArgs e)
        {
            this.ContactPage.Visibility = Visibility.Hidden;
            this.GalleryPage.Visibility = Visibility.Hidden;
            this.dataResult.Visibility = Visibility.Hidden;
            this.AboutPage.Visibility = Visibility.Visible;
        }

        private void Contact_Button_Click(object sender, RoutedEventArgs e)
        {
            this.GalleryPage.Visibility = Visibility.Hidden;
            this.AboutPage.Visibility = Visibility.Hidden;
            this.dataResult.Visibility = Visibility.Hidden;
            this.ContactPage.Visibility = Visibility.Visible;
        }

        private void Gallery_Button_Click(object sender, RoutedEventArgs e)
        {
            this.ContactPage.Visibility = Visibility.Hidden;
            this.AboutPage.Visibility = Visibility.Hidden;
            this.dataResult.Visibility = Visibility.Hidden;
            this.GalleryPage.Visibility = Visibility.Visible;
        }



        private void Dashboard_Button_Click(object sender, RoutedEventArgs e)
        {
            this.Visibility = Visibility.Hidden;

            Dashboard d = new Dashboard();

            d.Visibility = Visibility.Visible;
        }

        private void Get_Users(object sender, RoutedEventArgs e)
        {
            this.ContactPage.Visibility = Visibility.Hidden;
            this.AboutPage.Visibility = Visibility.Hidden;
            this.GalleryPage.Visibility = Visibility.Hidden;
            this.dataResult.Visibility = Visibility.Visible;



            dataResult.ItemsSource = new List<Person>() {
                new Person(){ Id=1002,Name="Sanket"},
                new Person(){ Id=23432,Name="Sagar"},
                new Person(){ Id=435,Name="Atharva",Group="A"},
                new Person(){ Id=445,Name="Yogesh"},
                new Person(){ Id=785,Name="Suraj",Group="A"},
            };
        }
    }


    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Contact { get; set; }
        public string Group { get; set; }
    }
}
