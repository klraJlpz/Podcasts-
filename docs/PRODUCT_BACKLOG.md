# 📋 PRODUCT BACKLOG — STREAMING PODCAST MANAGER
---
## Product Goal

Develop a secure, centralized, and cross-platform Podcast Management Platform (PMP) that allows users to discover content, manage their personal library, interact socially, and provides creators with tools to manage content and analyze performance metrics. The platform aims to minimize manual organization, improve accessibility, and deliver a seamless experience for listeners and creators.

---

# Epics

- **Epic 1: Account Management** – Registration, secure authentication, session management, and user profile administration.

- **Epic 2: Content Exploration** – Podcast catalog browsing, episode visualization, searching, filtering, and advanced search.

- **Epic 3: Personal Library** – Playlists, favorites, saved episodes, and library organization.

- **Epic 4: Social Interaction** – Comments, reviews, and ratings by listeners.

- **Epic 5: Creator Profile Management** – Creator profile, episode management, and content organization.

- **Epic 6: Metrics and Statistics** – Performance reports, download stats, ratings, and engagement tracking.

- **Epic 7: Infrastructure and Deployment** – Cloud deployment, documentation, integration, testing, and final delivery.

---

# User Stories & Acceptance Criteria

# Epic 1: Account Management

## US-PMP-01-01 – User Registration

**Story Points:** 3

### User Story

As a user, I want to register on the platform so that I can create my personal account and access the podcast services.

### Acceptance Criteria

```gherkin
Scenario: Successful account registration

Given a new user accesses the registration form
When the user enters valid credentials and submits
Then the system creates a unique account
And prevents duplicate accounts
And allows the user to access the platform
```

```gherkin
Scenario: Validation of required fields

Given the registration form is displayed
When the user leaves mandatory fields empty
Then the system displays validation messages
And prevents account creation
```

```gherkin
Scenario: Password security validation

Given the user enters a password
When the password does not meet security requirements
Then the system rejects the password
And displays the corresponding security guidelines
```

```gherkin
Scenario: Email uniqueness verification

Given an email address already exists
When the user attempts to register with the same email
Then the system rejects the registration
And informs the user that the email is already in use
```

---

## US-PMP-01-02 – Secure Login and Logout

**Story Points:** 3

### User Story

As a user, I want to securely log in and log out so that my account and personal information are protected.

### Acceptance Criteria

```gherkin
Scenario: Successful login

Given a registered user exists
When the user enters valid credentials
Then the system authenticates the user
And grants access to the personal profile
```

```gherkin
Scenario: Successful logout

Given an authenticated session
When the user logs out
Then the system invalidates the session immediately
And restricts access to protected resources
```

```gherkin
Scenario: Invalid login credentials

Given a registered user exists
When invalid credentials are entered
Then the system denies access
And displays an authentication error message
```

```gherkin
Scenario: Session persistence

Given a user successfully authenticates
When navigating through the platform
Then the session remains active until logout or expiration
```

```gherkin
Scenario: Automatic session expiration

Given a user remains inactive for a defined period
When the inactivity limit is reached
Then the system closes the session automatically
```

---

# Epic 2: Content Exploration

## US-PMP-02-03 – Podcast Catalog Exploration

**Story Points:** 5

### User Story

As a listener, I want to explore the available podcast catalog so that I can discover new content.

### Acceptance Criteria

```gherkin
Scenario: Viewing podcast catalog

Given podcasts exist in the platform
When the listener accesses the catalog
Then the system displays all podcasts
And shows title, category, and creator
```

```gherkin
Scenario: Empty catalog handling

Given no podcasts are available
When the listener accesses the catalog
Then the system displays an informative message
```

```gherkin
Scenario: Catalog loading performance

Given a large number of podcasts exist
When the listener accesses the catalog
Then the catalog loads successfully
And all information is displayed correctly
```

---

## US-PMP-02-04 – Episode Visualization

**Story Points:** 5

### User Story

As a listener, I want to view the episodes of a podcast so that I can select content to listen to.

### Acceptance Criteria

```gherkin
Scenario: Viewing podcast episodes

Given a podcast contains episodes
When the listener selects a podcast
Then the system displays all associated episodes correctly
```

```gherkin
Scenario: Episode information display

Given episodes exist for a podcast
When the listener views the episode list
Then each episode displays title, duration, and publication date
```

