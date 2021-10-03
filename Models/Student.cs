using System.Windows;

namespace WPFLabies.Models
{
    public class Student : DependencyObject
    {
        public static readonly DependencyProperty FirstNameProperty;
        public static readonly DependencyProperty LastNameProperty;
        public static readonly DependencyProperty GroupProperty;
        public static readonly DependencyProperty CourseProperty;

        
        
        static Student()
        {
            FirstNameProperty = DependencyProperty.Register("FirstName", typeof(string), typeof(Student));
            LastNameProperty = DependencyProperty.Register("LastName", typeof(string), typeof(Student));
            GroupProperty = DependencyProperty.Register("Group", typeof(int), typeof(Student));
            CourseProperty = DependencyProperty.Register("Course", typeof(int), typeof(Student));
        }

        public string FirstName
        {
            get { return (string) GetValue(FirstNameProperty); }
            set { SetValue(FirstNameProperty, value); }
        }

        public string LastName
        {
            get { return (string) GetValue(LastNameProperty); }
            set { SetValue(LastNameProperty, value); }
        }

        public int Group
        {
            get { return (int) GetValue(GroupProperty); }
            set { SetValue(GroupProperty, value); }
        }

        public int Course
        {
            get { return (int) GetValue(CourseProperty); }
            set { SetValue(CourseProperty, value); }
        }

        public override string ToString()
        {
            return $"{FirstName} {LastName} {Group} {Course}";
        }
    }
}