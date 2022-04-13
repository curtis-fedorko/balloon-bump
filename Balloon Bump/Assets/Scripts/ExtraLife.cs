using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ExtraLife : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool has_done = false;
    public float timey = 0f; 
    void Start()
    {
        has_done = true; 
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
