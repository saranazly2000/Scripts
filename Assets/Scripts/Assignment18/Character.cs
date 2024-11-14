using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18{

public class Character 
{
    public string name;
    private int health;
    protected Position position;

   public int Health{
    set{
        if(value > 100)  health=100;
        else if(value < 0) health=0;
        else health = value;
    }
    get{return health;}
   }
    public Character(string name,int health,Position position){
     this.name = name;
     this.Health = health;
     this.position =position;
   }
   public Character() : this("No name", 100, new Position(0,0,0)){
    
   }

   
   public virtual void DisplayInfo(){
      Debug.Log("Name: "+" "+this.name +" "+"Health: "+this.Health);
      position.printPosition();
   }

   public void Attack(int damage,Character target){
      target.Health -=damage;
   }
   
    public void Attack(int damage,Character target,string attackType){
      Attack(damage,target);
      Debug.Log(attackType);
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
}
