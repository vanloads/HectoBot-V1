using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HectoBot_V1.Modules
{
    public class Bitch : ModuleBase<SocketCommandContext>
    {
        [Command("Bitch"), Summary("Says something honest.")]
        [Alias("bitch", "female", "dog")]
        public async Task BitchAsync()
        {
            EmbedBuilder builder = new EmbedBuilder();

            builder.WithTitle("Bitch")
                .WithDescription("I personally believe you to be a fucking Bitch.")
                .WithColor(Color.Orange);

            await ReplyAsync("", true, builder.Build());

        }
    }
    public class Fuck : ModuleBase<SocketCommandContext>
    {
        [Command("Tomato"), Summary("Utilizes the ImageUrl func")]
        [Alias("Goat", "Cute")]
        public async Task TomatoAsync()
        {
            EmbedBuilder builder = new EmbedBuilder();

            builder.WithImageUrl("http://i65.tinypic.com/4r97kp.jpg")
                .WithDescription("This is a fucking tomato.")
                .WithColor(Color.Purple);

            await ReplyAsync("", false, builder.Build());
        }
    }
    public class w0nder : ModuleBase<SocketCommandContext>
    {
        [Command("w0nder"), Summary("Displays Santi's Videos")]
        [Alias("Santiago")]
        public async Task w0nderAsync()
        {
            EmbedBuilder builder = new EmbedBuilder();

            builder.WithTitle("__w0nder__")
                .WithDescription("*aka Santi*")
                .WithColor(Color.Green)
                .WithImageUrl("https://media.giphy.com/media/l0GRkzJhkMlJotMFq/giphy.gif");


            // Social Media Field *BETA*
            builder.AddField("Watch w0nder play your favorite games LIVE! :)", "[Twitch](https://www.twitch.tv/w0nder_what)")
                .AddField("Discover w0nder's stream highlights and more! :)", "[YouTube](https://www.youtube.com/user/xSneakyFoxX)")
                .AddField("Get the lastest and greatest news, straight from w0nder! :)", "[Twitter](https://twitter.com/santirend0n)");
            await ReplyAsync("", false, builder.Build());


            // Social Media Links
            //  builder.WithTitle("w0nder")
            //      .WithColor(Color.Green)
            //  .WithDescription("[Twitch](https://www.twitch.tv/w0nder_what) " +
            // "[YouTube](https://www.youtube.com/user/xSneakyFoxX) " +
            //  "[Twitter](https://twitter.com/santirend0n)")

            // Images
            // builder.WithThumbnailUrl("https://cdn.discordapp.com/attachments/396131592591900672/409565974421962761/4803049a93e73306c59a627e5baacde1.png")
            //.WithImageUrl("https://media.giphy.com/media/l0GRkzJhkMlJotMFq/giphy.gif");


            EmbedFooterBuilder footbuilder = new EmbedFooterBuilder();

            footbuilder.WithText("Don't Forget to Like and Subscribe");
            footbuilder.WithIconUrl("https://cdn.discordapp.com/attachments/396131592591900672/409565974421962761/4803049a93e73306c59a627e5baacde1.png");
            builder.WithFooter(footbuilder);

            EmbedAuthorBuilder authorbuilder = new EmbedAuthorBuilder();

            authorbuilder.WithName("w0nder");
            authorbuilder.WithIconUrl("https://cdn.discordapp.com/attachments/396131592591900672/409565974421962761/4803049a93e73306c59a627e5baacde1.png");


        }
    }

}
  


