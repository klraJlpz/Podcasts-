# 🎙 Streaming Podcast Manager (Audio)

---

## 📌 Project Overview

**Streaming Podcast Manager** is a *NoSQL-based application* designed to manage podcast content using a **document-oriented architecture**.

The platform allows users to manage:

- 🎧 **Podcasts**  
- 📻 **Episodes**  
- 👤 **Users**  
- 📂 **Playlists**  
- ⭐ **Reviews**

> **A podcast is represented as a document that contains episode data and creator metadata.**

This project demonstrates how **NoSQL databases can model real-world streaming platforms** using flexible document structures.

---

## 🧠 System Architecture

The application follows a **document-based architecture**.

Instead of traditional relational tables, the system stores information as **documents inside collections**.

### 🔹 Core Concept

A **Podcast Document** contains:

- Podcast metadata  
- Creator information  
- Embedded episodes  

### ✔ Benefits

- ✔ Flexible schema  
- ✔ Faster data retrieval  
- ✔ Better scalability  

---

## 🗂 Database Model

This project uses:

- **MongoDB** as the NoSQL database  
- **MongoDB Atlas** for cloud database hosting  

Data is stored as **JSON/BSON documents** organized in collections.

---

## 📊 Main Collections

| Collection | Description |
|------------|------------|
| **users** | Stores user information (name, email, age, role, active status) |
| **podcasts** | Contains podcast metadata and embedded episodes |
| **playlists** | Stores collections of podcast episodes |
| **reviews** | Stores user feedback and ratings |

---

## 🔍 Query System

The project includes a structured implementation of **MongoDB Query Language (MQL)**.

### 🔹 Implemented Queries

- *Basic Queries*
  - `find()`
  - `findOne()`

- *Filters*
  - `$gt`, `$lt`, `$in`, `$ne`

- *Logical Operators*
  - `$and`, `$or`, `$not`

### ✔ Capabilities

- Efficient data retrieval  
- Conditional filtering  
- Complex data analysis  

---

## 🧪 Data Seeding & Validation

To simulate a real-world environment:

- ✔ 50+ user documents were generated  
- ✔ Data was inserted using `insertMany()`  
- ✔ Queries were tested and validated  

---

## 📱 UI Design

The user interface was designed using **Figma** and partially implemented using **Flutter**.

### 🔹 Features

- Podcast browsing  
- Episode visualization  
- Basic navigation  

---

## 🧩 Development Methodology

The project was developed using **Scrum methodology**, dividing the work into iterative sprints:

| Sprint | Focus |
|--------|------|
| **Sprint 1** | Data modeling & database setup |
| **Sprint 2** | Data seeding & basic queries |
| **Sprint 3** | Filters implementation |
| **Sprint 4** | Logical queries |
| **Sprint 5** | Integration & UI |

---

## ⚙️ Technologies Used

- **MongoDB** — NoSQL database  
- **MongoDB Atlas** — Cloud database service  
- **MongoDB Compass** — Database visualization tool  
- **Flutter** — UI framework  
- **Figma** — UI design tool  
- **Visual Studio Code** — Development environment  
- **GitHub** — Version control  

---

## 👥 Team Data

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
      "age": 16
    },



## Team Responsibilities

🐋 Data Modeler

Designing document structures

Defining collections

Applying embedding and referencing


🐳 Integration Specialist

Managing MongoDB Atlas setup

Ensuring system integration

Organizing repository structure


🐬 Query Developer

Developing queries (basic, filters, logic)

Implementing MQL operators

Validating query results


🪼 Data Seeder / QA

Generating realistic JSON data

Inserting and validating data

Testing system behavior


🪷 Scrum Master

Managing sprints and tasks

Coordinating team workflow

Ensuring project organization


## AI-Assisted Development

During the development of this project, the team used AI tools such as ChatGPT and Abacus.AI.

• AI Contributions

Understanding NoSQL concepts

Generating query examples

Debugging errors

Improving documentation



## Learning Outcomes

NoSQL data modeling

JSON/BSON structure design

MongoDB query development

Cloud database deployment

Agile teamwork using Scrum


📃 Student Pledge

All team members reviewed and validated the code included in this repository.
This project represents our own work and reflects our learning process.

