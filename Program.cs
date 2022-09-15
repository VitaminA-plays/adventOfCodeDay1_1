string[] readings = System.IO.File.ReadAllLines(@"C:\Users\Axion\source\repos\adventofcode-day1\adventofcode-day1\measurements.txt");

int totalCount = readings.Count();
int[] measurements = new int [totalCount];

for (int line = 0; line < totalCount; line++)
{
    measurements[line] = int.Parse(readings[line]); 
}

int counter = 0;
int last = measurements[0];

foreach (int measurement in measurements)
{
    if (measurement > last)
    {
        counter++;
    }
    last = measurement;
}

Console.WriteLine(counter.ToString());