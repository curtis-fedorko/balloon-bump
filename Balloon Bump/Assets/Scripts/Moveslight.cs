using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; 

public class Moveslight : MonoBehaviour
{
    float timey = 0f; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timey += Time.deltaTime; 
        if(timey >= 4){
            SceneManager.LoadScene("Game");

        }

    }

}
