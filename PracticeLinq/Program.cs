var videoGames = new List<string>() { "mario", "mario cart", "donkey kong country", "final fantasy", "legend of zelda"};

var orderedGamesByLength = videoGames.OrderBy(x => x.Length);

foreach (var game in orderedGamesByLength)
{
    Console.WriteLine(game);
}