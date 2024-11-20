using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements.Experimental;



namespace Assignment18{
public class GameContainer<T>
{
    private T item;
    public void SetItem(T item){
      this.item = item;
    }
    public T GetItem(){
        return this.item;
    }
}
}
