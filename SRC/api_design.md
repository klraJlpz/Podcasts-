# API Specification — Horror Podcast App

Base URL: `/api`

All authenticated endpoints require `Authorization: Bearer <token>` header. 401 returned if missing/invalid.

---

## Auth

| Method | Path | Request Body | Response Body | Auth |
|--------|------|-------------|---------------|------|
| POST | /api/signup | {email: string (required), password: string (required), name: string (required)} | {token: string, user: {id: UUID, email: string, name: string}} | No |
| POST | /api/auth/login | {email: string (required), password: string (required)} | {token: string, user: {id: UUID, email: string, name: string}} | No |
| GET | /api/auth/me | — | {user: {id: UUID, email: string, name: string, bio: string | null, avatarFileId: UUID | null, avatarUrl: string | null, favoritesCount: integer, commentsCount: integer, ratingsCount: integer, createdAt: ISO8601}} | Bearer |

---

## User Profile

| Method | Path | Request Body | Response Body | Auth |
|--------|------|-------------|---------------|------|
| PATCH | /api/users/me | {name: string (optional), bio: string (optional), avatarFileId: UUID (optional)} | {id: UUID, email: string, name: string, bio: string | null, avatarFileId: UUID | null, avatarUrl: string | null} | Bearer |

---

## File Uploads

| Method | Path | Request Body | Response Body | Auth |
|--------|------|-------------|---------------|------|
| POST | /api/upload/presigned | {fileName: string (required), contentType: string (required), isPublic: boolean (required)} | {uploadUrl: string, cloud_storage_path: string} | Bearer |
| POST | /api/upload/complete | {cloud_storage_path: string (required), fileName: string (required), contentType: string (required), fileSize: integer (optional)} | {id: UUID, cloud_storage_path: string} | Bearer |
| GET | /api/files/:id/url?mode=view\|download | — | {url: string} | Bearer |
| DELETE | /api/files/:id | — | {success: boolean} | Bearer |

---

## Podcasts

| Method | Path | Request Body | Response Body | Auth |
|--------|------|-------------|---------------|------|
| GET | /api/podcasts | query: ?category=string&featured=boolean&sort=popular\|recent&page=integer&limit=integer | {items: PodcastSummary[], total: integer, page: integer, totalPages: integer} | Bearer |
| GET | /api/podcasts/:id | — | PodcastDetail | Bearer |

### PodcastSummary
```
{
  id: UUID,
  title: string,
  author: string,
  description: string,
  category: string,
  coverImageFileId: UUID,
  coverImageUrl: string,
  isFeatured: boolean,
  episodeCount: integer,
  averageRating: number | null,
  ratingCount: integer,
  isFavorited: boolean,
  createdAt: ISO8601
}
```

### PodcastDetail
```
{
  id: UUID,
  title: string,
  author: string,
  description: string,
  category: string,
  coverImageFileId: UUID,
  coverImageUrl: string,
  isFeatured: boolean,
  episodeCount: integer,
  averageRating: number | null,
  ratingCount: integer,
  favoriteCount: integer,
  isFavorited: boolean,
  userRating: integer | null,
  episodes: EpisodeSummary[],
  createdAt: ISO8601
}
```

---

## Episodes

| Method | Path | Request Body | Response Body | Auth |
|--------|------|-------------|---------------|------|
| GET | /api/episodes/recent | query: ?limit=integer | {items: EpisodeWithPodcast[]} | Bearer |
| GET | /api/episodes/:id | — | EpisodeDetail | Bearer |

### EpisodeSummary
```
{
  id: UUID,
  title: string,
  episodeNumber: integer,
  duration: integer,          // seconds
  publishedAt: ISO8601,
  playCount: integer
}
```

### EpisodeWithPodcast
```
{
  id: UUID,
  title: string,
  episodeNumber: integer,
  duration: integer,
  publishedAt: ISO8601,
  playCount: integer,
  podcast: {
    id: UUID,
    title: string,
    coverImageFileId: UUID,
    coverImageUrl: string
  }
}
```

### EpisodeDetail
```
{
  id: UUID,
  title: string,
  description: string,
  episodeNumber: integer,
  duration: integer,
  audioFileId: UUID,
  audioUrl: string,
  publishedAt: ISO8601,
  playCount: integer,
  podcast: {
    id: UUID,
    title: string,
    coverImageFileId: UUID,
    coverImageUrl: string
  },
  commentCount: integer,
  playbackPosition: integer | null   // user's saved position in seconds, null if never played
}
```

---

## Search

| Method | Path | Request Body | Response Body | Auth |
|--------|------|-------------|---------------|------|
| GET | /api/search | query: ?q=string (required)&categories=string (comma-separated, optional)&page=integer&limit=integer | {podcasts: PodcastSummary[], episodes: EpisodeWithPodcast[]} | Bearer |

---

## Favorites

| Method | Path | Request Body | Response Body | Auth |
|--------|------|-------------|---------------|------|
| GET | /api/favorites | query: ?page=integer&limit=integer | {items: PodcastSummary[], total: integer, page: integer, totalPages: integer} | Bearer |
| POST | /api/podcasts/:podcastId/favorite | — | {success: boolean, isFavorited: true} | Bearer |
| DELETE | /api/podcasts/:podcastId/favorite | — | {success: boolean, isFavorited: false} | Bearer |

---

## Ratings

| Method | Path | Request Body | Response Body | Auth |
|--------|------|-------------|---------------|------|
| POST | /api/podcasts/:podcastId/rating | {score: integer (required, 1-5)} | {id: UUID, score: integer, averageRating: number, ratingCount: integer} | Bearer |

Note: POST is upsert — creates or updates the user's rating for this podcast.

---

## Comments

| Method | Path | Request Body | Response Body | Auth |
|--------|------|-------------|---------------|------|
| GET | /api/episodes/:episodeId/comments | query: ?page=integer&limit=integer | {items: Comment[], total: integer, page: integer, totalPages: integer} | Bearer |
| POST | /api/episodes/:episodeId/comments | {content: string (required)} | Comment | Bearer |
| DELETE | /api/comments/:id | — | {success: boolean} | Bearer |

### Comment
```
{
  id: UUID,
  content: string,
  user: {
    id: UUID,
    name: string,
    avatarFileId: UUID | null,
    avatarUrl: string | null
  },
  isOwn: boolean,
  createdAt: ISO8601
}
```

---

## Playback Tracking

| Method | Path | Request Body | Response Body | Auth |
|--------|------|-------------|---------------|------|
| POST | /api/episodes/:episodeId/playback | {position: integer (required), completed: boolean (optional, default false)} | {success: boolean} | Bearer |

This endpoint:
- Saves/updates the user's playback position for resume functionality
- If `completed: true`, increments the episode's `playCount` (only once per user per episode)
- Upsert behavior: creates or updates the PlaybackProgress record

---

## Categories

| Method | Path | Request Body | Response Body | Auth |
|--------|------|-------------|---------------|------|
| GET | /api/categories | — | {items: string[]} | Bearer |

Returns: `["Terror Paranormal", "True Crime", "Ficción de Terror", "Leyendas Urbanas", "Horror Psicológico"]`
