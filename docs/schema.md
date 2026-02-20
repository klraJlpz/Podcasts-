erDiagram

    PLAYLIST {
        ObjectId _id
        string title
        string theme
        string description
        boolean isPublic
        number totalDuration
        date createdAt
    }

    CREATOR {
        string name
        string email
        number followers
        string country
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
        string title
        number duration
        string subgenre
        number rating
        boolean isExplicit
        string language
        date releaseDate
        number playCount
    }

    REVIEW {
        string username
        number rating
        string comment
        date createdAt
    }

    PLAYLIST ||--|| CREATOR : embeds
    PLAYLIST ||--|| STATISTICS : embeds
    PLAYLIST ||--o{ PODCAST_EPISODE : embeds
    PLAYLIST ||--o{ REVIEW : embeds 