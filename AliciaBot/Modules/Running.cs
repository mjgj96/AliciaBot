using AliciaBot;
using Discord;
using Discord.Commands;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace AliciaBot.Modules
{
    public class Channel
    {
        static public String[] channels = { "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   ", "   " };
    }

    [Group("running")]
    public class Running : ModuleBase<SocketCommandContext>
    {
        public async Task Delete()
        {
            string channelID = Context.Channel.Id.ToString();

            if (channelID == "448372488292925440" || channelID == "453078109684498433")
            {
                var messages = await Context.Channel.GetMessagesAsync(10).Flatten();
                await Context.Channel.DeleteMessagesAsync(messages);                
            }
            else
            {
                await Context.Message.DeleteAsync();
                await ReplyAsync("```Wrong Channel!```");
            }
        }

        [Command]
        public async Task Run(int ch)
        {
            await Delete();

            EmbedBuilder builder = new EmbedBuilder();

            if (ch < 1 || 20 < ch)
            {
                return;
            }
            else if (Channel.channels[ch - 1].Equals("   "))
            {
                Channel.channels.SetValue("X", ch - 1);

                builder.WithTitle("Updated Channels")
                    .WithDescription($"{Context.User.Mention} has marked CH. {ch} as occupied.")
                    .AddInlineField("CH. 1", "[" + Channel.channels[0] + "]")
                    .AddInlineField("CH. 2", "[" + Channel.channels[1] + "]")
                    .AddInlineField("CH. 3", "[" + Channel.channels[2] + "]")
                    .AddInlineField("CH. 4", "[" + Channel.channels[3] + "]")
                    .AddInlineField("CH. 5", "[" + Channel.channels[4] + "]")
                    .AddInlineField("CH. 6", "[" + Channel.channels[5] + "]")
                    .AddInlineField("CH. 7", "[" + Channel.channels[6] + "]")
                    .AddInlineField("CH. 8", "[" + Channel.channels[7] + "]")
                    .AddInlineField("CH. 9", "[" + Channel.channels[8] + "]")
                    .AddInlineField("CH. 10", "[" + Channel.channels[9] + "]")
                    .AddInlineField("CH. 11", "[" + Channel.channels[10] + "]")
                    .AddInlineField("CH. 12", "[" + Channel.channels[11] + "]")
                    .AddInlineField("CH. 13", "[" + Channel.channels[12] + "]")
                    .AddInlineField("CH. 14", "[" + Channel.channels[13] + "]")
                    .AddInlineField("CH. 15", "[" + Channel.channels[14] + "]")
                    .AddInlineField("CH. 16", "[" + Channel.channels[15] + "]")
                    .AddInlineField("CH. 17", "[" + Channel.channels[16] + "]")
                    .AddInlineField("CH. 18", "[" + Channel.channels[17] + "]")
                    .AddInlineField("CH. 19", "[" + Channel.channels[18] + "]")
                    .AddInlineField("CH. 20", "[" + Channel.channels[19] + "]")
                    .AddInlineField("Current Time", DateTimeOffset.UtcNow)
                    .WithColor(Color.Green);
                
                await ReplyAsync("", false, builder.Build());
            }
            else if (Channel.channels[ch - 1].Equals("X"))
            {

                builder.WithTitle("Channel Is Currently Occupied")
                    .WithDescription("Please check below for the current list of channels.")
                    .AddInlineField("CH. 1", "[" + Channel.channels[0] + "]")
                    .AddInlineField("CH. 2", "[" + Channel.channels[1] + "]")
                    .AddInlineField("CH. 3", "[" + Channel.channels[2] + "]")
                    .AddInlineField("CH. 4", "[" + Channel.channels[3] + "]")
                    .AddInlineField("CH. 5", "[" + Channel.channels[4] + "]")
                    .AddInlineField("CH. 6", "[" + Channel.channels[5] + "]")
                    .AddInlineField("CH. 7", "[" + Channel.channels[6] + "]")
                    .AddInlineField("CH. 8", "[" + Channel.channels[7] + "]")
                    .AddInlineField("CH. 9", "[" + Channel.channels[8] + "]")
                    .AddInlineField("CH. 10", "[" + Channel.channels[9] + "]")
                    .AddInlineField("CH. 11", "[" + Channel.channels[10] + "]")
                    .AddInlineField("CH. 12", "[" + Channel.channels[11] + "]")
                    .AddInlineField("CH. 13", "[" + Channel.channels[12] + "]")
                    .AddInlineField("CH. 14", "[" + Channel.channels[13] + "]")
                    .AddInlineField("CH. 15", "[" + Channel.channels[14] + "]")
                    .AddInlineField("CH. 16", "[" + Channel.channels[15] + "]")
                    .AddInlineField("CH. 17", "[" + Channel.channels[16] + "]")
                    .AddInlineField("CH. 18", "[" + Channel.channels[17] + "]")
                    .AddInlineField("CH. 19", "[" + Channel.channels[18] + "]")
                    .AddInlineField("CH. 20", "[" + Channel.channels[19] + "]")
                    .AddInlineField("Current Time", DateTimeOffset.UtcNow)
                    .WithColor(Color.Green);

                await ReplyAsync("!purge 3", false, builder.Build());
            }
        }
    }

    [Group("done")]
    public class Done : ModuleBase<SocketCommandContext>
    {
        public async Task Delete()
        {
            string channelID = Context.Channel.Id.ToString();

            if (channelID == "448372488292925440" || channelID == "453078109684498433")
            {
                if (Context.User.Id == 453023967587074048 || Context.User.Id == 184819362069217280)
                {
                    var messages = await Context.Channel.GetMessagesAsync(2).Flatten();

                    await Context.Channel.DeleteMessagesAsync(messages);
                }
                else
                {
                    await Context.Message.DeleteAsync();
                    await ReplyAsync("***```You don't have access!```***");
                }
            }
            else
            {
                await Context.Message.DeleteAsync();
                await ReplyAsync("```Wrong Channel!```");
            }
        }

        [Command]
        public async Task Finish(string input)
        {
            int ch = Convert.ToInt32(input);

            await Delete();

            EmbedBuilder builder = new EmbedBuilder();

            if (ch < 1 || 20 < ch)
            {
                return;
            }
            else if (Channel.channels[ch - 1].Equals("X"))
            {
                Channel.channels.SetValue("   ", ch - 1);

                builder.WithTitle("Updated Channels")
                    .WithDescription($"{Context.User.Mention} has marked CH. {ch} as unoccupied.")
                    .AddInlineField("CH. 1", "[" + Channel.channels[0] + "]")
                    .AddInlineField("CH. 2", "[" + Channel.channels[1] + "]")
                    .AddInlineField("CH. 3", "[" + Channel.channels[2] + "]")
                    .AddInlineField("CH. 4", "[" + Channel.channels[3] + "]")
                    .AddInlineField("CH. 5", "[" + Channel.channels[4] + "]")
                    .AddInlineField("CH. 6", "[" + Channel.channels[5] + "]")
                    .AddInlineField("CH. 7", "[" + Channel.channels[6] + "]")
                    .AddInlineField("CH. 8", "[" + Channel.channels[7] + "]")
                    .AddInlineField("CH. 9", "[" + Channel.channels[8] + "]")
                    .AddInlineField("CH. 10", "[" + Channel.channels[9] + "]")
                    .AddInlineField("CH. 11", "[" + Channel.channels[10] + "]")
                    .AddInlineField("CH. 12", "[" + Channel.channels[11] + "]")
                    .AddInlineField("CH. 13", "[" + Channel.channels[12] + "]")
                    .AddInlineField("CH. 14", "[" + Channel.channels[13] + "]")
                    .AddInlineField("CH. 15", "[" + Channel.channels[14] + "]")
                    .AddInlineField("CH. 16", "[" + Channel.channels[15] + "]")
                    .AddInlineField("CH. 17", "[" + Channel.channels[16] + "]")
                    .AddInlineField("CH. 18", "[" + Channel.channels[17] + "]")
                    .AddInlineField("CH. 19", "[" + Channel.channels[18] + "]")
                    .AddInlineField("CH. 20", "[" + Channel.channels[19] + "]")
                    .AddInlineField("Current Time", DateTimeOffset.UtcNow)
                    .WithColor(Color.Blue);

                await ReplyAsync("!purge 3", false, builder.Build());
            }
            else if (Channel.channels[ch - 1].Equals("   "))
            {

                builder.WithTitle("Channel Was Already Empty")
                    .WithDescription("Please check below for the current list of channels.")
                    .AddInlineField("CH. 1", "[" + Channel.channels[0] + "]")
                    .AddInlineField("CH. 2", "[" + Channel.channels[1] + "]")
                    .AddInlineField("CH. 3", "[" + Channel.channels[2] + "]")
                    .AddInlineField("CH. 4", "[" + Channel.channels[3] + "]")
                    .AddInlineField("CH. 5", "[" + Channel.channels[4] + "]")
                    .AddInlineField("CH. 6", "[" + Channel.channels[5] + "]")
                    .AddInlineField("CH. 7", "[" + Channel.channels[6] + "]")
                    .AddInlineField("CH. 8", "[" + Channel.channels[7] + "]")
                    .AddInlineField("CH. 9", "[" + Channel.channels[8] + "]")
                    .AddInlineField("CH. 10", "[" + Channel.channels[9] + "]")
                    .AddInlineField("CH. 11", "[" + Channel.channels[10] + "]")
                    .AddInlineField("CH. 12", "[" + Channel.channels[11] + "]")
                    .AddInlineField("CH. 13", "[" + Channel.channels[12] + "]")
                    .AddInlineField("CH. 14", "[" + Channel.channels[13] + "]")
                    .AddInlineField("CH. 15", "[" + Channel.channels[14] + "]")
                    .AddInlineField("CH. 16", "[" + Channel.channels[15] + "]")
                    .AddInlineField("CH. 17", "[" + Channel.channels[16] + "]")
                    .AddInlineField("CH. 18", "[" + Channel.channels[17] + "]")
                    .AddInlineField("CH. 19", "[" + Channel.channels[18] + "]")
                    .AddInlineField("CH. 20", "[" + Channel.channels[19] + "]")
                    .AddInlineField("Current Time", DateTimeOffset.UtcNow)
                    .WithColor(Color.Blue);

                await ReplyAsync("!purge 3", false, builder.Build());
            }
        }
    }
}
