# 📋 PRODUCT BACKLOG — STREAMING PODCAST MANAGER

---

## 🎯 PRODUCT GOAL

Desarrollar una aplicación de gestión de podcasts respaldada por una base de datos NoSQL en MongoDB Atlas, que permita a los usuarios explorar contenido, gestionar su biblioteca personal, interactuar con la comunidad y a los creadores administrar sus episodios — todo mediante operaciones CRUD, consultas avanzadas y agregaciones, aplicando metodología Scrum.

---

## 🗂️ ÉPICAS

| Epic ID | Nombre | Descripción |
|---------|--------|-------------|
| EP-01 | Gestión de cuenta | Registro, autenticación y administración del perfil de usuario. |
| EP-02 | Exploración de contenido | Búsqueda, filtrado y visualización de podcasts y episodios. |
| EP-03 | Biblioteca personal | Favoritos, listas de reproducción e historial del oyente. |
| EP-04 | Interacción social | Comentarios, reseñas y calificaciones de contenido. |
| EP-05 | Perfil de creador | Publicación y administración de contenido por parte del creador. |
| EP-06 | Métricas y estadísticas | Reportes de actividad y rendimiento del contenido. |
| EP-07 | Infraestructura y despliegue | Configuración de Atlas, repositorio, documentación y entrega final. |

---

## 📦 PRIMER PARCIAL — ARQUITECTURA Y MODELADO

| ID | Épica | Sprint | Historia de Usuario | Criterio de Aceptación | Colección MongoDB | Responsable | Estado |
|----|-------|--------|---------------------|------------------------|-------------------|-------------|--------|
| US-01 | EP-01 | S1 | Como usuario, quiero registrarme en la plataforma para crear mi cuenta personal. | El sistema crea documentos en `users` y `accounts` con credenciales válidas y sin duplicados. | `users` / `accounts` | Klara / Iván | ✅ Done |
| US-02 | EP-01 | S1 | Como usuario, quiero iniciar y cerrar sesión de forma segura. | Se genera un registro en `sessions` al iniciar. Al cerrar sesión, el documento se elimina o invalida. | `sessions` / `verificationtokens` | Iván | ✅ Done |
| US-03 | EP-02 | S2 | Como oyente, quiero explorar el catálogo de podcasts disponibles para descubrir contenido nuevo. | Se listan documentos de `podcasts` con sus campos principales (título, categoría, creador). | `podcasts` / `creadores` | Maria | ✅ Done |
| US-04 | EP-02 | S2 | Como oyente, quiero ver los episodios de un podcast para elegir cuál escuchar. | Al seleccionar un podcast, se recuperan sus `episodes` o `episodios` relacionados correctamente. | `episodes` / `episodios` | Maria | ✅ Done |
| US-05 | EP-07 | S3 | Como usuario, quiero que la aplicación esté conectada a una base de datos en la nube para acceder a mis datos desde cualquier lugar. | El clúster de Atlas está activo y la conexión desde Compass es exitosa. | Cluster0 / `proyectopodcast` | Iván | ✅ Done |
| US-06 | EP-07 | S4 | Como usuario, quiero que el sistema cuente con datos de prueba realistas para validar las funcionalidades. | Al menos 50 documentos insertados en las colecciones principales sin errores de esquema. | `usuarios` / `episodes` / `podcasts` | Klara / Ariz | ✅ Done |
| US-07 | EP-02 | S4 | Como oyente, quiero buscar un podcast por su nombre y obtener resultados precisos. | La consulta `find()` retorna documentos válidos de `podcasts` que coinciden con el término buscado. | `podcasts` | Dilan | ✅ Done |
| US-08 | EP-05 | S5 | Como creador, quiero que la estructura de mis episodios y datos de perfil esté bien definida para garantizar consistencia. | La documentación explica y justifica las decisiones de Embedding vs Referencing aplicadas al modelo. | `creadores` / `episodios` | Maria | ✅ Done |
| US-09 | EP-07 | S6 | Como equipo, queremos que el repositorio del proyecto esté organizado para facilitar la colaboración. | El repositorio en GitHub tiene estructura clara, README completo con guía de instalación, arquitectura y uso. | — | Klara / All Team | ✅ Done |
| US-10 | EP-07 | S7 | Como evaluador, quiero ver una presentación de la arquitectura de la base de datos para entender las decisiones de diseño. | La presentación incluye diagramas de colecciones, justificación del modelo y ejemplos de documentos. | — | All Team | ✅ Done |

