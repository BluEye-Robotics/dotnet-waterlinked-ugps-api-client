using WaterLinked.UGPS;

var httpClient = new HttpClient();
IWaterLinkedUGPSApiClient client = new WaterLinkedUGPSApiClient(httpClient);

var about = await client.ApiV1AboutAsync();

Console.WriteLine($"Product name: {about.Product_name}");
Console.WriteLine($"Product id: {about.Product_id}");
Console.WriteLine($"Hardware revision: {about.Hardware_revision}");

var statusReport = await client.ApiV1StatusReportAsync();
foreach (var report in statusReport)
{
    Console.WriteLine($"{report.Status_group_id} {report.Status}: {report.Message}");
}
