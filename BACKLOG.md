# 📋 PRODUCT BACKLOG — STREAMING PODCAST MANAGER

---

## 🎯 OBJETIVO DEL PRODUCTO

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
| US-01 | EP-01 | S1 | Como usuario, quiero registrarme en la plataforma para crear mi cuenta personal. | El sistema crea mi cuenta con credenciales válidas y sin duplicados, permitiéndome acceder a la plataforma. | `users` / `accounts` | Klara / Iván | ✅ Done |
| US-02 | EP-01 | S1 | Como usuario, quiero iniciar y cerrar sesión de forma segura para proteger mi cuenta. | Al iniciar sesión accedo a mi perfil de manera segura. Al cerrar sesión, mi acceso queda invalidado inmediatamente. | `sessions` / `verificationtokens` | Iván | ✅ Done |
| US-03 | EP-02 | S2 | Como oyente, quiero explorar el catálogo de podcasts disponibles para descubrir contenido nuevo. | Puedo ver una lista de podcasts con su título, categoría y creador. | `podcasts` / `creadores` | Isabel | ✅ Done |
| US-04 | EP-02 | S2 | Como oyente, quiero ver los episodios de un podcast para elegir cuál escuchar. | Al seleccionar un podcast, veo correctamente todos sus episodios disponibles. | `episodes` / `episodios` | Isabel | ✅ Done |
| US-05 | EP-07 | S3 | Como usuario, quiero que la aplicación esté conectada a la nube para acceder a mis datos desde cualquier lugar. | Puedo acceder a mis datos en cualquier momento y desde cualquier dispositivo sin interrupciones. | Cluster0 / `proyectopodcast` | Iván | ✅ Done |
| US-06 | EP-07 | S4 | Como usuario, quiero que el sistema funcione con datos reales para poder validar todas sus funcionalidades. | La plataforma opera con al menos 50 registros reales en las colecciones principales sin errores visibles. | `usuarios` / `episodes` / `podcasts` | Klara / Ariz | ✅ Done |
| US-07 | EP-02 | S4 | Como oyente, quiero buscar un podcast por su nombre y obtener resultados precisos. | Al escribir un nombre, veo únicamente los podcasts que coinciden con mi búsqueda. | `podcasts` | Dilan | ✅ Done |
| US-08 | EP-05 | S5 | Como creador, quiero que la información de mis episodios y perfil esté bien organizada para garantizar consistencia en mi contenido. | Mi perfil y episodios siempre se muestran con información completa y sin inconsistencias. | `creadores` / `episodios` | Isabel | ✅ Done |
| US-09 | EP-07 | S6 | Como usuario, quiero que el proyecto esté bien documentado para poder entender cómo funciona y cómo instalarlo. | Existe una guía clara de instalación, arquitectura y uso que cualquier persona puede seguir sin conocimientos previos del proyecto. | — | Klara / All Team | ✅ Done |
| US-10 | EP-07 | S7 | Como usuario, quiero entender la estructura de la base de datos para confiar en que mi información está bien organizada. | Existe una presentación con diagramas de la base de datos, explicación del modelo y ejemplos de cómo se almacena la información. | — | All Team | ✅ Done |

---

## 📦 SEGUNDO PARCIAL — CONSULTAS Y MANIPULACIÓN DE DATOS

