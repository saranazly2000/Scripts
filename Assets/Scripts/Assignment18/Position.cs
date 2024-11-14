using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor.ShaderGraph.Internal;
using UnityEngine;

namespace Assignment18{
public struct Position 
{
    public float X;
    public float Y;
    public float Z;
    public Position(float x , float y ,float z){
        this.X = x;
        this.Y = y;
        this.Z = z;
    }
    
    public void printPosition(){
        Debug.Log("X value = "+this.X+" "+"Y value = "+this.Y+" "+"Z value = "+this.Z);
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
