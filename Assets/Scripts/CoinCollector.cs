using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinCollector : MonoBehaviour
{
    public int collectedCoinsCount=0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        //Debug.Log("collided with" + other.gameObject.name);
        if (other.gameObject.tag=="coin")
        {
            other.gameObject.SetActive(false);
            collectedCoinsCount++;
            Debug.Log("your score is " + collectedCoinsCount);
            Debug.Log(Time.timeSinceLevelLoad);
        }
    }
}


