using System.Collections;
using System.Collections.Generic;
using Assignment18;
using UnityEngine;


namespace Assignment18{
public class CharacterTest : MonoBehaviour
{

    Officer officer ;
    Soldier soldier;
    
    // Start is called before the first frame update
    void Start()
    {
        officer = new Officer("Fathi",80,new Position(1,1,1));
        soldier = new Soldier();
        Character[] characters = new Character[2];
        characters[0] = officer;
        characters[1] = soldier;
        for(int i=0; i<characters.Length;i++){
          characters[i].DisplayInfo();
        }
        Debug.Log("Soldier's Health before the attack "+soldier.Health);
        officer.Attack(10,soldier);
        Debug.Log("Soldier's Health after the attack "+soldier.Health);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}
