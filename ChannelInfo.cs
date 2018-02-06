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
    public class ChannelInfo : ModuleBase<SocketCommandContext>
    {

        [Command("ServerInfo"), Summary("Lists all Server Info!")]
        [Alias("server", "sinfo", "info")]
        public async Task Info()
        {
            EmbedBuilder embedBuilder;
            embedBuilder = new EmbedBuilder()
                .WithColor(Color.Red);


            var gld = Context.Guild as SocketGuild;
            var client = Context.Client as DiscordSocketClient;

            if (!String.IsNullOrWhiteSpace(gld.IconUrl))
                embedBuilder.ThumbnailUrl = gld.IconUrl;
            var o = gld.Owner.Username;

            var v = gld.VoiceRegionId;
            var c = gld.CreatedAt;
            var n = gld.DefaultMessageNotifications;
            var VL = gld.VerificationLevel;
            var XD = gld.Roles.Count;
            var X = gld.MemberCount;
            var Z = client.ConnectionState;


            embedBuilder.WithTitle($"__{gld.Name} Server Information__")
                .WithDescription($"Server Owner: **{o}**\n" +
                $" Voice Region: **{v}**\n" +
                $" Created At: **{c}**\n" +
                $" MsgNotif: **{n}**\n" +
                $" Verification: **{VL}**\n" +
                $" Role Amount: **{XD}**\n" +
                $" Member Amount: **{X}**\n" +
                $" Status: **{Z}**\n");

            await ReplyAsync("", false, embedBuilder);


        }




    }
}