---

## 📦 SEGUNDO PARCIAL — CONSULTAS Y MANIPULACIÓN DE DATOS

| ID | Épica | Sprint | Historia de Usuario | Criterio de Aceptación | Colección MongoDB | Responsable | Estado |
|----|-------|--------|---------------------|------------------------|-------------------|-------------|--------|
| US-11 | EP-02 | S8 | Como oyente, quiero buscar un episodio específico por su título o ID para acceder directamente a él. | Las consultas `find()` y `findOne()` retornan los documentos correctos de `episodes`. | `episodes` / `episodios` | Dilan | ✅ Done |
| US-12 | EP-07 | S8 | Como usuario, quiero que el sistema valide las consultas con datos reales para garantizar su correcto funcionamiento. | Todas las consultas básicas son validadas con datos reales en Atlas sin errores. | `podcasts` / `episodes` | Klara / Ariz | ✅ Done |
| US-13 | EP-02 | S9 | Como oyente, quiero filtrar podcasts por duración, calificación o categoría para encontrar contenido que se adapte a mis preferencias. | Los operadores `$gt`, `$lt`, `$in`, `$ne` filtran correctamente sobre los campos numéricos y categóricos. | `podcasts` / `ratings` | Dilan | ✅ Done |
| US-14 | EP-07 | S9 | Como desarrollador, quiero identificar errores en los filtros aplicados para garantizar la calidad de las consultas. | Se documentan los bugs de consulta encontrados durante las pruebas de los operadores de comparación. | `queries` | Klara / Ariz | ✅ Done |
| US-15 | EP-02 | S10 | Como oyente, quiero combinar múltiples filtros de búsqueda para obtener resultados más precisos. | Los operadores `$and`, `$or`, `$not` combinan condiciones y retornan los documentos esperados. | `podcasts` / `episodes` | Dilan | 🔄 In Progress |
| US-16 | EP-07 | S10 | Como equipo, queremos verificar que las consultas avanzadas sean compatibles con el esquema de la base de datos. | Las consultas lógicas son compatibles con la estructura de `usuarios` y `creadores` sin errores de esquema. | `usuarios` / `creadores` | Maria | 🔄 In Progress |
| US-17 | EP-03 | S11 | Como oyente, quiero que mis listas de reproducción puedan contener múltiples episodios organizados de forma eficiente. | Las consultas sobre arreglos en `playlists` y documentos anidados en `favorites` retornan resultados válidos. | `playlists` / `favorites` | Dilan | ⏳ Pending |
| US-18 | EP-07 | S11 | Como desarrollador, quiero contar con datos de prueba con arreglos complejos para validar consultas anidadas. | Se generan documentos con arrays de más de 3 elementos en `playlists` y `favorites` sin errores. | `playlists` / `favorites` | Klara / Ariz | ⏳ Pending |
| US-19 | EP-04 | S12 | Como oyente, quiero poder editar o eliminar mis reseñas y comentarios para mantener mi opinión actualizada. | `updateOne()` modifica correctamente un documento en `reviews` o `comments` del usuario autenticado. | `reviews` / `comments` | Dilan | ⏳ Pending |
| US-20 | EP-03 | S12 | Como oyente, quiero que mis favoritos se actualicen en tiempo real al agregar o quitar contenido. | `updateMany()` actualiza el estado de los documentos en `favorites` y los cambios se reflejan en Atlas. | `favorites` / `downloads` | Iván | ⏳ Pending |

---

## 📦 TERCER PARCIAL — INTEGRACIÓN FINAL Y DESPLIEGUE

