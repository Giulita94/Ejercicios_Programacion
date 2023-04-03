using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Ejercicio03 : MonoBehaviour
{
    
        
        Vector3 v = new Vector3(111.1f, -5f, 4.5f);
        void Start ()
        {
            GameObject Cube = new GameObject();
            Cube.transform.position = v;
        }
        void Update ()
        {


        }
    
   

}
