namespace ColorChat.WPF.ViewModels
{
    public class MainViewModel
    {
        public ColorChatViewModel ColorChatViewModel { get; }

        public MainViewModel(ColorChatViewModel chatViewModel)
        {
            ColorChatViewModel = chatViewModel;
        }
    }
}
