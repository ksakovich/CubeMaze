/**
* @author Kirill Sakovich
* Game 267 Winter 2018
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByTime : MonoBehaviour {
	public float lifetime;
	/**
	 * Method destrotes spheres  after its lifetime is over
	 */
	void Start() {
		Destroy (gameObject, lifetime);
	}
}
