using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Player player1=new Player();
        Player player2=new Player();
        player1.InitializePlayer("Fathi",80);
        player2.InitializePlayer("Fathia",60);
        player1.Heal(10);
        player1.Heal(true);
        player2.Heal(15);
        player2.Heal(true);
        Player.ShowPlayerCount(); 
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
