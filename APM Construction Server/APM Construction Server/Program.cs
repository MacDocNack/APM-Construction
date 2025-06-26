using APM_Construction_Server;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

DataStore.Instance.Clients = [];
DataStore.Instance.Contractors = [];
DataStore.Instance.Resources = [];
DataStore.Instance.ProjectResources = [];
DataStore.Instance.Projects = [];
DataStore.Instance.Employees = [];
DataStore.Instance.FinanceOperations = [];
DataStore.Instance.Jobs = [];
DataStore.Instance.Tasks = [];
DataStore.Instance.Users = [];

// Check Data folder. If exists then load from json object
if (Directory.Exists(Path.Combine(JSONDataLoadService.Instance.GetPath(), "Data")))
{
    JSONDataLoadService.Instance.LoadData();
}

app.Run();
