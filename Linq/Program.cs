

var names = new List<string>()
{
    "Larrysalsa", "Jennifer", "Roberto", "Hugo", "Pedro"  //origen de datos


};
var namesResult = (from n in names
                   where n.Length > 3 && n.Length < 5
                   orderby n ascending  //descending 
                   select n).ToList();                 //consulta de datos


var namesResult2 = names.Where(n=>n.Length>3 && n.Length < 5) //se puede expresar en funcion y es lo mismo
                          . OrderByDescending(n => n);


foreach (var name in namesResult)
{                                       //ejecucion de datos
    Console.WriteLine(name);
}
