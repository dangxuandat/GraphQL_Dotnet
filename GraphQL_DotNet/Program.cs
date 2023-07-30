using System.Text.Json.Serialization;
using GraphQL_DotNet.Contracts;
using GraphQL_DotNet.Entities.Context;
using GraphQL_DotNet.GraphQL.GraphQLQueries;
using GraphQL_DotNet.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers().AddJsonOptions( opts => opts.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles);
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ApplicationContext>(opt => opt.UseSqlServer(builder.Configuration.GetConnectionString("MSSQL")));
builder.Services.AddScoped<IAccountRepository, AccountRepository>();
builder.Services.AddScoped<IOwnerRepository, OwnerRepository>();
builder.Services.AddGraphQLServer().AddQueryType<AppQuery>().AddProjections().AddFiltering().AddSorting();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();
app.MapControllers();
app.MapGraphQL((PathString)"/graphql");
app.Run();