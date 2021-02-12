-- Write queries to return the following:
-- The following changes are applied to the "dvdstore" database.**

-- 1. Add actors, Hampton Avenue, and Lisa Byway to the actor table.
SELECT*
	From actor
		Where first_name='Hampton' OR first_name='Lisa';
		--
Insert Into actor(first_name,last_name)
	Values ('Hampton','Avenue'),
			('Lisa','Byway');
-- 2. Add "Euclidean PI", "The epic story of Euclid as a pizza delivery boy in
-- ancient Greece", to the film table. The movie was released in 2008 in English.
-- Since its an epic, the run length is 3hrs and 18mins. There are no special
-- features, the film speaks for itself, and doesn't need any gimmicks.
SELECT*
	From film
		Where title='Euclidean PI'
-- EnglishID
SELECT language_id FROM language WHERE name='English'
--
Insert Into film(title,description,release_year,language_id,length)
	Values ('Euclidean PI','The epic story of Euclid as a pizza delivery boy in ancient Greece',2008,(SELECT language_id FROM language WHERE name='English'),198)
-- 3. Hampton Avenue plays Euclid, while Lisa Byway plays his slightly
-- overprotective mother, in the film, "Euclidean PI". Add them to the film.
	-- Are there actor_id to the movie 'Euclidean PI'?(NO)
	SELECT*
		FROM film_actor 
		WHERE film_id=(SELECT film_id FROM film WHERE title='Euclidean PI') 
	-- Are there actors Hampton Avenue and Lisa Byway in actors list? (YES)
	SELECT*
		FROM actor
		WHERE last_name='Avenue' OR last_name='Byway'
	-- Associate film with actors
	Insert into film_actor (film_id,actor_id)
		Values ((SELECT film_id FROM film WHERE title='Euclidean PI'),(SELECT actor_id FROM actor WHERE first_name='Hampton' AND last_name='Avenue')),
			   ((SELECT film_id FROM film WHERE title='Euclidean PI'),(SELECT actor_id FROM actor WHERE first_name='Lisa' AND last_name='Byway'))

-- 4. Add Mathmagical to the category table.
	SELECT*
		FROM category
		WHERE name='Mathmagical'
	--
	Insert Into category(name) Values ('Mathmagical')
-- 5. Assign the Mathmagical category to the following films, "Euclidean PI",
-- "EGG IGBY", "KARATE MOON", "RANDOM GO", and "YOUNG LANGUAGE"
	-- category_id
	SELECT category_id		FROM category		WHERE name='Mathmagical'
	-- movie id
	SELECT film_id	FROM film	WHERE title IN ('Euclidean PI','EGG IGBY', 'KARATE MOON', 'RANDOM GO', 'YOUNG LANGUAGE')
	-- Associate movie with category)
	Insert Into film_category(film_id,category_id)
		Values ((SELECT film_id	FROM film	WHERE title='YOUNG LANGUAGE'),(SELECT category_id	FROM category	WHERE name='Mathmagical')),
		((SELECT film_id	FROM film	WHERE title='Euclidean PI'),(SELECT category_id	FROM category	WHERE name='Mathmagical')),
		((SELECT film_id	FROM film	WHERE title='EGG IGBY'),(SELECT category_id	FROM category	WHERE name='Mathmagical')),
		((SELECT film_id	FROM film	WHERE title='KARATE MOON'),(SELECT category_id	FROM category	WHERE name='Mathmagical')),
		((SELECT film_id	FROM film	WHERE title='RANDOM GO'),(SELECT category_id	FROM category	WHERE name='Mathmagical'));
	-- Check
	SELECT * 
		FROM film_category
		WHERE category_id=(SELECT category_id		FROM category		WHERE name='Mathmagical')

-- 6. Mathmagical films always have a "G" rating, adjust all Mathmagical films
-- accordingly.
-- (5 rows affected)
	-- find catacory id
	--Check
	SELECT *
		FROM film
		WHERE film_id IN (SELECT film_id	FROM film_category WHERE category_id=(SELECT category_id	FROM category	WHERE name='Mathmagical'))
	-- Update rating 
	UPDATE film
		SET rating='G'
		WHERE film_id IN (SELECT film_id	FROM film_category WHERE category_id=(SELECT category_id	FROM category	WHERE name='Mathmagical'));
-- 7. Add a copy of "Euclidean PI" to all the stores.
	--Check in inventory
	SELECT *
		FROM inventory
		WHERE film_id=(SELECT film_id From film WHERE title='Euclidean PI');
		
	--INSERT new copy
	Insert Into inventory(film_id, store_id)
		Values((SELECT film_id From film WHERE title='Euclidean PI'),1),
			  ((SELECT film_id From film WHERE title='Euclidean PI'),2);
-- 8. The Feds have stepped in and have impounded all copies of the pirated film,
-- "Euclidean PI". The film has been seized from all stores, and needs to be
-- deleted from the film table. Delete "Euclidean PI" from the film table.
-- (Did it succeed? Why?) Because I deleted all of the movie assosiate connections
-- <YOUR ANSWER HERE>
	--Inventory & Film Check
	SELECT*
		FROM inventory
		WHERE film_id=(SELECT film_id	From film	WHERE title='Euclidean PI')
	-- DELETE film
	Begin Transaction
	DELETE	From inventory	Where film_id=(SELECT film_id	From film	WHERE title='Euclidean PI')
	DELETE	From film_actor	Where film_id=(SELECT film_id	From film	WHERE title='Euclidean PI')
	Delete	From film_category	Where film_id=(SELECT film_id	From film	WHERE title='Euclidean PI')
	DELETE	From film	Where title='Euclidean PI'
	Commit Transaction

-- 9. Delete Mathmagical from the category table.
-- (Did it succeed? Why?) Yes, because all associated values were deleted
-- <YOUR ANSWER HERE>
	-- film category & category Check
	SELECT*
		FROM film_category
		WHERE category_id=(SELECT category_id	FROM category	WHERE name='Mathmagical')
	-- DELETE Category
	Begin Transaction
		Delete	From film_category	WHERE category_id=(SELECT category_id	FROM category	WHERE name='Mathmagical')
		Delete	From category	WHERE name='Mathmagical'
	Commit Transaction

-- 10. Delete all links to Mathmagical in the film_category tale.
-- (Did it succeed? Why?) Already done in Q.9
-- <YOUR ANSWER HERE> 
-- film category & category Check
	SELECT*
		FROM film_category
		WHERE category_id=(SELECT category_id	FROM category	WHERE name='Mathmagical')
	-- DELETE Category
	Begin Transaction
		Delete	From film_category	WHERE category_id=(SELECT category_id	FROM category	WHERE name='Mathmagical')
		Delete	From category	WHERE name='Mathmagical'
	Commit Transaction

-- 11. Retry deleting Mathmagical from the category table, followed by retrying
-- to delete "Euclidean PI".
-- (Did either deletes succeed? Why?) Already done
-- <YOUR ANSWER HERE>
-- film category & category Check
	SELECT*
		FROM film_category
		WHERE category_id=(SELECT category_id	FROM category	WHERE name='Mathmagical')
	-- DELETE Category
	Begin Transaction
		Delete	From film_category	WHERE category_id=(SELECT category_id	FROM category	WHERE name='Mathmagical')
		Delete	From category	WHERE name='Mathmagical'
	Commit Transaction

-- 12. Check database metadata to determine all constraints of the film id, and
-- describe any remaining adjustments needed before the film "Euclidean PI" can
-- be removed from the film table.
SELECT *
	FROM INFORMATION_SCHEMA.TABLE_CONSTRAINTS