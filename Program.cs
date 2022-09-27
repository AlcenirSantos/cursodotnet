using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>();


var app = builder.Build();
var configuration = app.Configuration;

app.MapPost("/Products", (Product product) =>{

});

app.MapGet("/",()=>{
    return "Heloo Word";
});

app.MapGet("/user/",()=>{
    return "Alcenir";
});

app.Run();

public class Category {
    public int Id { get; set; }
    public string Name { get; set; }
}

public class Product {
    public int Id { get; set; }
    public string Code { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public int? CategoryId { get; set; }
    public Category Category { get; set; }
    public List<Tag> Tags { get; set; }
}

public class Tag {
    public int Id { get; set; }
    public string Name { get; set; }
    public int ProductId { get; set; }
}

public class ApplicationDbContext : DbContext {

    public DbSet<Product> products { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<Product>().Property(p => p.Description).HasMaxLength(500).IsRequired(false);
        modelBuilder.Entity<Product>().Property(p => p.Name).HasMaxLength(120).IsRequired();
        modelBuilder.Entity<Product>().Property(p => p.Code).HasMaxLength(20).IsRequired();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder options) 
    => options.UseSqlServer("Server=localhost;Database=Products;User Id=sa;Password=A@8406abs;MultipleActiveResultSets=true;Encrypt=true;TrustServerCertificate=YES");

}