| ID | Épica | Sprint | Historia de Usuario | Criterio de Aceptación | Colección MongoDB | Responsable | Estado |
|----|-------|--------|---------------------|------------------------|-------------------|-------------|--------|
| US-11 | EP-02 | S8 | Como oyente, quiero buscar un episodio específico por su título para acceder directamente a él. | Al buscar un episodio por nombre, encuentro el contenido correcto de forma inmediata. | `episodes` / `episodios` | Dilan | ✅ Done |
| US-12 | EP-07 | S8 | Como usuario, quiero que las búsquedas en la plataforma funcionen correctamente con datos reales. | Todas las búsquedas retornan resultados correctos y sin errores cuando se prueban con contenido real. | `podcasts` / `episodes` | Klara / Ariz | ✅ Done |
| US-13 | EP-02 | S9 | Como oyente, quiero filtrar podcasts por duración, calificación o categoría para encontrar contenido que se adapte a mis preferencias. | Puedo aplicar filtros y ver únicamente los podcasts que cumplen los criterios que seleccioné. | `podcasts` / `ratings` | Dilan | ✅ Done |
| US-14 | EP-07 | S9 | Como usuario, quiero que los filtros de búsqueda funcionen sin errores para no recibir resultados incorrectos. | Los errores encontrados en los filtros están documentados y corregidos antes de que afecten mi experiencia. | `queries` | Klara / Ariz | ✅ Done |
| US-15 | EP-02 | S10 | Como oyente, quiero combinar múltiples filtros de búsqueda para obtener resultados más precisos. | Puedo aplicar varios filtros al mismo tiempo y ver solo el contenido que cumple todas mis condiciones. | `podcasts` / `episodes` | Dilan | 🔄 In Progress |
| US-16 | EP-07 | S10 | Como usuario, quiero que los filtros avanzados funcionen correctamente con todos los tipos de contenido disponibles. | Los filtros combinados funcionan sin errores tanto para perfiles de oyentes como de creadores. | `usuarios` / `creadores` | Isabel | 🔄 In Progress |
| US-17 | EP-03 | S11 | Como oyente, quiero que mis listas de reproducción puedan contener múltiples episodios organizados de forma eficiente. | Puedo ver todos mis episodios guardados en listas y en favoritos de manera ordenada y sin errores. | `playlists` / `favorites` | Dilan | ⏳ Pending |
| US-18 | EP-07 | S11 | Como usuario, quiero que las listas de reproducción y favoritos soporten grandes cantidades de contenido sin problemas. | Puedo guardar más de 3 episodios en mis listas y favoritos sin que se pierda información. | `playlists` / `favorites` | Klara / Ariz | ⏳ Pending |
| US-19 | EP-04 | S12 | Como oyente, quiero poder editar o eliminar mis reseñas y comentarios para mantener mi opinión actualizada. | Puedo modificar o borrar cualquier reseña o comentario que yo haya publicado. | `reviews` / `comments` | Dilan | ⏳ Pending |
| US-20 | EP-03 | S12 | Como oyente, quiero que mis favoritos se actualicen de inmediato al agregar o quitar contenido. | Al agregar o eliminar un favorito, el cambio se refleja al instante en mi biblioteca personal. | `favorites` / `downloads` | Iván | ⏳ Pending |

---

## 📦 TERCER PARCIAL — INTEGRACIÓN FINAL Y DESPLIEGUE

