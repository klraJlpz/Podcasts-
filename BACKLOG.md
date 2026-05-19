# PRODUCT BACKLOG — STREAMING PODCAST MANAGER (AUDIO)
# MongoDB Project Backlog

# PRODUCT GOAL

Develop a functional NoSQL database using MongoDB Atlas that allows modeling, storing, querying, updating, and validating information through CRUD operations, advanced queries, and aggregations while applying Scrum methodology and best practices for documentation, testing, and deployment.

---

# EPICS

| Epic ID | Epic Name | Description |
|---|---|---|
| EP-01 | Database Architecture & Modeling | Design of NoSQL architecture, collections, and JSON structures. |
| EP-02 | Database Integration | MongoDB Atlas configuration and connectivity. |
| EP-03 | Query Development | Development of MongoDB queries and operators. |
| EP-04 | Data Validation & QA | Data validation, testing, and bug detection. |
| EP-05 | CRUD Operations | Full CRUD operation implementation. |
| EP-06 | Final Integration & Deployment | Final integration, deployment, and documentation. |

---

# FIRST PARTIAL — DATABASE ARCHITECTURE & MODELING

| ID | Epic | Sprint | User Story | Acceptance Criteria | Responsible | Status |
|---|---|---|---|---|---|---|
| PB-01 | EP-01 | S1 | As a team, we want to define the project idea and assign Scrum roles. | Roles assigned and project scope approved. | All Team | ✅ Done |
| PB-02 | EP-01 | S1 | As Scrum Master, I want to organize the Trello board and sprint planning. | Trello board created and sprint tasks organized. | Klara | ✅ Done |
| PB-03 | EP-01 | S2 | As Data Modeler, I want to design the NoSQL document architecture. | Collections and schema structure documented correctly. | Maria | ✅ Done |
| PB-04 | EP-01 | S2 | As Data Modeler, I want to define collections and JSON structures. | JSON structures validated and compatible with MongoDB. | Maria | ✅ Done |
| PB-05 | EP-02 | S3 | As Integration Specialist, I want to create the MongoDB Atlas cluster. | Atlas cluster created and active. | Iván | ✅ Done |
| PB-06 | EP-02 | S3 | As Integration Specialist, I want to connect the database using MongoDB Compass. | Compass connection successful. | Iván | ✅ Done |
| PB-07 | EP-03 | S4 | As Query Developer, I want to test basic document retrieval. | `find()` queries return valid documents. | Dilan | ✅ Done |
| PB-08 | EP-04 | S4 | As Data Seeder / QA, I want to generate mock JSON data for testing. | Mock data generated without schema errors. | Klara / Ariz | ✅ Done |
| PB-09 | EP-04 | S5 | As Data Seeder / QA, I want to insert 50+ test documents into MongoDB Atlas. | At least 50 documents inserted successfully. | Klara / Ariz | ✅ Done |
| PB-10 | EP-01 | S5 | As Data Modeler, I want to explain Embedding vs Referencing decisions. | Documentation includes justification of modeling decisions. | Maria | ✅ Done |
| PB-11 | EP-06 | S6 | As Scrum Master, I want to organize the GitHub repository structure. | Repository structure organized and accessible. | Klara | ✅ Done |
| PB-12 | EP-06 | S6 | As a team, we want to create the README documentation. | README contains setup, architecture, and usage guide. | All Team | ✅ Done |
| PB-13 | EP-06 | S7 | As a team, we want to prepare the architecture defense presentation. | Presentation completed with diagrams and explanations. | All Team | ✅ Done |

---

# SECOND PARTIAL — QUERIES & DATA MANIPULATION

| ID | Epic | Sprint | User Story | Acceptance Criteria | Responsible | Status |
|---|---|---|---|---|---|---|
| PB-14 | EP-03 | S8 | As Query Developer, I want to create queries using `find()` and `findOne()`. | Queries return correct documents. | Dilan | ✅ Done |
| PB-15 | EP-04 | S8 | As Data Seeder / QA, I want to validate basic queries with real JSON data. | Queries validated successfully with real data. | Klara / Ariz | ✅ Done |
| PB-16 | EP-02 | S8 | As Integration Specialist, I want to verify database connectivity. | Atlas connectivity stable and verified. | Iván | ✅ Done |
| PB-17 | EP-03 | S9 | As Query Developer, I want to use comparison operators (`$gt`, `$lt`, `$in`, `$ne`). | Operators filter documents correctly. | Dilan | ✅ Done |
| PB-18 | EP-04 | S9 | As Data Seeder / QA, I want to test filters and identify query bugs. | Query issues detected and documented. | Klara / Ariz | ✅ Done |
| PB-19 | EP-03 | S10 | As Query Developer, I want to implement logical operators (`$and`, `$or`, `$not`). | Logical operators execute correctly. | Dilan | 🔄 In Progress |
| PB-20 | EP-01 | S10 | As Data Modeler, I want to validate query compatibility with the schema. | Queries compatible with schema design. | Maria | 🔄 In Progress |
| PB-21 | EP-03 | S11 | As Query Developer, I want to query embedded arrays and nested documents. | Nested document queries return valid results. | Dilan | ⏳ Pending |
| PB-22 | EP-04 | S11 | As Data Seeder / QA, I want to generate advanced JSON arrays for testing. | Complex arrays generated successfully. | Klara / Ariz | ⏳ Pending |
| PB-23 | EP-05 | S12 | As Query Developer, I want to update documents using `updateOne()` and `updateMany()`. | Update operations modify documents correctly. | Dilan | ⏳ Pending |
| PB-24 | EP-02 | S12 | As Integration Specialist, I want to validate update operations in Atlas. | Atlas reflects updated data successfully. | Iván | ⏳ Pending |

