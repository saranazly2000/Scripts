using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    //Exercise 2: Funny Sentence Generator:
       string[] arr = {"Cat", "Dog", "Car", "Pizza", "Hat", "Fish", "Tree", "Monkey", "Ball", "Bird"};
       int counter =0;
       string funnySentence = "";
       while(counter<7){
       int random = Random.Range(0,arr.Length);
       funnySentence+=arr[random] + " ";
       counter++;
       }
      Debug.Log(funnySentence);
    }
}
