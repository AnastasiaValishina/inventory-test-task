using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class InventoryItemIcon : MonoBehaviour
{
	[SerializeField] GameObject textContainer = null;
	//[SerializeField] TextMeshProUGUI priceText = null;

	public void SetItem(InventoryItem item)
	{
		var iconImage = GetComponent<Image>();
		if (item == null)
		{
			iconImage.enabled = false;
		}
		else
		{
			iconImage.enabled = true;
			iconImage.sprite = item.GetIcon();
		}
	}
}
