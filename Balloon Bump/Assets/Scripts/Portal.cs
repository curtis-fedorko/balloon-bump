using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    Vector3 tempx; 
    Vector3 tempy; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.down * 1f * Time.deltaTime); 
        if(BalloonMove.is_portal){
            tempx = transform.localScale;
            tempy = transform.localScale;
            tempx.x += .05f; 
            tempy.y += .05f; 
            transform.localScale = new Vector3(tempx.x, tempy.y, transform.localScale.z);

        }
        
    }
}
