const int MaximumRed = 12;
const int MaximumGreen = 13;
const int MaximumBlue = 14;

var Total = 0;
string[] lines = File.ReadAllLines("C:\\Users\\Lungelo\\source\\repos\\Day2_Part1\\Day2_Part1\\Input.txt");

foreach (var line in lines) 
{
    var gameInformation = line.Split(':');
    var gameIdentity = int.Parse(gameInformation[0].Split(' ')[1]);
    var rounds = gameInformation[1].Split(';', StringSplitOptions.TrimEntries);
    bool gameValidation = true;
    foreach (var round in rounds)
    {
        
        var colorInformations = round.Split(",", StringSplitOptions.TrimEntries);
        foreach(var color in colorInformations) 
        {
            var colorInformation = color.Split(' ');
            var colorCount = int.Parse(colorInformation[0]);
            var colorName = colorInformation[1];
            switch (colorName) 
            {
                case "red":
                    if(colorCount > MaximumRed) 
                    {
                        gameValidation = false;
                    }
                    break;
                case "green":
                    if (colorCount > MaximumGreen)
                    {
                        gameValidation = false;
                    }
                    break;
                case "blue":
                    if (colorCount > MaximumBlue)
                    {
                        gameValidation = false;
                    }
                    break;

            }
        }
        if (!gameValidation) 
        {
            break;
        }
    }
    if (gameValidation) 
    {
        Total += gameIdentity;
    }
}

Console.WriteLine(Total);
Console.ReadLine();