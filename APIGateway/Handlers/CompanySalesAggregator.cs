using System.Net;
using System.Text.Json;
using Microsoft.AspNetCore.Http;
using Ocelot.Middleware;
using Ocelot.Multiplexer;

namespace APIGateway.Handlers
{
    public class CompanySalesAggregator : IDefinedAggregator
    {
        public async Task<DownstreamResponse> Aggregate(List<HttpContext> responses)
        {
            var companyBody = await responses[0].Items.DownstreamResponse().Content.ReadAsStringAsync();
            var salesBody = await responses[1].Items.DownstreamResponse().Content.ReadAsStringAsync();

            var merged = new
            {
                company = TryParseJson(companyBody),
                sales = TryParseJson(salesBody)
            };

            var json = JsonSerializer.Serialize(merged);
            return new DownstreamResponse(
                new StringContent(json),
                HttpStatusCode.OK,
                new List<KeyValuePair<string, IEnumerable<string>>> {
                    new("Content-Type", new[] { "application/json" })
                },
                "OK"
            );
            throw new NotImplementedException();
        }
        private static object? TryParseJson(string s)
        {
            try { return JsonSerializer.Deserialize<object>(s); }
            catch { return s; }
        }
    }
}
