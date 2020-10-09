using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour
{
	public float speed;
	public Text countText;
	public Text winText;

	private Rigidbody2D rb2d;
	private int count;

	private void Start()
	{
		rb2d = GetComponent<Rigidbody2D>();
		count = 0;
		winText.text = "";
		SetCountText();
	}

	private void FixedUpdate()
	{
		float moveHorizontal = 0;
		float moveVertical = 0;
		if (Application.platform == RuntimePlatform.WindowsPlayer || Application.platform == RuntimePlatform.WindowsEditor)
		{
			moveHorizontal = Input.GetAxis("Horizontal");
			moveVertical = Input.GetAxis("Vertical");
		}
		else if (Application.platform == RuntimePlatform.Android)
		{
			moveHorizontal = Input.acceleration.x;
			moveVertical = Input.acceleration.y;
		}

		Vector2 movement = new Vector2(moveHorizontal, moveVertical);
		rb2d.AddForce(movement * speed);
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		if (collision.gameObject.CompareTag("PickUp"))
		{
			collision.gameObject.SetActive(false);
			count = count + 1;
			SetCountText();
		}
	}

	private void SetCountText()
	{
		countText.text = "Count: " + count.ToString();
		if (count >= 12)
		{
			winText.text = "You win!";
		}
	}
}
