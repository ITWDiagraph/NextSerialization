using NextSerialization.MessageTypes.Next;
using NextSerialization.MessageTypes.Next.Extensions;
using NextSerialization.MessageTypes.Next.Serialization;

var inputFile = @"SampleFiles/00157.next";
var outputFile = @"SampleFiles/00157_Serialized.next";

// The following code uses the static methods of the MessageSerializer class to read and write the 
// message XML data to/from file.
try
{
    File.Delete(outputFile);

    var message = MessageSerializer.ReadMessageFile<NextMessage>(inputFile);

    if (message is null)
    {
        throw new InvalidOperationException("Unable to deserialize message data.");
    }

    Console.WriteLine("Message successfully read.");
    Console.WriteLine($"Writing message data to {outputFile}");

    MessageSerializer.WriteMessageFile<NextMessage>(message, outputFile);

    Console.WriteLine("Message file successfully written.");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("Press enter to continue");
Console.ReadLine();

// The following code uses extension methods provided for your convienience to perform the same
// operations as above.
try
{
    File.Delete(outputFile);

    Console.WriteLine($"Reading message data from {inputFile}");
    var message = inputFile.ReadMessageFromFile();

    if (message is null)
    {
        throw new InvalidOperationException("Unable to deserialize message data.");
    }

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
