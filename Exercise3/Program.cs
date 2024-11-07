using Exercise3;

Console.WriteLine("Hello, World!");

var messageHandler = new MessageHandler();
messageHandler.OnSendMessage += (sender)
messageHandler.SendMessage("Test1234");
messageHandler.SendMessage("Test12345");
messageHandler.SendMessage("Test123456");
messageHandler.SendMessage("Test1234567");