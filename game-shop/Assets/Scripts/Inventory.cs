using System;
using UnityEngine;

public class Inventory : MonoBehaviour
{
	[SerializeField] int inventorySize = 16;

	InventoryItem[] items;

	public event Action inventoryUpdated;

	private void Awake()
	{
		items = new InventoryItem[inventorySize];
	}

	public static Inventory GetPlayerInventory()
	{
		var player = GameObject.FindWithTag("Player");
		return player.GetComponent<Inventory>();
	}

	public int GetSize()
	{
		return items.Length;
	}
	public bool AddItemToSlot(int slot, InventoryItem item)
	{
		if (items[slot] != null)
		{
			return AddToFirstEmptySlot(item); ;
		}

		items[slot] = item;

		if (inventoryUpdated != null)
		{
			inventoryUpdated();
		}
		return true;
	}

	public void RemoveFromSlot(int slot)
	{
		items[slot] = null;

		if (inventoryUpdated != null)
		{
			inventoryUpdated();
		}
	}

	public bool HasSpace()
	{
		for (int i = 0; i < items.Length; i++)
		{
			if (items[i] == null)
			{
				return true;
			}
		}
		return false;
	}
	public InventoryItem GetItemInSlot(int slot)
	{
		return items[slot];
	}

	private int FindEmptySlot() // returns number of the slot
	{
		for (int i = 0; i < items.Length; i++)
		{
			if (items[i] == null)
			{
				return i;
			}
		}
		return -1;
	}

	private bool AddToFirstEmptySlot(InventoryItem item)
	{
		int i = FindEmptySlot();

		if (i < 0)
		{
			return false;
		}

		items[i] = item;

		if (inventoryUpdated != null)
		{
			inventoryUpdated();
		}
		return true;
	}
}
