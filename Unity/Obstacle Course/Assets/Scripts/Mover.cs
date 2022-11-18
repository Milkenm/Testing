using UnityEngine;

public class Mover : MonoBehaviour
{
	[SerializeField] private float moveSpeed = 10F;

	// Start is called before the first frame update
	private void Start()
	{
		PrintInstructions();
	}

	// Update is called once per frame
	private void Update()
	{
		MovePlayer();
	}

	private void PrintInstructions()
	{
		Debug.Log("Welcome to the game");
		Debug.Log("Move your player with WASD or arrow keys");
		Debug.Log("Don't hit the walls!");
	}

	private void MovePlayer()
	{
		float xValue = Input.GetAxis("Horizontal") * Time.deltaTime * moveSpeed;
		float zValue = Input.GetAxis("Vertical") * Time.deltaTime * moveSpeed;
		transform.Translate(xValue, 0, zValue);
	}
}
