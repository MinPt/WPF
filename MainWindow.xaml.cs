using System.Windows;
using System.Windows.Input;

namespace WPFLabies
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public void CommandBinding_Executed(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("HELP MEEE");
        }
        
        public void CommandBinding_Executed2(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("COPY HERE");
        }
        
        public void CommandBinding_Executed3(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Cut Me");
        }
        
        public void CommandBinding_Executed4(object sender, ExecutedRoutedEventArgs e)
        {
            MessageBox.Show("Paste in HERE");
        }
        public MainWindow()
        {
            InitializeComponent();
            this.HelpItem.Command = ApplicationCommands.Help;
            
            CommandBinding commandBinding = new CommandBinding();
            commandBinding.Command = ApplicationCommands.Help;
            commandBinding.Executed += CommandBinding_Executed;
            HelpItem.CommandBindings.Add(commandBinding);

            this.CopyItem.Command = ApplicationCommands.Copy;
            
            CommandBinding copyBind = new CommandBinding();
            copyBind.Command = ApplicationCommands.Copy;
            copyBind.Executed += CommandBinding_Executed2;
            CopyItem.CommandBindings.Add(copyBind);
            
            this.CutItem.Command = ApplicationCommands.Cut;
            
            CommandBinding cutBind = new CommandBinding();
            cutBind.Command = ApplicationCommands.Cut;
            cutBind.Executed += CommandBinding_Executed3;
            CutItem.CommandBindings.Add(cutBind);
            
            this.PastItem.Command = ApplicationCommands.Paste;
            
            CommandBinding pasteBind = new CommandBinding();
            pasteBind.Command = ApplicationCommands.Paste;
            pasteBind.Executed += CommandBinding_Executed4;
            PastItem.CommandBindings.Add(pasteBind);
        }
    }
}