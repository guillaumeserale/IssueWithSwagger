using FastEndpoints;
using System.Text.Json.Serialization;

namespace IssueWithSwagger.Features
{
    [JsonSerializable(typeof(SampleRequest))]
    [JsonSerializable(typeof(SampleResponse))]
    partial class MyJsonContext : JsonSerializerContext { };

    public class SampleEndpointDefinition : Endpoint<SampleRequest, SampleResponse>
    {
        public override void Configure()
        {
            Get("Sample");

            SerializerContext<MyJsonContext>();
            AllowAnonymous();
        }

        public async override Task HandleAsync(SampleRequest req, CancellationToken ct)
        {
            await SendAsync(new SampleResponse { Field1 = req.Field1, Field2 = req.Field2 });
        }
    }

    public class SampleRequest
    {
        public string Field1 { get; set; }
        public string Field2 { get; set; }
    };
    public class SampleResponse
    {
        public string Field1 { get; set; }
        public string Field2 { get; set; }
    };
}