| ID | Épica | Sprint | Historia de Usuario | Criterio de Aceptación | Colección MongoDB | Responsable | Estado |
|----|-------|--------|---------------------|------------------------|-------------------|-------------|--------|
| US-21 | EP-07 | S17 | Como usuario, quiero que todas las funcionalidades de la app funcionen correctamente de forma integrada. | CRUD completo y consultas avanzadas operan sin conflictos en todas las colecciones del proyecto. | Todas | All Team | ⏳ Pending |
| US-22 | EP-07 | S17 | Como usuario, quiero que la base de datos esté disponible de forma estable en la nube para garantizar acceso continuo. | El despliegue en Atlas es estable, la conexión responde correctamente y no hay caídas en pruebas. | Cluster0 | Iván | ⏳ Pending |
| US-23 | EP-07 | S17 | Como colaborador del proyecto, quiero que el repositorio tenga documentación completa y actualizada. | El README y la documentación técnica están actualizados con instrucciones de uso, arquitectura y ejemplos. | — | Klara | ⏳ Pending |
| US-24 | EP-06 | S17 | Como creador, quiero ver estadísticas de rendimiento de mis episodios para tomar decisiones sobre mi contenido. | Los pipelines de agregación con `$group`, `$sum` y `$avg` sobre `ratings`, `downloads` y `favorites` retornan datos correctos. | `ratings` / `downloads` / `favorites` | Dilan | ⏳ Pending |
| US-25 | EP-05 | S17 | Como creador, quiero que el esquema final de la base de datos soporte todas las operaciones de mi perfil sin errores. | El esquema final es revisado y aprobado; soporta insert, update y delete en `creadores` y `episodios`. | `creadores` / `episodios` | Maria | ⏳ Pending |
| US-26 | EP-07 | S17 | Como equipo QA, quiero validar todos los datasets de prueba para asegurar la integridad de los datos. | Las pruebas detectan y documentan todos los bugs; los datos de prueba pasan validación de esquema. | Todas | Klara / Ariz | ⏳ Pending |
| US-27 | EP-07 | S17 | Como equipo, queremos publicar la versión final del proyecto para entregar un producto completo y funcional. | El Release v3.0 es generado en GitHub con todos los scripts, documentación y colecciones funcionando. | — | All Team | ⏳ Pending |
| US-28 | EP-07 | S17 | Como evaluador, quiero ver una demostración funcional del sistema para verificar que cumple los requisitos del proyecto. | El video demo muestra CRUD, consultas, agregaciones y conectividad con Atlas de forma fluida. | — | All Team | ⏳ Pending |
| US-29 | EP-07 | S18 | Como evaluador académico, quiero presenciar la defensa del proyecto para verificar el dominio técnico del equipo. | La presentación final es entregada con éxito, incluyendo diagramas, decisiones de diseño y demo en vivo. | — | All Team | ⏳ Pending |
| US-30 | EP-07 | S18 | Como Scrum Master, quiero entregar el reporte final del proyecto con toda la evidencia requerida. | El reporte final incluye backlog, sprints, retrospectivas, evidencia de pruebas y evaluación del equipo. | — | Klara | ⏳ Pending |

---

## 🧪 PRUEBAS UNITARIAS — GHERKIN

### Feature: Gestión de cuenta de usuario

```gherkin
Feature: Registro e inicio de sesión de usuario

  Scenario: Registro exitoso de un nuevo usuario
    Given el usuario no tiene una cuenta registrada
    When el usuario envía su nombre, correo y contraseña válidos
    Then el sistema crea un documento en la colección "users"
    And crea un documento asociado en la colección "accounts"
    And la contraseña se almacena de forma encriptada

  Scenario: Inicio de sesión exitoso
    Given el usuario tiene una cuenta registrada en "users"
    When el usuario ingresa sus credenciales correctas
    Then el sistema genera un documento activo en la colección "sessions"
    And el usuario obtiene acceso a su perfil personal

  Scenario: Cierre de sesión
    Given el usuario tiene una sesión activa en "sessions"
    When el usuario ejecuta la acción de cerrar sesión
    Then el documento de sesión es eliminado o marcado como inválido
    And el usuario pierde acceso a las funciones autenticadas
```

