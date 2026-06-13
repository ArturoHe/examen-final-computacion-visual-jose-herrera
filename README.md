# Examen Final — Computación Visual

**Autor:** Jose Arturo Herrera Rivera

---

## Descripción general

Este repositorio contiene las soluciones desarrolladas para el examen final de la asignatura de Computación Visual. Se abordaron dos ejercicios independientes:

- **Ejercicio 1 — Procesamiento visual:** análisis y procesamiento de imágenes mediante técnicas computacionales implementadas en Python (Jupyter Notebook).
- **Ejercicio 2 — Escena en Unity:** escena interactiva de exploración espacial ambientada en una base destruida en Marte.

Ambos ejercicios demuestran el dominio de herramientas clave de la computación visual, tanto en el dominio del procesamiento de imágenes como en el de gráficos 3D en tiempo real.

---

## Dependencias

### Ejercicio 1 — Procesamiento visual (Python / Wolfram)

| Dependencia                   | Versión recomendada |
| ----------------------------- | ------------------- |
| Python                        | 3.9+                |
| Jupyter Notebook / JupyterLab | Última estable      |
| NumPy                         | 1.24+               |
| OpenCV (`cv2`)                | 4.7+                |
| Matplotlib                    | 3.7+                |

### Ejercicio 2 — Shaders (Unity)

| Dependencia                     | Versión recomendada     |
| ------------------------------- | ----------------------- |
| Unity                           | 2022.3 LTS              |
| Universal Render Pipeline (URP) | Incluido en Unity       |
| ShaderLab / HLSL                | Integrado en Unity      |
| .NET / C#                       | 9.0 (incluido en Unity) |

---

## Instalación

### Ejercicio 1

1. Clonar el repositorio:
   ```bash
   git clone https://github.com/ArturoHe/examen-final-computacion-visual-jose-herrera.git
   cd examen-final-computacion-visual-jose-herrera/ejercicio_1_procesamiento_visual
   ```

### Ejercicio 2

1. Abrir Unity Hub e importar el proyecto ubicado en la carpeta `ejercicio2/`.
2. Seleccionar la versión de Unity correspondiente (2022.3 LTS recomendada).
3. Esperar a que Unity resuelva los paquetes automáticamente.
4. No se requiere instalación adicional; los shaders están incluidos en el proyecto.

---

## Ejecución

### Ejercicio 1

```bash
cd ejercicio_1_procesamiento_visual
jupyter notebook
```

Abrir el notebook `.ipynb` correspondiente en el navegador y ejecutar las celdas secuencialmente con **Kernel → Restart & Run All**.

### Ejercicio 2

1. Abrir el proyecto en Unity desde Unity Hub.
2. En el panel Project, navegar a la escena principal dentro de `Assets/Scenes/`.
3. Hacer doble clic en la escena para cargarla.
4. Presionar el botón Play en el editor para ejecutar la demostración de shaders.

---

## Estructura del repositorio

```
examen-final-computacion-visual-jose-herrera/
│
├── ejercicio_1_procesamiento_visual/    # Procesamiento de imágenes
│   ├── /resultados                      # Resultados Obtenidos
│   ├── /src                             # Notebook principal de análisis visual
│   └── README.md                        # Readme específico ejercicio 1
│
├── ejercicio2/                          # Proyecto Unity
│   ├── src                              # Carpeta principal del proyecto
│   ├── media                            # Carpeta con los resultados obtenidos
│   └── README.md                        # Readme específico ejercicio 2
```

---

## Evidencias

Las evidencias visuales de cada ejercicio se encuentran en la carpetas `/media` para el ejercicio y en la carpeta `/resultados` para el ejercicio 1

### Ejercicio 1 — Procesamiento visual

Se adjuntan las evidencias de las 7 imágenes requeridas en el desarrollo del procesamiento visual

### Ejercicio 2 — Unity

Se adjuntan evidencias del desarrollo en Blender de los assets, el GIF requerido para observar el funcionamiento del proyecto

---

## Análisis técnico

### Ejercicio 1 — Procesamiento visual

