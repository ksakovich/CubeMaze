
/**
* @author Kirill Sakovich
* Game 267 Winter 2018
*/

using System.Collections;

using UnityEngine;

public class Rotator : MonoBehaviour {

	/**
	 * Method updates pickUp object' rortation once per frame
	 */
	void Update () 
	{
		transform.Rotate (new Vector3 (15, 30, 45) * Time.deltaTime);
	}
}
