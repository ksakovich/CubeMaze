/**
* @author Kirill Sakovich
* Game 267 Winter 2018
*/
using System.Collections;
using UnityEngine;

public class CameraController : MonoBehaviour 
{

	public GameObject player;
	private Vector3 offset;
	/**
	 * Method sets camera position for initialization at the beginning of thr game
	 */
	void Start () {
		offset = transform.position - player.transform.position;
	}
	/**
	 * Method updates camera position once per frame
	 * and if the player is destroyed stops
	 */

	void LateUpdate ()
	{
		if (player == null) 
		{
			return;
		}

		transform.position = player.transform.position + offset;
	}
}
