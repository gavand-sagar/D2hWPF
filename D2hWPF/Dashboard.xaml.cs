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

namespace D2hWPF
{
    /// <summary>
    /// Interaction logic for Dashboard.xaml
    /// </summary>
    public partial class Dashboard : Window
    {
        public string Username { get; set; } = "Sagar Gavand";
        public List<Person> Users { get; set; }


        public Dashboard()
        {
            InitializeComponent();
            this.Users = new List<Person>
            {
                new Person(){ Name = "Sagar",Group="D",Id=1},
                new Person(){ Name = "Atharva",Group="C",Id=2},
                new Person(){ Name = "Suraj",Group="B",Id=3},
                 new Person(){ Name = "Sagar",Group="D",Id=1},
                new Person(){ Name = "Atharva",Group="C",Id=2},
                new Person(){ Name = "Suraj",Group="B",Id=3},
                new Person(){ Name = "Sagar",Group="D",Id=1},
                new Person(){ Name = "Atharva",Group="C",Id=2},
                new Person(){ Name = "Suraj",Group="B",Id=3},
                new Person(){ Name = "Suraj",Group="B",Id=3},
                new Person(){ Name = "Suraj",Group="B",Id=3},
            };

            this.DataContext = this;
        }
    }

}
