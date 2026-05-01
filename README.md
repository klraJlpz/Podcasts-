

🎙️ Streaming Podcast Manager (Audio)


---

📌 Project Overview

Streaming Podcast Manager is a NoSQL-based application designed to manage podcast content using a document-oriented architecture.

The platform allows users to manage:

🎧 Podcasts

📻 Episodes

👤 Users

📂 Playlists

⭐ Reviews


> A podcast is represented as a document that contains episode data and creator metadata.



This project demonstrates how NoSQL databases can model real-world streaming platforms using flexible document structures.


---

🧠 System Architecture

The application follows a document-based architecture.

Instead of traditional relational tables, the system stores information as:

Documents

Collections

JSON/BSON structures


🔑 Core Concept

A Podcast Document contains:

Podcast metadata

Creator information

Embedded episodes


✅ Advantages

✔ Flexible schema

✔ Faster data retrieval

✔ Better scalability



---

🗂️ Database Model

This project uses:

MongoDB as the NoSQL database

MongoDB Atlas for cloud database hosting


Data is stored as:

JSON documents

BSON format internally



---

📊 Main Collections

users

Stores user information (name, email, age, role, active status)


podcasts

Contains podcast metadata and embedded episodes


playlists

Stores collections of podcast episodes


reviews

Stores user feedback and ratings




---

🔍 Query System

The project implements MongoDB Query Language (MQL).

🔹 Basic Queries

find()

findOne()


🔹 Filters

$gt

$lt

$in

$ne


🔹 Logical Operators

$and

$or

$not


🎯 Capabilities

Efficient data retrieval

Conditional filtering

Complex queries



---

🧪 Data Seeding & Validation

To simulate real-world conditions:

✔ 50+ users generated

✔ Data inserted using insertMany()

✔ Queries tested and validated



---

📱 UI Design

The interface was:

Designed in Figma

Partially implemented in Flutter


Features:

Podcast browsing

Episode visualization

Basic navigation



---

🧩 Development Methodology

The project followed Scrum methodology:

🚀 Sprints

Sprint 1

Data modeling & database setup


Sprint 2

Data seeding & basic queries


Sprint 3

Filters implementation


Sprint 4

Logical queries


Sprint 5

Integration & UI




---

⚙️ Technologies Used

MongoDB — NoSQL database

MongoDB Atlas — Cloud database service

MongoDB Compass — Visualization tool

Flutter — UI framework

Figma — UI design

Visual Studio Code — Development environment

GitHub — Version control



---

👥 Team Data

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
    {
      "firstName": "Iván Mauricio",
      "lastName": "Morales Olguín",
      "role": "The Integration Specialist",
      "age": 16
    },
    {
      "firstName": "Ariz",
      "lastName": "",
      "role": "The Data Seeder / QA",
      "age": 16
    }
  ]
}


---

👨‍💻 Team Responsibilities

🐋 Data Modeler

Designing document structures

Defining collections

Applying embedding and referencing


🐳 Integration Specialist

Managing MongoDB Atlas

Ensuring system integration

Organizing repository


🐬 Query Developer

Developing queries

Implementing filters and logic

Validating results


🪼 Data Seeder / QA

Generating JSON data

Inserting documents

Testing queries


🧠 Scrum Master

Managing sprints

Coordinating team

Organizing workflow



---

🤖 AI-Assisted Development

During the project, the team used:

ChatGPT

Abacus.AI


🔍 Purpose:

Understanding NoSQL concepts

Generating examples

Debugging queries

Improving documentation



---

🎯 Learning Outcomes

NoSQL data modeling

JSON/BSON structures

MongoDB query development

Cloud database deployment

Scrum teamwork



---

📃 Student Pledge

All team members reviewed and validated the code included in this repository.

This project represents our own work and reflects our learning process.