| ID | Épica | Sprint | Historia de Usuario | Criterio de Aceptación | Colección MongoDB | Responsable | Estado |
|----|-------|--------|---------------------|------------------------|-------------------|-------------|--------|
| US-21 | EP-07 | S17 | Como usuario, quiero que todas las funciones de la aplicación operen correctamente de forma integrada. | Puedo registrarme, buscar, guardar favoritos, comentar y gestionar contenido sin conflictos entre funciones. | Todas | All Team | ⏳ Pending |
| US-22 | EP-07 | S17 | Como usuario, quiero que la aplicación esté disponible de forma estable en la nube para garantizar acceso continuo. | La plataforma responde correctamente y sin caídas durante las pruebas de disponibilidad. | Cluster0 | Iván | ⏳ Pending |
| US-23 | EP-07 | S17 | Como usuario, quiero contar con documentación completa y actualizada para entender cómo usar la plataforma. | La guía de uso, arquitectura y ejemplos están actualizados y son comprensibles para cualquier persona. | — | Klara | ⏳ Pending |
| US-24 | EP-06 | S17 | Como creador, quiero ver estadísticas de rendimiento de mis episodios para tomar decisiones sobre mi contenido. | Puedo consultar datos como calificaciones promedio, descargas y episodios guardados en favoritos. | `ratings` / `downloads` / `favorites` | Dilan | ⏳ Pending |
| US-25 | EP-05 | S17 | Como creador, quiero que mi perfil y episodios soporten todas las operaciones disponibles sin errores. | Puedo crear, modificar y eliminar mi información y episodios sin que el sistema falle. | `creadores` / `episodios` | Isabel | ⏳ Pending |
| US-26 | EP-07 | S17 | Como usuario, quiero que los datos de la plataforma sean confiables e íntegros para recibir información correcta. | Todos los datos de prueba pasan validación y no existen errores de integridad en la información disponible. | Todas | Klara / Ariz | ⏳ Pending |
| US-27 | EP-07 | S17 | Como usuario, quiero que la versión final del proyecto esté completa y funcional para su uso real. | La versión final incluye todas las funciones, scripts y documentación operando correctamente. | — | All Team | ⏳ Pending |
| US-28 | EP-07 | S17 | Como usuario, quiero ver una demostración del sistema funcionando para verificar que cumple mis necesidades. | El video demo muestra registro, búsqueda, favoritos, comentarios y estadísticas de forma fluida. | — | All Team | ⏳ Pending |
| US-29 | EP-07 | S18 | Como usuario, quiero presenciar una presentación del proyecto para verificar el dominio técnico del equipo responsable. | La presentación final incluye diagramas, decisiones de diseño y demo en vivo funcionando correctamente. | — | All Team | ⏳ Pending |
| US-30 | EP-07 | S18 | Como usuario, quiero contar con un reporte final del proyecto que incluya toda la evidencia de su desarrollo y pruebas. | El reporte final incluye backlog, sprints, retrospectivas, evidencia de pruebas y evaluación del equipo. | — | Klara | ⏳ Pending |

---

## 🧪 PRUEBAS UNITARIAS — GHERKIN

### Feature: Gestión de cuenta de usuario

```gherkin
Feature: Registro e inicio de sesión de usuario

  Scenario: Registro exitoso de un nuevo usuario
    Given el usuario no tiene una cuenta registrada
    When el usuario envía su nombre, correo y contraseña válidos
    Then el sistema crea su cuenta de forma segura
    And asocia sus credenciales a su perfil personal
    And la contraseña se almacena de forma encriptada

  Scenario: Inicio de sesión exitoso
    Given el usuario tiene una cuenta registrada
    When el usuario ingresa sus credenciales correctas
    Then el sistema inicia su sesión de forma segura
    And el usuario obtiene acceso a su perfil personal

  Scenario: Cierre de sesión
    Given el usuario tiene una sesión activa
    When el usuario ejecuta la acción de cerrar sesión
    Then su sesión queda invalidada inmediatamente
    And el usuario pierde acceso a las funciones autenticadas
```

---

### Feature: Exploración de podcasts y episodios

```gherkin
Feature: Búsqueda y visualización de contenido

  Scenario: Listar todos los podcasts disponibles
    Given existen podcasts disponibles en el catálogo
    When el usuario accede a la sección de exploración
    Then se muestran todos los podcasts disponibles
    And se visualizan título, categoría y nombre del creador

  Scenario: Ver episodios de un podcast específico
    Given existe un podcast en el catálogo
    When el usuario selecciona ese podcast
    Then se muestran únicamente los episodios pertenecientes a ese podcast

  Scenario: Buscar un episodio por título
    Given existen episodios en el catálogo
    When el usuario escribe un término de búsqueda
    Then se muestra el primer episodio cuyo título coincida con el término ingresado
```

---

### Feature: Filtrado avanzado de contenido

