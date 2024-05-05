

var names = new List<string>()
{
    "Larrysalsa", "Jennifer", "Roberto", "Hugo", "Pedro"  //origen de datos


};
var namesResult = (from n in names
                   where n.Length > 3 && n.Length < 5
                   orderby n ascending  //descending 
                   select n).ToList();                 //consulta de datos


foreach (var name in namesResult)
{                                       //ejecucion de datos
    Console.WriteLine(name);
}
