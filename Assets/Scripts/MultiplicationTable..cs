using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultiplicationTable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("The 5’smultiplication table:");
        for(int i=1 ; i<=10 ; i++){
          Debug.Log("5 x "+i+"="+Multiply(i,5));
        }

    }

    int Multiply(int firstNumber,int secondNumber){
        int result = firstNumber*secondNumber;
        return result;
    }
}

