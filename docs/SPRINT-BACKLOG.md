
---

# 🎧 Podcast Management Platform (PMP)

## Sprint 1 – Fundamentos y Modelado (6 Feb – 20 Mar)




---

### 🥅 Sprint Goal
Diseñar la arquitectura NoSQL del sistema, establecer la base de datos, crear el esquema principal y poblar datos iniciales para el proyecto PMP.

---

### ⚙️ Sprint Parameters & Capacity Plan
- **Duración:** 6 semanas  
- **Horas semanales:** 8 h  
- **Capacidad total:** 48 h  
- **Carga estimada:** 40 h  
- **Buffer:** 8 h  

---

### 🧩 Selected Epics & User Stories

#### **Epic 1 – Account Management**
**US-PMP-01-01 – Registro y Autenticación**  
**Story Points:** 5  
**Acceptance Criteria:**
```gherkin
Scenario: Registro exitoso
Given un usuario nuevo
When ingresa credenciales válidas
Then el sistema crea una cuenta y autentica sesión

Scenario: Registro inválido
Given un usuario nuevo
When ingresa credenciales incompletas
Then el sistema muestra un mensaje de error
```

#### **Epic 2 – Schema Design**
**US-PMP-02-03 – Diseño de Esquema NoSQL**  
**Story Points:** 8  
**Acceptance Criteria:**
```gherkin
Scenario: Validación de esquema
Given un diagrama ER
When se crean las colecciones
Then la estructura soporta relaciones entre podcasts y episodios
```

#### **Epic 3 – Data Seeding**
**US-PMP-03-05 – Generación de Datos Masivos**  
**Story Points:** 5  
**Acceptance Criteria:**
```gherkin
Scenario: Carga de datos
Given un script de seeding
When se ejecuta
Then se generan 50+ documentos válidos
```

---

### 👥 Responsables
| Rol | Persona | Responsabilidad |
|------|----------|----------------|
| Data Architect | Isabel | Diseño de esquema y modelado |
| Backend Developer | Dilan | Configuración MongoDB y CRUD |
| QA Engineer | Ariz | Validación de datos y pruebas |
| Scrum Master | Klara | Documentación y seguimiento |

---

### 🔗 Dependencias e Independencias
- **Dependencias:** Conexión estable a MongoDB Atlas, instalación de VS Code y Git.  
- **Independencias:** Diseño de esquema puede avanzar sin datos reales; seeding depende del esquema final.

---

## Sprint 2 – Consultas y Manipulación (23 Mar – 14 May)




---

### 🥅 Sprint Goal
Implementar consultas básicas y avanzadas, operadores lógicos y manipulación de arrays para lograr un manejo completo de datos en la plataforma.

---

### ⚙️ Sprint Parameters & Capacity Plan
- **Duración:** 7 semanas  
- **Horas semanales:** 6 h  
- **Capacidad total:** 42 h  
- **Carga estimada:** 36 h  
- **Buffer:** 6 h  

---

### 🧩 Selected Epics & User Stories

#### **Epic 4 – CRUD Operations**
**US-PMP-04-10 – Lectura y Proyección de Datos**  
**Story Points:** 5  
**Acceptance Criteria:**
```gherkin
Scenario: Consulta básica
Given datos de podcasts
When se ejecuta findOne()
Then se muestran los documentos correctos
```

#### **Epic 5 – Logical & Comparison Operators**
**US-PMP-05-13 – Filtros Avanzados**
**Story Points:** 8  
**Acceptance Criteria:**
```gherkin
Scenario: Filtro lógico
Given múltiples condiciones
When se usa $and y $or
Then se devuelven solo los documentos válidos
```

#### **Epic 6 – Array Manipulation**
**US-PMP-06-17 – Actualización de Arrays**
**Story Points:** 5  
**Acceptance Criteria:**
```gherkin
Scenario: Actualización incremental
Given un documento con comentarios
When se usa $push
Then se agrega un nuevo comentario sin sobrescribir el array
```

---

### 👥 Responsables
| Rol | Persona | Responsabilidad |
|------|----------|----------------|
| Query Developer | Dilan | Implementación de consultas y operadores |
| QA Engineer | Ariz | Pruebas de filtrado y manipulación |
| Data Modeler | Isabel | Validación de estructura y consistencia |
| Scrum Master | Klara | Documentación y control de versiones |

---

### 🔗 Dependencias e Independencias
- **Dependencias:** Base de datos inicial del Sprint 1, colecciones creadas y pobladas.  
- **Independencias:** Las pruebas de operadores pueden realizarse con datos simulados.

---

## Sprint 3 – Agregaciones y Optimización (18 May – 19 Jun)




---

### 🥅 Sprint Goal
Desarrollar reportes analíticos con el Aggregation Framework, optimizar consultas mediante índices y entregar la versión final del proyecto PMP.

---

### ⚙️ Sprint Parameters & Capacity Plan
- **Duración:** 4 semanas  
- **Horas semanales:** 10 h  
- **Capacidad total:** 40 h  
- **Carga estimada:** 32 h  
- **Buffer:** 8 h  

---

### 🧩 Selected Epics & User Stories

#### **Epic 7 – Analytics & Reporting**
**US-PMP-07-21 – Reportes de Desempeño**
**Story Points:** 8  
**Acceptance Criteria:**
```gherkin
Scenario: Generación de reportes
Given datos de desempeño
When se ejecuta el pipeline de agregación
Then se muestran métricas de descargas y favoritos
```

#### **Epic 8 – Index Optimization**
**US-PMP-08-25 – Creación de Índices**
**Story Points:** 5  
**Acceptance Criteria:**
```gherkin
Scenario: Optimización de consultas
Given consultas lentas
When se aplican índices
Then el tiempo de respuesta mejora
```

#### **Epic 9 – Final Integration**
**US-PMP-09-30 – Entrega Final**
**Story Points:** 13  
**Acceptance Criteria:**
```gherkin
Scenario: Validación final
Given todos los módulos integrados
When se ejecutan pruebas E2E
Then el sistema funciona sin errores
```

---

### 👥 Responsables
| Rol | Persona | Responsabilidad |
|------|----------|----------------|
| Data Analyst | Isabel | Diseño de pipelines y reportes |
| Query Developer | Dilan | Implementación de agregaciones e índices |
| QA Engineer | Ariz | Auditoría de rendimiento |
| Integration Specialist | Iván | Integración y despliegue final |
| Scrum Master | Klara | Documentación y demo final |

---

### 🔗 Dependencias e Independencias
- **Dependencias:** Datos y consultas funcionales del Sprint 2, conexión estable con MongoDB Atlas.  
- **Independencias:** Optimización e índices pueden desarrollarse en paralelo con reportes.

