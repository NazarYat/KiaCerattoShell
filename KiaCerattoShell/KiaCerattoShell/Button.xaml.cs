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
    /// Interaction logic for Button.xaml
    /// </summary>
    public partial class Button : UserControl
    {
        public ImageSource Source 
        {
            get => ButtonImage.Source;
            set
            {
                if (value == ButtonImage.Source) return;

                ButtonImage.Source = value;
            }
        }
        public Button()
        {
            InitializeComponent();
        }
    }
}
