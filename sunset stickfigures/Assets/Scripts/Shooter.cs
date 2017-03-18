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
        float fire3 = 0; //Input.GetAxis("Fire3");

        if (fire1 > 0.7f || fire2 > 0.7f || Mathf.Abs(fire3) > 0.7f)
		{
			gun.Shoot();
		}

        if (Input.GetButtonDown("Swap"))
            gun.Swap();

        Debug.Log("Fire1: " + fire1 + "Fire2: " + fire2 + "Fire3: " + fire3);
	}
}
