using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character 
{
    private string Name;
    private int Health;
    public string name{
        get { return Name; } 
        set { Name = value; } 
    }
     public int health{
        get { return Health; } 
        set { Health = value; } 
    }
    public Character(string Name ,int Health){
        name=Name;
        health=Health;
    }    

       

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
