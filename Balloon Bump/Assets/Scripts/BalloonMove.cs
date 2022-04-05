using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonMove : MonoBehaviour
{
public float speed = 3f;
public float startspeed = 1f;
private Animator anim;
private float time = 0f; 
private int tracky = 0; 

void Start(){
    anim = GetComponent<Animator>();
    tracky = 0; 
}
void Update()
{
    time += Time.deltaTime; 
    if(time <= 4.5){
    transform.Translate(Vector3.up * startspeed * Time.deltaTime); 
    }
     if(time >= 4.5){
    transform.Translate(Vector3.up * 0f * Time.deltaTime); 
    }

     anim.SetBool("is_left", false);
     anim.SetBool("is_right", false);
    if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)){
        transform.Translate(Vector3.left * speed * Time.deltaTime); 
        anim.SetBool("is_left", true);
    }
      if(Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)){
        transform.Translate(Vector3.down * speed * Time.deltaTime); 
    }
    if(tracky != 1){
     if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)){
        transform.Translate(Vector3.up * speed * Time.deltaTime); 
    }  
    }
    if(tracky == 1){transform.Translate(Vector3.down * speed * Time.deltaTime);}
     if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)){
        transform.Translate(Vector3.right * speed * Time.deltaTime); 
        anim.SetBool("is_right", true);
    }
}

void OnTriggerEnter2D(Collider2D other){
    if (other.CompareTag("full_cloud"))
    {
       tracky = 1; 
    }
}
void OnTriggerExit2D(Collider2D other)
    {
        tracky = 0; 
        startspeed = 1f; 
    }
}