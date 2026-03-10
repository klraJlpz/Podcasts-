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

# 🧠 System Architecture

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

# 🗄 Database Model

This project uses:

- **MongoDB** as the NoSQL database
- **MongoDB Atlas** for cloud database hosting

Data is stored as **JSON/BSON documents** organized in collections.

---

## 📂 Main Collections

| Collection | Description |
|-------------|-------------|
| **users** | Stores