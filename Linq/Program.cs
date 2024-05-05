

var names = new List<string>()
{
    "Larrysalsa", "Jennifer", "Roberto", "Hugo", "Pedro"  //origen de datos


};
var namesResult = (from n in names
                   orderby n ascending  //descending 
                   select n).ToList();                 //consulta de datos


foreach (var name in namesResult)
{                                       //ejecucion de datos
    Console.WriteLine(name);
}
