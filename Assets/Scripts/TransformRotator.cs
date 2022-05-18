using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformRotator : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public float speed = 45f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float angleDelta = speed * Time.deltaTime; 
        Vector3 rotationDelta = new Vector3(angleDelta, 0f, 0f );
        target.Rotate(rotationDelta);
        
        
    }
}
