using UnityEngine;

public class Oscillator : MonoBehaviour
{
	private Vector3 startingPosition;
	[SerializeField] private Vector3 movementVector;
	[SerializeField][Range(0, 1)] private float movementFactor;
	[SerializeField] private float period = 2F;

	private void Start()
	{
		startingPosition = transform.position;
	}

	private void Update()
	{
		if (period <= Mathf.Epsilon
			)
		{
			return;
		}
		float cycles = Time.time / period;  // continually growing over time

		const float tau = Mathf.PI * 2; // constant value of 6.283
		float rawSinWave = Mathf.Sin(cycles * tau); // going from -1 to 1

		movementFactor = (rawSinWave + 1F) / 2F;    // recalculated to go from 0 to 1 so its cleaner

		Vector3 offset = movementVector * movementFactor;
		transform.position = startingPosition + offset;
	}
}
