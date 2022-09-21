var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/",()=>{
    return "Heloo Word";
});

app.MapGet("/user/",()=>{
    return "Alcenir";
});

app.Run();
