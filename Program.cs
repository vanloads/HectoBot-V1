using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;
using System.Threading.Tasks;


//all Functionality comes from *class Program*
namespace HectoBot_V1
{
    class Program
    {
        static void Main(string[] args) => new Program().RunBotAsync().GetAwaiter().GetResult();

        private DiscordSocketClient _client;
        private CommandService _commands;
        private IServiceProvider _services;

        public async Task RunBotAsync()
        {
            _client = new DiscordSocketClient();
            _commands = new CommandService();

            _services = new ServiceCollection()
                .AddSingleton(_client)
                .AddSingleton(_commands)
                .BuildServiceProvider();

            string botToken = "NDA4NzMyOTM2NDA2NDMzODAy.DVU-6w.rlEd6LeS4awc4jh_1W3zIqsw9YE";

            //event Subscription
            _client.Log += _client_Log;
            _client.UserJoined += AnnounceUserJoined;

            await _client.LoginAsync(TokenType.Bot, botToken);

            await _client.StartAsync();

            await RegisterCommandsAsync();

            await Task.Delay(-1);




        }

        private async Task AnnounceUserJoined(SocketGuildUser user)
        {
            var guild = user.Guild;
            var channel = guild.DefaultChannel;
            await channel.SendMessageAsync($"Welcome, {user.Mention}, to hell!");
        }

        private Task _client_Log(Discord.LogMessage arg)
        {
            Console.WriteLine(arg);

            return Task.CompletedTask;

        }

        private async Task RegisterCommandsAsync()
        {
            _client.MessageReceived += HandleCommandAsync;

            await _commands.AddModulesAsync(Assembly.GetEntryAssembly());

}

        private async Task HandleCommandAsync(SocketMessage arg)
        {
            var message = arg as SocketUserMessage;

            if (message is null || message.Author.IsBot) return;

            int argPos = 0;

            if (message.HasStringPrefix("!", ref argPos) || message.HasMentionPrefix(_client.CurrentUser, ref argPos))
            {
                //context variable
                var context = new SocketCommandContext(_client, message);

                //result variable
                var result = await _commands.ExecuteAsync(context, argPos, _services);

                await _commands.ExecuteAsync(context, argPos, _services);
                if (!result.IsSuccess)
                    Console.WriteLine(result.ErrorReason);
            }
        }
    }
}
