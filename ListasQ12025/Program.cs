
List<string> listaString = new List<string>();
listaString.Add("Naranja");
listaString.Add("5");
listaString.Add("Real España");
listaString.Add("Barcelona");
listaString.Add("Real Madrid");
listaString.Add("Real Madrid");
listaString.Add("Alajuela");
listaString.Insert(0, "Real Madrid");
//listaString.Remove("Real Madrid");
//listaString.RemoveAt(5); // Tener cuidado de no agregar un indice fuera del rango
//listaString.RemoveAll(lista => lista.Contains("Real Madrid"));

foreach (string item in listaString)
{
    //Console.WriteLine($"{listaString.IndexOf(item)}: {item}");
    Console.WriteLine($"Item: {item}");
}
