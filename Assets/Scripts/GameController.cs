/**
* @author Kirill Sakovich
* Game 267 Winter 2018
*/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

	/**
	 * Class generates moving  waves of spheres starting at certain ponts
	 * and next one will appear in certain time frame.
	 * Spheres are generated to be a moving obstacles that will try to push player out of the plain
	 */
public class GameController : MonoBehaviour {
	// variables declaration
	public GameObject hazard;
	public Vector3 spawnValues;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;

	public GameObject hazard2;
	public Vector3 spawnValues2;
	public int hazardCount2;
	public float spawnWait2;
	public float startWait2;
	public float waveWait2;

	/**
	 * method sets start conditions
	 */
	void Start()
	{
		StartCoroutine (SpawnWaves ());
		StartCoroutine (SpawnWaves2 ());
	}
	/**
	 * Method generates first level waves of spheres
	 */
	IEnumerator SpawnWaves()
	{
		yield return new WaitForSeconds (startWait);
		while(true) 
		{
			for (int i = 0; i < hazardCount; i++) 
			{
				Vector3 spawnPosition = new Vector3 (spawnValues.x, spawnValues.y, spawnValues.z);
				Quaternion spawnRotation = Quaternion.identity;
				Instantiate (hazard, spawnPosition, spawnRotation);
				yield return new WaitForSeconds (waveWait);
			}
		}
	}
	/**
	 * Method generates second level waves of spheres
	 */
	IEnumerator SpawnWaves2()
	{
		yield return new WaitForSeconds (startWait2);
		while(true) 
		{
			for (int i = 0; i < hazardCount2; i++) 
			{
				Vector3 spawnPosition2 = new Vector3 (spawnValues2.x, spawnValues2.y, spawnValues2.z);
				Quaternion spawnRotation2 = Quaternion.identity;
				Instantiate (hazard2, spawnPosition2, spawnRotation2);
				yield return new WaitForSeconds (waveWait2);
			}
		}
	}
}
