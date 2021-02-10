-- The following queries utilize the "dvdstore" database.

-- 1. All of the films that Nick Stallone has appeared in
-- (30 rows)
SELECT CONCAT(actor.first_name,' ',actor.last_name) AS ActorName, film.title
	FROM actor Join film_actor AS FActor ON actor.actor_id=FActor.actor_id
	JOIN film ON film.film_id=FActor.film_id
	WHERE actor.last_name='stallone' AND actor.first_name='Nick';

-- 2. All of the films that Rita Reynolds has appeared in
-- (20 rows)
SELECT CONCAT(actor.first_name,' ',actor.last_name) AS ActorName, film.title
	FROM actor
	JOIN film_actor on actor.actor_id=film_actor.actor_id
	JOIN film on film_actor.film_id=film.film_id
	WHERE actor.first_name='rita' AND actor.last_name='reynolds';

-- 3. All of the films that Judy Dean or River Dean have appeared in
-- (46 rows)
SELECT CONCAT(actor.first_name,' ',actor.last_name) AS ActorName, film.title
	FROM actor
	JOIN film_actor on actor.actor_id=film_actor.actor_id
	JOIN film on film_actor.film_id=film.film_id
	WHERE (actor.first_name='Judy' OR actor.first_name='River' ) AND  (actor.last_name='Dean') ;

-- 4. All of the the ‘Documentary’ films
-- (68 rows)
SELECT film.title AS DocumentaryMovies
	From film 
		JOIN film_category AS FC ON film.film_id=FC.film_id
		JOIN category ON category.category_id=FC.category_id
	WHERE category.name='Documentary';

-- 5. All of the ‘Comedy’ films
-- (58 rows)
SELECT film.title AS ComedyMovies
	From film 
		JOIN film_category AS FC ON film.film_id=FC.film_id
		JOIN category ON category.category_id=FC.category_id
	WHERE category.name='Comedy';

-- 6. All of the ‘Children’ films that are rated ‘G’
-- (10 rows)
SELECT film.title AS ChildrenMoviesRatedG
	FROM film
	JOIN film_category AS FC ON film.film_id=FC.film_id
		JOIN category ON FC.category_id=category.category_id
	WHERE category.name='Children'
		AND film.rating='G';

-- 7. All of the ‘Family’ films that are rated ‘G’ and are less than 2 hours in length
-- (3 rows)
SELECT film.title AS FamilyMoviesRatedG, film.length AS TwoHR_And_Less 
	FROM film
		JOIN film_category AS FC ON film.film_id=FC.film_id
		JOIN category ON FC.category_id=category.category_id
	WHERE category.name='Family' AND film.rating='G' AND film.length<120;

-- 8. All of the films featuring actor Matthew Leigh that are rated ‘G’
-- (9 rows)
SELECT film.title AS RatedRWithMattLeigh, FA.film_id
	FROM film
		JOIN film_actor AS FA ON film.film_id=FA.film_id
		JOIN actor ON actor.actor_id=FA.actor_id
	WHERE actor.last_name='Leigh' AND actor.first_name='Matthew' AND film.rating='G';

-- 9. All of the ‘Sci-Fi’ films released in 2006
-- (61 rows)
SELECT film.film_id, film.title AS Sci_Fi_Movie_2006
	FROM film
		JOIN film_category AS FC ON film.film_id=FC.film_id
		JOIN category ON category.category_id=FC.category_id
	WHERE category.name='Sci-Fi' AND film.release_year=2006;

-- 10. All of the ‘Action’ films starring Nick Stallone
-- (2 rows)
SELECT film.title AS NickStalloneActionMovie
	FROM film
		JOIN film_category AS FC ON film.film_id=FC.film_id
		JOIN category ON category.category_id=FC.category_id
		JOIN film_actor AS FA ON film.film_id=FA.film_id
		JOIN actor ON actor.actor_id=FA.actor_id
	WHERE category.name='Action' AND actor.last_name='Stallone' AND actor.first_name='Nick';
		
-- 11. The address of all stores, including street address, city, district, and country
-- (2 rows)
SELECT store.store_id, address.address,city.city, address.district, country.country
	From store
		JOIN address ON store.address_id=address.address_id
		JOIN city ON city.city_id=address.city_id
		JOIN country ON country.country_id=city.country_id

-- 12. A list of all stores by ID, the store’s street address, and the name of the store’s manager
-- (2 rows)
SELECT store.store_id, address.address, CONCAT(staff.first_name,' ',staff.last_name) AS Store_Manager
	FROM store
		JOIN address ON store.address_id=address.address_id
		Join staff ON store.manager_staff_id=staff.staff_id;

