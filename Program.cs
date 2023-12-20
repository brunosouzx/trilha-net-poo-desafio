using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia");
Smartphone nokia = new Nokia(numero: "123456", modelo: "x1", imei: "1111111111", memoria: 32);
nokia.Ligar();
nokia.InstalarAplicativo("FaceBook");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
Smartphone iphone = new Iphone(numero: "9852263", modelo: "15 Pro Max", imei: "2222222222", memoria: 512);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("WhatsApp");