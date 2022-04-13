using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGenerator : MonoBehaviour
{
    public GameObject[] newCloud; 
    public float timey = 0f; 
    public float randomtime = 0f; 
    public float darttime = 0f; 
    public bool heart = false; 
    public float totaltime = 0f; 
    public bool tracky = false; 
    
    void Start(){
       randomtime = Random.Range(0f, 5f); 
    }
    void Update()
    {
         totaltime += Time.deltaTime; 
         timey += Time.deltaTime; 
         darttime += Time.deltaTime; 
if(totaltime < 30){
         if(timey >= 2){
             timey = 0; 
             SpawnNewCloud(); 
         }
         if(totaltime >= randomtime && !heart && !ExtraLife.has_done){
             SpawnHeart(); 
             heart = true; 
         }
}

if(totaltime > 30){
         if(timey >= 4){
             timey = 0; 
             SpawnNewCloud(); 
         }
         if(totaltime >= randomtime && !heart && !ExtraLife.has_done){
             SpawnHeart(); 
             heart = true; 
         }
         if(darttime >= 10){
              darttime = 0; 
             SpawnDart(); 
         }
}
if(ExtraLife.has_done && !tracky){
    SpawnBalloon();
    tracky = true; 
}
        
    }

 public void SpawnNewCloud(){
        GameObject nc = Instantiate(newCloud[0], this.transform) as GameObject; 
        GameObject nc2 = Instantiate(newCloud[0], this.transform) as GameObject; 
        nc.transform.localPosition = new Vector3(Random.Range(-13.9f, 12f), 2.25f, 0f);
        nc2.transform.localPosition = new Vector3(Random.Range(-13.9f, 12f), 2.25f, 0f);

    }
    public void SpawnHeart(){
         GameObject nc = Instantiate(newCloud[1], this.transform) as GameObject; 
        nc.transform.localPosition = new Vector3(Random.Range(-13.9f, 12f), 2.25f, 0f);
    }
    public void SpawnDart(){
        GameObject nc = Instantiate(newCloud[2], this.transform) as GameObject; 
        nc.transform.localPosition = new Vector3(Random.Range(-13.9f, 12f), 4.5f, 0f);
   }
   public void SpawnBalloon(){
        GameObject nc = Instantiate(newCloud[3], this.transform) as GameObject; 
        nc.transform.localPosition = new Vector3(0f , -1.5f, 0f);
   }
}