```gherkin
Feature: Filtros de búsqueda en el catálogo

  Scenario: Filtrar podcasts con calificación mayor a 4
    Given existen podcasts con calificaciones registradas
    When el usuario aplica el filtro de "mejor calificados"
    Then solo se muestran los podcasts con calificación superior a 4

  Scenario: Filtrar episodios por categoría específica
    Given existen podcasts con categorías asignadas
    When el usuario selecciona una o más categorías del filtro
    Then se muestran únicamente los podcasts que pertenecen a las categorías seleccionadas

  Scenario: Combinar filtros de categoría y duración
    Given existen podcasts con categoría y duración registradas
    When el usuario aplica filtros de categoría y duración simultáneamente
    Then solo se muestran los podcasts que cumplen ambas condiciones al mismo tiempo
```

---

### Feature: Biblioteca personal del oyente

```gherkin
Feature: Gestión de favoritos y listas de reproducción

  Scenario: Agregar un podcast a favoritos
    Given el usuario está autenticado y el podcast existe en el catálogo
    When el usuario presiona "Agregar a favoritos"
    Then el podcast se guarda en su sección de favoritos
    And aparece disponible en su biblioteca personal

  Scenario: Eliminar un podcast de favoritos
    Given el usuario tiene un podcast guardado en favoritos
    When el usuario presiona "Eliminar de favoritos"
    Then el podcast desaparece de su sección de favoritos

  Scenario: Crear una lista de reproducción con episodios
    Given el usuario está autenticado
    When el usuario crea una nueva lista y agrega episodios
    Then la lista queda guardada con los episodios seleccionados
    And aparece disponible en su perfil personal
```

---

### Feature: Interacción social

```gherkin
Feature: Reseñas y comentarios de contenido

  Scenario: Publicar una reseña sobre un podcast
    Given el usuario está autenticado y ha escuchado el podcast
    When el usuario escribe una reseña y la envía
    Then la reseña queda publicada con su calificación numérica correspondiente

  Scenario: Editar un comentario existente
    Given el usuario tiene un comentario publicado
    When el usuario modifica el texto del comentario
    Then el comentario queda actualizado con el nuevo contenido

  Scenario: Eliminar un comentario propio
    Given el usuario es el autor del comentario
    When el usuario elige eliminar el comentario
    Then el comentario ya no aparece en la vista del episodio
```

---

### Feature: Perfil del creador

```gherkin
Feature: Publicación y gestión de episodios por el creador

  Scenario: Publicar un nuevo episodio
    Given el creador tiene un perfil activo en la plataforma
    When el creador sube un nuevo episodio con título, duración y descripción
    Then el episodio queda publicado y aparece en el catálogo de la plataforma

  Scenario: Actualizar los datos de un episodio publicado
    Given el episodio existe y está publicado en la plataforma
    When el creador modifica el título o la descripción
    Then los cambios se reflejan correctamente en el catálogo

  Scenario: Eliminar un episodio
    Given el episodio existe y pertenece al creador autenticado
    When el creador elige eliminar el episodio
    Then el episodio deja de aparecer en el catálogo
```

---

### Feature: Conectividad y despliegue en la nube

```gherkin
Feature: Disponibilidad y estabilidad del sistema

  Scenario: Conexión exitosa de la plataforma a la base de datos en la nube
    Given la base de datos en la nube está activa
    When la plataforma intenta conectarse
    Then la conexión es exitosa
    And el contenido de la plataforma queda disponible para los usuarios

  Scenario: Validar que el sistema responde correctamente
    Given la plataforma está desplegada y conectada
    When el usuario realiza cualquier acción de lectura de contenido
    Then la plataforma retorna una respuesta válida en menos de 2 segundos
    And el estado del sistema muestra "All Good"

  Scenario: Validar integridad de la versión final del proyecto
    Given la versión final está publicada en el repositorio
    When el usuario sigue las instrucciones de instalación
    Then todas las funciones de la plataforma operan sin errores
    And el contenido de la base de datos refleja los datos esperados
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
| Data Modeler | Isabel |
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
