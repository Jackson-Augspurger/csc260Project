using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    [SerializeField] public float screenWidthInUnits = 16f;
    [SerializeField] public float minX = 1f;
    [SerializeField] public float maxX = 15;
	// Use this for initialization
	void Start () {
        

    }
	
	// Update is called once per frame
	void Update () {
        float mousePosition = Input.mousePosition.x / Screen.width * screenWidthInUnits;
        Vector2 paddlePossition = new Vector2(transform.position.x,transform.position.y);
        paddlePossition.x = Mathf.Clamp(mousePosition, minX, maxX);
        transform.position = paddlePossition;
	}
}
