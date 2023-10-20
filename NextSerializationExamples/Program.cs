using Diagraph.Message.Next.Extensions;

var inputFile = @"SampleFiles/00157.next";
var outputFile = @"SampleFiles/00157_Serialized.next";

try
{
    File.Delete(outputFile);

    Console.WriteLine($"Reading message data from {inputFile}");

    var message = inputFile.ReadMessageFromFile() ?? throw new InvalidOperationException("Unable to deserialize message data.");

    Console.WriteLine("Message successfully read.");
    Console.WriteLine($"Writing message data to {outputFile}");

    message.WriteMessageToFile(outputFile);

    Console.WriteLine("Message file successfully written.");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("Press any key to exit.");
Console.ReadKey();
