-- File: queries/03_logic.sql
-- Purpose: Logical operators (AND, OR, NOT)
-- Description: Retrieve podcasts with high engagement

SELECT id, title, downloads, favorites
FROM podcasts
WHERE (downloads > 1000 OR favorites > 500)
  AND NOT is_archived
ORDER BY downloads DESC;
