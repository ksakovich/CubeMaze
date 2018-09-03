/**
* @author Kirill Sakovich
* Game 267 Winter 2018
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class badSphereScript : MonoBehaviour 
{

	void OnTriggerEnter(Collider other) 
	{
			if (other.CompareTag("Boundaries")) 
			{
				return;
			}
			
			if(other.CompareTag("Player")) 
		{
			Destroy (other.gameObject);
			Destroy (gameObject);
		}
	}
}
