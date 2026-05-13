# 🎙️ Streaming Podcast Manager (Audio)

---

## 💠 Project Overview

**Streaming Podcast Manager** is a NoSQL-based application designed to manage podcast content using a document-oriented architecture hosted on MongoDB Atlas.

The platform allows users to manage:

- 🎧 **Podcasts** — Full podcast metadata and embedded episode data
- 📻 **Episodes** — Individual audio content units
- 👤 **Users & Accounts** — User profiles and authentication
- 📂 **Playlists** — Custom user-curated content collections
- ⭐ **Reviews & Ratings** — Community feedback system
- 💬 **Comments** — Episode-level discussion
- 📥 **Downloads** — Offline content tracking
- 🕓 **Listening Histories** — Personalized playback records
- 🔐 **Sessions & Verification** — Auth and security management
- ❤️ **Favorites** — Saved content per user

A podcast is represented as a document containing episode data and creator metadata, demonstrating how NoSQL databases can model real-world streaming platforms using flexible document structures.

---

## 🔹 System Architecture

The application follows a **document-based architecture**.

Instead of traditional relational tables, the system stores information as documents inside collections, hosted on MongoDB Atlas (cloud) and visualized through MongoDB Compass.

### Core Concept

A **Podcast Document** contains:
- Podcast metadata
- Creator information
- Embedded episodes

### Benefits

- ✔️ Flexible schema — no rigid column definitions
- ✔️ Faster data retrieval — embedded documents reduce joins
- ✔️ Better scalability — horizontal scaling via Atlas clusters

---

## 🗄️ Database Model

This project uses:
- **MongoDB** as the NoSQL database engine
- **MongoDB Atlas** for cloud database hosting (Cluster0)
- Data stored as **JSON/BSON** documents organized in collections

> **Current database:** `proyectopodcast`
> **Storage size:** 471.04 kB | **Data size:** 41.89 kB | **Collections:** 17 | **Indexes:** 33

---

## 📂 Active Collections (English Only)

> ⚠️ **Important:** During development, some collections were created in Spanish (`usuarios`, `episodios`, `creadores`). These are **deprecated and no longer in use**. All active data now lives exclusively in the **English-named collections** listed below.

| Collection | Description |
|---|---|
| `accounts` | Stores user account credentials and profile settings |
| `comments` | Episode-level user comments and replies |
| `downloads` | Tracks episodes downloaded for offline listening |
| `episodes` | Individual podcast episode content and metadata |
| `favorites` | Episodes and podcasts saved/liked by users |
| `listeninghistories` | Full playback history per user |
| `playlists` | Custom user-curated episode collections |
| `podcasts` | Podcast metadata, creator info, and embedded episode references |
| `queries` | Saved query templates used during development and testing |
| `ratings` | Numeric ratings submitted by users per podcast/episode |
| `reviews` | Full-text user reviews with rating and timestamp |
| `sessions` | Active user session tokens and device info |
| `users` | Core user documents (name, email, age, role, active status) |
| `verificationtokens` | Email/account verification token management |

### 🔹 Deprecated Collections (No Longer Used)

The following collections exist in the cluster but contain **no active data** and are kept only for historical reference:

| Collection | Replaced By |
|---|---|
| `usuarios` | `users` |
| `episodios` | `episodes` |
| `creadores` | Embedded inside `podcasts` |

---

## 🔹 Query System

The project includes a structured implementation of **MongoDB Query Language (MQL)**.

### Implemented Queries

**Basic Queries**
```js
db.podcasts.find()
db.users.findOne({ email: "user@example.com" })
```

**Comparison Filters**
```js
// Users older than 18
db.users.find({ age: { $gt: 18 } })

// Episodes shorter than 30 minutes
db.episodes.find({ duration: { $lt: 30 } })

// Podcasts in specific categories
db.podcasts.find({ category: { $in: ["Tech", "Science"] } })

// Reviews that are not pending
db.reviews.find({ status: { $ne: "pending" } })
```

**Logical Operators**
```js
// Active users over 20 years old
db.users.find({ $and: [{ active: true }, { age: { $gt: 20 } }] })

// Episodes that are free OR featured
db.episodes.find({ $or: [{ isFree: true }, { featured: true }] })

// Users that are NOT inactive
db.users.find({ active: { $not: { $eq: false } } })
```

---

## 🔹Capabilities

