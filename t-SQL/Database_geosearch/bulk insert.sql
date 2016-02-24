truncate table Database1.dbo.GeoCity --очищаем основную таблицу

Create table #temp  -- создаем временную таблицу в которую будем грузить данные
(
	[Contry] VARCHAR(MAX) NULL, 
    [City] VARCHAR(MAX) NULL, 
    [AccentCity] VARCHAR(MAX) NULL, 
    [Region] VARCHAR(MAX) NULL, 
    [Pupulation] VARCHAR(MAX) NULL, 
    [Lat] FLOAT NULL, 
    [Long] FLOAT NULL
);

bulk insert #temp From 'C:\lonlat.txt'   -- грузим данные из файла
with (FIELDTERMINATOR = ',', ROWTERMINATOR = '\n'); -- разделеитель полей запятая, разделитель строк - перенос строки

Insert into Database1.dbo.GeoCity (Contry,City,AccentCity,Region,Pupulation,Lat,Long) --вставляем в основную таблицу
select txt.Contry, txt.City, txt.AccentCity, txt.Region, txt.Pupulation, txt.Lat, txt.Long  from [#temp] as txt -- данные из временной

drop table #temp -- удаляем временную 

select count(id) from Database1.dbo.GeoCity -- проверяем наличие записей в основной таблице, считая количество первичных ключей