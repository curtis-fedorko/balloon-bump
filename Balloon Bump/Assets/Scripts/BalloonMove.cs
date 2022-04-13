using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class BalloonMove : MonoBehaviour
{
public float speed = 5f;
public float startspeed = 1f;
private Animator anim;
private static float time; 
private int tracky = 0; 
public static bool is_portal; 
public static bool has_heart; 
public static bool is_dead; 

void Start(){
    anim = GetComponent<Animator>();
    tracky = 0; 
    anim.SetBool("is_hit", false);
    anim.SetBool("is_portal", false);
    is_portal = false; 
    is_dead = false; 
}
void Update()
{
     anim.SetBool("is_left", false);
     anim.SetBool("is_right", false);

    time += Time.deltaTime; 

    if(time <= 4.5){
    transform.Translate(Vector3.up * startspeed * Time.deltaTime); 
    }
     if(time >= 4.5 && time <= 30){
    transform.Translate(Vector3.down * 1f * Time.deltaTime); 
    }
    if(time >= 30 && time <= 60){
    transform.Translate(Vector3.down * 1f * Time.deltaTime); 
    }
    if(time >= 60){
    transform.Translate(Vector3.down * 1f * Time.deltaTime); 
    }

    if(Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A)){
        transform.Translate(Vector3.left * speed * Time.deltaTime); 
        anim.SetBool("is_left", true);
    }
      if(Input.GetKey(KeyCode.DownArrow) || Input.GetKey(KeyCode.S)){
        transform.Translate(Vector3.down * speed * Time.deltaTime); 
    }
    //if(tracky != 1){
    // if(Input.GetKey(KeyCode.UpArrow) || Input.GetKey(KeyCode.W)){
     //   transform.Translate(Vector3.up * speed * Time.deltaTime); 
    //}  
    //}
    
    if(tracky == 1){transform.Translate(Vector3.up * 5f * Time.deltaTime);}

     if(Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D)){
        transform.Translate(Vector3.right * speed * Time.deltaTime); 
        anim.SetBool("is_right", true);
    }
    if(is_dead && has_heart){

         SceneManager.LoadScene("Extra");
    }
}
public static float getScore(){
    return time;
    }

void OnTriggerEnter2D(Collider2D other){
    if (other.CompareTag("full_cloud"))
    {
       tracky = 1; 
    }
     if (other.CompareTag("dart"))
    {
       anim.SetBool("is_hit", true);
       is_dead = true; 
       Destroy(this.gameObject);
       EndGame(); 

    }
     if (other.CompareTag("portal"))
    {
       is_portal = true; 
       anim.SetBool("is_portal", true);
    }
    if(other.CompareTag("heart")){
        has_heart = true; 
        other.GetComponent<Renderer>().enabled = false;
    }
    if(other.CompareTag("right_side")){
        gameObject.transform.position = new Vector3(-13.3f, gameObject.transform.position.y, gameObject.transform.position.z);

    }
    if(other.CompareTag("left_side")){
        gameObject.transform.position = new Vector3(13.3f, gameObject.transform.position.y, gameObject.transform.position.z);

    }
    if(other.CompareTag("bottom")){
       // end the game, save the score, check if they have collected a hear
       // if they have, keep score and continue from same point. 
       Destroy(this.gameObject);
        EndGame(); 

    }

    
}
void EndGame(){
    if(has_heart){
        has_heart = false; 
        SceneManager.LoadScene("Extra");
    }
    else{
        //SceneManager.LoadScene("YouLost");
    }


}
void OnTriggerExit2D(Collider2D other)
    {
        tracky = 0; 
        startspeed = 1f; 
    }
}