# 🎙 Streaming Podcast Manager (Audio)
 Project Overview
Streaming Podcast Manager is a NoSQL-based application designed to manage podcast content and metadata.
The system allows the storage and organization of podcast information such as:
podcast metadata
episodes
creators
user interactions
playlists and reviews
The application follows a document-oriented architecture, where a podcast is represented as a document containing episode data and creator metadata.
The goal of this project is to demonstrate the design and implementation of a NoSQL data architecture using document databases.
System Architecture
The system uses a document-based model inspired by real-world podcast platforms.
In this model:
A Podcast acts as the main document.
Each podcast contains a list of Episodes.
Episodes can include metadata, duration, and description.
Additional collections manage users, playlists, and reviews.
This approach allows flexible data structures and efficient content retrieval.
Database Model
The project uses a NoSQL database implemented with
MongoDB and deployed in
MongoDB Atlas.
Main Collections
users: Stores user information and roles
podcasts: Main podcast documents
episodes: Podcast episodes
playlists: User-created episode lists
reviews: Feedback and ratings for episodes
Example Podcast Document
Example of a podcast document stored in the database:
JSON
{
  "podcastTitle": "Ecos de México",
  "creator": {
    "name": "Podcast Studio",
    "country": "Mexico"
  },
  "episodes": [
    {
      "title": "La Llorona",
      "duration": "18:25",
      "description": "A famous Mexican legend."
    },
    {
      "title": "El Charro Negro",
      "duration": "21:10",
      "description": "A mysterious supernatural story."
    }
  ]
}
This structure demonstrates how episode information can be embedded inside the podcast document, improving read performance for streaming applications.
Technologies Used
The following technologies were used in the development of this project:
MongoDB — document database used to store podcast data
MongoDB Atlas — cloud database deployment
MongoDB Compass — database visualization and management
Figma — mobile interface development
Visual Studio Code — development environment
GitHub — version control and collaboration
👥 Team Data
JSON
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
Team Roles
Each team member had a specific responsibility during the project development:
Data Modeler
Designed the document structure
Defined collections and relationships
Decided between embedding and referencing
Integration Specialist
Created the MongoDB Atlas cluster
Configured database access
Managed repository integration with GitHub
Query Developer
Implemented database queries
Tested retrieval operations
Optimized data access patterns
Data Seeder / QA
Created mock data using JSON files
Inserted test documents into the database
Validated query results and detected possible bugs
AI-Assisted Development
During the development of this project, the team used
ChatGPT as a Senior NoSQL Mentor.
The AI assisted with:
understanding document-oriented database design
generating JSON examples
explaining NoSQL modeling strategies
validating architecture decisions
This interaction helped the team improve their understanding of NoSQL concepts.
Learning Outcomes
Through this project, the team learned:
how to design NoSQL document architectures
how to structure JSON/BSON documents
how to use MongoDB Atlas in a cloud environment
how to collaborate using GitHub version control
Student Pledge
All team members reviewed and validated the code and documentation included in this repository.
This project represents our own work and learning process throughout the course.",
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