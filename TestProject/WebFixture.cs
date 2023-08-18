using Alba;

namespace TestProject;

public class WebFixture : IAsyncLifetime
{
    private static IAlbaHost _host = default!;
    public IAlbaHost Host => _host;

    public async Task InitializeAsync()
    {
        _host ??= await AlbaHost.For<IssueWithSwagger.Program>();
    }

    public Task DisposeAsync()
    {
        //don't dispose the host
        return Task.CompletedTask;
    }

}
