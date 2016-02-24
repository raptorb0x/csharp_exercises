CREATE TABLE [dbo].[GeoCity]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Contry] VARCHAR(MAX) NULL, 
    [City] VARCHAR(MAX) NULL, 
    [AccentCity] VARCHAR(MAX) NULL, 
    [Region] VARCHAR(MAX) NULL, 
    [Pupulation] VARCHAR(MAX) NULL, 
    [Lat] FLOAT NULL, 
    [Long] FLOAT NULL
)

GO
