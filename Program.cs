
Random random = new Random();

Console.WriteLine("================================");
Console.WriteLine("   INDUSTRIAL IoT MONITORING");
Console.WriteLine("================================");

// Create a list to store machines
List<Machine> machines = new List<Machine>();

// Generate 3 machines
for (int i = 1; i <= 3; i++)
{
    Machine machine = new Machine($"MACHINE-{i:000}");

    machine.GenerateReadings(random);
    machine.CheckStatus();

    machines.Add(machine);
}
machines[0].Temperature = -999;
// Display all machines
foreach (Machine machine in machines)
{
    Console.WriteLine($"Machine ID: {machine.MachineID}");

    if (machine.ValidateReadings())
    {
        machine.CheckStatus();

        Console.WriteLine($"Temperature: {machine.Temperature:F1} °C");
        Console.WriteLine($"Humidity: {machine.Humidity:F1}%");
        Console.WriteLine($"Status: {machine.Status}");
    }
    else
    {
        Console.WriteLine("SENSOR FAULT DETECTED!");
        Console.WriteLine("Invalid sensor readings.");
    }

    Console.WriteLine("--------------------------------");
}

Console.WriteLine("================================");
