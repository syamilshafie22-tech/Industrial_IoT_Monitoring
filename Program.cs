
Random random = new Random();

Console.WriteLine("================================");
Console.WriteLine("   INDUSTRIAL IoT MONITORING");
Console.WriteLine("================================");

/* for (int i = 1; i<=3; i++){
string machineID = $"MACHINE-{i:000}";
double temperature = Math.Round(random.NextDouble() * 80 + 20, 1);
double humidity = Math.Round(random.NextDouble() * 60 + 30, 1);
string status;

if (temperature < 60)
{
    status = "Normal";
}
else if (temperature < 80)
{
    status = "Warning";
}
else
{
    status = "Alert! Machine is OVERHEATING";
}

Console.WriteLine($"Machine ID: {machineID}");
Console.WriteLine($"Temperature: {temperature:F1} °C");
Console.WriteLine($"Humidity: {humidity:F1}%");
Console.WriteLine($"Machine Status: {status}");
Console.WriteLine("------------------------\n");
}
Console.WriteLine("================================"); */

Machine machine1 = new Machine();
Machine machine2 = new Machine();
Machine machine3 = new Machine();

machine1.MachineID = "MACHINE-001";
machine2.MachineID = "MACHINE-002";
machine3.MachineID = "MACHINE-003";

machine1.GenerateReadings(random);
machine2.GenerateReadings(random);
machine3.GenerateReadings(random);

machine1.CheckStatus();
machine2.CheckStatus();
machine3.CheckStatus();

Console.WriteLine(machine1.MachineID);
Console.WriteLine($"Temperature: {machine1.Temperature:F1} °C");
Console.WriteLine($"Humidity: {machine1.Humidity:F1}");
Console.WriteLine(machine1.Status);
Console.WriteLine(machine2.MachineID);
Console.WriteLine($"Temperature: {machine3.Temperature:F1} °C");
Console.WriteLine($"Humidity: {machine2.Humidity:F1}");
Console.WriteLine(machine2.Status);
Console.WriteLine(machine3.MachineID);
Console.WriteLine($"Temperature: {machine2.Temperature:F1} °C");
Console.WriteLine($"Humidity: {machine3.Humidity:F1}");
Console.WriteLine(machine3.Status);
