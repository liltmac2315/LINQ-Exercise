


List<string> nailPolishColors = new List<string>() { "Left Your Texts on Red","Tealing Festive", "Silicon Valley Girl"};

nailPolishColors.Add("Big Bluetiful Planet");
nailPolishColors.Add("Force of Nailture");


var orderedColors = nailPolishColors.OrderBy(name  => name.Length);

foreach (var color in orderedColors) 
{
    Console.WriteLine(color);
}