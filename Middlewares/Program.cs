using Middlewares.Extensions;

var builder = WebApplication.CreateBuilder(args);
//Service Collection Section
builder.Services.AddHttpsRedirectionAndHsts();

var app = builder.Build();
//Application Builder Section
app.UseXFrameOptions();
app.UseXContentTypeOptions();
app.UseXXSSProtection();
app.UseContentSecurityPolicy();
app.UseReferrerPolicy();
app.UsePermissionPolicy();


app.MapGet("/", () => "Hello World!");

app.Run();
