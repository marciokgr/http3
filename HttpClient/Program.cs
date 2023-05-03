using System.Net;

System.AppContext.SetSwitch("System.Net.SocketsHttpHandler.Http3Support", true);

try
{
    using var client = new HttpClient()
    {
        DefaultRequestVersion = HttpVersion.Version30,
        DefaultVersionPolicy = HttpVersionPolicy.RequestVersionExact
    };

    Console.WriteLine("Enviando request https://localhost:5001");

    using var request = new HttpRequestMessage(HttpMethod.Get, "https://localhost:5001/");
    request.Version = HttpVersion.Version30;
    request.VersionPolicy = HttpVersionPolicy.RequestVersionExact;

    using var response = await client.SendAsync(request);
    var data = await response.Content.ReadAsStringAsync();

}
catch(Exception e)
{
    Console.WriteLine(e.Message);
}