```gherkin
Scenario: Podcast without episodes

Given a selected podcast contains no episodes
When the listener opens the podcast
Then the system displays an informative message
```

---

### US-PMP-02-07 – Podcast Search

**Story Points:** 5

### User Story

As a listener, I want to search podcasts by name so that I can quickly find desired content.

### Acceptance Criteria

```gherkin
Scenario: Searching podcasts

Given podcasts exist in the platform
When the listener types a podcast name
Then the system returns only matching podcasts
```

---

### US-PMP-02-11 – Episode Search

**Story Points:** 5

### User Story

As a listener, I want to search episodes by title so that I can directly access specific content.

### Acceptance Criteria

```gherkin
Scenario: Searching episodes

Given episodes exist in the platform
When the listener searches by title
Then the system immediately displays the correct episode
```

---

### US-PMP-02-13 – Podcast Filtering

**Story Points:** 8

### User Story

As a listener, I want to filter podcasts by duration, rating, or category so that I can discover content matching my preferences.

### Acceptance Criteria

```gherkin
Scenario: Applying podcast filters

Given multiple podcasts are available
When the listener applies filters
Then the system displays only matching podcasts
```

---

### US-PMP-02-15 – Advanced Combined Filters

**Story Points:** 8

### User Story

As a listener, I want to combine multiple search filters so that I can obtain more precise results.

### Acceptance Criteria

```gherkin
Scenario: Applying combined filters

Given multiple search filters exist
When the listener combines them
Then the system displays only content satisfying all conditions
```

---

# Epic 3: Personal Library

## US-PMP-03-17 – Playlist Organization

**Story Points:** 5

### User Story

As a listener, I want my playlists to contain multiple organized episodes so that I can manage my listening experience efficiently.

### Acceptance Criteria

```gherkin
Scenario: Viewing playlists and favorites

Given the listener has saved episodes
When accessing the personal library
Then the system displays playlists and favorites correctly
And organizes all content without errors
```

```gherkin
Scenario: Creating playlists

Given the listener accesses the library
When a new playlist is created
Then the playlist is stored successfully
```

```gherkin
Scenario: Adding episodes to playlists

Given a playlist exists
When the listener adds an episode
Then the episode appears in the selected playlist
```

```gherkin
Scenario: Removing episodes from playlists

Given episodes exist in a playlist
When the listener removes an episode
Then the playlist updates immediately
```

---

## US-PMP-03-20 – Favorites Synchronization

**Story Points:** 5

### User Story

As a listener, I want favorites to update immediately when adding or removing content so that my library remains synchronized.

### Acceptance Criteria

```gherkin
Scenario: Updating favorites

Given favorite content exists
When the listener adds or removes an episode
Then the system updates the favorites section instantly
```

```gherkin
Scenario: Favorite persistence

Given an episode is marked as favorite
When the user logs in from another device
Then the favorite episode remains synchronized
```

```gherkin
Scenario: Duplicate favorite prevention

Given an episode is already marked as favorite
When the listener attempts to add it again
Then the system prevents duplicate entries
```

---

# Epic 4: Social Interaction

## US-PMP-04-19 – Review and Comment Management

**Story Points:** 5

### User Story

As a listener, I want to edit or delete my reviews and comments so that I can keep my opinions updated.

### Acceptance Criteria

```gherkin
Scenario: Editing comments and reviews

Given the listener has published reviews or comments
When the listener edits or deletes content
Then the system updates or removes it successfully
```

```gherkin
Scenario: Editing own comments only

Given comments exist
When a listener attempts to edit another user's comment
Then the system denies the operation
```

```gherkin
Scenario: Deleting own review

Given a listener has submitted a review
When the review is deleted
Then it is removed from the platform immediately
```

```gherkin
Scenario: Content validation

Given a review is submitted
When prohibited or empty content is detected
Then the system rejects the submission
```

---

## Epic 5: Creator Profile Management

### US-PMP-05-08 – Creator Content Organization

**Story Points:** 5

### User Story

As a creator, I want my profile and episode information to remain organized so that my content stays consistent.

### Acceptance Criteria

```gherkin
Scenario: Managing creator profile information

Given a creator profile exists
When accessing profile management
Then the system displays complete and consistent information
```

---

### US-PMP-05-25 – Creator Content Operations

**Story Points:** 8

### User Story

