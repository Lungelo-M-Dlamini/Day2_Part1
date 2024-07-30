var Total = 0;
string[] lines = File.ReadAllLines("C:\\Users\\Lungelo\\source\\repos\\Day2_Part1\\Day2_Part2\\Input.txt");

foreach (var line in lines)
{
    var gameInformation = line.Split(':');
    var gameIdentity = int.Parse(gameInformation[0].Split(' ')[1]);
    var rounds = gameInformation[1].Split(';', StringSplitOptions.TrimEntries);
    var maximumRed = 0; var maximumGreen = 0; var maximumBlue = 0;
    foreach (var round in rounds)
    {

        var colorInformations = round.Split(",", StringSplitOptions.TrimEntries);
        foreach (var color in colorInformations)
        {
            var colorInformation = color.Split(' ');
            var colorCount = int.Parse(colorInformation[0]);
            var colorName = colorInformation[1];
            switch (colorName)
            {
                case "red":
                    maximumRed = Math.Max(colorCount, maximumRed);
                    break;
                case "green":
                    maximumGreen = Math.Max(colorCount, maximumGreen);
                    break;
                case "blue":
                    maximumBlue = Math.Max(colorCount, maximumBlue);
                    break;

            }
        }
    }
    var ans = maximumRed * maximumGreen * maximumBlue;
    Total += ans;
}

Console.WriteLine(Total);
Console.ReadLine();