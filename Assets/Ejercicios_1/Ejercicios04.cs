using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Ejercicios_1;


namespace Ejercicios_1
{
   public class Ejercicios04 : MonoBehaviour
    {


     void Start()
        {

            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.localScale = new Vector3(2f, 2f, 2f);
        }

    }

}