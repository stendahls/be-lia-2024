using NMemory;
using NMemory.Tables;

namespace LiaBE;

public class ToDoListItemRepository : Database
{
    private ITable<ToDoListItem> items { get; set; }
    public ToDoListItemRepository(IEnumerable<ToDoListItem> seedItems)
    {
        items = this.Tables.Create<ToDoListItem, int>(x => x.Id);
        foreach (var item in seedItems)
        {
            items.Insert(item);
        }
    }

    public IEnumerable<ToDoListItem> GetAll()
    {
        return items.ToList();
    }

    public ToDoListItem? GetById(int id)
    {
        return items.FirstOrDefault(x => x.Id == id);
    }

    public void Add(ToDoListItem item)
    {
        items.Insert(item);
    }

    public void Update(ToDoListItem item)
    {
        items.Update(item);
    }

    public void Delete(int id)
    {
        var item = items.FirstOrDefault(x => x.Id == id);
        if (item != null)
        {
            items.Delete(item);
        }
    }
}
