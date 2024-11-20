using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18{
public class GameInventory : MonoBehaviour
{
     Inventory potions = new Inventory();
    Inventory elixirs = new Inventory();
    // Start is called before the first frame update
    void Start()
    {
       
        potions.AddItem("Healing Potion");
        potions.AddItem("Strength Potion");
        elixirs.AddItem("Elixir");
        elixirs.AddItem("Dark Elixir");
       Inventory combinedInventory = potions + elixirs; 
       combinedInventory.ShowItems();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}
