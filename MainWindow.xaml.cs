using System.Windows;
using WPFLabies.Models;

namespace WPFLabies
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private readonly Student _student = new Student
        {
            FirstName = "Petro",
            LastName = "Minailiuk",
            Group = 308,
            Course = 3
        };

        public Student Student => _student;
        
        public MainWindow()
        {
            InitializeComponent();

            DataContext = Student;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(Student.ToString());
        }
    }
}