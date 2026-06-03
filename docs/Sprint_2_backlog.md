# 🎧 Podcast Management Platform (PMP)
---

# Sprint 2 – Querying and Data Manipulation (Mar 23 – May 14)

---

## 🥅 Sprint Goal
Implement basic and advanced queries, logical operators, and array manipulation to achieve complete data management within the platform.

---

## ⚙️ Sprint Parameters & Capacity Plan
- **Duration:** 4 weeks
- **Weekly Hours:** 40 h
- **Total Capacity:** 160 h
- **Estimated Workload:** 150 h
- **Buffer:** 10 h

---

## 🧩 Selected Epics & User Stories

### Epic 4 – CRUD Operations
**US-PMP-04-10 – Data Retrieval and Projection**  
**Story Points:** 5

#### Acceptance Criteria

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

### Epic 5 – Logical & Comparison Operators
**US-PMP-05-13 – Advanced Filtering**  
**Story Points:** 8

#### Acceptance Criteria

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

### Epic 6 – Array Manipulation
**US-PMP-06-17 – Array Updates**  
**Story Points:** 5

#### Acceptance Criteria

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

## 📅 Weekly Tasks & Estimated Hours

### Week 1 – Query Development (40 h)

| Task | Role | Hours |
|------|------|------|
| Basic query implementation | Query Developer | 20 h |
| Documentation update | Scrum Master | 8 h |
| Initial testing | QA Engineer | 12 h |

### Week 2 – Advanced Filtering (40 h)

| Task | Role | Hours |
|------|------|------|
| Logical operators implementation | Query Developer | 16 h |
| Comparison operators implementation | Query Developer | 12 h |
| Validation testing | QA Engineer | 12 h |

### Week 3 – Array Manipulation (40 h)

| Task | Role | Hours |
|------|------|------|
| $push and $pull implementation | Query Developer | 16 h |
| Structure consistency review | Data Modeler | 12 h |
| Functional testing | QA Engineer | 12 h |

### Week 4 – Integration & Review (40 h)

| Task | Role | Hours |
|------|------|------|
| End-to-end query testing | QA Engineer | 16 h |
| Documentation update | Scrum Master | 12 h |
| Sprint review | Entire Team | 12 h |

---

## 👥 Team Members

| Role | Person | Sprint Responsibilities |
|------|--------|-------------------------|
| Scrum Master | Klara | Track sprint progress, update documentation, manage version control and sprint reviews. |
| Data Modeler | Isabel | Verify schema consistency, support query design, validate data relationships. |
| Query Developer | Dilan | Implement CRUD operations, logical operators, comparison operators, and array manipulation queries. |
| Data Seeder / QA | Ariz | Perform query testing, validate filters, verify array updates, and execute end-to-end tests. |

---

## 🚧 Impediments & Dependencies

### Dependencies
- Database created in Sprint 1.
- Populated collections available.
- Approved schema structure.

### Potential Impediments
- Incorrect query optimization.
- Data inconsistencies.
- Delays in testing activities.

---
