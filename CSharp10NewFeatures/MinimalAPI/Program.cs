// Just four lines code to create API endpoint
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World! Minimal API");

// Creating New endpoint for demo

app.MapGet("/getDetails", () => new { Name = "Murari jha", Address = "New Delhi", Contact = "888888" }); //done going to run now 
//
app.Run();
