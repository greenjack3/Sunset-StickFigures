using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour {

    public GameObject bulletPistol;
    public GameObject bulletShotgun;
    public GameObject pistol;
    public GameObject shotgun;

    public Transform pistolnuzzle;
    public Transform[] shotgunnuzzle;
    public bool isShotgun;

    public float pistolCD;
    public float shotgunCD;

    float cooldown;

    void Update()
    {
        cooldown -= Time.deltaTime;
        SelectModel(isShotgun);
    }

    void SelectModel(bool whichModel)
    {
        if (!whichModel)
        {
            pistol.SetActive(true);
            shotgun.SetActive(false);
        }
        if (whichModel)
        {
            pistol.SetActive(false);
            shotgun.SetActive(true);
        }
    }

    public void Shoot ()
	{
        if (cooldown <= 0)
        {
            if (isShotgun)
            {
                Shotgun();
            }
            if (!isShotgun)
            {
                Pistol();
            }
            ResetCooldown();
        }		
	}

    void Pistol()
    {
        Instantiate(bulletPistol, pistolnuzzle.position, pistolnuzzle.rotation);
    }

    void Shotgun()
    {
        for (int i = 0; i < shotgunnuzzle.Length; i++)
        {
            Instantiate(bulletShotgun, shotgunnuzzle[i].position, shotgunnuzzle[i].rotation);
        }
    }

    public void Swap()
    {
        isShotgun = !isShotgun;

        ResetCooldown();       
    }

    void ResetCooldown()
    {
        if (isShotgun)
            cooldown = shotgunCD;
        if (!isShotgun)
            cooldown = pistolCD;
    }
}
