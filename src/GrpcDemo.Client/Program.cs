using Grpc.Net.Client;
using GrpcDemo.Greet;

var client = new Greeter.GreeterClient(
    GrpcChannel.ForAddress("http://localhost:5000"));

var response = await client.SayHelloAsync(
    new HelloRequest { Name = "John" });

Console.WriteLine("Response: {0}", response.Message);

