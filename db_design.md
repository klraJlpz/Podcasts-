# Database Schema — Horror Podcast App

PostgreSQL with Prisma ORM. UUID primary keys, DateTime timestamps.

---

## Entities

### User
| Field | Type | Constraints |
|-------|------|-------------|
| id | UUID | PK, auto-generated |
| email | String | Unique, required |
| password | String | bcrypt hashed, required |
| name | String | Required |
| bio | String? | Nullable, max 200 |
| avatarFileId | UUID? | FK to File.id, nullable, ON DELETE SET NULL |
| createdAt | DateTime | Auto |
| updatedAt | DateTime | Auto-updated |

Indexes: `email` (unique)

### File
| Field | Type | Constraints |
|-------|------|-------------|
| id | UUID | PK, auto-generated |
| userId | UUID | FK to User.id, required, ON DELETE CASCADE |
| fileName | String | Required |
| cloud_storage_path | String | Unique, required |
| isPublic | Boolean | Default false |
| contentType | String | MIME type |
| fileSize | Int? | Bytes, optional |
| createdAt | DateTime | Auto |

Indexes: `cloud_storage_path` (unique), `userId`

### Podcast
| Field | Type | Constraints |
|-------|------|-------------|
| id | UUID | PK, auto-generated |
| title | String | Required |
| author | String | Required |
| description | String | Required (text/long) |
| category | String | Required, one of enum values |
| coverImageFileId | UUID | FK to File.id, required, ON DELETE RESTRICT |
| isFeatured | Boolean | Default false |
| createdAt | DateTime | Auto |
| updatedAt | DateTime | Auto-updated |

Indexes: `category`, `isFeatured`, `createdAt`

Category enum values: `Terror Paranormal`, `True Crime`, `Ficción de Terror`, `Leyendas Urbanas`, `Horror Psicológico`

### Episode
| Field | Type | Constraints |
|-------|------|-------------|
| id | UUID | PK, auto-generated |
| podcastId | UUID | FK to Podcast.id, required, ON DELETE CASCADE |
| title | String | Required |
| description | String | Required (text/long) |
| episodeNumber | Int | Required |
| duration | Int | Required (seconds) |
| audioFileId | UUID | FK to File.id, required, ON DELETE RESTRICT |
| playCount | Int | Default 0 |
| publishedAt | DateTime | Required |
| createdAt | DateTime | Auto |
| updatedAt | DateTime | Auto-updated |

Indexes: `podcastId`, `publishedAt`, unique(`podcastId`, `episodeNumber`)

### Favorite
| Field | Type | Constraints |
|-------|------|-------------|
| id | UUID | PK, auto-generated |
| userId | UUID | FK to User.id, required, ON DELETE CASCADE |
| podcastId | UUID | FK to Podcast.id, required, ON DELETE CASCADE |
| createdAt | DateTime | Auto |

Indexes: unique(`userId`, `podcastId`), `podcastId`

### Rating
| Field | Type | Constraints |
|-------|------|-------------|
| id | UUID | PK, auto-generated |
| userId | UUID | FK to User.id, required, ON DELETE CASCADE |
| podcastId | UUID | FK to Podcast.id, required, ON DELETE CASCADE |
| score | Int | Required, 1-5 |
| createdAt | DateTime | Auto |
| updatedAt | DateTime | Auto-updated |

Indexes: unique(`userId`, `podcastId`), `podcastId`

### Comment
| Field | Type | Constraints |
|-------|------|-------------|
| id | UUID | PK, auto-generated |
| userId | UUID | FK to User.id, required, ON DELETE CASCADE |
| episodeId | UUID | FK to Episode.id, required, ON DELETE CASCADE |
| content | String | Required, max 1000 |
| createdAt | DateTime | Auto |

Indexes: `episodeId` + `createdAt` (compound, for sorted listing), `userId`

### PlaybackProgress
| Field | Type | Constraints |
|-------|------|-------------|
| id | UUID | PK, auto-generated |
| userId | UUID | FK to User.id, required, ON DELETE CASCADE |
| episodeId | UUID | FK to Episode.id, required, ON DELETE CASCADE |
| position | Int | Required (seconds) |
| completed | Boolean | Default false |
| updatedAt | DateTime | Auto-updated |

Indexes: unique(`userId`, `episodeId`)

---

## Relationships

- User 1 → N File (uploaded files)
- User 1 → 0..1 File (avatar, via avatarFileId)
- Podcast 1 → 1 File (cover image, via coverImageFileId)
- Podcast 1 → N Episode
- Episode 1 → 1 File (audio, via audioFileId)
- User N ↔ N Podcast (via Favorite)
- User N ↔ N Podcast (via Rating)
- User N ↔ N Episode (via Comment)
- User N ↔ N Episode (via PlaybackProgress)

---

## Seed Data Requirements

The seed script must create:
1. File records for all cover images and audio files (using placeholder `cloud_storage_path` values like `seed/covers/podcast-1.jpg` and `seed/audio/ep-1.mp3`; the presigned URL generation should return a placeholder URL for seed paths)
2. At least 6 podcasts (at least one per category, 2 featured), all in Spanish with realistic horror content:
   - "Voces del Más Allá" (Terror Paranormal) — historias de encuentros paranormales reales
   - "Crímenes en la Oscuridad" (True Crime) — casos criminales escalofriantes
   - "Relatos de Medianoche" (Ficción de Terror) — cuentos de horror originales
   - "Susurros del Pueblo" (Leyendas Urbanas) — leyendas urbanas latinoamericanas
   - "Mentes Rotas" (Horror Psicológico) — terror psicológico y perturbador
   - "La Hora Siniestra" (Terror Paranormal) — investigaciones paranormales
3. 3-5 episodes per podcast with Spanish titles, descriptions (2-3 sentences), realistic durations (1200-3600 seconds), sequential episode numbers, varied publishedAt dates
4. A demo user: `demo@siniestro.com` / `password123` / "Usuario Demo"
