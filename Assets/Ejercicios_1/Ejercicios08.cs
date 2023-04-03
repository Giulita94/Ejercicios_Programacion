using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    public class Ejercicios08 : MonoBehaviour
    {
        private void Start()
        {
            GameObject cub01 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            GameObject cub02 = GameObject.CreatePrimitive(PrimitiveType.Cube);
            GameObject cub03 = GameObject.CreatePrimitive(PrimitiveType.Cube);

            cub01.transform.localScale = new Vector3();
            cub02.transform.localScale = Vector3.one * 2f;
            cub03.transform.localScale = Vector3.one * 4f; 
        }
       

        
    }
}

