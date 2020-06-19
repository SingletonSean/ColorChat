using ColorChat.Domain.Models;
using Microsoft.AspNetCore.SignalR.Client;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ColorChat.WPF.Services
{
    public class SignalRChatService
    {
        private readonly HubConnection _connection;

        public event Action<ColorChatColor> ColorMessageReceived;

        public SignalRChatService(HubConnection connection)
        {
            _connection = connection;

            _connection.On<ColorChatColor>("ReceiveColorMessage", (color) => ColorMessageReceived?.Invoke(color));
        }

        public async Task Connect()
        {
            await _connection.StartAsync();
        }

        public async Task SendColorMessage(ColorChatColor color)
        {
            await _connection.SendAsync("SendColorMessage", color);
        }
    }
}
