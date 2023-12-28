using System.ComponentModel;
using DesafioPOO.Models;

Smartphone nokia1 = new Nokia(numero:"21 97372-8999", modelo:"Nokia", imei:"12345", memoria: 128);

Smartphone iphone1 = new Iphone(numero:"21 97692-6622", modelo:"Iphone", imei:"13579", memoria: 128);

nokia1.Ligar();
Console.WriteLine("\n");
iphone1.Ligar();
Console.WriteLine("\n");

iphone1.InstalarAplicativo("Whatsapp");
iphone1.ReceberLigacao();
