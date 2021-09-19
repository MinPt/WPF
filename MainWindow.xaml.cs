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
            var val = ((ListBoxItem) this.MyListBox.SelectedValue).Content.ToString();
            

            if (this.CheckBox1.IsChecked.Value)
            {
                val += " Minailiuk";
            }
            if (this.CheckBox2.IsChecked.Value)
            {
                val += " Petro";
            }
            if (this.CheckBox3.IsChecked.Value)
            {
                val += " Sergeevich";
            }

            MessageBox.Show(val);
        }
    }
}