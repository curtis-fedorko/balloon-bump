using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : MonoBehaviour
{
    private static MusicManager musicManagerInstance; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
    DontDestroyOnLoad(this); 
    if(musicManagerInstance == null){
        musicManagerInstance = this;
    }
    else{
        Destroy(gameObject);
    }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
