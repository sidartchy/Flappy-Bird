using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{

    public Rigidbody2D myRigidBody;
    public float flapStrength;
    public LogicManagerScript logicScript;
    public bool birdIsAlive = true; 


    // Start is called before the first frame update
    void Start()
    {
        logicScript = GameObject.FindGameObjectWithTag("Logic").GetComponent<LogicManagerScript>();
    }

    // Update is called once per frame
    void Update()
    {

        if(Input.GetKeyDown(KeyCode.Space) && birdIsAlive)
        {
            myRigidBody.velocity = Vector2.up * flapStrength;
        }
     
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logicScript.gameOver();
        birdIsAlive = false; 
    }
}
