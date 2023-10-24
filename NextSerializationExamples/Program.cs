using Diagraph.Message.Next;
using Diagraph.Message.Next.Serialization;

var inputFile = @"C:\Source\MessageData\convert_Serialized.next";
var outputFile = @"C:\Source\MessageData\convert_Serialized_out.next";

try
{
    File.Delete(outputFile);

    Console.WriteLine($"Reading message data from {inputFile}");

    //var messageLines = File.ReadAllLines(inputFile);
    //var messageXml = MessageSerializer.CorrectMessageXml(messageLines);

    var product = MessageSerializer.ReadMessageFile<Product>(inputFile);

    var message = new NextMessage
    {
        Product = product
    };

    //var message = inputFile.ReadMessageFromFile() ?? throw new InvalidOperationException("Unable to deserialize message data.");

    Console.WriteLine("Message successfully read.");
    Console.WriteLine($"Writing message data to {outputFile}");

    MessageSerializer.WriteMessageFile<Product>(message.Product, outputFile);

    Console.WriteLine("Message file successfully written.");
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

Console.WriteLine("Press any key to exit.");
Console.ReadKey();
