using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18{
public class Inventory 
{
    private List<string> items = new List<string>();
    public void AddItem(string item){
     this.items.Add(item);
    }
    public void ShowItems(){
        foreach(string i in items){
         Debug.Log(i);
      }
    }
    public static Inventory operator + (Inventory a, Inventory b){
        Inventory inventory= new Inventory();
        foreach(string i in a.items){
          inventory.AddItem(i);
        }
          foreach(string i in b.items){
          inventory.AddItem(i);
        }
       return inventory;
    }
}
}
