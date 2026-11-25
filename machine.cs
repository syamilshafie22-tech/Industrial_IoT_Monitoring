class Machine
{
    public string MachineID = "";
    public double Temperature;
    public double Humidity;
    public string Status = "Unknown";

    public void CheckStatus()
    {
        if (Temperature < 60)
        {
            Status = "Normal";
        }
        else if (Temperature < 80)
        {
            Status = "Warning";
        }
        else
        {
            Status = "Alert";
        }
    }

    public void GenerateReadings(Random random)
{
    Temperature = Math.Round(random.NextDouble() * 80 + 20, 1);
    Humidity = Math.Round(random.NextDouble() * 60 + 30, 1);
}
}
