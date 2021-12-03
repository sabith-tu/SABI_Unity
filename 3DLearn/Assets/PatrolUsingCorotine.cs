using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class PatrolUsingCorotine : MonoBehaviour
{
	public Transform[] waypoins;

	private void Start()
	{
		StartCoroutine(patrol());
		//Debug.Log("Started");
	}

	IEnumerator patrol()
	{
		while (true)
		{
			foreach (Transform loc in waypoins)
			{
				//Debug.Log("Calling coroutine to First Location ");
				yield return StartCoroutine(aiMoveTo(loc.position));
			}
		}
	}

	IEnumerator aiMoveTo(Vector3 loc)
	{
		while(transform.position != loc)
		{
			//Debug.Log("Moving To First Location");
			//Vector3.Lerp(this.transform.position, loc, 10f );
			transform.position = Vector3.MoveTowards(transform.position, loc, 5f * Time.deltaTime );
			yield return null;
		}
		//Debug.Log("First Location Complete");
		
	}


}