La implementación en Python se enfocó en la aplicación de técnicas clásicas de visión por computador utilizando OpenCV y NumPy para el procesamiento y análisis de imágenes digitales.

El pipeline desarrollado sigue una secuencia típica de procesamiento visual. Inicialmente se trabaja con una imagen de entrada controlada, lo que permite evaluar el comportamiento de los algoritmos bajo condiciones reproducibles. Posteriormente, se realizan transformaciones de representación, incluyendo la conversión a escala de grises y al espacio de color HSV.

La utilización del espacio HSV representa una decisión técnica importante, ya que desacopla la información cromática de la intensidad luminosa. Esto mejora significativamente la robustez de los procesos de segmentación frente a cambios de iluminación, en comparación con espacios como RGB o BGR.

Para reducir ruido y mejorar la estabilidad de los algoritmos posteriores, se aplicó un filtro Gaussiano. Este procedimiento suaviza las variaciones de alta frecuencia presentes en la imagen, disminuyendo la aparición de falsas detecciones durante la extracción de características.

La detección de bordes se realizó mediante el algoritmo Canny, ampliamente utilizado en visión artificial debido a su capacidad para producir contornos precisos mediante técnicas de supresión de no máximos e histéresis. Este enfoque genera resultados más robustos que operadores de gradiente simples como Sobel o Prewitt.

Finalmente, la detección de objetos se llevó a cabo mediante segmentación basada en color utilizando máscaras HSV y extracción de contornos. Esta estrategia permitió identificar regiones de interés, calcular sus límites y generar cuadros delimitadores alrededor de los objetos detectados.

Desde una perspectiva computacional, la solución demuestra cómo técnicas clásicas de visión por computador continúan siendo altamente efectivas cuando se trabaja en escenarios controlados, ofreciendo bajo costo computacional, interpretabilidad y facilidad de implementación en comparación con métodos basados en redes neuronales profundas.

### Ejercicio 2 — Shaders en Unity

La implementación en Unity se centró en la construcción de una experiencia interactiva tridimensional mediante la integración de modelos, animaciones, sistemas de cámara y elementos de interfaz gráfica.

Desde el punto de vista técnico, el proyecto siguió un flujo de trabajo estándar de producción 3D. Los modelos fueron desarrollados inicialmente en Blender y exportados en formato FBX para su integración en Unity. Posteriormente, se aplicaron materiales y texturas PBR generados en Substance Painter, permitiendo obtener una representación visual más realista mediante mapas de color, rugosidad y normales.

La lógica de interacción fue implementada mediante scripts en C#. Se desarrolló un sistema de movimiento basado en entradas del teclado (WASD), complementado por un sistema de animaciones gestionado mediante el Animator Controller de Unity. Este sistema permite la transición entre estados de reposo y movimiento según la entrada del usuario.

Adicionalmente, se implementó una cámara de seguimiento con capacidades de órbita y zoom. El sistema utiliza la posición del personaje como referencia para mantener el encuadre mientras permite al usuario explorar visualmente el entorno mediante movimientos del ratón y la rueda de desplazamiento.

La interfaz gráfica se utilizó para controlar parámetros del entorno en tiempo real. Como ejemplo, el panel solar puede rotarse mediante un Slider de Unity UI, demostrando la integración entre componentes visuales y lógica programada.

En conjunto, la solución evidencia la integración de múltiples áreas del desarrollo de videojuegos y simulaciones interactivas: modelado 3D, animación, programación orientada a componentes, gestión de cámaras e interfaces de usuario.

---

## Uso de IA

Durante el desarrollo del examen se utilizaron herramientas de inteligencia artificial como apoyo en las siguientes áreas:

- **Generación y depuración de código:** asistencia en la escritura de fragmentos de código HLSL y Python, así como en la corrección de errores lógicos y de sintaxis.
- **Consulta conceptual:** resolución de dudas sobre técnicas de procesamiento de imágenes y sobre el pipeline de renderizado de Unity.
- **Documentación:** apoyo en la redacción y estructuración de los README.
