🎙️ REPORTE DEL PROYECTO
Streaming Podcast Manager (Audio)
1. Introducción
El presente proyecto tiene como objetivo el desarrollo de un sistema basado en NoSQL para la gestión de podcasts, utilizando una arquitectura orientada a documentos.
Se diseñó una solución que permite almacenar y consultar información sobre usuarios, podcasts, episodios y playlists, aplicando herramientas modernas como , y .
El proyecto se organizó mediante la metodología Scrum, lo que permitió dividir el trabajo en sprints y distribuir responsabilidades de manera eficiente.
 2. Objetivo del Proyecto
Desarrollar una base de datos funcional en MongoDB que permita:
• Gestionar información de podcasts
• Aplicar consultas simples y avanzadas
• Implementar filtros y lógica en queries
• Diseñar una interfaz visual del sistema
 3. Product Backlog (Resumen)
El proyecto se estructuró en diferentes áreas clave:
• Modelado de datos (JSON, Embedding, Referencing)
• Configuración de MongoDB Atlas
• Generación de datos (seeding)
• Consultas básicas (find, findOne)
• Filtros ($gt, $lt, $in, $ne)
• Lógica ($and, $or, $not)
• Testing y validación
• Interfaz en Flutter
Este backlog permitió organizar el desarrollo de forma progresiva.

 4. Desarrollo por Sprints

♤ Sprint 1: Modelado y Base de Datos
Objetivo: Definir la estructura del sistema
Actividades realizadas:
• Diseño del modelo de datos en formato JSON
• Implementación de Embedding y Referencing
• Creación de diagrama en Mermaid
• Configuración de base de datos en MongoDB Atlas
♤ Sprint 2: Seeding y Consultas Básicas
Objetivo: Insertar y consultar datos
Actividades:
• Generación de 50 usuarios en JSON
• Inserción de datos con insertMany()
• Uso de find() y findOne()
♤Sprint 3: Filtros
Objetivo: Aplicar condiciones a consultas
Actividades:
• Implementación de operadores $gt, $lt, $in, $ne
• Creación de consultas con filtros
• Validación de resultados
♤ Sprint 4: Lógica
Objetivo: Crear consultas avanzadas
Actividades:
• Uso de $and, $or, $not
• Desarrollo de queries complejas
• Pruebas en MongoDB Atlas
♤ Sprint 5: Integración e Interfaz
Objetivo: Presentar el sistema completo
Actividades:
• Integración del sistema
• Diseño de interfaz en Figma
• Desarrollo básico en Flutter
• Organización del repositorio en GitHub

 5. Roles y Aportaciones del Equipo
☆ Iván — Integration Specialist
• Configuración de MongoDB Atlas
• Verificación de conexión y funcionamiento
• Integración general del sistema
• Organización técnica del proyecto
☆Dilan — Query Developer
• Desarrollo de consultas (find, filtros, lógica)
• Implementación de operadores de MongoDB
• Optimización de queries
☆ Maria — Data Modeler
• Diseño del modelo de datos
• Definición de colecciones y estructura JSON
• Aplicación de embedding y referencing
• Creación del diagrama Mermaid
☆ Ariz — Data Seeder / QA
• Generación de datos de prueba
• Inserción de datos en la base
• Validación de consultas
• Verificación de resultados
☆ Klara — Scrum Master
• Organización del equipo
• Distribución de tareas
• Seguimiento de sprints
• Coordinación del proyecto

 6. Uso de Inteligencia Artificial
Durante el desarrollo del proyecto se utilizó como herramienta de apoyo.

Aplicaciones del uso de IA:
• Explicación de conceptos (NoSQL, MongoDB, queries)
• Generación de ejemplos de consultas
• Corrección de errores en código
• Apoyo en diseño del backlog y sprints
• Asistencia en documentación y estructura del proyecto
El uso de IA permitió mejorar la comprensión de los temas y agilizar el desarrollo.
 7. Validación del Sistema
Para comprobar el correcto funcionamiento del proyecto se realizaron:
• Consultas en MongoDB Atlas
• Pruebas con filtros y operadores
• Verificación de resultados en tiempo real
Ejemplo:
db.users.find({ active_status: true }) 
Esto permitió confirmar que la base de datos funciona correctamente.
 8. Interfaz de Usuario
Se diseñó una interfaz basada en Figma y se implementó una versión básica en Flutter.
La interfaz permite:
• Visualizar podcasts
• Navegar entre episodios
• Representar la estructura del sistema
 9. Resultados
El proyecto logró:
• Implementar una base de datos NoSQL funcional
• Aplicar consultas básicas y avanzadas
• Organizar el desarrollo con Scrum
• Integrar herramientas modernas
• Simular una aplicación real de streaming
  10. Conclusión
El desarrollo del proyecto permitió comprender el funcionamiento de las bases de datos NoSQL y su aplicación en sistemas reales.
Además, el uso de Scrum facilitó la organización del trabajo, mientras que las herramientas tecnológicas y la inteligencia artificial ayudaron a mejorar la eficiencia del equipo.
