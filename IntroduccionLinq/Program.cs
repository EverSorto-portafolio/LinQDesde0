string []palabras;
palabras = new string[] { "gato", "perro", "lagarto", "tortuga", "cocdrilo","serpiente", "123456789" };
Console.WriteLine("Mas de 5 letras");

List<string> resultado = new List<string>();

foreach (string str in palabras) {
    if (str.Length >5) {
        resultado.Add(str);
    }
}

foreach (var r in resultado) 
    Console.WriteLine(r);

#region utilizando Linq

Console.WriteLine("-----------------------------------------------------");    
IEnumerable<string> list = from r in palabras where r.Length > 8 select r;
foreach(var listado in list)
    Console.WriteLine(listado);
Console.WriteLine("-----------------------------------------------------");




#endregion