using ColorChat.Domain.Models;
using ColorChat.WPF.Services;
using ColorChat.WPF.ViewModels;
using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Windows.Input;

namespace ColorChat.WPF.Commands
{
    public class SendColorChatColorMessageCommand : ICommand
    {
        private readonly ColorChatViewModel _viewModel;
        private readonly SignalRChatService _chatService;

        public SendColorChatColorMessageCommand(ColorChatViewModel viewModel, SignalRChatService chatService)
        {
            _viewModel = viewModel;
            _chatService = chatService;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public async void Execute(object parameter)
        {
            try
            {
                await _chatService.SendColorMessage(new ColorChatColor()
                {
                    Red = _viewModel.Red,
                    Green = _viewModel.Green,
                    Blue = _viewModel.Blue,
                });

                _viewModel.ErrorMessage = string.Empty;
            }
            catch (Exception)
            {
                _viewModel.ErrorMessage = "Unable to send color message.";
            }
        }
    }
}
