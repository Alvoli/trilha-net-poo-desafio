using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nokia 8.1:");
Nokia N = new Nokia("938571534","Nokia 8.1","1234567890", 128);
N.Ligar();
N.ReceberLigacao();
N.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Iphone XS MAX:");
Iphone I = new Iphone("998765723", "Iphone XS MAX", "987654431", 256);
I.Ligar();
I.ReceberLigacao();
I.InstalarAplicativo("Telegram");