---

# THIRD PARTIAL — FINAL INTEGRATION & DEPLOYMENT

| ID | Epic | Sprint | User Story | Acceptance Criteria | Responsible | Status |
|---|---|---|---|---|---|---|
| PB-32 | EP-06 | S17 | As a team, we want to integrate all database features into the final project. | CRUD and queries work correctly together. | All Team | ⏳ Pending |
| PB-33 | EP-06 | S17 | As Integration Specialist, I want to ensure the final MongoDB deployment works correctly. | Deployment stable and connected to Atlas. | Iván | ⏳ Pending |
| PB-34 | EP-06 | S17 | As Scrum Master, I want to finalize the GitHub repository documentation. | Documentation updated and complete. | Klara | ⏳ Pending |
| PB-35 | EP-05 | S17 | As Query Developer, I want to validate all CRUD and aggregation scripts. | CRUD and aggregation scripts validated. | Dilan | ⏳ Pending |
| PB-36 | EP-01 | S17 | As Data Modeler, I want to review the final schema structure. | Final schema reviewed and approved. | Maria | ⏳ Pending |
| PB-37 | EP-04 | S17 | As Data Seeder / QA, I want to validate all test datasets and detect bugs. | QA testing completed and bugs documented. | Klara / Ariz | ⏳ Pending |
| PB-38 | EP-06 | S17 | As a team, we want to create the Release v3.0 final version. | Final release generated successfully. | All Team | ⏳ Pending |
| PB-39 | EP-06 | S17 | As a team, we want to record the final functional demo video. | Demo video recorded and shared. | All Team | ⏳ Pending |
| PB-40 | EP-06 | S18 | As a team, we want to present and defend the final project architecture. | Final presentation delivered successfully. | All Team | ⏳ Pending |
| PB-41 | EP-06 | S18 | As Scrum Master, I want to deliver the final project report and evaluation evidence. | Final report submitted with evidence. | Klara | ⏳ Pending |

---

# GHERKIN TEST CASES

## Feature: Basic MongoDB Queries

```gherkin
Feature: Basic Queries

Scenario: Retrieve documents using find()
  Given the collection contains documents
  When the developer executes find()
  Then matching documents should be returned

Scenario: Retrieve a single document
  Given the collection contains valid data
  When the developer executes findOne()
  Then only one document should be returned
```

---

## Feature: Comparison Operators

```gherkin
Feature: Comparison Operators

Scenario: Filter documents with $gt
  Given documents contain numeric values
  When the user executes a query with $gt
  Then only documents greater than the specified value should appear

Scenario: Filter documents with $in
  Given documents contain categories
  When the user executes a query with $in
  Then matching categories should be returned
```

---

## Feature: Update Operations

```gherkin
Feature: Update Documents

Scenario: Update a single document
  Given a document exists
  When updateOne() is executed
  Then only one document should be updated

Scenario: Update multiple documents
  Given multiple matching documents exist
  When updateMany() is executed
  Then all matching documents should be updated
```

---

## Feature: MongoDB Atlas Integration

```gherkin
Feature: Atlas Connectivity

Scenario: Connect MongoDB Compass to Atlas
  Given the Atlas cluster is active
  When Compass attempts connection
  Then the connection should be successful

Scenario: Validate deployment
  Given the project is deployed
  When the application accesses MongoDB Atlas
  Then the database should respond correctly
```

---

# PROJECT PROGRESS

- ✅ Completed Tasks: 18
- 🔄 Tasks In Progress: 2
- ⏳ Pending Tasks: 10

## Overall Progress

Project completion formula:

```math
(18 / 30) * 100 = 60%
```

Current project progress: **60% Completed**
