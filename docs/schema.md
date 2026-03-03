```mermaid
erDiagram
CREATOR {
    ObjectId creatorId PK
    string name
    string email
    string country
    number followers
    string bio
    date joinedAt
}

OYENTES {
    ObjectId oyenteId PK
    string username
    string email
    string country
    date registeredAt
}

PLAYLIST {
    ObjectId playlistId PK
    ObjectId creatorId FK
    string title
    string theme
    string description
    boolean isPublic
    number totalDurationMinutes
    date createdAt
}

STATISTICS {
    ObjectId statisticsId PK
    ObjectId playlistId FK
    number totalPlays
    number totalLikes
    number averageRating
    number totalEpisodes
}

PODCAST_EPISODE {
    ObjectId episodeId PK
    ObjectId playlistId FK
    string legendTitle
    string legendOriginRegion
    string historicalContext
    number durationMinutes
    number rating
    boolean isExplicit
    string language
    date releaseDate
    number playCount
    string audioUrl
}

REVIEW {
    ObjectId reviewId PK
    ObjectId playlistId FK
    ObjectId oyenteId FK
    number rating
    string comment
    date createdAt
}

PLAYBACK_PROGRESS {
    ObjectId progressId PK
    ObjectId oyenteId FK
    ObjectId episodeId FK
    number minuteStopped
    date lastPlayedAt
}

SUBSCRIPTION {
    ObjectId subscriptionId PK
    ObjectId oyenteId FK
    ObjectId creatorId FK
    date subscribedAt
}

CREATOR ||--o{ PLAYLIST : creates
PLAYLIST ||--|| STATISTICS : has
PLAYLIST ||--o{ PODCAST_EPISODE : contains
PLAYLIST ||--o{ REVIEW : receives
OYENTES ||--o{ REVIEW : writes
OYENTES ||--o{ PLAYBACK_PROGRESS : tracks
PODCAST_EPISODE ||--o{ PLAYBACK_PROGRESS : stores
OYENTES ||--o{ SUBSCRIPTION : follows
CREATOR ||--o{ SUBSCRIPTION : gains
```