---

### Feature: Exploración de podcasts y episodios

```gherkin
Feature: Búsqueda y visualización de contenido

  Scenario: Listar todos los podcasts disponibles
    Given la colección "podcasts" contiene documentos
    When el usuario accede a la sección de exploración
    Then se retornan todos los podcasts con find()
    And se muestran título, categoría y referencia al creador

  Scenario: Ver episodios de un podcast específico
    Given existe un podcast con ID válido en la colección "podcasts"
    When el usuario selecciona ese podcast
    Then se ejecuta find() sobre "episodes" filtrando por podcast_id
    And se retornan únicamente los episodios pertenecientes a ese podcast

  Scenario: Buscar un episodio por título
    Given la colección "episodes" contiene documentos con campo "title"
    When el usuario escribe un término de búsqueda
    Then se ejecuta findOne() con filtro sobre el campo "title"
    And se retorna el primer episodio cuyo título coincida con el término
```

---

### Feature: Filtrado avanzado de contenido

```gherkin
Feature: Operadores de comparación en consultas

  Scenario: Filtrar podcasts con calificación mayor a 4
    Given la colección "ratings" contiene documentos con campo numérico "score"
    When el usuario aplica el filtro de "mejor calificados"
    Then se ejecuta una consulta con $gt: 4 sobre "ratings"
    And solo se retornan los documentos cuyo "score" es mayor a 4

  Scenario: Filtrar episodios por categoría específica
    Given la colección "podcasts" tiene documentos con campo "category"
    When el usuario selecciona una o más categorías del filtro
    Then se ejecuta una consulta con $in sobre el campo "category"
    And se retornan únicamente los podcasts que pertenecen a las categorías seleccionadas

  Scenario: Combinar filtros de categoría y duración
    Given existen podcasts con campos "category" y "duration"
    When el usuario aplica filtros de categoría y duración simultáneamente
    Then se ejecuta una consulta con $and combinando ambas condiciones
    And solo se retornan documentos que cumplen ambos criterios
```

---

### Feature: Biblioteca personal del oyente

```gherkin
Feature: Gestión de favoritos y listas de reproducción

  Scenario: Agregar un podcast a favoritos
    Given el usuario está autenticado y el podcast existe en "podcasts"
    When el usuario presiona "Agregar a favoritos"
    Then se inserta un documento en la colección "favorites" con el user_id y el podcast_id
    And el podcast aparece en la sección de favoritos del usuario

  Scenario: Eliminar un podcast de favoritos
    Given el usuario tiene un podcast guardado en "favorites"
    When el usuario presiona "Eliminar de favoritos"
    Then se ejecuta deleteOne() sobre "favorites" con el user_id y podcast_id correspondientes
    And el podcast desaparece de la sección de favoritos

  Scenario: Crear una lista de reproducción con episodios
    Given el usuario está autenticado
    When el usuario crea una nueva lista y agrega episodios
    Then se inserta un documento en "playlists" con un arreglo embebido de episode_ids
    And la lista aparece disponible en el perfil del usuario
```

---

### Feature: Interacción social

```gherkin
Feature: Reseñas y comentarios de contenido

  Scenario: Publicar una reseña sobre un podcast
    Given el usuario está autenticado y ha escuchado el podcast
    When el usuario escribe una reseña y la envía
    Then se inserta un documento en "reviews" con user_id, podcast_id y texto
    And se inserta un documento en "ratings" con la calificación numérica correspondiente

  Scenario: Editar un comentario existente
    Given el usuario tiene un comentario publicado en "comments"
    When el usuario modifica el texto del comentario
    Then se ejecuta updateOne() sobre "comments" con el _id del documento
    And el campo "text" queda actualizado con el nuevo contenido

  Scenario: Eliminar un comentario propio
    Given el usuario es el autor del comentario en "comments"
    When el usuario elige eliminar el comentario
    Then se ejecuta deleteOne() sobre "comments" con el _id correspondiente
    And el comentario ya no aparece en la vista del episodio
```

