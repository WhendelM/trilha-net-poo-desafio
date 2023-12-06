using DesafioPOO.Models;
Console.WriteLine("Bem-Vindo ao Celular Nokia");
Smartphone nokiacelular = new Nokia(numero: "123456", modelo: "Modelo 1", imei: "12345678", memoria: 128);
nokiacelular.Ligar();
nokiacelular.InstalarAplicativo("Facebook");


Console.WriteLine("\n");

Console.WriteLine("Bem-Vindo ao Celular Iphone");
Smartphone iphonecelular = new Iphone(numero: "654321", modelo: "Modelo 2", imei: "87654321", memoria: 256);
iphonecelular.Ligar();
iphonecelular.InstalarAplicativo("Instagram");
// Programa testado!
