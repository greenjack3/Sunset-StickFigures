using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehavior : MonoBehaviour {

    public float speed;
    public float lifeTime;
    public int damage;

	void Update () 
	{
		transform.Translate (speed * Vector3.right * Time.deltaTime);
        lifeTime -= Time.deltaTime;

        if (lifeTime <= 0)
            Destroy(gameObject);
	}
}
