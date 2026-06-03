# 🎧 Podcast Management Platform (PMP)
---

# Sprint 3 – Aggregations and Optimization (May 18 – Jun 19)

---

## 🥅 Sprint Goal
Develop analytical reports using the Aggregation Framework, optimize queries through indexes, and deliver the final version of the PMP project.

---

## ⚙️ Sprint Parameters & Capacity Plan
- **Duration:** 4 weeks
- **Weekly Hours:** 40 h
- **Total Capacity:** 160 h
- **Estimated Workload:** 150 h
- **Buffer:** 10 h

---

## 🧩 Selected Epics & User Stories

### Epic 7 – Analytics & Reporting
**US-PMP-07-21 – Performance Reports**  
**Story Points:** 8

#### Acceptance Criteria

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

### Epic 8 – Index Optimization
**US-PMP-08-25 – Index Creation**  
**Story Points:** 5

#### Acceptance Criteria

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

### Epic 9 – Final Integration
**US-PMP-09-30 – Final Delivery**  
**Story Points:** 13

#### Acceptance Criteria

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

## 📅 Weekly Tasks & Estimated Hours

### Week 1 – Aggregation Framework (40 h)

| Task | Role | Hours |
|------|------|------|
| Aggregation pipeline design | Data Analyst | 16 h |
| Metrics implementation | Query Developer | 12 h |
| Testing | QA Engineer | 12 h |

### Week 2 – Reporting System (40 h)

| Task | Role | Hours |
|------|------|------|
| Report generation | Data Analyst | 16 h |
| Dashboard validation | QA Engineer | 12 h |
| Documentation | Scrum Master | 12 h |

### Week 3 – Optimization (40 h)

| Task | Role | Hours |
|------|------|------|
| Index creation | Query Developer | 16 h |
| Performance testing | QA Engineer | 12 h |
| Optimization adjustments | Query Developer | 12 h |

### Week 4 – Final Delivery (40 h)

| Task | Role | Hours |
|------|------|------|
| Final integration | Integration Specialist | 16 h |
| End-to-end testing | QA Engineer | 12 h |
| Final presentation and documentation | Scrum Master | 12 h |

---

## 👥 Team Members

| Role | Person | Sprint Responsibilities |
|------|--------|-------------------------|
| Scrum Master | Klara | Coordinate final delivery, prepare documentation, organize project presentation and demo. |
| Data Modeler | Isabel | Design aggregation pipelines, validate reports, and ensure data consistency. |
| Query Developer | Dilan | Develop aggregation queries, implement indexes, optimize performance, and support integration. |
| Data Seeder / QA | Ariz | Execute performance testing, validate reports, perform final quality assurance and acceptance testing. |
| Integration Specialist | Iván | Integrate all modules, deploy the final system, resolve integration issues, and support final delivery. |

---

## 🚧 Impediments & Dependencies

### Dependencies
- Functional queries from Sprint 2.
- Stable MongoDB Atlas environment.
- Complete dataset for reporting.

### Potential Impediments
- Performance bottlenecks in aggregation pipelines.
- Index conflicts or misconfiguration.
- Integration issues between modules.
- Delays during final testing and deployment.