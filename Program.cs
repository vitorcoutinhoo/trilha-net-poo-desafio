using trilha_net_poo_desafio.Models;

Nokia nokia = new("123456789", "Nokia 3310", "123456789", 16);
Iphone iphone = new("987654321", "Iphone 12", "987654321", 128);

System.Console.WriteLine("Nokia:");
nokia.Ligar();
nokia.ReceberChamada();
nokia.InstalarApp("WhatsApp");

System.Console.WriteLine("--------------------");

System.Console.WriteLine("Iphone:");
iphone.Ligar();
iphone.ReceberChamada();
iphone.InstalarApp("WhatsApp");
