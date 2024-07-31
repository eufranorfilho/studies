using System;
using desafio_poo_dio.Models;

Smartphone nokia = new Nokia();

Smartphone iphone = new Iphone();

Smartphone nokia2 = new Nokia("84998223344", "Lumia 35", "XSY344534", 8);
Smartphone iphone2 = new Iphone("84998223344", "Iphone XR", "IMED345F5", 16);


nokia.Ligar();
iphone.Ligar();

nokia.ReceberLigacao();
iphone.ReceberLigacao();

nokia.InstalarAplicativo("Instagram");
iphone.InstalarAplicativo("whatsapp");

Console.WriteLine(nokia);
Console.WriteLine(iphone);
Console.WriteLine("-----------------------------------");
nokia2.Ligar();
iphone2.Ligar();

nokia2.ReceberLigacao();
iphone2.ReceberLigacao();

nokia2.InstalarAplicativo("Instagram");
iphone2.InstalarAplicativo("whatsapp");

Console.WriteLine(nokia2);
Console.WriteLine(iphone2);


