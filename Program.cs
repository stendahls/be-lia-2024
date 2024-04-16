using LiaBE;

var builder = WebApplication.CreateBuilder(args);

// Adding swagger to see the API on /swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Register the ToDoListItemRepository and seed it with some items
builder.Services.AddSingleton<ToDoListItemRepository>(new ToDoListItemRepository(SeedToDoListItems.SeedItems()));

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();

app.UseHttpsRedirection();

//Add endpoints
app.MapGet("/items", (ToDoListItemRepository repository) => { return repository.GetAll(); });
app.MapGet("/items/{id}", (ToDoListItemRepository repository, int id) => { return repository.GetById(id); });

app.Run();
