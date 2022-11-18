using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Iphone");
Iphone iphone = new Iphone("1199999", "14", "213123", 128);
iphone.Ligar();
iphone.InstalarAplicativo("Redtube");
iphone.ReceberLigacao();

Console.WriteLine("/n");

Nokia nokia = new Nokia("1188888", "g5", "33422", 128);
Console.WriteLine($"O numero do telefone é {nokia.Numero}");
nokia.ReceberLigacao();
nokia.InstalarAplicativo("youtube");
