using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Assignment18{
public class GenericsTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameContainer<string> gameContainerb= new GameContainer<string>();
        gameContainerb.SetItem("Healing Potion.");
        Debug.Log("Stored item: "+gameContainerb.GetItem());
        Debug.Log(GameUtils.DescribeItem<string>(gameContainerb.GetItem()));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
}
