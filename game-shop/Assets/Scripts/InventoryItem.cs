using UnityEngine;

public abstract class InventoryItem : ScriptableObject
{
	[SerializeField] string itemID;
	[SerializeField] Sprite icon;

	public Sprite GetIcon()
	{
		return icon;
	}
}
