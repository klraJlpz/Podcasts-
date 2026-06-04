-- Query without index
EXPLAIN ANALYZE
SELECT * FROM podcasts WHERE title = 'Tech Talks';

-- Create index on title
CREATE INDEX idx_podcasts_title ON podcasts(title);

-- Query with index
EXPLAIN ANALYZE
SELECT * FROM podcasts WHERE title = 'Tech Talks';
