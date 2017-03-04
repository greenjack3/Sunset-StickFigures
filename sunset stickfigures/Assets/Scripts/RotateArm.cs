using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateArm : MonoBehaviour {

	void Start () 
	{
		
	}
	
	void Update () 
	{
		transform.Rotate (0, 0, 4 * Time.deltaTime);
	}
}
