using System;
using System.Windows;

namespace WPFLabies.Models
{
   
    
    public class Himan : DependencyObject
    {
        public static readonly DependencyProperty NameProperty;
        public static readonly DependencyProperty SurnameProperty;
        public static readonly DependencyProperty AgeProperty;
        
        static Himan()
        {
            NameProperty = DependencyProperty.Register("Name", typeof(string), typeof(Himan));
            SurnameProperty = DependencyProperty.Register("Surname", typeof(string), typeof(Himan));
            AgeProperty = DependencyProperty.Register("Age", typeof(int), typeof(Himan));
        }
        public string Name
        {
            get { return (string) GetValue(NameProperty); }
            set { SetValue(NameProperty, value); }
        }
        
        public string Surname
        {
            get { return (string) GetValue(SurnameProperty); }
            set { SetValue(SurnameProperty, value); }
        }
        
        public int Age
        {
            get { return (int) GetValue(AgeProperty); }
            set { SetValue(AgeProperty, value); }
        }
        
        public override string ToString()
        {
            return $"{Name} {Surname} {Age}";
        }
    }
}