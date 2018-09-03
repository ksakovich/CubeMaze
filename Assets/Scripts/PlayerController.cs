using System.Collections;
using UnityEngine.UI;
using UnityEngine;

	/**
	 * @author Kirill Sakovich
	 * Game 267 Winter 2018
	 * Class defines all fields related to the player
	 * 
	 */
public class PlayerController : MonoBehaviour 
{
	// desttroyable objects in the game
	// and tiggers to destroy them
	public GameObject floor1;
	public GameObject floor2;
	public GameObject floor3;
	public GameObject CollapsingWall;
	public GameObject DestroyWall;
	public GameObject CollapsingWall2;
	public GameObject DestroyWall2;
	public GameObject CollapsingWall3;
	public GameObject DestroyWall3;
	// ball speed
	public float speed;

	//GUI trxt fileds
	public Text countText;
	public Text winText;
	public UnityEngine.UI.Text gameOverText;
	// check if the game is over
	private bool gameOver;
	// Physics in the game
	private Rigidbody rb;
	// counter
	private int count;

	/**
	 * Method sets up all begining base things
	 * 
	 */
	void Start()
	{
		rb = GetComponent<Rigidbody> ();
		count = 0;
		gameOver = false;
		gameOverText.text = "";
		SetCountText ();
		winText.text = "";
	}
	/**
	 * Method changes all base components
	 * updates ball position on a plane
	 * and contol it by user 
	 */
	void FixedUpdate()
	{
		float moveHorizontal = Input.GetAxis ("Horizontal");
		float moveVertical = Input.GetAxis ("Vertical");
		Vector3 movement = new Vector3 (moveHorizontal, 0.0f, moveVertical);

		rb.AddForce (movement * speed);

	}

	/**
	 * Method sets all tiger events for destroying
	 * walls, floors under certain coditions
	 * and to collect pick up objects
	 * with updating count score
	 */
	void OnTriggerEnter (Collider other)
	{
		// to pick up  pickups objects
		if (other.gameObject.CompareTag ("Pick Up")) 
		{
			other.gameObject.SetActive (false);
			count = count + 1;
			SetCountText ();
		}
		// to destroy floors
		if (other.gameObject.CompareTag("Hole"))
		{
			Destroy(floor1);
		}
		if (other.gameObject.CompareTag("Hole2"))
		{
			Destroy(floor2);
		}
		if (other.gameObject.CompareTag("Hole3"))
		{
			Destroy(floor3);
		}
		// to destroy walls
		// set up 3 for first floor only for making presentation shorter
		if (other.gameObject.CompareTag("DestroyWall") && count == 4)
		{
			Destroy(CollapsingWall);
		}
		// set up 10 for the second floor only for making presentation shorter
		if (other.gameObject.CompareTag("DestroyWall2") && count >= 24)
		{
			Destroy(CollapsingWall2);
		}
		// set up 13 for the third floor only for making presentation shorter
		if (other.gameObject.CompareTag("DestroyWall3") && count >= 43)
		{	
			Destroy(CollapsingWall3);
		}
	}

	/**
	 * Method sets GUI winning text 
	 * when user got enough pick up objects
	 */
	void SetCountText() 
	{
		countText.text = "Count: " + count.ToString ();
		// set up 15 pickUp objects for the victory only for making presentation shorter
		if (count >= 64) 
		{
			winText.text = "You Win!";
		}
	}
	/**
	 * Method sets GUI game over text 
	 * when user was destroyed by falling out the bpundaries
	 */
	public void GameOver()
	{
		gameOverText.text = "Game Over!";
		gameOver = true;

	}
}
