using UnityEngine;
using UnityEngine.SceneManagement;

public class CollisionHandler : MonoBehaviour
{
	[SerializeField] private float levelLoadDelay = 2F;
	[SerializeField] private AudioClip successSfx;
	[SerializeField] private AudioClip crashSfx;
	[SerializeField] private ParticleSystem successParticles;
	[SerializeField] private ParticleSystem crashParticles;

	private AudioSource audioSource;

	private bool isTransitioning = false;
	private bool canCollide = true;
	private float lastClick = 0F;

	private void Start()
	{
		audioSource = GetComponent<AudioSource>();
	}

	private void Update()
	{
		CheckDebugKeys();
	}

	private void OnCollisionEnter(Collision collision)
	{
		if (isTransitioning || !canCollide)
		{
			return;
		}

		switch (collision.gameObject.tag)
		{
			case "Friendly":
				Debug.Log("This thing is friendly");
				break;
			case "Finish":
				StartSuccessSequence();
				break;
			default:
				StartCrashSequence();
				break;
		}
	}

	private void CheckDebugKeys()
	{
		if (lastClick + 1 > Time.time)
		{
			return;
		}
		if (Input.GetKey(KeyCode.C))
		{
			canCollide = !canCollide;
			lastClick = Time.time;
		}
		else if (Input.GetKey(KeyCode.L))
		{
			StartSuccessSequence();
			lastClick = Time.time;
		}
	}

	private void StartSuccessSequence()
	{
		isTransitioning = true;
		audioSource.Stop();
		audioSource.PlayOneShot(successSfx);
		successParticles.Play();
		GetComponent<Movement>().enabled = false;
		Invoke(nameof(LoadNextLevel), levelLoadDelay);
	}

	private void LoadNextLevel()
	{
		int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
		int nextSceneIndex = currentSceneIndex + 1;
		if (nextSceneIndex == SceneManager.sceneCountInBuildSettings)
		{
			nextSceneIndex = 0;
		}
		SceneManager.LoadScene(nextSceneIndex);
	}

	private void StartCrashSequence()
	{
		isTransitioning = true;
		audioSource.Stop();
		audioSource.PlayOneShot(crashSfx);
		crashParticles.Play();
		GetComponent<Movement>().enabled = false;
		Invoke(nameof(ReloadLevel), levelLoadDelay);
	}

	private void ReloadLevel()
	{
		int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
		SceneManager.LoadScene(currentSceneIndex);
	}
}
