using ClassroomAssignment.DomainServices;
using ClassroomAssignment.GraphQL.Mutation;
using ClassroomAssignment.GraphQL.Queries;
using ClassroomAssignment.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddScoped<IStudentClassRepo, StudentClassRepository>();


var connectionString = builder.Configuration.GetConnectionString("Default");
builder.Services.AddDbContext<ClassroomAssignmentDBContext>(options => options.UseSqlServer(connectionString));



builder.Services
    .AddGraphQLServer()
    .RegisterService<IStudentClassRepo>()
    .AddMutationType<Mutation>()
    .AddQueryType<StudentClassQueries>();

var app = builder.Build();

app.MapGraphQL();

app.Run();
