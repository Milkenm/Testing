using UnityEngine;

public class Dropper : MonoBehaviour
{
	private MeshRenderer renderer;
	private Rigidbody rigidbody;

	[SerializeField] private float timeToWait = 5F;

	// Start is called before the first frame update
	private void Start()
	{
		renderer = GetComponent<MeshRenderer>();
		rigidbody = GetComponent<Rigidbody>();

		renderer.enabled = false;
		rigidbody.useGravity = false;
	}

	// Update is called once per frame
	private void Update()
	{
		if (Time.time > timeToWait)
		{
			Debug.Log("3 seconds has elapsed");

			renderer.enabled = true;
			rigidbody.useGravity = true;
		}
	}
}
