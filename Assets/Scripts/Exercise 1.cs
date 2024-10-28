using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
      
     // Exercise 1: Number Generator:
      int counter = 0;
       while(counter < 20 ){
       int random = Random.Range(1,21);
       if(random==5){
        continue;
       }
       if(random==15){
        break;
       }
       Debug.Log(random);
       counter++;
       }



    }



   
}
