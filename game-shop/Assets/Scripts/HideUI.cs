using UnityEngine;

public class HideUI : MonoBehaviour
{
	void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			gameObject.SetActive(false);
		}
	}
}
