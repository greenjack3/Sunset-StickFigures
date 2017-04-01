using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class EnemySpawner : MonoBehaviour {

    public float Timer;
    public float minT;
    public float maxT;
    public bool startTimer = false;
    public GameObject[] enemy;


	void Start ()
    {
        Timer = Random.Range(minT, maxT);
        startTimer = true;
		
	}
	
	

	void Update ()
    {
        if(startTimer == true)
        {
            Timer -= Time.deltaTime;
        }
		if(Timer <= 0)
        {
            GameObject enem = enemy[Random.Range(0, enemy.Length)];
            GameObject instance = Instantiate(enem, gameObject.transform.position, gameObject.transform.rotation);
            Timer = Random.Range(minT, maxT);
            startTimer = false;
        }
	}


    public void Spwaning()
    {
        Timer = Random.Range(minT, maxT);
        startTimer = true;
    }
}
