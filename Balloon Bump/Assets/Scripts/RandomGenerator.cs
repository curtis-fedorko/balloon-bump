using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomGenerator : MonoBehaviour
{
    public GameObject[] newCloud; 
    public float timey = 0f; 
    public float randomtime = 0f; 
    public float darttime = 0f; 
    public float portaltime = 0f; 
    public bool heart = false; 
    public float totaltime = 0f; 
    public bool tracky = false; 
    
    void Start(){
       randomtime = Random.Range(0f, 5f); 
    }
    void Update()
    {
        portaltime += Time.deltaTime; 
         totaltime += Time.deltaTime; 
         timey += Time.deltaTime; 
         darttime += Time.deltaTime; 

if(totaltime < 15){
         if(timey >= 2){
             timey = 0;                       
             SpawnNewCloud(); 
         }
         if(totaltime >= randomtime && !heart && !ExtraLife.has_done){
             SpawnHeart(); 
             heart = true; 
         }
}

if(totaltime < 30){
         if(timey >= 2){
             timey = 0; 
             SpawnNewCloud(); 
         }
          if(portaltime >= 12){
        portaltime = 0;
        SpawnPortal(); 
        }
        /*
         if(totaltime >= randomtime && !heart && !ExtraLife.has_done){
             SpawnHeart(); 
             heart = true; 
         }
         */
          if(darttime >= 6){
              darttime = 0; 
             SpawnDart(); 
         }
}


if(totaltime > 30 && totaltime < 60){
        if(portaltime >= 12){
        portaltime = 0;
        SpawnPortal(); 
        }
         if(timey >= 4){
             timey = 0; 
             SpawnNewCloud(); 
         }
         if(totaltime >= randomtime && !heart && !ExtraLife.has_done){
             SpawnHeart(); 
             heart = true; 
         }
         if(darttime >= 6){
              darttime = 0; 
             SpawnDart(); 
         }
}

if(totaltime > 60 && totaltime < 75){
   if(portaltime >= 10){
        portaltime = 0;
        SpawnPortal(); 
    }
         if(timey >= 3.5){
             timey = 0; 
             SpawnNewCloud(); 
         }
         if(darttime >= 4){
              darttime = 0; 
             SpawnDart(); 
         }

}
if(totaltime > 75 && totaltime < 100){
   if(portaltime >= 7){
        portaltime = 0;
        SpawnPortal(); 
    }
         if(timey >= 3){
             timey = 0; 
             SpawnNewCloud(); 
         }
         if(darttime >= 5){
              darttime = 0; 
             SpawnDart(); 
         }

}
if(totaltime > 100){
   if(portaltime >= 4){
        portaltime = 0;
        SpawnPortal(); 
    }
         if(timey >= 2){
             timey = 0; 
             SpawnNewCloud(); 
         }
         if(darttime >= 2){
              darttime = 0; 
             SpawnDart(); 
         }

}
//if(ExtraLife.has_done && !tracky){
    //SpawnBalloon();
    //tracky = true; 
//}
        
    }

 public void SpawnNewCloud(){
        GameObject nc = Instantiate(newCloud[0], this.transform) as GameObject; 
        GameObject nc2 = Instantiate(newCloud[0], this.transform) as GameObject; 
        nc.transform.localPosition = new Vector3(Random.Range(-13.9f, 12f), Random.Range(2.25f, 3.25f), 0f);
        nc2.transform.localPosition = new Vector3(Random.Range(-13.9f, 12f), Random.Range(2.25f, 5.25f), 0f);

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
   public void SpawnPortal(){
        GameObject nc = Instantiate(newCloud[4], this.transform) as GameObject; 
        nc.transform.localPosition = new Vector3(Random.Range(-12.75f,12.75f), 10.2f, 0f);
   }
}
