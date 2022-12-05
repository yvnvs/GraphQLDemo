using GraphQLDemo.API.Schema.Mutations;
using GraphQLDemo.API.Schema.Queries;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddGraphQLServer()
    .AddQueryType<Query>()
    .AddMutationType<Mutation>();
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();



app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.MapGraphQL();
});


app.Run();
