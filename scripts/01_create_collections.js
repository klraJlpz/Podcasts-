// Seleccionar base de datos
use("podcast_legends");

// Colección CREATOR
// -----------------
db.creators.insertMany([
  {
    _id: ObjectId(),           // PK
    name: "Historias del Mundo",
    email: "historias@podcasts.com",
    country: "ES",
    followers: 120000,
    joinedAt: new Date("2022-01-10T00:00:00Z")
  },
  {
    _id: ObjectId(),
    name: "Mitos y Leyendas",
    email: "mitos@podcasts.com",
    country: "MX",
    followers: 85000,
    joinedAt: new Date("2023-03-05T00:00:00Z")
  }
]);

// Guardamos algunos IDs para relacionar datos
const creator = db.creators.findOne({ name: "Historias del Mundo" });

// Colección PLAYLIST
// ------------------
db.playlists.insertOne({
  _id: ObjectId(),                   // PK
  creatorId: creator._id,            // FK -> CREATOR._id
  title: "Leyendas Europeas",
  theme: "Europa",
  description: "Colección de leyendas históricas de distintas regiones de Europa.",
  isPublic: true,
  totalDurationMinutes: 180,
  createdAt: new Date("2023-06-01T00:00:00Z")
});

const playlist = db.playlists.findOne({ title: "Leyendas Europeas" });

// Colección STATISTICS (1 a 1 con PLAYLIST)
// -----------------------------------------
db.statistics.insertOne({
  _id: ObjectId(),               // PK
  playlistId: playlist._id,      // FK -> PLAYLIST._id
  totalPlays: 25000,
  totalLikes: 3200,
  averageRating: 4.6,
  totalEpisodes: 6
});

// Colección PODCAST_EPISODE
// -------------------------
db.podcast_episodes.insertMany([
  {
    episodeId: ObjectId(),               // PK
    playlistId: playlist._id,            // FK -> PLAYLIST._id
    legendTitle: "La Dama Blanca",
    legendOriginRegion: "Francia",
    historicalContext: "Leyenda medieval asociada a castillos y nobles.",
    durationMinutes: 35,
    rating: 4.7,
    isExplicit: false,
    language: "es",
    releaseDate: new Date("2023-06-05T00:00:00Z"),
    playCount: 6000
  },
  {
    episodeId: ObjectId(),
    playlistId: playlist._id,
    legendTitle: "El Jinete sin Cabeza",
    legendOriginRegion: "Alemania",
    historicalContext: "Relato popular sobre un caballero maldito.",
    durationMinutes: 40,
    rating: 4.5,
    isExplicit: false,
    language: "es",
    releaseDate: new Date("2023-06-10T00:00:00Z"),
    playCount: 5200
  }
]);

// Colección REVIEW
// ----------------
db.reviews.insertMany([
  {
    reviewId: ObjectId(),              // PK
    playlistId: playlist._id,          // FK -> PLAYLIST._id
    username: "user123",
    rating: 5,
    comment: "Excelente selección de leyendas, muy bien narradas.",
    createdAt: new Date("2023-06-15T00:00:00Z")
  },
  {
    reviewId: ObjectId(),
    playlistId: playlist._id,
    username: "legend_fan",
    rating: 4,
    comment: "Muy interesante, pero me gustaría episodios más largos.",
    createdAt: new Date("2023-06-18T00:00:00Z")
  }
]);

// Ejemplos de índices recomendados
// --------------------------------
db.creators.createIndex({ email: 1 }, { unique: true });
db.playlists.createIndex({ creatorId: 1 });
db.statistics.createIndex({ playlistId: 1 }, { unique: true });
db.podcast_episodes.createIndex({ playlistId: 1 });
db.reviews.createIndex({ playlistId: 1 });
