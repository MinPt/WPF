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


        private void RangeBase_OnValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            if (this.Choose == null)
            {
                return;
            }
            switch (this.Choose.SelectedIndex)
            {
                case 0:
                {
                    this.MyImage1.Width = this.MySlider.Value;
                }
                    break;
                case 1:
                {
                    this.MyImage2.Width = this.MySlider.Value;
                }
                    break;
            }
        }
    }
}