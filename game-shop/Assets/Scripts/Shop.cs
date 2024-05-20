using UnityEngine;

public class Shop : MonoBehaviour
{
	[SerializeField] GameObject shoppingPanel;

	public void OnMouseDown()
	{
		shoppingPanel.SetActive(true);
	}
}
