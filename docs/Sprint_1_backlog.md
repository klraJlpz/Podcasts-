# 🎧 Podcast Management Platform (PMP)

# Sprint 1 – Foundations and Modeling (Feb 6 – Mar 20)

---

## 🥅 Sprint Goal
Design the NoSQL architecture of the system, establish the database, create the main schema, and populate initial data for the PMP project.

---

## ⚙️ Sprint Parameters & Capacity Plan
- **Duration:** 4 weeks
- **Weekly Hours:** 40 h
- **Total Capacity:** 160 h
- **Estimated Workload:** 150 h
- **Buffer:** 10 h

---

## 🧩 Selected Epics & User Stories

### Epic 1 – Account Management
**US-PMP-01-01 – Registration and Authentication**  
**Story Points:** 5

#### Acceptance Criteria

```gherkin
Scenario: Successful registration
Given a new user
When valid credentials are entered
Then the system creates an account and authenticates the session

Scenario: Invalid registration
Given a new user
When incomplete credentials are entered
Then the system displays an error message
```

### Epic 2 – Schema Design
**US-PMP-02-03 – NoSQL Schema Design**  
**Story Points:** 8

#### Acceptance Criteria

```gherkin
Scenario: Schema validation
Given an ER diagram
When the collections are created
Then the structure supports relationships between podcasts and episodes

Scenario: Inconsistent schema
Given a poorly defined schema
When data population is attempted
Then the system rejects the operation
```

### Epic 3 – Data Seeding
**US-PMP-03-05 – Bulk Data Generation**  
**Story Points:** 5

#### Acceptance Criteria

```gherkin
Scenario: Data loading
Given a seeding script
When it is executed
Then 50+ valid documents are generated

Scenario: Duplicate data
Given an existing dataset
When the seeding process is executed
Then no duplicate records are generated
```

---

## 📅 Weekly Tasks & Estimated Hours

### Week 1 – Project Setup (40 h)

| Task | Role | Hours |
|------|------|------|
| Repository creation and Git configuration | Scrum Master | 6 h |
| MongoDB Atlas setup | Query Developer | 10 h |
| Requirements analysis | Data Modeler | 12 h |
| Initial documentation | Scrum Master | 12 h |

### Week 2 – Data Modeling (40 h)

| Task | Role | Hours |
|------|------|------|
| Collection design | Data Modeler | 16 h |
| Relationship modeling | Data Modeler | 12 h |
| Schema validation | Data Seeder / QA | 12 h |

### Week 3 – Database Implementation (40 h)

| Task | Role | Hours |
|------|------|------|
| Collection creation | Query Developer | 16 h |
| CRUD structure setup | Integration Specialist| 12 h |
| Testing and validation | Data Seeder / QA | 12 h |

### Week 4 – Data Seeding & Review (40 h)

| Task | Role | Hours |
|------|------|------|
| Seed script development | Query Developer | 16 h |
| Sample data generation | Data Modeler | 12 h |
| Sprint review and documentation | Scrum Master | 12 h |

---

## 👥 Team Members

| Role | Person | Sprint Responsibilities |
|------|--------|-------------------------|
| Scrum Master | Klara | Manage sprint planning, daily meetings, sprint review, documentation, and progress tracking. |
| Data Modeler | Isabel | Design the NoSQL schema, define collections and relationships, validate the data model. |
| Query Developer | Dilan | Configure MongoDB Atlas, create collections, implement database structure and seed scripts. |
| Data Seeder / QA | Ariz | Validate schemas, verify data integrity, test database operations and generated datasets. |

---

## 🚧 Impediments & Dependencies

### Dependencies
- Stable MongoDB Atlas connection.
- Git and VS Code properly configured.
- Team access to project repository.

### Potential Impediments
- Connectivity issues with MongoDB Atlas.
- Delays in schema approval.
- Inconsistent sample data generation.

---
