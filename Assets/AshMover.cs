using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AshMover : MonoBehaviour
{
    public float movespeed = 2;
    public float killash = -20;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position +(Vector3.left * movespeed) * Time.deltaTime;

        if (transform.position.x < killash)
        {
            Debug.Log("Ash killed");
            Destroy(gameObject);
        }
    }
}
