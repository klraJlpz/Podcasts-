-- Advanced Pipeline – Top 5 podcasts with episodes
SELECT p.title, p.category, p.downloads, p.creator, e.title AS episode_title
FROM podcasts p
LEFT JOIN episodes e ON p.id = e.podcast_id
ORDER BY p.downloads DESC
LIMIT 5;
