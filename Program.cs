using DesafioPOO.Models;

Console.WriteLine("Smarthphone Nokia");
Nokia nk = new Nokia("999887766", "Zenfone 5", "152489965874", 64);
nk.Ligar();
nk.ReceberLigacao();
nk.InstalarAplicativo("WhatsApp");

Console.WriteLine("Smarthphone Iphone");
Iphone ip = new Iphone("933221166", "Iphone X", "98798745874", 256);
ip.Ligar();
ip.ReceberLigacao();
ip.InstalarAplicativo("Telegram");