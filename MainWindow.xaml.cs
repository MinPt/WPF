
using WPFLabies.Models;

namespace WPFLabies
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        private readonly Himan _human = new Himan()
        {
            Name = "Petro",
            Surname = "Minailiuk",
            Age = 19,
        };
        public Himan Himan => _human;
        public MainWindow()
        {
            InitializeComponent();
            
            DataContext = _human;
        }
    }
}