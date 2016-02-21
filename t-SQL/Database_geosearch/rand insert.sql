truncate table Database1.dbo.GeoCity --очищаем основную таблицу
drop table #temp
create table #temp
(
    [Lat] FLOAT NULL, 
    [Long] FLOAT NULL
)

Insert top (100000) into #temp (Lat,Long) 
select  abs(CHECKSUM(NEWID())) %180 - 90, abs(CHECKSUM(NEWID())) %360 - 180 
		from sys.objects A
		cross join sys.objects B

  
insert into Database1.dbo.GeoCity (Lat,Long)
select temp.Lat,temp.Long from #temp as temp

select COUNT(Id) from Database1.dbo.GeoCity -- проверяем наличие записей в основной таблице, считая количество первичных ключей

select top 100000 ABS (checksum(newid())) % 1000
from sys.objects a
cross join sys.objects b
