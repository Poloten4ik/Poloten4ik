﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int health;
    public int damage;

    // Start is called before the first frame update
    void Start()
    {
        print("Goodbye");
    }

    // Update is called once per frame
    public void Attack(int damageParameter)
    {
        health -= damageParameter;
        print("Осталось " + health);
        if (health <= 0)
        {
            print(name + "I a dead");
        }
    }

    public int GetHealth()
    {
        return health;
    }
}
