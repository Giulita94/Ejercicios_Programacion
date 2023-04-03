using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    public class Ejercicios07 : MonoBehaviour
    {
        private void Start()
        {
            GameObject esf01 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            GameObject esf02 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            GameObject esf03 = GameObject.CreatePrimitive(PrimitiveType.Sphere);

            esf01.transform.position = new Vector3(100f, 0f, 0f);
            esf02.transform.position = new Vector3(0f, 100f, 0f);
            esf03.transform.position = new Vector3(0f, 0f, 100f);
        }
    }
}
