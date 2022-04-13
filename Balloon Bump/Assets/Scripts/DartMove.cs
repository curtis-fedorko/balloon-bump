using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartMove : MonoBehaviour
{
    public float speed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
          transform.Translate(Vector3.right * speed * Time.deltaTime); 
         transform.Translate(Vector3.down * 1f * Time.deltaTime);
        
    }
    void OnTriggerEnter2D(Collider2D other){
    
    if(other.CompareTag("right_side")){
        gameObject.transform.position = new Vector3(-12.7f, gameObject.transform.position.y, gameObject.transform.position.z);

    }
    if(other.CompareTag("left_side")){
        gameObject.transform.position = new Vector3(12.7f, gameObject.transform.position.y, gameObject.transform.position.z);

    }

    
}
}
