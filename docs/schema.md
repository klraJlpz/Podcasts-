```mermaid
erDiagram
PLAYLIST {
    ObjectId _id
    ObjectId creatorId  // Llave foránea → CREATOR._id
    string title "Leyendas de Mexico: Voces del Mas Alla"
    string theme "Mexican Urban Legends"
    string description "Narraciones documentadas sobre leyendas tradicionales mexicanas"
    boolean isPublic
    number totalDurationMinutes
    date createdAt
}

CREATOR {
    ObjectId _id   // Llave primaria
    string name "Kari Hernandez"
    string email "kari.podcast@schoolproject.mx"
    string country "Mexico"
    number followers
    date joinedAt
}

STATISTICS {
    ObjectId _id              // Llave primaria
    ObjectId playlistId       // Llave foránea → PLAYLIST._id
    number totalPlays
    number totalLikes
    number averageRating
    number totalEpisodes
}

PODCAST_EPISODE {
    ObjectId episodeId   // Llave primaria
    ObjectId playlistId  // Llave foránea → PLAYLIST._id
    string legendTitle "La Llorona / El Charro Negro / La Pascualita"
    string legendOriginRegion "Mexico"
    string historicalContext "Colonial and Popular Folklore"
    number durationMinutes
    number rating
    boolean isExplicit
    string language "Spanish"
    date releaseDate
    number playCount
}

REVIEW {
    ObjectId reviewId        // Llave primaria
    ObjectId playlistId      // Llave foránea → PLAYLIST._id
    string username "Ana_MX"
    number rating
    string comment "Excelente narracion y respeto cultural"
    date createdAt
}

CREATOR ||--o{ PLAYLIST : creates
PLAYLIST ||--|| STATISTICS : has
PLAYLIST ||--o{ PODCAST_EPISODE : contains
PLAYLIST ||--o{ REVIEW : receives
```
