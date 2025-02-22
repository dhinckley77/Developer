using Azure.Messaging.ServiceBus;

//connection string to your service bus namespace

string connectionString = "Endpoint=sb://danielsb.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=ac5wYBHFYL32xtKaiJkoMwxhKrNZyXA/s+ASbNQcFEo=";

// name of your Service Bus queue

string queueName = "queue1";

// the client that owns the connection and can be used to create senders and receivers
ServiceBusClient client;

// the processor that reads and processes messages from the queue
ServiceBusProcessor processor;

// Create the client object that will be used to create sender and receiver objects
client = new ServiceBusClient(connectionString);

// create a processor that we can use to process the messages
processor = client.CreateProcessor(queueName, new ServiceBusProcessorOptions());

