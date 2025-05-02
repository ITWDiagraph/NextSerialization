using Diagraph.Message.Serialization.Serializers;

string[] inputMessages =
    [
        @"C:\Customer Support\Conversions\Baudere\backup1\WMT000045.next",
        @"C:\Customer Support\Conversions\Baudere\backup1\files\prds\WMT.000045.prd",
        @"C:\Source\MessageData\PRDs\THOUSAND ISLAND.prd"
    ];

foreach (var inputMessage in inputMessages)
{
    var serializer = MessageSerializerFactory.CreateSerializerFromFile(inputMessage);
    var message = serializer.ReadMessageFile(inputMessage);

    Console.WriteLine($"Message is {message!.GetType().FullName}");
}

foreach (var inputMessage in inputMessages)
{
    var messageXmlContent = File.ReadAllText(inputMessage);
    var serializer = MessageSerializerFactory.CreateSerializerFromContent(messageXmlContent);
    var message = serializer.ReadMessageXml(messageXmlContent);

    Console.WriteLine($"Message is {message!.GetType().FullName}");
}

