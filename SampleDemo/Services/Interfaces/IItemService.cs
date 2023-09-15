using System.Collections.Generic;

public interface IItemService
{
    List<ItemDto> GetItems();

    ItemDto GetItemById(long id);

    ItemDto CreateItem(ItemDto dto);

    ItemDto UpdateItem(long id, ItemDto dto);

    void DeleteItem(long id);
}
