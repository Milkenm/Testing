using UnityEngine;

public class QuitApplication : MonoBehaviour
{
	private void Update()
	{
		if (Input.GetKeyDown(KeyCode.Escape))
		{
			Debug.Log("we pushed escape");
			Application.Quit();
		}
	}
}
