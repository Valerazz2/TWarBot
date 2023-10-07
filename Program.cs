using Telegram.Bot;
using Telegram.Bot.Types;

class TBot
{
    private List<long> ids = new List<long>();
    public static void Main()
    {
        TelegramBotClient client = new TelegramBotClient("6516365462:AAGl4piCfELIn6TBd12OVFCyJq9ZwADHUWI");
        client.StartReceiving(Update, Exeption);
        Console.ReadLine();
    }

    private static void Exeption(ITelegramBotClient botClient, Exception update, CancellationToken token)
    {
        throw new Exception("Ex");
    }

    private static async void Update(ITelegramBotClient botClient, Update update, CancellationToken token)
    {
        var msg = update.Message;
        var id = msg?.Chat.Id;

        if (msg?.Text != null)
        {
            if (msg.Text.Contains())
            {
                
            }
            await botClient.SendTextMessageAsync();
        }
      
    }
    
    
}