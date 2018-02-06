using Discord;
using Discord.Commands;
using Discord.WebSocket;
using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace HectoBot_V1.Modules
{
    public class UserInformation : ModuleBase
    {
        [Command("User"), Summary("Displays basic info for every User")]
        [Alias("user", "UserInfo")]

        public async Task UserInfo(IGuildUser user);

        var application = await Context.Client.GetApplicationInfoAsync();
        var date = $"{User.CreatedAt.Month}/{User.CreatedAt.Day}/{User.CreatedAt.Year}";




        EmbedBuilder embedBuilder;
        embedBuilder = new EmbedBuilder()
        { 
            embedBuilder.WithTitle("__User Information!__")
                .WithColor(Color.Orange);
        }

        await ReplyAsync("", false, embedBuilder(UserInfo);

        
    }
}
