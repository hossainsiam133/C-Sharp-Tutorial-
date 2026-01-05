using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.Design;
using System.Diagnostics.Contracts;
using System.Dynamic;
using System.IO.Pipelines;
using System.IO.Pipes;
using System.Net.Security;
using System.Net.WebSockets;
using System.Reflection.Metadata;
using System.Reflection.Metadata.Ecma335;
using System.Runtime;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks.Sources;
using System.Xml.Schema;
using Microsoft.VisualBasic;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseHttpsRedirection();
List<Category> categories = new List<Category>();
app.MapGet("/api/categories", () =>
{
    return Results.Ok(categories);
});
int id = 0;
app.MapPost("/api/categories", () =>
{
    id++;
    var category = new Category
    {
        // categoryID = Guid.NewGuid(),
        categoryID = id,
        name = "HP EliteBook",
        description = "Nice Laptop",
        createdAt = DateTime.UtcNow,
    };
    categories.Add(category);
    Results.Created($"/api/categories/{category.categoryID}", category);
});
app.MapDelete("/api/categories", () =>
{
    for (int i = 0; i < categories.Count; i++)
    {
        if (categories[i].categoryID % 2 == 0)
        {
            categories.RemoveAt(i);
        }
    }
});
app.MapPut("/api/categories", () =>
{
    int uid = int.Parse(Console.ReadLine());
    for (int i = 0; i < categories.Count; i++)
    {
        if (categories[i].categoryID == uid)
        {
            categories[i].name = "Walton";
            return "ok";
        }
    }
    return "Not Found";
});
app.Run();
public record Category
{
    public int categoryID { get; set; }
    public string? name { get; set; }
    public string? description { get; set; }
    public DateTime createdAt { get; set; }
}