using System;
using System.Windows;

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
            if (int.TryParse(this.MyBox.Text, out var num))
            {
                MessageBox.Show(num.ToString());
            }
            else
            {
                MessageBox.Show(this.MyBox.Text.Length.ToString());
            } ;
            
            
            
        }
    }
}