As a creator, I want to create, modify, and delete my episodes and profile information so that I can fully manage my content.

### Acceptance Criteria

```gherkin
Scenario: Managing creator content

Given creator permissions exist
When performing create, update, or delete operations
Then the system executes them successfully
And prevents system failures
```

---

## Epic 6: Metrics and Statistics

### US-PMP-06-24 – Content Performance Statistics

**Story Points:** 8

### User Story

As a creator, I want to view episode performance statistics so that I can make informed decisions about my content.

### Acceptance Criteria

```gherkin
Scenario: Viewing analytics

Given analytics data exists
When the creator accesses the statistics dashboard
Then the system displays ratings, downloads, and favorite metrics correctly
```

---

## Epic 7: Infrastructure and Deployment

### US-PMP-07-05 – Cloud Connectivity

**Story Points:** 5

### User Story

As a user, I want the platform connected to the cloud so that I can access my data from any device.

### Acceptance Criteria

```gherkin
Scenario: Accessing cloud services

Given the platform is deployed in the cloud
When the user accesses it
Then the system provides uninterrupted data access
```

---

### US-PMP-07-06 – Real Data Validation

**Story Points:** 5

### User Story

As a user, I want the platform to work with real data so that all functionalities can be validated properly.

### Acceptance Criteria

```gherkin
Scenario: Operating with real data

Given real records exist
When users interact with the platform
Then all functionalities work without visible errors
```

---

### US-PMP-07-09 – Project Documentation

**Story Points:** 3

### User Story

As a user, I want complete project documentation so that I can understand installation and usage processes.

### Acceptance Criteria

```gherkin
Scenario: Accessing project documentation

Given documentation exists
When the user reviews installation and usage guides
Then the information is clear and understandable
```

---

### US-PMP-07-10 – Database Structure Presentation

**Story Points:** 3

### User Story

As a user, I want to understand the database structure so that I can trust the organization of stored information.

### Acceptance Criteria

```gherkin
Scenario: Reviewing database structure

Given the database presentation exists
When the user reviews diagrams and explanations
Then the database structure is clearly documented
```

---

### US-PMP-07-21 to US-PMP-07-30 – Final Integration and Delivery

**Story Points:** 13

### User Story

As a user, I want the final version of the project to be stable, complete, and fully functional so that all platform features operate correctly in real scenarios.

### Acceptance Criteria

```gherkin
Scenario: Final system validation

Given all modules are integrated
When users test registration, searches, favorites, comments, statistics, and creator operations
Then the platform functions correctly without integration conflicts
```

```gherkin
Scenario: Final presentation and documentation

Given the project reaches final delivery
When the development team presents the platform
Then the presentation, documentation, diagrams, testing evidence, and demonstrations are complete and functional
```
## 📊 PROJECT PROGRESS

| Status | Quantity | Percentage |
|--------|----------|------------|
| ✅ Completed | 16 | 53% |
| 🔄 In Progress | 2 | 7% |
| ⏳ Pending | 12 | 40% |
| **Total** | **30** | **100%** |

```text
Current Progress: (16 / 30) × 100 = 53%
```

---

## 👥 SCRUM TEAM

| Role | Team Member |
|-----|-------------|
| Scrum Master | Klara |
| Data Modeler | Isabel |
| Integration Specialist | Iván |
| Query Developer | Dilan |
| Data Seeder / QA | Ariz |

---

## 🗄️ COLLECTIONS IN MONGODB ATLAS

| Collection | Documents | Main Purpose |
|-----------|-----------|---------------|
| `usuarios` | 72 | Extended user profile |
| `episodes` | 31 | Main catalog episodes |
| `users` | 10 | Authentication data |
| `podcasts` | 8 | Podcast catalog |
| `ratings` | 5 | Content ratings |
| `downloads` | 5 | Episode downloads |
| `favorites` | 6 | User saved content |
| `creadores` | 26 | Content creator profiles |
| `episodios` | 3 | Spanish-language episodes |
| `playlists` | 1 | Playlists |
| `reviews` | 1 | Written reviews |
| `queries` | 1 | Stored queries |
| `accounts` | 0 | Access accounts |
| `comments` | 0 | Episode comments |
| `sessions` | 0 | Active sessions |
| `listeninghistories` | 0 | Listening history |
| `verificationtokens` | 0 | Verification tokens |
```
