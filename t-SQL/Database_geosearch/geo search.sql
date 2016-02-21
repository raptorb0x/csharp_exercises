-- координаты москвы
Declare @initial_lat float = 55.751244; 
Declare @initial_long float = 37.618423;
-- диаметр поиска в км
Declare @dist float = 10000;

--Включаем статистику временных затрат
SET STATISTICS TIME ON;

select City, Distance 
From (
	select destination.City, -- берем название города/местности
	6373 * 2 * ASIN(SQRT(POWER(SIN((@initial_lat - abs(destination.lat)) * pi()/180 / 2),2) + COS(@initial_lat * pi()/180 ) * COS(abs(destination.lat) * pi()/180) * POWER(SIN((@initial_long - destination.long) *pi()/180 / 2), 2) ))  -- считаем формуле гаверсисинуса(Haversine) - расстояние между двумя точками на сфере
	as Distance 
	from 
	Database1.dbo.GeoCity as destination
	where destination.Lat between @initial_lat - (@dist/111) and  @initial_lat + (@dist/111) -- отсеиваем те значения, что не виписываются в квадрат со сторонами 2R и центром в нашей точке
	and
	destination.Long between @initial_long - @dist/abs(cos(RADIANS(@initial_lat))*111) and  @initial_long + @dist/abs(cos(RADIANS(@initial_lat))*111)
	) as x
Where Distance < @dist -- отсеиваем по радиусу
order by Distance asc 


SET STATISTICS TIME off;
