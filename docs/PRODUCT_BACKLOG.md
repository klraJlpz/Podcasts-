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
📦 FIRST TERM — ARCHITECTURE AND MODELING
ID	Sprint	User Story + Acceptance Criteria	MongoDB Collection
US-SPM-01-01	S1	User Story: As a user, I want to register on the platform to create my personal account.
Acceptance Criteria: The system creates my account with valid credentials and no duplicates, allowing me to access the platform.	users / accounts
US-SPM-01-02	S1	User Story: As a user, I want to securely log in and log out to protect my account.
Acceptance Criteria: When logging in, I securely access my profile. When logging out, my access is immediately invalidated.	sessions / verificationtokens
US-SPM-02-03	S2	User Story: As a listener, I want to explore the available podcast catalog to discover new content.
Acceptance Criteria: I can view a list of podcasts with their title, category, and creator.	podcasts / creadores
US-SPM-02-04	S2	User Story: As a listener, I want to view the episodes of a podcast to choose which one to listen to.
Acceptance Criteria: When selecting a podcast, I correctly see all its available episodes.	episodes / episodios
US-SPM-07-05	S3	User Story: As a user, I want the application to be connected to the cloud so I can access my data from anywhere.
Acceptance Criteria: I can access my data anytime and from any device without interruptions.	Cluster0 / proyectopodcast
US-SPM-07-06	S4	User Story: As a user, I want the system to work with real data so I can validate all its functionalities.
Acceptance Criteria: The platform operates with at least 50 real records in the main collections without visible errors.	usuarios / episodes / podcasts
US-SPM-02-07	S4	User Story: As a listener, I want to search for a podcast by name and get accurate results.
Acceptance Criteria: When typing a name, I only see the podcasts that match my search.	podcasts
US-SPM-05-08	S5	User Story: As a creator, I want my episode and profile information to be well organized to ensure consistency in my content.
Acceptance Criteria: My profile and episodes are always displayed with complete and consistent information.	creadores / episodios
US-SPM-07-09	S6	User Story: As a user, I want the project to be well documented so I can understand how it works and how to install it.
Acceptance Criteria: There is a clear installation, architecture, and usage guide that anyone can follow without prior knowledge of the project.	—
US-SPM-07-10	S7	User Story: As a user, I want to understand the database structure so I can trust that my information is well organized.
Acceptance Criteria: There is a presentation with database diagrams, model explanations, and examples of how information is stored.	—
📦 SECOND TERM — QUERIES AND DATA MANIPULATION
ID	Sprint	User Story + Acceptance Criteria	MongoDB Collection
US-SPM-02-11	S8	User Story: As a listener, I want to search for a specific episode by title to access it directly.
Acceptance Criteria: When searching for an episode by name, I immediately find the correct content.	episodes / episodios
US-SPM-07-12	S8	User Story: As a user, I want searches on the platform to work correctly with real data.
Acceptance Criteria: All searches return correct results and no errors when tested with real content.	podcasts / episodes
US-SPM-02-13	S9	User Story: As a listener, I want to filter podcasts by duration, rating, or category to find content that matches my preferences.
Acceptance Criteria: I can apply filters and only see podcasts that meet the selected criteria.	podcasts / ratings
US-SPM-07-14	S9	User Story: As a user, I want search filters to work without errors so I do not receive incorrect results.
Acceptance Criteria: Errors found in filters are documented and fixed before affecting my experience.	queries
US-SPM-02-15	S10	User Story: As a listener, I want to combine multiple search filters to obtain more precise results.
Acceptance Criteria: I can apply multiple filters at the same time and only see content that meets all my conditions.	podcasts / episodes
US-SPM-07-16	S10	User Story: As a user, I want advanced filters to work correctly with all available content types.
Acceptance Criteria: Combined filters work without errors for both listener and creator profiles.	usuarios / creadores
US-SPM-03-17	S11	User Story: As a listener, I want my playlists to contain multiple episodes organized efficiently.
Acceptance Criteria: I can see all my saved episodes in playlists and favorites in an organized and error-free way.	playlists / favorites
US-SPM-07-18	S11	User Story: As a user, I want playlists and favorites to support large amounts of content without issues.
Acceptance Criteria: I can save more than 3 episodes in my playlists and favorites without losing information.	playlists / favorites
US-SPM-04-19	S12	User Story: As a listener, I want to edit or delete my reviews and comments to keep my opinion updated.
Acceptance Criteria: I can modify or delete any review or comment I have published.	reviews / comments
US-SPM-03-20	S12	User Story: As a listener, I want my favorites to update immediately when adding or removing content.
Acceptance Criteria: When adding or removing a favorite, the change is instantly reflected in my personal library.	favorites / downloads
📦 THIRD TERM — FINAL INTEGRATION AND DEPLOYMENT
ID	Sprint	User Story + Acceptance Criteria	MongoDB Collection
US-SPM-07-21	S17	User Story: As a user, I want all application features to operate correctly in an integrated manner.
Acceptance Criteria: I can register, search, save favorites, comment, and manage content without conflicts between features.	All
US-SPM-07-22	S17	User Story: As a user, I want the application to be stably available in the cloud to guarantee continuous access.
Acceptance Criteria: The platform responds correctly and without crashes during availability tests.	Cluster0
US-SPM-07-23	S17	User Story: As a user, I want complete and updated documentation to understand how to use the platform.
Acceptance Criteria: The usage guide, architecture, and examples are updated and understandable for anyone.	—
US-SPM-06-24	S17	User Story: As a creator, I want to see performance statistics for my episodes to make decisions about my content.
Acceptance Criteria: I can consult data such as average ratings, downloads, and episodes saved as favorites.	ratings / downloads / favorites
US-SPM-05-25	S17	User Story: As a creator, I want my profile and episodes to support all available operations without errors.
Acceptance Criteria: I can create, modify, and delete my information and episodes without the system failing.	creadores / episodios
US-SPM-07-26	S17	User Story: As a user, I want the platform data to be reliable and consistent so I can receive correct information.
Acceptance Criteria: All test data passes validation and there are no integrity errors in the available information.	All
US-SPM-07-27	S17	User Story: As a user, I want the final version of the project to be complete and functional for real use.
Acceptance Criteria: The final version includes all functions, scripts, and documentation operating correctly.	—
US-SPM-07-28	S17	User Story: As a user, I want to see a demonstration of the system working to verify that it meets my needs.
Acceptance Criteria: The demo video shows registration, search, favorites, comments, and statistics smoothly.	—
US-SPM-07-29	S18	User Story: As a user, I want to attend a project presentation to verify the technical expertise of the responsible team.
Acceptance Criteria: The final presentation includes diagrams, design decisions, and a live demo working correctly.	—
US-SPM-07-30	S18	User Story: As a user, I want a final project report that includes all evidence of its development and testing.
Acceptance Criteria: The final report includes backlog, sprints, retrospectives, testing evidence, and team evaluation

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
