USE assessment;
GO

-- Select all columns from blog_posts that are published (note the "published" column)
Select * From blog_posts Where published=1; 

-- Select posted_by and body from comments that have a body and were created after Oct. 15, 2019
Select posted_by, body From comments Where body IS NOT NULL AND created > Convert(date, '2019-10-15') ;

-- Select name and published from blog_posts ordered by when they were created, earliest first
Select name, published From blog_posts Order BY created ASC;

-- Select the created date and the count of all the comments created on that date
Select created, COUNT(id) AS 'Count' From comments Group by created;

-- Select the post name, comment posted_by and comment body for all blog_posts created after Oct. 1st, 2019
Select blog_posts.name,comments.posted_by ,comments.body 
From blog_posts Join comments on blog_posts.id=comments.blog_post_id
Where blog_posts.created > CONVERT(date, '2019-10-01');
