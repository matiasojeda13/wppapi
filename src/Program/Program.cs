using System;

namespace WhatsAppApiUCU
{
    class Program 
    {
        static void Main(string[] args)
        { 
            const string accountSid = "AC52493b284c82ba2c6b196ef82e412576";
            const string authToken = "f027e9b15f3777950cdb0179f159a35d";

            var whatsApp = new WhatsAppApi(accountSid, authToken);
            string sid = whatsApp.Send("+598<Poné tu teléfono acá>", "Hey there! I'm using WhatsAppUCU");
            Console.WriteLine(sid);
        }
    }
}
