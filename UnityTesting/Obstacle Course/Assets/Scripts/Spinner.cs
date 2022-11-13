using UnityEngine;

public class Spinner : MonoBehaviour
{
	[SerializeField] private float xAngle = 0F;
	[SerializeField] private float yAngle = 0F;
	[SerializeField] private float zAngle = 0F;

	// Update is called once per frame
	private void Update()
	{
		transform.Rotate(xAngle, yAngle, zAngle);
	}
}
