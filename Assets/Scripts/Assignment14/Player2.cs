using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : Character
{
    public Player2(string Name, int Health) : base(Name, Health){}

    public int Heal(int amount){
      return health+=amount;
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
