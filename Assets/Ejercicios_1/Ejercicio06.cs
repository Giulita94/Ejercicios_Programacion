using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    public class Ejercicio06 : MonoBehaviour
    {
        private void Start()
        {
            GameObject esfera = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            GameObject esfera01 = GameObject.CreatePrimitive(PrimitiveType.Sphere);

            esfera.transform.position = new Vector3(0f, 0f, 0f);
            esfera01.transform.position = new Vector3(100f, 0f, 0f);
        }
    }
}