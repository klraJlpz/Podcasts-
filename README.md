# 🎙 Streaming Podcast Manager (Audio)

## 📌 Project Overview

**Streaming Podcast Manager** is a **NoSQL-based application** designed to manage podcast content using a **document-oriented architecture**.

The platform allows users to manage:

- 🎧 **Podcasts**
- 📻 **Episodes**
- 👤 **Users**
- 📂 **Playlists**
- ⭐ **Reviews**

The main concept of the system is:

> **A podcast is represented as a document that contains episode data and creator metadata.**

This project demonstrates how **NoSQL databases can model real-world streaming platforms** using flexible document structures.

---

# System Architecture

The application follows a **document-based architecture**.

Instead of traditional relational tables, the system stores information as **documents inside collections**.

### Core Concept

A **Podcast Document** contains:

- Podcast metadata  
- Creator information  
- Embedded episodes  

This structure allows:

- ✔ Flexible schema  
- ✔ Faster data retrieval  
- ✔ Better scalability for streaming platforms  

---

# Database Model

This project uses:

- **MongoDB** as the NoSQL database
- **MongoDB Atlas** for cloud database hosting

Data is stored as **JSON/BSON documents** organized in collections.

---

## Main Collections

| Collection | Description |
|-------------|-------------|
| **users** | Stores



## Technologies Used
**The following technologies were used during development:**

- ***MongoDB*** — NoSQL database
- ***MongoDB Atlas*** — cloud database service
- ***MongoDB Compass*** — database visualization tool
- ***Figma*** — mobile interface framework
- ***Visual Studio Code*** — development environment
- ***GitHub*** — version control and collaboration platform

## 👥 Team Data

```json
{
  "teamName": "Equipo NoSQL Podcast Project",
  "project": "Streaming Podcast Manager (Audio)",
  "team": [
{
      "firstName": "Klara Karime",
      "lastName": "Jácome López",
      "role": "The Data Seeder / QA",
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
    {
      "firstName": "Iván Mauricio",
      "lastName": "Morales Olguín",
      "role": "The Integration Specialist",
      "age": 16
    }
  ]
}
```


# Team Responsibilities

****🐋 Data Modeler****

Responsible for:
- Designing the document structure
- Defining collections
- Deciding between embedding vs referencing

****🐳 Integration Specialist****

Responsible for:
- Creating the MongoDB Atlas cluster
- Managing the database connection
- Organizing the GitHub repository

 ****🐬 Query Developer****

Responsible for:
- Creating database queries
- Retrieving and filtering data
- Testing query performance

****🪼 Data Seeder / QA****

Responsible for:
- Generating mock data using JSON
- Inserting documents into the database
- Validating queries and identifying bugs

# AI-Assisted Development

During the development of this project the team used ChatGPT as a Senior NoSQL Mentor.

The AI helped the team to:

- Understand NoSQL architecture concepts
- Generate JSON examples
- Explain database modeling strategies
- Validate technical decisions

This helped improve the learning process and technical understanding of the team.

# Learning Outcomes

Through this project the team learned:

- How to design NoSQL document architectures
- How to structure JSON/BSON documents
- How to deploy databases using MongoDB Atlas
- How to collaborate using GitHub version control

# Student Pledge

All team members reviewed and validated the code included in this repository.
This project represents our own work and reflects our learning process throughout the course.