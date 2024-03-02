using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KiaCerattoShell
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            DataContext = new MainWindowViewModel();
        }

        private void DoubleAnimation_Completed(object sender, EventArgs e)
        {
            LoadingScreen.Visibility = Visibility.Collapsed;

            if (DataContext is MainWindowViewModel viewModel)
            {
                viewModel.LoadContent(new MainMenu());
            }
        }
    }
}
