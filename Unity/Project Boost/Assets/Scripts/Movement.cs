using UnityEngine;

public class Movement : MonoBehaviour
{
	[SerializeField] private float thrust = 1000F;
	[SerializeField] private float rotationThrust = 100F;
	[SerializeField] private AudioClip mainEngine;
	[SerializeField] private ParticleSystem mainBoosterParticles;
	[SerializeField] private ParticleSystem rightBoosterParticles;
	[SerializeField] private ParticleSystem leftBoosterParticles;

	private Rigidbody rigidbody;
	private AudioSource audioSource;

	// Start is called before the first frame update
	private void Start()
	{
		rigidbody = GetComponent<Rigidbody>();
		audioSource = GetComponent<AudioSource>();
	}

	// Update is called once per frame
	private void Update()
	{
		ProcessThrust();
		ProcessRotation();
	}

	private void ProcessThrust()
	{
		if (Input.GetKey(KeyCode.Space))
		{
			StartThrusting();
		}
		else
		{
			StopThrusting();
		}
	}

	private void ProcessRotation()
	{
		if (Input.GetKey(KeyCode.A))
		{
			RotateRight();
		}
		else if (Input.GetKey(KeyCode.D))
		{
			RotateLeft();
		}
		else
		{
			StopRotating();
		}
	}

	private void StartThrusting()
	{
		rigidbody.AddRelativeForce(Vector3.up * thrust * Time.deltaTime);
		if (!audioSource.isPlaying)
		{
			audioSource.PlayOneShot(mainEngine);
		}
		if (!mainBoosterParticles.isPlaying)
		{
			mainBoosterParticles.Play();
		}
	}

	private void StopThrusting()
	{
		audioSource.Stop();
		mainBoosterParticles.Stop();
	}

	private void RotateRight()
	{
		ApplyRotation(rotationThrust);
		if (!rightBoosterParticles.isPlaying)
		{
			rightBoosterParticles.Play();
		}
	}

	private void RotateLeft()
	{
		ApplyRotation(-rotationThrust);
		if (!leftBoosterParticles.isPlaying)
		{
			leftBoosterParticles.Play();
		}
	}

	private void StopRotating()
	{
		rightBoosterParticles.Stop();
		leftBoosterParticles.Stop();
	}

	private void ApplyRotation(float rotationThisFrame)
	{
		rigidbody.freezeRotation = true; // freezing rotation so we can manually rotate
		transform.Rotate(Vector3.forward * rotationThisFrame * Time.deltaTime);
		rigidbody.freezeRotation = false; // unfreezing rotation so the physics system can take over
		rigidbody.constraints = RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY | RigidbodyConstraints.FreezePositionZ;
	}
}
