erDiagram

    PLAYLIST {
        ObjectId _id
        string title "Leyendas de Mexico: Voces del Mas Alla"
        string theme "Mexican Urban Legends"
        string description "Narraciones documentadas sobre leyendas tradicionales mexicanas"
        boolean isPublic
        number totalDurationMinutes
        date createdAt
    }

    CREATOR {
        string name "Kari Hernandez"
        string email "kari.podcast@schoolproject.mx"
        string country "Mexico"
        number followers
        date joinedAt
    }

    STATISTICS {
        number totalPlays
        number totalLikes
        number averageRating
        number totalEpisodes
    }

    PODCAST_EPISODE {
        ObjectId episodeId
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
        string username "Ana_MX"
        number rating
        string comment "Excelente narracion y respeto cultural"
        date createdAt
    }

    PLAYLIST ||--|| CREATOR : embeds
    PLAYLIST ||--|| STATISTICS : embeds
    PLAYLIST ||--o{ PODCAST_EPISODE : embeds
    PLAYLIST ||--o{ REVIEW : embeds