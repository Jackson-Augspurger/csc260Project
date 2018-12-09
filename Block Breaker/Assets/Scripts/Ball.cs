using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    //config params
    [SerializeField] Paddle paddle1;
    [SerializeField] float xPush = 1f;
    [SerializeField] float yPush = 15f;

    //State
    Vector2 paddleToBallVector;

    public bool hasStarted = false;

    // Use this for initialization
    void Start ()
    {
        
        paddleToBallVector = transform.position - paddle1.transform.position;
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (!hasStarted)
        { 
            ShootBallOnClick();
            LockBallToPaddle();
        }
    }

    private void ShootBallOnClick()
    {
        if (Input.GetMouseButtonDown(0))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector2(xPush,yPush);
            hasStarted = true;
        }
    }

    private void LockBallToPaddle()
    {
        Vector2 paddlePos = new Vector2(paddle1.transform.position.x, paddle1.transform.position.y);
        transform.position = paddlePos + paddleToBallVector;
    }
}