- Efficient data retrieval across 14 active collections
- Conditional filtering with comparison operators
- Complex data analysis with logical query chaining
- Listening history and download tracking per user
- Token-based authentication and session management

---

## 🔹 Data Seeding & Validation

To simulate a real-world environment:

- ✔️ **50+ user documents** were generated with realistic data
- ✔️ Data was inserted using `insertMany()` across all active collections
- ✔️ Queries were tested and validated in MongoDB Compass
- ✔️ Deprecated Spanish collections were identified and excluded from active use

---

## 🔹 UI Design

The user interface was designed using **Figma** and partially implemented using **Flutter**.

### Features
- Podcast browsing and discovery
- Episode visualization and playback UI
- Playlist management views
- Basic navigation and routing

---

## 🔹 Development Methodology

The project was developed using **Scrum**, dividing work into iterative sprints:

| Sprint | Focus |
|---|---|
| Sprint 1 | Data modeling & database setup |
| Sprint 2 | Data seeding & basic queries |
| Sprint 3 | Filters implementation |
| Sprint 4 | Logical queries |
| Sprint 5 | Integration, collection cleanup & UI |

> **Sprint 5 update:** Spanish-named collections were officially deprecated. All collections were standardized to English naming conventions.

---

## 🔹 Technologies Used

| Tool | Purpose |
|---|---|
| MongoDB | NoSQL database engine |
| MongoDB Atlas | Cloud database hosting (Cluster0) |
| MongoDB Compass | Database visualization & query testing |
| Flutter | UI framework |
| Figma | UI/UX design |
| Visual Studio Code | Development environment |
| GitHub | Version control |

---

## 🔹 Team Data

```json
{
  "teamName": "Equipo NoSQL Podcast Project",
  "project": "Streaming Podcast Manager (Audio)",
  "team": [
    {
      "firstName": "Klara Karime",
      "lastName": "Jácome López",
      "role": "Scrum Master",
      "age": 16
    },
    {
      "firstName": "Maria Isabel",
      "lastName": "Baigen Jarillo",
      "role": "The Data Modeler",
      "age": 16
    },
    {
      "firstName": "Dilan Guillermo",
      "lastName": "Xochiquixtle Díaz",
      "role": "The Query Developer",
      "age": 17
    },
    {
      "firstName": "Iván Mauricio",
      "lastName": "Morales Olguín",
      "role": "The Integration Specialist",
      "age": 17
    },
    {
      "firstName": "Ariz",
      "lastName": "Martinez Rendon",
      "role": "The Data Seeder / QA",
      "age": 16
    }
  ]
}
```

---

## 🔹 Team Responsibilities

### 🐟 Data Modeler
- Designing document structures
- Defining and standardizing collections (English naming convention)
- Applying embedding and referencing strategies

### 🐳 Integration Specialist
- Managing MongoDB Atlas cluster setup (Cluster0)
- Ensuring integration between collections and app layer
- Organizing and maintaining repository structure

### 🐬 Query Developer
- Developing queries (basic, filters, logical)
- Implementing MQL operators across active collections
- Validating query results and documenting examples

### 🪼 Data Seeder / QA
- Generating realistic JSON seed data
- Inserting and validating data with `insertMany()`
- Testing system behavior and identifying deprecated collections

### 🪷 Scrum Master
- Managing sprints and task assignments
- Coordinating team workflow across all roles
- Ensuring project organization and delivery

---

## 🔹 AI-Assisted Development

During development, the team used AI tools including **ChatGPT** and **Abacus.AI** for:

- Understanding NoSQL concepts and document modeling
- Generating query examples and operator usage
- Debugging errors in MQL and data structure
- Improving technical documentation

---

## 🔹 Learning Outcomes

- NoSQL data modeling with embedded and referenced documents
- JSON/BSON document structure design
- MongoDB query development with MQL operators
- Cloud database deployment on MongoDB Atlas
- Collection lifecycle management (deprecation, standardization)
- Agile teamwork using Scrum methodology

---

## 🔹 Student Pledge

All team members reviewed and validated the code included in this repository. This project represents our own work and reflects our learning process.

---



### 🔹 Work Record

*View the Project Report here:*

[📍See Report](WORKLOG.md)

### 📝 Detailed individual report:

*View the report by team member here:*

[📍See Report](Portfolio/Individual_Report.md)
