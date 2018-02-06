using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HectoBot_V1.Modules
{
    //FUCKING WORD CMDS BITCH WOOOOOOOO
    public class Hello_World : ModuleBase<SocketCommandContext>
    {
        [Command("ping")]
        public async Task PingAsync()
        {
            await ReplyAsync("Hello World");
        }
    
    }

    public class Hector : ModuleBase<SocketCommandContext>
    {
        [Command("Hector")]
        public async Task PingAsync()
        {
            await ReplyAsync("Fuck Yeah Hector! You're the fucking best! All the people love you!");
        }

    }
    public class Eric : ModuleBase<SocketCommandContext>
    {
        [Command("Eric")]
        public async Task PingAsync()
        {
            await ReplyAsync("You're the fucking best homie! Keep that shit up!");
        }

    }
    public class Santi : ModuleBase<SocketCommandContext>
    {
        [Command("Santi")]
        public async Task PingAsync()
        {
            await ReplyAsync("WOOOOO SAANTIIIII! LETS FUCKING GOOOOOOO BRODIEEE!");
        }

    }
    public class Kyle : ModuleBase<SocketCommandContext>
    {
        [Command("Kyle")]
        public async Task PingAsync()
        {
            await ReplyAsync("Noice shit blooder! Keep that spicy shit up!");
        }

    }
}
