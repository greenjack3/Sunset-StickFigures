using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

	public Gun gun;

	void Start () 
	{
		
	}
	
	void Update () 
	{
        float fire1 = Input.GetAxis("Fire1");
        float fire2 = Input.GetAxis("Fire2");

        if (fire1 > 0.7f || fire2 > 0.7f)
		{
			gun.Shoot();
		}
	}
}
