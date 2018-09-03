using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/**
* @author Kirill Sakovich
* Game 267 Winter 2018
*/
	/**
	 * Class serves to destroy object that fallen out the boundaries
	 */
public class DestroyByBoundaries : MonoBehaviour 
{
	private PlayerController gameController;
	/**
	 * Method destroyes player when s/he fall out the boundaries
	 */
	void Start()
	{
		GameObject gameControllerObject = GameObject.FindWithTag ("Player");
		if (gameControllerObject != null) 
		{
			gameController = gameControllerObject.GetComponent<PlayerController> ();
		}
		if (gameController == null)
		{
			Debug.Log ("Cannot find 'PlayerController' Script");
		}
	}

	/**
	 * Method calls game over method if the player was destroyed
	 */
	void OnTriggerExit(Collider other) 
	{
		Destroy (other.gameObject);
		if(other.CompareTag("Player")) 
		{
			gameController.GameOver ();
		}
	}

}