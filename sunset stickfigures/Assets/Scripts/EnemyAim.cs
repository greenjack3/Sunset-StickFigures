using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAim : MonoBehaviour {

    GameObject player;

    public float[] aimingPattern;
    public bool repeatPattern;

    float patternTimer;
    int count;
    bool isAiming;

    bool continuePattern;

	void OnEnable ()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        continuePattern = true;

        count = 0;
        isAiming = false;
        	
	}
	
	void Update ()
    {
        if (continuePattern)
        {
            if (patternTimer <= 0)
            {
                isAiming = !isAiming;
                patternTimer = aimingPattern[count];
                count++;
                if (count == aimingPattern.Length)
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

        if (isAiming && player != null)
        {
            transform.LookAt(player.transform);
        }
    }

    public bool returnAiming ()
    {
        return isAiming;
    }
}
