using Smartphone_projeto_.NET.Model;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia(123, "Nokia 3310", "123456789", 16);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");



Console.WriteLine("\nSmartphone Iphone:");
Smartphone iphone = new Iphone(456, "Iphone 12", "987654321", 128);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");
