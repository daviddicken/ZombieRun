using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieScript : MonoBehaviour
{
    
    public GameObject zombie1;   
    public GameObject zombie2;  
    public GameObject zombie3;

    // Start is called before the first frame update
    void Start()
    {
        

    }

    public float timeRemaining = .1f;
    
    void Update()
    {
        if (timeRemaining > 0)
        {
            timeRemaining -= Time.deltaTime;
        }
        else 
        {
            float rand = Random.Range(1, 3);
            Debug.Log("random number: " + rand);
            GameObject randomZombie = new GameObject();
            switch (rand) 
            {
                case 1:
                    randomZombie = zombie1;
                    break;
                case 2:
                    randomZombie = zombie2;
                    break;
                case 3:
                    randomZombie = zombie3;
                    break;
            }
            float pointX = Random.Range(-100, 100);
            float pointZ = Random.Range(10, 190);

            Instantiate(randomZombie, new Vector3(pointX, -1, pointZ), Quaternion.identity);
            timeRemaining = .1f; 
        }

        

    }
    
  
 
}
