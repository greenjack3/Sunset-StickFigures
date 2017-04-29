﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EnemySpawner : MonoBehaviour {

    public float Timer;
    public float minT;
    public float maxT;
    public bool startTimer = false;
    public GameObject[] enemy;
    public GameObject spawnedEnemy;

	void Start ()
    {
        Timer = Random.Range(minT, maxT);
        startTimer = true;
		
	}
	
	

	void Update ()
    {
        if(startTimer == true)
        {
           // Timer = Random.Range(minT, maxT);
            Timer -= Time.deltaTime;
        }
		if(Timer <= 0)
        {
            GameObject enem = enemy[Random.Range(0, enemy.Length)];
            GameObject e = Instantiate(enem, gameObject.transform.position, gameObject.transform.rotation);
            spawnedEnemy = e;
           startTimer = false;
            Timer = Random.Range(minT, maxT);
        }

        if(startTimer==false && spawnedEnemy == null)
        {
            Spwaning();
        }
	}


    public void Spwaning()
    {
        Timer = Random.Range(minT, maxT);
        startTimer = true;
    }
}
