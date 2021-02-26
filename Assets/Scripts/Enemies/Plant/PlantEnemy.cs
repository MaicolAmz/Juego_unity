﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantEnemy : MonoBehaviour
{
    private float waitedTime;
    public float waitedTimeToAttack;
    public Animator animator;
    public GameObject bulletPrefab;
    public Transform LauchspawnPoint;
    private void Start()
    {
        waitedTime = waitedTimeToAttack; 
    }
    private void Update()
    {

        if (waitedTime<=0)
        {
            waitedTime = waitedTimeToAttack;
            animator.Play("Attack");
            Invoke("LaunchBullet", 0.5f);

        }
        else
        {
            waitedTime -= Time.deltaTime;
        }

    }
    public void LaunchBullet()
    {
        GameObject newBullet;
        newBullet = Instantiate(bulletPrefab,LauchspawnPoint.position,LauchspawnPoint.rotation);
    }
    
}
