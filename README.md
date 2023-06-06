# NEXT Message Serialization

## Overview

The NextSerialization API has been created to facilitate reading and writing messages in the NEXT 
message format without the need to use the UI on an HMI device.  Documentation for the serialization is available here: https://itwdiagraph.github.io/NextSerialization/

## Intended Audience

The NextSerialization API is intended to be used by customers or third-party agents with 
development teams tasked with creating custom messages outside of the NEXTCreate platform.

## Getting Started

### Installing

#### Package Manager Console

```
Install-Package NextSerialization -Version 1.0.0
```

#### PackageReference
```
<PackageReference Include="NextSerialization" Version="1.0.0" />
```

#### .NET CLI
```
dotnet add package NextSerialization --version 1.0.0
```

#### NuGet Package Manager - Visual Studio
- Click the 'Project' menu
- Select 'Manage NuGet Packages'
- Enter 'NextSerialization' in the search bar and press enter to search
- Select the NextSerialization package in the results
- Click 'Install'

### Basic Usage

#### Read an Existing Message File

```
var inputFile = "DiagraphReferenceResMarkData.next";
var messageSerializer = new MessageSerializer();
var message = MessageSerializer.ReadMessageFile<NextMessage>(inputFile);
```

#### Write Message Data to a File

```
var outputFile = @"DiagraphReference_Serialized.next";
MessageSerializer.WriteMessageFile<NextMessage>(message, outputFile);
```

## License

This project is licensed under the MIT License
