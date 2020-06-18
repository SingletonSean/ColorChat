using ColorChat.WPF.ViewModels;
using System.Windows;

namespace ColorChat.WPF
{
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            ColorChatViewModel chatViewModel = new ColorChatViewModel();

            MainWindow window = new MainWindow
            {
                DataContext = new MainViewModel(chatViewModel)
            };

            window.Show();
        }
    }
}
