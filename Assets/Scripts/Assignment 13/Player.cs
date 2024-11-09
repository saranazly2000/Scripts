using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player 
{
 public string playerName;
 public int health;
 static public int playerCount;
 public void InitializePlayer(string name, int initialHealth){
    playerName=name;
    health=initialHealth;
    playerCount++;
 }
 public void Heal(int amount){
  Debug.Log(health+=amount);
 }
 public void Heal(bool fullRestore){
  if(fullRestore == true) health=100;
 }
 static public void ShowPlayerCount(){
    Debug.Log(playerCount);
 }

}
