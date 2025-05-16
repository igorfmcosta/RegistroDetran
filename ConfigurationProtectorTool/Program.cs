using Microsoft.AspNetCore.DataProtection;
using System.Text;

var provider = DataProtectionProvider.Create("RegistroDetran");
var protector = provider.CreateProtector("5m4r7pr073c70r");

Console.WriteLine("=== Secret Protection Tool ===");
Console.WriteLine("Enter values to protect (press Enter twice to finish):");
Console.WriteLine();

var results = new StringBuilder();

while (true)
{
    Console.Write("Enter value to protect (or leave empty to exit): ");
    var input = Console.ReadLine();

    if (string.IsNullOrEmpty(input))
        break;

    var protectedValue = protector.Protect(input);
    results.AppendLine($"Original: {input}");
    results.AppendLine($"Protected: {protectedValue}");
    results.AppendLine();
}

Console.WriteLine();
Console.WriteLine("=== Protected Values ===");
Console.WriteLine(results.ToString());
Console.WriteLine("(These can be copied to appsettings.json)");

// Optional: Save to file
Console.Write("Save to file? (y/n): ");
if (Console.ReadLine()?.ToLower() == "y")
{
    File.WriteAllText("protected-values.txt", results.ToString());
    Console.WriteLine("Saved to 'protected-values.txt'");
}