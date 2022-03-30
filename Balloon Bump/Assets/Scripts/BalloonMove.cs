using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonMove : MonoBehaviour
{
    public float speed = 10f;
public static bool isHit; 
public int tracky; 
void Start(){
    isHit = false; 
    tracky = 0; 
}
void Update()
{
    // Make balloon float upwards slowly
    transform.Translate(Vector3.up * 1f * Time.deltaTime); 

    if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)){
        transform.Translate(Vector3.left * speed * Time.deltaTime); 
    }
      if(Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)){
        transform.Translate(Vector3.down * speed * Time.deltaTime); 
    }
        
     if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)){
        transform.Translate(Vector3.right * speed * Time.deltaTime); 
    }
}
}