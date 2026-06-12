using UnityEngine;

public class RotadorObjeto : MonoBehaviour
{
    private float rotacionInicialY;
    private float rotacionInicialZ;

    void Start()
    {
        // Guardamos los ángulos EULER LOCALES actuales en Y y Z
        rotacionInicialY = transform.localEulerAngles.y;
        rotacionInicialZ = transform.localEulerAngles.z;
    }

    public void ActualizarRotacionX(float valorSlider)
    {
        // Cambia solo el eje X local del padre, manteniendo Y y Z en 0
        transform.localRotation = Quaternion.Euler(valorSlider, 0, 0);
    }
}