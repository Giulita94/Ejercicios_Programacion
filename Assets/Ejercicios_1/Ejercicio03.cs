using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Ejercicios_1
{
    /// <summary>
    /// Crear un script que genere un cubo al inicio y duplique su escala
    /// </summary>
    public class Ejercicio03 : MonoBehaviour
    {
        void Start()
        {
            GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
            cube.transform.localScale *= 2f;
        }
    }
}