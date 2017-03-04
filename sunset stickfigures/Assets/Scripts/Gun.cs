using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

	public GameObject bullet;

	public void Shoot ()
	{
		//Debug.Log ("I am shooting!");
		Instantiate (bullet, transform.position, transform.rotation);
	}
}
