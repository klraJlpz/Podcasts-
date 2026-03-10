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
The following technologies were used during development:
MongoDB — NoSQL database
MongoDB Atlas — cloud database service
MongoDB Compass — database visualization tool
Flutter — mobile interface framework
Visual Studio Code — development environment
GitHub — version control and collaboration platform

## 👥 Team Data
JSON
Copiar código
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