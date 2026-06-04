-- File: queries/01_simple_find.sql
-- Purpose: Basic data retrieval (CRUD Read)
-- Description: Select active podcasts from the database

SELECT id, title, category, downloads
FROM podcasts
WHERE is_active = TRUE
ORDER BY downloads DESC;
