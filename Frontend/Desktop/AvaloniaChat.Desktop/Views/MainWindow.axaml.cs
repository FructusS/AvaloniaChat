using Avalonia.Controls;
using Avalonia.Markup.Xaml;

namespace AvaloniaChat.Desktop.Views
{
    public partial class MainWindow : Window
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }
        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(obj:this);
        }
    }
}
