using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour {

	float debugTimer = 0.2f;
	float timeLeft;

	public Gun gun;

	void Start () 
	{
		timeLeft = debugTimer;
	}
	
	void Update () 
	{
		if (timeLeft <= 0)
		{
			gun.Shoot();
			timeLeft = debugTimer;
		}
		timeLeft -= Time.deltaTime;
	}
}
