using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Testes com a classe Iphone");
Iphone iphone15 = new Iphone("+31313123", "iPhone 15", "231312NDQW32", 128);
iphone15.InstalarAplicativo("Twitter");
iphone15.ReceberLigacao();
iphone15.Ligar();

Console.WriteLine("Testes com a classe Nokia");
Nokia n = new Nokia("+123123131", "Nokia 1", "JSDF123MSDF2", 512);
n.InstalarAplicativo("Facebook");
n.ReceberLigacao();
n.Ligar();
