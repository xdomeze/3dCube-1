using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinningCube : MonoBehaviour
{
    public Vector3 RotateAmount;
    void Start()
    {
        
    }

    
    void Update()
    {
     transform.Rotate(RotateAmount);
    }
}
