using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hittable : MonoBehaviour {

    public GameObject parent;
    //public GameObject deathParticles;

    public bool isPlayer;

    void Death()
    {
        //Instantiate(deathParticles, transform);
        Destroy(parent);
    }

    void OnTriggerEnter(Collider other)
    {
        print("trigger entered");
        BulletBehavior bullet = other.GetComponent<BulletBehavior>();
        if (bullet != null)
        {
            if (bullet.playersBullet)
            {
                if (isPlayer)
                    return;
            }
            if (!bullet.playersBullet)
            {
                if (!isPlayer)
                    return;
            }

            Death();
        }
    }
}
