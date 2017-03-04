using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour {

	//staty to-do

	void Update () 
	{
		transform.Translate (Vector3.right * Time.deltaTime);
	}
}
