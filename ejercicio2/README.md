# Autor: Jose Arturo Herrera Rivera

# Ejercicio 2 - Entorno 3d

## ¿Qué problema o propósito aborda el ejercicio?

El objetivo de este ejercicio fue desarrollar una escena interactiva de exploración espacial ambientada en una base destruida en Marte. La práctica permitió aplicar conocimientos de modelado 3D, texturizado PBR, integración de assets en Unity, programación de mecánicas de interacción y control de cámaras en un entorno tridimensional funcional.

## ¿Qué herramientas, librerías o motores se utilizaron?

Durante el desarrollo se utilizaron las siguientes herramientas:

- Blender para el modelado 3D de los assets de la escena y la creación del terreno marciano.
- Substance Painter para la generación de materiales y texturas PBR mediante el uso de materiales inteligentes.
- Mixamo para obtener el modelo del personaje y sus animaciones de reposo y caminata.
- Unity como motor principal para la integración de los assets, programación de interacciones y construcción de la experiencia final.
- C# para el desarrollo de los scripts de control y comportamiento de los elementos de la escena.

## ¿Cómo se ejecuta la solución?

La solución se ejecuta dentro del motor Unity. Una vez iniciada la escena:

- El personaje puede desplazarse utilizando las teclas W, A, S y D.
- La cámara sigue automáticamente al personaje.
- Al mantener presionado el clic derecho del ratón y moverlo, la cámara puede orbitar alrededor del personaje.
- La rueda del ratón permite acercar o alejar la vista.
- Un control deslizante (slider) en la interfaz permite modificar la orientación de un panel solar instalado en la base marciana.

## ¿Qué resultados se obtuvieron?

Se logró construir una escena completa de exploración espacial ambientada en Marte, incluyendo:

- Modelos 3D personalizados creados en Blender.
- Materiales y texturas PBR aplicadas a todos los elementos de la escena.
- Un terreno marciano modelado y texturizado manualmente.
- Un personaje animado con movimientos de reposo y caminata.
- Una cámara interactiva con seguimiento, órbita y zoom.
- Un sistema de interfaz gráfica para controlar la rotación de un panel solar.

El resultado final fue una experiencia interactiva funcional que integra modelado, texturizado, animación y programación dentro de un entorno tridimensional cohesivo.

## ¿Qué dificultades aparecieron y cómo se resolvieron?

### Creación del proyecto en Unity

Se tuvo que cambiar el nombre de la carpeta que contenía el proyecto ya que Unity decía que era muy largo

### Exportación de modelos entre Blender y Unity

Inicialmente surgieron problemas al importar los modelos desde Blender hacia Unity debido a que varios objetos no se encontraban correctamente posicionados respecto al origen de coordenadas. Tras investigar el flujo de trabajo adecuado, se descubrió que los modelos debían estar correctamente centrados en el origen de Blender antes de exportarlos, lo que solucionó los errores de ubicación dentro de Unity.

### Sistema de animaciones del personaje

También se presentaron dificultades al implementar las animaciones del personaje y su movimiento. Gran parte de la documentación disponible hacía referencia a sistemas de movimiento utilizados en versiones anteriores de Unity, mientras que las versiones actuales incorporan nuevos componentes y metodologías de control. Este problema fue resuelto mediante la consulta de documentación actualizada y tutoriales especializados.

### Integración de animaciones

Durante la configuración de las animaciones de caminata y reposo surgieron inconvenientes relacionados con las transiciones y la sincronización de estados. La solución consistió en estudiar ejemplos prácticos y realizar múltiples pruebas hasta obtener transiciones fluidas y coherentes entre las animaciones.

## ¿Qué prompts de IA se usaron, si aplica?

Durante el desarrollo de este proyecto se utilizó inteligencia artificial como herramienta de apoyo para resolver dudas relacionadas con:

Implementación de movimiento de personajes en Unity.
Configuración de cámaras orbitales.
Programación de interfaces gráficas mediante sliders.
Resolución de problemas de importación de modelos y animaciones.
Consulta de ejemplos de scripts en C#.

Ejemplos de prompts utilizados:

- "¿Cómo hacer que una cámara siga y orbite alrededor de un personaje en Unity?"
- "¿Cómo controlar la rotación de un objeto usando un Slider de Unity?"
- "¿Cómo importar correctamente modelos FBX desde Blender a Unity?"
- "¿Cómo configurar animaciones de caminata y reposo en Unity utilizando Animator?"

## ¿Qué partes fueron verificadas manualmente por el estudiante?

Las siguientes funcionalidades fueron verificadas manualmente:

- Correcta importación de los modelos desde Blender hacia Unity.
- Aplicación adecuada de las texturas PBR generadas en Substance Painter.
- Funcionamiento del movimiento del personaje mediante teclado.
- Transiciones entre las animaciones de reposo y caminata.
- Seguimiento y órbita de la cámara alrededor del personaje.
- Control de zoom mediante la rueda del ratón.
- Funcionamiento del slider para modificar la orientación del panel solar.
- Integración visual de todos los elementos dentro de la escena final.
