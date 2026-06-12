using UnityEngine;
// 1. IMPORTANTE: Agregamos el espacio de nombres del nuevo Input System
using UnityEngine.InputSystem;

public class CamaraSeguimiento : MonoBehaviour
{
    [Header("Objetivo")]
    public Transform objetivo;

    [Header("Configuración de Distancia (Zoom)")]
    public float distancia = 5.0f;
    public float distanciaMin = 2.0f;
    public float distanciaMax = 15.0f;
    public float velocidadZoom = 2.0f; // Ajustado para el nuevo sistema

    [Header("Configuración de Rotación")]
    public float velocidadRotacionX = 0.15f; // Ajustado para la sensibilidad del nuevo sistema
    public float velocidadRotacionY = 0.15f;
    public float limiteYMin = -20f;
    public float limiteYMax = 80f;

    private float x = 0.0f;
    private float y = 0.0f;

    void Start()
    {
        Vector3 angles = transform.eulerAngles;
        x = angles.y;
        y = angles.x;
    }

    void LateUpdate()
    {
        if (!objetivo) return;

        // Validamos que el ratón esté disponible
        if (Mouse.current == null) return;

        // 1. ROTACIÓN: Comprobamos si el Clic Derecho está presionado
        if (Mouse.current.rightButton.isPressed)
        {
            // Leemos el delta del ratón (el movimiento físico en pantalla)
            Vector2 mouseDelta = Mouse.current.delta.ReadValue();

            x += mouseDelta.x * velocidadRotacionX;
            y -= mouseDelta.y * velocidadRotacionY;

            y = Mathf.Clamp(y, limiteYMin, limiteYMax);
        }

        // 2. ZOOM: Leemos el scroll de la rueda del ratón
        Vector2 scrollDelta = Mouse.current.scroll.ReadValue();
        if (scrollDelta.y != 0)
        {
            // El scroll en el nuevo sistema suele devolver valores altos (ej. 120 o -120),
            // por lo que lo normalizamos multiplicando por un valor pequeño.
            distancia = Mathf.Clamp(distancia - (scrollDelta.y * 0.01f) * velocidadZoom, distanciaMin, distanciaMax);
        }

        // 3. POSICIONAMIENTO
        Quaternion rotation = Quaternion.Euler(y, x, 0);
        Vector3 calculoDistancia = new Vector3(0.0f, 0.0f, -distancia);
        Vector3 position = rotation * calculoDistancia + objetivo.position;

        transform.rotation = rotation;
        transform.position = position;
    }
}