using System.ComponentModel;
using System.Windows;

namespace KiaCerattoShell
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public FrameworkElement? Content { get; set; }
        public event PropertyChangedEventHandler? PropertyChanged;

        public void LoadContent(FrameworkElement content)
        {
            Content = content;
            OnPropertyChanged(nameof(Content));
        }

        protected void OnPropertyChanged(string name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
