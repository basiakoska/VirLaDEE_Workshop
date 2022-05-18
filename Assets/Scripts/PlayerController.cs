using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Rigidbody player;
    //public float speed;
    public float forceMultiplier = 10f; 
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        Vector3 moveDirection = new Vector3(Input.GetAxisRaw("Horizontal"), 0, Input.GetAxisRaw("Vertical"));
        //Vector3 moveDelta = moveDirection * speed * Time.deltaTime; //speed * timedelta = distance
        //player.position += moveDelta;
        Vector3 movingForce = moveDirection * forceMultiplier;
        player.AddForce(movingForce);
    }
}
