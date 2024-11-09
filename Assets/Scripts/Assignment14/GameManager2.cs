using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager2 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       Player2 player=new Player2("Fathi",80); 
       Enemy enemy=new Enemy("Fathia",70); 
       Debug.Log(player.name);
       Debug.Log(player.health);
       Debug.Log(enemy.name);
       Debug.Log(enemy.health);
       Debug.Log(player.Heal(10));
       Debug.Log(enemy.Attack(player,10));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
