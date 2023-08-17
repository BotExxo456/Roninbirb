using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Roninscript : MonoBehaviour
{
    public Rigidbody2D myRigidbody;
    public float jumpstrength;
    public Logicscript logic;
    public bool RoninAlive = true;
    


    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("Logic").GetComponent<Logicscript>();

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && RoninAlive == true)
        {
            myRigidbody.velocity = Vector2.up * jumpstrength;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "Deathzone")
        {
            logic.gameOver();
            RoninAlive = false;
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Deathzone")
        {
            logic.gameOver();
            RoninAlive = false;
        }
        
        }
   }

