using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ejercicios_1
{
    /// <summary>
    /// Crear un script que genere 12 esferas cada una el doble de grande que la anterior
    /// </summary>
    public class Ejercicio09 : MonoBehaviour
    {
        private void Start()
        {
            GameObject esfera = GameObject.CreatePrimitive(PrimitiveType.Sphere);
            esfera.transform.position = new Vector3();
            esfera.transform.localScale = new Vector3();

            for (int i = 1; i <= 12; i++)
            {
                GameObject esfera1 = GameObject.CreatePrimitive(PrimitiveType.Sphere);
                esfera1.transform.position = new Vector3(i, i, 1f) * 5f;
                esfera1.transform.localScale = new Vector3(i, i, i) * 2f;
            }

            //❕ Ejercicio08.CrearFiguras(PrimitiveType.Sphere, 12);
        }
    }
}