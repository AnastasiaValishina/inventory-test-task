using UnityEngine;

public abstract class InventoryItem : ScriptableObject
{
	[SerializeField] string itemID;
	[SerializeField] Sprite icon;
	[SerializeField] bool stackable = false;

	public bool IsStackable()
	{
		return stackable;
	}
}
