using System;
using System.Windows;
using System.Windows.Controls;

namespace WPFLabies
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        
        
        public MainWindow()
        {
            InitializeComponent();
        }


       

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            if (this.Calendar1.SelectedDate.Value.Date.ToShortDateString() == this.UserInput1.Text)
            {
                MessageBox.Show("GOT IT!!");
            }
        }
    }
}