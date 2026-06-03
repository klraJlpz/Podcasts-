# 🎧 Podcast Management Platform (PMP)

## Sprint 1 – Foundations and Modeling (Feb 6 – Mar 20)

---

### 🥅 Sprint Goal
Design the NoSQL architecture of the system, establish the database, create the main schema, and populate initial data for the PMP project.

---

### ⚙️ Sprint Parameters & Capacity Plan
- **Duration:** 6 weeks
- **Weekly Hours:** 8 h
- **Total Capacity:** 48 h
- **Estimated Workload:** 40 h
- **Buffer:** 8 h

---

### 🧩 Selected Epics & User Stories

#### Epic 1 – Account Management
**US-PMP-01-01 – Registration and Authentication**  
**Story Points:** 5

**Acceptance Criteria:**
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

#### Epic 2 – Schema Design
**US-PMP-02-03 – NoSQL Schema Design**  
**Story Points:** 8

**Acceptance Criteria:**
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

#### Epic 3 – Data Seeding
**US-PMP-03-05 – Bulk Data Generation**  
**Story Points:** 5

**Acceptance Criteria:**
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

### 👥 Team Members

| Role | Person | Responsibility |
|------|--------|----------------|
| Data Architect | Isabel | Schema design and data modeling |
| Backend Developer | Dilan | MongoDB configuration and CRUD operations |
| QA Engineer | Ariz | Data validation and testing |
| Scrum Master | Klara | Documentation and progress tracking |

---

### 🔗 Dependencies and Independencies
- **Dependencies:** Stable MongoDB Atlas connection, VS Code and Git installation.
- **Independencies:** Schema design can progress without real data; seeding depends on the final schema.

---

# Sprint 2 – Querying and Data Manipulation (Mar 23 – May 14)

---

### 🥅 Sprint Goal
Implement basic and advanced queries, logical operators, and array manipulation to achieve complete data management within the platform.

---

### ⚙️ Sprint Parameters & Capacity Plan
- **Duration:** 5 weeks
- **Weekly Hours:** 8 h
- **Total Capacity:** 36 h
- **Estimated Workload:** 30 h
- **Buffer:** 8 h

---

### 🧩 Selected Epics & User Stories

#### Epic 4 – CRUD Operations
**US-PMP-04-10 – Data Retrieval and Projection**  
**Story Points:** 5

**Acceptance Criteria:**
```gherkin
Scenario: Basic query
Given podcast data exists
When findOne() is executed
Then the correct document is displayed

Scenario: Query with no results
Given podcast data exists
When a non-existent title is queried
Then the system displays a "no results found" message
```

#### Epic 5 – Logical & Comparison Operators
**US-PMP-05-13 – Advanced Filtering**  
**Story Points:** 8

**Acceptance Criteria:**
```gherkin
Scenario: Logical filtering
Given multiple conditions
When $and and $or operators are used
Then only valid documents are returned

Scenario: Comparison filtering
Given episodes with different durations
When $gt and $lt operators are used
Then only episodes meeting the condition are returned
```

#### Epic 6 – Array Manipulation
**US-PMP-06-17 – Array Updates**  
**Story Points:** 5

**Acceptance Criteria:**
```gherkin
Scenario: Incremental update
Given a document containing comments
When $push is used
Then a new comment is added without overwriting the array

Scenario: Element removal
Given a document containing comments
When $pull is used
Then the selected comment is removed successfully
```

---

### 👥 Team Members

| Role | Person | Responsibility |
|------|--------|----------------|
| Query Developer | Dilan | Query and operator implementation |
| QA Engineer | Ariz | Filtering and manipulation testing |
| Data Modeler | Isabel | Structure validation and consistency checks |
| Scrum Master | Klara | Documentation and version control |

---

### 🔗 Dependencies and Independencies
- **Dependencies:** Initial database from Sprint 1, created and populated collections.
- **Independencies:** Operator testing can be performed with mock data.

---

# Sprint 3 – Aggregations and Optimization (May 18 – Jun 19)

---

### 🥅 Sprint Goal
Develop analytical reports using the Aggregation Framework, optimize queries through indexes, and deliver the final version of the PMP project.

---

### ⚙️ Sprint Parameters & Capacity Plan
- **Duration:** 4 weeks
- **Weekly Hours:** 8 h
- **Total Capacity:** 36 h
- **Estimated Workload:** 30 h
- **Buffer:** 8 h

---

### 🧩 Selected Epics & User Stories

#### Epic 7 – Analytics & Reporting
**US-PMP-07-21 – Performance Reports**  
**Story Points:** 8

**Acceptance Criteria:**
```gherkin
Scenario: Report generation
Given performance data exists
When the aggregation pipeline is executed
Then download and favorite metrics are displayed

Scenario: Empty report
Given no data exists
When the pipeline is executed
Then the system displays a "no data available" message
```

#### Epic 8 – Index Optimization
**US-PMP-08-25 – Index Creation**  
**Story Points:** 5

**Acceptance Criteria:**
```gherkin
Scenario: Query optimization
Given slow-running queries
When indexes are applied
Then response time improves

Scenario: Missing index
Given a collection without an index
When querying a specific field
Then the system warns about poor performance
```

#### Epic 9 – Final Integration
**US-PMP-09-30 – Final Delivery**  
**Story Points:** 13

**Acceptance Criteria:**
```gherkin
Scenario: Final validation
Given all modules are integrated
When end-to-end tests are executed
Then the system runs without errors

Scenario: Final presentation
Given the project is complete
When the demo is presented
Then the documentation and system are approved by the Product Owner
```

---

### 👥 Team Members

| Role | Person | Responsibility |
|------|--------|----------------|
| Data Analyst | Isabel | Pipeline and report design |
| Query Developer | Dilan | Aggregation and index implementation |
| QA Engineer | Ariz | Performance auditing |
| Integration Specialist | Iván | Final integration and deployment |
| Scrum Master | Klara | Documentation and final demo |

---

### 🔗 Dependencies and Independencies
- **Dependencies:** Functional data and queries from Sprint 2, stable MongoDB Atlas connection.
- **Independencies:** Optimization and indexing can be developed in parallel with reporting tasks.