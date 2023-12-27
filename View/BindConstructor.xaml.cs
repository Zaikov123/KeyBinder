using System.Windows;
using KeyBinderV1.ViewModel;

namespace KeyBinderV1.View
{
    /// <summary>
    /// Interaction logic for BindConstructor.xaml
    /// </summary>
    public partial class BindConstructor : Window
    {
        public BindConstructor()
        {
            InitializeComponent();
            DataContext = new BindManager();
        }

        private void ListBox_SelectionChanged(object sender, System.Windows.Controls.SelectionChangedEventArgs e)
        {

        }
    }
}   
