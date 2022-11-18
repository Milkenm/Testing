using UnityEngine;

public class Move : MonoBehaviour
{
	// Start is called before the first frame update
	private void Start()
	{

	}

	// This function is called every fixed framerate frame, if the MonoBehaviour is enabled
	private void FixedUpdate()
	{
		float x = transform.position.x;
		float y = transform.position.y;
		float z = transform.position.z;

		const float mov = (float)0.1;

		if (Input.GetKeyDown(KeyCode.W))
		{
			transform.position = new Vector3(x, y += mov, z);
		}
		else if (Input.GetKeyDown(KeyCode.A))
		{
			transform.position = new Vector3(x -= mov, y, z);
		}
		else if (Input.GetKeyDown(KeyCode.S))
		{
			transform.position = new Vector3(x, y -= mov, z);
		}
		else if (Input.GetKeyDown(KeyCode.D))
		{
			transform.position = new Vector3(x += mov, y, z);
		}
	}
}
