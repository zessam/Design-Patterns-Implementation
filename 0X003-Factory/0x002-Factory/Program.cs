// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

Client c1 = new Client();
var AE = c1.getbrand("AE");
var a = AE.create_jackets();
a.fabric();

Client c2 = new Client();
var Chanel = c2.getbrand("Chanel");
var c = Chanel.create_jackets();
c.fabric();

Client c3 = new Client();
var Dior = c3.getbrand("Dior");
var d = Dior.create_jackets();
d.fabric();


Client c4 = new Client();
var LV = c4.getbrand("LV");
var l = LV.create_jackets();
l.fabric();