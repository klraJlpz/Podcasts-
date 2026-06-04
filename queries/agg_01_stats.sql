-- Aggregation Intro – Podcast count by category
SELECT category, COUNT(*) AS total_podcasts
FROM podcasts
WHERE is_active = TRUE
GROUP BY category
ORDER BY total_podcasts DESC;
