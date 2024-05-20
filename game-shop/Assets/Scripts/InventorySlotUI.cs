using UnityEngine;

public class InventorySlotUI : MonoBehaviour
{
	[SerializeField] InventoryItemIcon icon = null;

	int _index;
	InventoryItem _item;
	Inventory _inventory;

	public void Setup(Inventory inventory, int index)
	{
		_inventory = inventory;
		_index = index;
		icon.SetItem(inventory.GetItemInSlot(index));
	}

	public void AddItems(InventoryItem item)
	{
		_inventory.AddItemToSlot(_index, item);
	}

	public InventoryItem GetItem()
	{
		return _inventory.GetItemInSlot(_index);
	}

	public void RemoveItems()
	{
		_inventory.RemoveFromSlot(_index);
	}
}
