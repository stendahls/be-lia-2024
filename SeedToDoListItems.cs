namespace LiaBE;

public static class SeedToDoListItems
{
    public static IEnumerable<ToDoListItem> SeedItems()
    {
        return new List<ToDoListItem>
        {
            new ToDoListItem { Id = 1, Body = "Buy milk" },
            new ToDoListItem { Id = 2, Body = "Buy eggs" },
            new ToDoListItem { Id = 3, Body = "Buy bread" },
            new ToDoListItem { Id = 4, Body = "Buy butter" },
            new ToDoListItem { Id = 5, Body = "Buy cheese" }
        };
    }
}
