using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonMove : MonoBehaviour
{
    public float speed = 50f;
public static bool isHit; 
public int tracky; 
void Start(){
    isHit = false; 
    tracky = 0; 
}
void Update()
{
    if(Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A)){
        transform.Translate(Vector3.left * speed * Time.deltaTime); 
    }
      if(Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)){
        transform.Translate(Vector3.down * speed * Time.deltaTime); 
    }
    if(Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)){
        transform.Translate(Vector3.up * speed * Time.deltaTime); 
    }
     if(Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D)){
        transform.Translate(Vector3.right * speed * Time.deltaTime); 
    }
}
}
