using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour {

    public EnemyAim aim;
    public bool shootWhileAiming;

    public Gun gun;

    public float[] shootingPattern;
    public bool repeatPattern;

    float patternTimer;
    int count;
    bool isShooting;

    bool continuePattern;
    public GameObject spawner;

    void OnEnable()
    {
        continuePattern = true;

        count = 0;
        isShooting = false;
        patternTimer = shootingPattern[0];
    }

    void Update()
    {
        if (aim.returnAiming())
        {
            if (!shootWhileAiming)
            {
                return;
            }
        }

        if (continuePattern)
        {
            if (patternTimer <= 0)
            {
                isShooting = !isShooting;
                patternTimer = shootingPattern[count];
                count++;
                if (count == shootingPattern.Length)
                {
                    if (repeatPattern)
                    {
                        count = 0;
                    }
                    else
                    {
                        continuePattern = false;
                    }
                }
            }

            patternTimer -= Time.deltaTime;
        }
                  
        if (isShooting)
        {
            gun.Shoot();
            isShooting = false;
        }

        
    }

    
}
