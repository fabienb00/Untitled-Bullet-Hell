using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static Pattern;


public class EnemyPatternHandler : MonoBehaviour
{

    public Pattern[] patterns;
    private int currentPattern = -1;
    public int[] healthThreshHolds;

    public int maxHealth = 200;
    private int currentHealth;


    // Start is called before the first frame update
    void Start()
    { 
        if (patterns.Length != 0)
        {
            currentPattern = 0;
        }
        currentHealth = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {
    
    }

    void FixedUpdate()
    {
        if (currentPattern != -1)
        {
            patterns[currentPattern].shoot();
        }
    }

    public void changeHealth(int amount)
    {
        currentHealth += amount;
        Debug.Log(currentHealth);
        if(currentHealth >= maxHealth)
        {
            currentHealth = maxHealth;
        }
        else if(currentHealth <= 0)
        {
            GameObject.Destroy(this.gameObject);
        }
    }
}

