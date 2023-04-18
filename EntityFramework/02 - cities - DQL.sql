-- use cities;
-- 1. Sélectionner le nom de toutes les villes
select city_name from cities;

-- 2. Sélectionner l'identifiant et le nom de toutes triées les villes triées par nom de ville
--	et par ordre alphabétique.
select city_id, city_name
from cities
order by city_name asc;

-- 3. sélectionner toutes les villes avec le nom du pays associé à chaque ville.
--	Trier la liste par code pays et par ordre alphabétique inverse.
select
city_name,
country_name,
city_id,
countries.country_code
from
cities
join countries on countries.country_code = cities.country_code
order by countries.country_code desc;

-- 4. Sélectionner le code ISO et le nom de tous les pays avec le nombre de villes pays.
--	Les pays avec le moins de villes apparaissent en 1er

select
countries.country_code,
countries.country_name,
count(cities.city_id) as country_number
from
countries
join cities on cities.country_code = countries.country_code
group by
countries.country_code,
countries.country_name
order by country_number asc;
