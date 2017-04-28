using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBehaviorMaster : MonoBehaviour
{

    public EnemyAim aim;
    public EnemyShoot shoot;
    public Animator anim;
    public float[] hidingPattern;
  
    float patternTimer;
    int count;
    bool hidden;

    void Start()
    {
        hidden = true;
        count = 0;
        
    }



    void Update()
    {
        if (patternTimer <= 0)
        {
            hidden = !hidden;
            patternTimer = hidingPattern[count];
            count++;
            if (count == hidingPattern.Length)
            {
                count = 0;
            }
        }

        patternTimer -= Time.deltaTime;
        aim.enabled = !hidden;
        shoot.enabled = !hidden;

        anim.SetBool("Crouch", hidden);

      
    }

    public void OnDestroy()
    {
        SendMessageUpwards("Spawning");
    }
}
