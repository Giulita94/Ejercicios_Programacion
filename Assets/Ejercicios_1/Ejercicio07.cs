using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    /// <summary>
/// Crear un script que genere tres esferas al inicio separadas 100 metros
/// </summary>
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

            //❕ GenerarEsferas();
        }

        //❕
        void GenerarEsferas()
        {
            for (int i = 0; i < 3; i++)
            {
                GameObject esfera = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                esfera.transform.position = Vector3.right * i;
            }
        }
    }
}
