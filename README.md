# TicketBot
Discord

In this example, when a user calls the !createTicket command, the bot creates a new text channel with the name ticket-{userId}, where userId is the identifier of the user who invoked the command. Permissions are then set for the channel, allowing only that user to view and send messages in it. The bot sends a message to the new channel and replies in the current channel with a link to the new channel.

Please note that you will need to add the Discord.Net library to your project for this code to work. Additionally, make sure to handle errors and add any additional functionality you may need.
