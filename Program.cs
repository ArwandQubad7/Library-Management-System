var builder = WebApplication.CreateBuilder(args);

var app = builder.Build();

app.MapGet("/", () =>
{
    return "Welcome to the Library Management System";
});

app.MapGet("/books", () =>
{
   return "This is where we display the Books"; 
});

app.MapGet("/members", () =>
{
   return "we Display the Members here"; 
});

app.MapGet("/borrowings", () =>
{
   return "Here we display the Borrowings"; 
});

app.Run();