---

### Feature: Perfil del creador

```gherkin
Feature: Publicación y gestión de episodios por el creador

  Scenario: Publicar un nuevo episodio
    Given el creador tiene un perfil en "creadores"
    When el creador sube un nuevo episodio con título, duración y descripción
    Then se inserta un documento en "episodios" referenciando el _id del creador
    And el episodio aparece en el catálogo de la plataforma

  Scenario: Actualizar los datos de un episodio publicado
    Given el episodio existe en la colección "episodios"
    When el creador modifica el título o la descripción
    Then se ejecuta updateOne() sobre "episodios" con el _id del episodio
    And los cambios se reflejan correctamente en la base de datos

  Scenario: Eliminar un episodio
    Given el episodio existe y pertenece al creador autenticado
    When el creador elige eliminar el episodio
    Then se ejecuta deleteOne() sobre "episodios" con el _id correspondiente
    And el episodio deja de aparecer en el catálogo
```

---

### Feature: Conectividad y despliegue en MongoDB Atlas

```gherkin
Feature: Infraestructura y disponibilidad del sistema

  Scenario: Conexión exitosa desde MongoDB Compass a Atlas
    Given el clúster Cluster0 en Atlas está activo
    When Compass intenta establecer conexión con la cadena de conexión del proyecto
    Then la conexión es exitosa
    And se visualizan las colecciones de "proyectopodcast" en el explorador

  Scenario: Validar que el despliegue final responde correctamente
    Given el proyecto está desplegado y conectado a Atlas
    When la aplicación ejecuta una operación de lectura sobre cualquier colección
    Then la base de datos retorna una respuesta válida en menos de 2 segundos
    And el estado del sistema muestra "All Good"

  Scenario: Validar integridad del release final
    Given el Release v3.0 está publicado en el repositorio de GitHub
    When el evaluador clona el repositorio y sigue las instrucciones del README
    Then todos los scripts de CRUD y agregaciones se ejecutan sin errores
    And las colecciones de Atlas reflejan los datos esperados
```

---

## 📊 PROGRESO DEL PROYECTO

| Estado | Cantidad | Porcentaje |
|--------|----------|------------|
| ✅ Completadas | 16 | 53% |
| 🔄 En progreso | 2 | 7% |
| ⏳ Pendientes | 12 | 40% |
| **Total** | **30** | **100%** |

```
Progreso actual: (16 / 30) × 100 = 53%
```

---

## 👥 EQUIPO SCRUM

| Rol | Integrante |
|-----|------------|
| Scrum Master | Klara |
| Data Modeler | Maria |
| Integration Specialist | Iván |
| Query Developer | Dilan |
| Data Seeder / QA | Klara / Ariz |

---

## 🗄️ COLECCIONES EN MONGODB ATLAS

| Colección | Documentos | Uso principal |
|-----------|-----------|---------------|
| `usuarios` | 72 | Perfil extendido del usuario |
| `episodes` | 31 | Episodios del catálogo principal |
| `users` | 10 | Datos de autenticación |
| `podcasts` | 8 | Catálogo de podcasts |
| `ratings` | 5 | Calificaciones de contenido |
| `downloads` | 5 | Descargas de episodios |
| `favorites` | 6 | Contenido guardado por el usuario |
| `creadores` | 26 | Perfiles de creadores de contenido |
| `episodios` | 3 | Episodios en español |
| `playlists` | 1 | Listas de reproducción |
| `reviews` | 1 | Reseñas escritas |
| `queries` | 1 | Consultas registradas |
| `accounts` | 0 | Cuentas de acceso |
| `comments` | 0 | Comentarios de episodios |
| `sessions` | 0 | Sesiones activas |
| `listeninghistories` | 0 | Historial de escucha |
| `verificationtokens` | 0 | Tokens de verificación |