-- 13. The first and last name of the top ten customers ranked by number of rentals
-- (#1 should be “ELEANOR HUNT” with 46 rentals, #10 should have 39 rentals)
SELECT TOP 10 CONCAT(customer.first_name,' ',customer.last_name),  COUNT(rental.rental_id)
	FROM rental
		JOIN customer ON rental.customer_id=customer.customer_id
	GROUP BY CONCAT(customer.first_name,' ',customer.last_name)
	ORDER BY COUNT(rental.rental_id) DESC;

-- 14. The first and last name of the top ten customers ranked by dollars spent
-- (#1 should be “KARL SEAL” with 221.55 spent, #10 should be “ANA BRADLEY” with 174.66 spent)
SELECT TOP 10 CONCAT(customer.first_name,' ',customer.last_name) AS CustomerName,  SUM(payment.amount) AS Spent$
	FROM payment
		JOIN customer ON payment.customer_id=customer.customer_id
	GROUP BY CONCAT(customer.first_name,' ',customer.last_name)
	ORDER BY SUM(payment.amount) DESC;

-- 15. The store ID, street address, total number of rentals, total amount of sales (i.e. payments), and average sale of each store.
-- (NOTE: Keep in mind that while a customer has only one primary store, they may rent from either store.)
-- (Store 1 has 7928 total rentals and Store 2 has 8121 total rentals)
SELECT store.store_id AS StoreID, address.address AS StreetAddress, COUNT(rental.rental_id) AS TotalRentals, SUM(payment.amount) TotalSales, AVG(payment.amount) AS AvgSales
	FROM rental
		JOIN payment ON rental.rental_id=payment.rental_id
		JOIN inventory ON rental.inventory_id=inventory.inventory_id
		JOIN store ON inventory.store_id=store.store_id
		JOIN address ON store.address_id=address.address_id
	GROUP BY store.store_id, address.address;


-- 16. The top ten film titles by number of rentals
-- (#1 should be “BUCKET BROTHERHOOD” with 34 rentals and #10 should have 31 rentals)
SELECT TOP 10 film.title, COUNT(rental.rental_id) AS Rentals
	FROM rental
		JOIN inventory ON rental.inventory_id=inventory.inventory_id
		JOIN film ON inventory.film_id=film.film_id
	GROUP BY film.title
	ORDER BY Rentals DESC;

-- 17. The top five film categories by number of rentals
-- (#1 should be “Sports” with 1179 rentals and #5 should be “Family” with 1096 rentals)
SELECT TOP 5 category.name, COUNT(rental.rental_id) AS TotalRentals
	FROM rental
		JOIN inventory ON rental.inventory_id=inventory.inventory_id
		JOIN film ON inventory.film_id=film.film_id
		JOIN film_category AS FC ON film.film_id=FC.film_id
		JOIN category ON category.category_id=FC.category_id
	GROUP BY category.name
	ORDER BY TotalRentals DESC;

-- 18. The top five Action film titles by number of rentals
-- (#1 should have 30 rentals and #5 should have 28 rentals)
SELECT TOP 5 film.title, COUNT(rental.rental_id) AS Rentals
	FROM rental
	JOIN inventory ON rental.inventory_id=inventory.inventory_id
		JOIN film ON inventory.film_id=film.film_id
		JOIN film_category AS FC ON film.film_id=FC.film_id
		JOIN category ON category.category_id=FC.category_id
	WHERE category.name='Action'
	GROUP BY film.title
	ORDER BY COUNT(rental.rental_id) DESC;

-- 19. The top 10 actors ranked by number of rentals of films starring that actor
-- (#1 should be “GINA DEGENERES” with 753 rentals and #10 should be “SEAN GUINESS” with 599 rentals)
SELECT TOP 10 CONCAT(actor.first_name,' ', actor.last_name) AS ActorName, COUNT(rental.rental_id) AS RentalCount
	FROM rental
		JOIN inventory ON inventory.inventory_id=rental.inventory_id
		JOIN film ON inventory.film_id=film.film_id
		JOIN film_actor FA ON FA.film_id=film.film_id
		JOIN actor ON FA.actor_id=actor.actor_id
	GROUP BY CONCAT(actor.first_name,' ', actor.last_name)
	ORDER BY COUNT(rental.rental_id) DESC;

-- 20. The top 5 “Comedy” actors ranked by number of rentals of films in the “Comedy” category starring that actor
-- (#1 should have 87 rentals and #5 should have 72 rentals)
SELECT TOP 5 CONCAT(actor.first_name,' ',actor.last_name) AS ActorName, COUNT(rental.rental_id) AS ComedyRentals
	FROM rental
		JOIN inventory ON rental.inventory_id=inventory.inventory_id
		JOIN film ON inventory.film_id=film.film_id
		JOIN film_category AS FC ON film.film_id=FC.film_id
		JOIN category ON category.category_id=FC.category_id
		JOIN film_actor AS FA ON film.film_id=FA.film_id
		JOIN actor ON actor.actor_id=FA.actor_id
	WHERE category.name='Comedy'
	GROUP BY CONCAT(actor.first_name,' ',actor.last_name)
	ORDER BY COUNT(rental.rental_id) DESC;
	
