using KeyBinderV1.ViewModel;
using System.Windows;

namespace KeyBinderV1.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new BindManager();
        }
    }
}
