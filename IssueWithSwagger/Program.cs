using FastEndpoints.Swagger;
using FastEndpoints;

namespace IssueWithSwagger
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddFastEndpoints();
            builder.Services.AddProblemDetails();
            builder.Services.SwaggerDocument();
            var app = builder.Build();

            app.UseAuthorization();
            app.UseFastEndpoints(options => {
                options.Errors.UseProblemDetails();
            });
            app.UseSwaggerGen();
            app.Run();
        }
    }
}