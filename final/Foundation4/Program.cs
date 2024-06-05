using System;

List<Exercise> exerciseList = new List<Exercise>();

Running running = new Running("April 15, 2024", 30, 4.8);
exerciseList.Add(running);

StationaryBicycles stationaryBicycles = new StationaryBicycles("April 17, 2024", 60, 15);
exerciseList.Add(stationaryBicycles);

Swimming swimming = new Swimming("April 24, 2024", 10, 15);
//exerciseList.Add(swimming);

Console.WriteLine("Exercises:");
Console.WriteLine();

foreach (Exercise exercise in exerciseList)

{
    Console.WriteLine(exercise.GetSummary());

}

internal class Swimming
{
    private string v1;
    private int v2;
    private int v3;

    public Swimming(string v1, int v2, int v3)
    {
        this.v1 = v1;
        this.v2 = v2;
        this.v3 = v3;
    }

}