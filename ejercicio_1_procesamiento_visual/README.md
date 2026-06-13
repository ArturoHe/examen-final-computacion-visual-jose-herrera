# Autor: Jose Arturo Herrera Rivera

# Ejercicio 1 - Procesamiento Visual e Inteligencia Artificial con OpenCV

## ¿Qué problema o propósito aborda el ejercicio?

El objetivo principal de este taller fue explorar técnicas fundamentales de procesamiento digital de imágenes utilizando OpenCV y NumPy. A lo largo de la práctica se implementó un pipeline completo de procesamiento visual que incluyó conversión de espacios de color, filtrado, detección de bordes y segmentación de objetos mediante técnicas clásicas de visión por computador. El ejercicio permitió analizar cómo distintas transformaciones afectan la representación de una imagen y cómo pueden emplearse para extraer información relevante de manera eficiente.

## ¿Qué herramientas, librerías o motores se utilizaron?

Durante el desarrollo se emplearon las siguientes tecnologías:

- Python como lenguaje principal de programación.
- OpenCV (opencv-python-headless) para las operaciones de visión por computador y procesamiento de imágenes.
- NumPy para el manejo eficiente de matrices y estructuras de datos numéricas.
- VS Code / Entorno Python para el desarrollo y ejecución del proyecto.

Para el desarrollo se tomaron varias decisiones técnicas importantes:

- Se utilizó una imagen sintética para garantizar reproducibilidad total del experimento.
- Se seleccionó el espacio de color HSV debido a su robustez frente a cambios de iluminación y facilidad para definir rangos de color.
- Se eligió el filtro Gaussiano por su capacidad para reducir ruido preservando transiciones suaves.
- Se utilizó Canny en lugar de Sobel debido a que produce bordes más limpios y precisos mediante histéresis y supresión de no máximos.
- Se implementó segmentación clásica basada en color en lugar de modelos de inteligencia artificial, ya que la naturaleza controlada de los objetos hacía innecesario el uso de redes neuronales más complejas.

## ¿Cómo se ejecuta la solución?

Una vez instaladas las dependencias necesarias, la aplicación puede ejecutarse con el archivo .ipynb en jupyter lab:

Durante la ejecución se generan automáticamente todas las imágenes de salida dentro de la carpeta resultados/, incluyendo tanto los resultados individuales como el panel comparativo final.

## ¿Qué resultados se obtuvieron?

La implementación permitió obtener correctamente todas las etapas del pipeline de procesamiento visual:

- Imagen original sintética utilizada como entrada.
- Conversión a escala de grises.
- Conversión al espacio de color HSV.
- Aplicación del filtro Gaussiano.
- Detección de bordes mediante el algoritmo Canny.
- Segmentación de objetos basada en color.
- Panel comparativo con todas las etapas del procesamiento.

Además, la etapa de segmentación logró detectar siete objetos presentes en la escena sintética, generando sus correspondientes contornos, etiquetas y cajas delimitadoras.

Los resultados permitieron comprobar la efectividad de las técnicas clásicas de visión por computador cuando se trabaja en entornos controlados donde las características de los objetos son conocidas previamente.

## ¿Qué dificultades aparecieron y cómo se resolvieron?

### Selección de parámetros de procesamiento

Uno de los principales desafíos fue comprender cómo afectan los distintos parámetros a la calidad de los resultados obtenidos. Fue necesario experimentar con diferentes tamaños de kernel y umbrales hasta encontrar configuraciones que permitieran obtener imágenes suavizadas sin perder detalles importantes.

### Comprensión de los espacios de color

Inicialmente resultó complejo entender las diferencias prácticas entre los espacios BGR y HSV. Tras realizar pruebas y revisar documentación técnica, se observó que HSV ofrece una representación mucho más adecuada para tareas de segmentación por color debido a la separación entre cromaticidad e intensidad.

### Ajuste de la detección de bordes

La detección de bordes mediante Canny requirió varios ensayos para seleccionar valores de umbral adecuados. Valores demasiado bajos generaban ruido excesivo, mientras que valores altos eliminaban detalles relevantes. Finalmente se adoptó la configuración 50/150 por ofrecer un equilibrio adecuado.

### Segmentación de objetos

La implementación de la segmentación por color exigió ajustar correctamente los rangos HSV y los filtros de área mínima para evitar falsas detecciones. El problema se resolvió mediante pruebas iterativas y análisis visual de los resultados generados.

## ¿Qué prompts de IA se usaron, si aplica?

Durante el desarrollo se empleó inteligencia artificial como apoyo para comprender conceptos y resolver dudas relacionadas con el procesamiento de imágenes.

Algunos ejemplos de prompts utilizados fueron:

- "¿Cuál es la diferencia entre BGR y HSV en OpenCV?"
- "¿Cómo funciona el algoritmo de detección de bordes Canny?"
- "¿Qué ventajas tiene el filtro Gaussiano frente al filtro de mediana?"
- "¿Cómo detectar objetos mediante segmentación por color usando OpenCV?"
- "¿Cómo encontrar contornos y dibujar bounding boxes en OpenCV?"

## ¿Qué partes fueron verificadas manualmente por el estudiante?

Las siguientes partes del proyecto fueron verificadas manualmente:

- Correcta generación de la imagen sintética de entrada.
- Conversión adecuada a escala de grises.
- Transformación correcta al espacio HSV.
- Aplicación apropiada del filtro de suavizado.
- Calidad de los bordes obtenidos mediante Canny.
- Precisión de la segmentación por color.
- Correcta detección y etiquetado de objetos.
- Generación de todas las imágenes de salida.
- Construcción correcta del panel comparativo final.

La inspección visual de cada etapa permitió validar el funcionamiento esperado del pipeline completo de procesamiento de imágenes.
