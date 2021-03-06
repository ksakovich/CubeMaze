/**
* @author Kirill Sakovich
* Game 267 Winter 2018
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
	
public class PickUpCreator : MonoBehaviour 
{
	public Transform pickup;

	// Use this for initialization
	void Start () 
	{

	/**
	 * Method generates pick up objects 
	 * right after the game starts
	 */
		//while loop solution
		 int x = 0; // control loop variable
		 while (x < 4) // condition when loop stops
		{
			float theta =  (2.5f+ 90.0f) * (float) x; // 00 degree rotation
			Transform xform = Instantiate (pickup, new Vector3 (0.0f, 0.5f, 13.8f), Quaternion.identity);
			xform.RotateAround (Vector3.zero, Vector3.up, theta);
			x++; // incrementing control loop variable
		}

	}
}
