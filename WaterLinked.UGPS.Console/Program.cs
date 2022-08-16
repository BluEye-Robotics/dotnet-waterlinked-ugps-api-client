using WaterLinked.UGPS;

var httpClient = new HttpClient();
IWaterLinkedUGPSApiClient client = new WaterLinkedUGPSApiClient(httpClient);

var about = await client.ApiV1AboutAsync();

Console.WriteLine($"Product name: {about.Product_name}");
Console.WriteLine($"Product id: {about.Product_id}");
Console.WriteLine($"Hardware revision: {about.Hardware_revision}");
