using System;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;

public class TicketModule : ModuleBase<SocketCommandContext>
{
    [Command("createTicket")]
    public async Task CreateTicketAsync()
    {
        // Create a new text channel for the ticket
        var ticketChannel = await Context.Guild.CreateTextChannelAsync($"ticket-{Context.User.Id}");
        
        // Set permissions for the channel
        var permissions = new OverwritePermissions(viewChannel: PermValue.Allow, sendMessages: PermValue.Allow);
        await ticketChannel.AddPermissionOverwriteAsync(Context.User, permissions);

        // Send a message to the new channel
        await ticketChannel.SendMessageAsync($"Hello, {Context.User.Mention}! Welcome to your ticket.");

        // Send a message in the current channel with a link to the new channel
        await ReplyAsync($"Ticket created! Please follow this link: {ticketChannel.Mention}");
    }
}
