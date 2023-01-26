using DesafioPOO.Models;

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone("11 99999-9999", "Iphone 12", "123456789", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia("11 2256-4544", "Nokia 3310", "987654321", 64);
nokia.ReceberLigacao();
nokia.InstalarAplicativo("Jogo da Velha");

// TODO: Realizar os testes com as classes Nokia e Iphone