using Alba;
using FluentAssertions;
using IssueWithSwagger.Features;

namespace TestProject
{
    public class IntegrationTests : IClassFixture<WebFixture>
    {
        private readonly IAlbaHost host;

        public IntegrationTests(WebFixture fixture)
        {
            host = fixture.Host;
        }

        [Fact]
        public async Task Test1()
        {
            var request = new SampleRequest
            {
                Field1 = "Test",
                Field2 = "Test"

            };

            var response = await host.Scenario(_ =>
            {
                _.WithRequestHeader("Accept", "application/*");

                _.Get.Url("/Sample").QueryString<SampleRequest>(request);
                _.StatusCodeShouldBeOk();
            });
            var typedResponse = response.ReadAsJson<SampleResponse>();
            typedResponse.Field1.Should().NotBeNull();
            typedResponse.Field2.Should().NotBeNull();
        }


        [Fact]
        public async Task Test2()
        {
            var request = new SampleRequest
            {
                Field1 = "Test",
                Field2 = "Test",


            };

            var response = await host.Scenario(_ =>
            {
                _.WithRequestHeader("Accept", "application/*");

                _.Get.Url("/Sample").QueryString<SampleRequest>(request);
                _.StatusCodeShouldBeOk();
            });
            var typedResponse = response.ReadAsJson<SampleResponse>();
            typedResponse.Field1.Should().NotBeNull();
            typedResponse.Field2.Should().NotBeNull();
        }

        [Fact]
        public async Task Test3()
        {
            var request = new SampleRequest
            {
                Field1 = "Test",
                Field2 = "Test",


            };

            var response = await host.Scenario(_ =>
            {
                _.WithRequestHeader("Accept", "application/*");

                _.Get.Url("/Sample").QueryString<SampleRequest>(request);
                _.StatusCodeShouldBeOk();
            });
            var typedResponse = response.ReadAsJson<SampleResponse>();
            typedResponse.Field1.Should().NotBeNull();
            typedResponse.Field2.Should().NotBeNull();
        }

        [Fact]
        public async Task Test4()
        {
            var request = new SampleRequest
            {
                Field1 = "Test",
                Field2 = "Test",


            };

            var response = await host.Scenario(_ =>
            {
                _.WithRequestHeader("Accept", "application/*");

                _.Get.Url("/Sample").QueryString<SampleRequest>(request);
                _.StatusCodeShouldBeOk();
            });
            var typedResponse = response.ReadAsJson<SampleResponse>();
            typedResponse.Field1.Should().NotBeNull();
            typedResponse.Field2.Should().NotBeNull();
        }
    }
}