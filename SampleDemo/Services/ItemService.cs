using System.Collections.Generic;

public class ItemService : IItemService
{
    private readonly IDao<Item> _dao;

    public ItemService([Qualifier("itemDao")] IDao<Item> dao)
    {
        _dao = dao;
    }

    public List<ItemDto> GetItems()
    {
        return ItemAdapter.ToDtos(_dao.GetAll());
    }

    public ItemDto GetItemById(long id)
    {
        return ItemAdapter.ToDto(_dao.Get(id));
    }

    public ItemDto CreateItem(ItemDto dto)
    {
        return ItemAdapter.ToDto(_dao.Save(ItemAdapter.Create(dto)));
    }

    public ItemDto UpdateItem(long id, ItemDto dto)
    {
        var item = _dao.Get(id);
        if (ItemAdapter.Update(item, dto))
        {
            return ItemAdapter.ToDto(_dao.Update(item));
        }
        return dto;
    }

    public void DeleteItem(long id)
    {
        _dao.Delete(id);
    }
}
