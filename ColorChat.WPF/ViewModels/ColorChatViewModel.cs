using System.Collections.ObjectModel;

namespace ColorChat.WPF.ViewModels
{
    public class ColorChatViewModel : ViewModelBase
    {
        private byte _red;
        public byte Red
        {
            get
            {
                return _red;
            }
            set
            {
                _red = value;
                OnPropertyChanged(nameof(Red));
            }
        }

        private byte _green;
        public byte Green
        {
            get
            {
                return _green;
            }
            set
            {
                _green = value;
                OnPropertyChanged(nameof(Green));
            }
        }

        private byte _blue;
        public byte Blue
        {
            get
            {
                return _blue;
            }
            set
            {
                _blue = value;
                OnPropertyChanged(nameof(Blue));
            }
        }

        private string _errorMessage = string.Empty;
		public string ErrorMessage
		{
			get
			{
				return _errorMessage;
			}
			set
			{
				_errorMessage = value;
				OnPropertyChanged(nameof(ErrorMessage));
				OnPropertyChanged(nameof(HasErrorMessage));
			}
		}

		public bool HasErrorMessage => !string.IsNullOrEmpty(ErrorMessage);

		private bool _isConnected;
		public bool IsConnected
		{
			get
			{
				return _isConnected;
			}
			set
			{
				_isConnected = value;
				OnPropertyChanged(nameof(IsConnected));
			}
		}

		public ObservableCollection<ColorChatColorViewModel> Messages { get; }

		public ColorChatViewModel()
		{
			Messages = new ObservableCollection<ColorChatColorViewModel>();
		}
	}
}
