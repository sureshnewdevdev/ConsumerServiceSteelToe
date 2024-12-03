using Microsoft.AspNetCore.Mvc;
using Steeltoe.Common.Discovery;
using Steeltoe.Discovery;

[ApiController]
[Route("api/[controller]")]
public class ConsumerController : ControllerBase
{
    private readonly DiscoveryHttpClientHandler _handler;

    public ConsumerController(IDiscoveryClient discoveryClient)
    {
        _handler = new DiscoveryHttpClientHandler(discoveryClient);
    }

    [HttpGet]
    public async Task<IActionResult> GetProducerWeather()
    {
        var client = new HttpClient(_handler, false);
        var response = await client.GetStringAsync("http://ProducerService/api/Weather");
        return Ok(response);
    }
}
