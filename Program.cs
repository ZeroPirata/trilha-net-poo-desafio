using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Nokia building...");
Smartphone nokia = new Nokia(numero: "4002-8922", modelo: "C24", imei: "123", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");
Console.WriteLine("\n");
Console.WriteLine("Iphone building...");
Smartphone iphone = new Iphone(numero: "4002-8922", modelo: "42", imei: "123", memoria: 256);
iphone.Ligar();
iphone.InstalarAplicativo("FaceBook");