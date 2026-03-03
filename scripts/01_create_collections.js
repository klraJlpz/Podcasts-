// Usa la base de datos (la crea si no existe)
use leyendas_podcast;

// CREATOR
db.createCollection("creator", {
  validator: {
    $jsonSchema: {
      bsonType: "object",
      required: ["name", "email", "country", "followers", "joinedAt"],
      properties: {
        name: { bsonType: "string" },
        email: { bsonType: "string" },
        country: { bsonType: "string" },
        followers: { bsonType: "int" },
        bio: { bsonType: "string" },
        joinedAt: { bsonType: "date" }
      }
    }
  }
});

// índices sugeridos
db.creator.createIndex({ email: 1 }, { unique: true });


// OYENTES
db.createCollection("oyente", {
  validator: {
    $jsonSchema: {
      bsonType: "object",
      required: ["username", "email", "country", "registeredAt"],
      properties: {
        username: { bsonType: "string" },
        email: { bsonType: "string" },
        country: { bsonType: "string" },
        registeredAt: { bsonType: "date" }
      }
    }
  }
});

db.oyente.createIndex({ username: 1 }, { unique: true });
db.oyente.createIndex({ email: 1 }, { unique: true });


// PLAYLIST
db.createCollection("playlist", {
  validator: {
    $jsonSchema: {
      bsonType: "object",
      required: [
        "creatorId",
        "title",
        "theme",
        "description",
        "isPublic",
        "totalDurationMinutes",
        "createdAt"
      ],
      properties: {
        creatorId: { bsonType: "objectId" },
        title: { bsonType: "string" },
        theme: { bsonType: "string" },
        description: { bsonType: "string" },
        isPublic: { bsonType: "bool" },
        totalDurationMinutes: { bsonType: "int" },
        createdAt: { bsonType: "date" }
      }
    }
  }
});

db.playlist.createIndex({ creatorId: 1 });
db.playlist.createIndex({ isPublic: 1 });


// STATISTICS (1:1 con PLAYLIST)
db.createCollection("statistics", {
  validator: {
    $jsonSchema: {
      bsonType: "object",
      required: [
        "playlistId",
        "totalPlays",
        "totalLikes",
        "averageRating",
        "totalEpisodes"
      ],
      properties: {
        playlistId: { bsonType: "objectId" },
        totalPlays: { bsonType: "int" },
        totalLikes: { bsonType: "int" },
        averageRating: { bsonType: "double" },
        totalEpisodes: { bsonType: "int" }
      }
    }
  }
});

// Enforce 1:1 playlist <-> statistics
db.statistics.createIndex(
  { playlistId: 1 },
  { unique: true }
);


// PODCAST_EPISODE
db.createCollection("podcast_episode", {
  validator: {
    $jsonSchema: {
      bsonType: "object",
      required: [
        "playlistId",
        "legendTitle",
        "legendOriginRegion",
        "historicalContext",
        "durationMinutes",
        "rating",
        "isExplicit",
        "language",
        "releaseDate",
        "playCount",
        "audioUrl"
      ],
      properties: {
        playlistId: { bsonType: "objectId" },
        legendTitle: { bsonType: "string" },
        legendOriginRegion: { bsonType: "string" },
        historicalContext: { bsonType: "string" },
        durationMinutes: { bsonType: "int" },
        rating: { bsonType: "double" },
        isExplicit: { bsonType: "bool" },
        language: { bsonType: "string" },
        releaseDate: { bsonType: "date" },
        playCount: { bsonType: "int" },
        audioUrl: { bsonType: "string" }
      }
    }
  }
});

db.podcast_episode.createIndex({ playlistId: 1 });
db.podcast_episode.createIndex({ releaseDate: -1 });


// REVIEW
db.createCollection("review", {
  validator: {
    $jsonSchema: {
      bsonType: "object",
      required: ["playlistId", "oyenteId", "rating", "comment", "createdAt"],
      properties: {
        playlistId: { bsonType: "objectId" },
        oyenteId: { bsonType: "objectId" },
        rating: { bsonType: "int" },
        comment: { bsonType: "string" },
        createdAt: { bsonType: "date" }
      }
    }
  }
});

db.review.createIndex({ playlistId: 1 });
db.review.createIndex({ oyenteId: 1 });
// Una reseña por oyente por playlist (opcional)
db.review.createIndex(
  { playlistId: 1, oyenteId: 1 },
  { unique: true }
);


// PLAYBACK_PROGRESS
db.createCollection("playback_progress", {
  validator: {
    $jsonSchema: {
      bsonType: "object",
      required: ["oyenteId", "episodeId", "minuteStopped", "lastPlayedAt"],
      properties: {
        oyenteId: { bsonType: "objectId" },
        episodeId: { bsonType: "objectId" },
        minuteStopped: { bsonType: "int" },
        lastPlayedAt: { bsonType: "date" }
      }
    }
  }
});

// Solo un registro de progreso por (oyente, episodio)
db.playback_progress.createIndex(
  { oyenteId: 1, episodeId: 1 },
  { unique: true }
);


// SUBSCRIPTION
db.createCollection("subscription", {
  validator: {
    $jsonSchema: {
      bsonType: "object",
      required: ["oyenteId", "creatorId", "subscribedAt"],
      properties: {
        oyenteId: { bsonType: "objectId" },
        creatorId: { bsonType: "objectId" },
        subscribedAt: { bsonType: "date" }
      }
    }
  }
});

db.subscription.createIndex({ oyenteId: 1 });
db.subscription.createIndex({ creatorId: 1 });
db.subscription.createIndex(
  { oyenteId: 1, creatorId: 1 },
  { unique: true }
);
