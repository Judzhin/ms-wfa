--SELECT * FROM Classes WHERE [Name] LIKE '1-%'

--SELECT * FROM Classes WHERE NOT (RoomNumber > 200 AND [Name] LIKE '%Б') ORDER BY [Name] DESC

--SELECT * FROM Classes WHERE [Name] IN ('1-А', '1-Б', '1-В') ORDER BY [Name]

--SELECT * FROM Classes WHERE RoomNumber BETWEEN 200 AND 400

--Отбрасывает повторяющие записи
--SELECT DISTINCT(RoomNumber) FROM Classes 

--SELECT MAX(ID) FROM Classes
--SELECT MIN(ID) FROM Classes
--SELECT SUM(ID) FROM Classes
--SELECT COUNT(ID) FROM Classes
--SELECT AVG(ID) FROM Classes

--SELECT [Classes].[Name], [Head].[Name] FROM Classes, Head WHERE [Classes].[HeadID] = [Head].[ID]

--SELECT [Classes].[Name], [Head].[Name]
--FROM [Classes] JOIN [Head] ON [Classes].[HeadID] = [Head].[ID]
--WHERE [Classes].[RoomNumber] < 200

--SELECT [Classes].[Name] FROM Classes WHERE Classes.HeadID = 
--(SELECT Head.ID FROM Head WHERE Head.[Name] LIKE '%ирон%')

--SELECT [Classes].[Name], [Head].[Name] FROM Classes
--LEFT JOIN [Head] ON [Classes].[HeadID] = [Head].[ID] 
--WHERE Head.ID IS NULL

--SELECT [Classes].[Name] FROM [Classes]
--UNION
--SELECT [Head].[Name] FROM [Head]

--SELECT * FROM Classes WHERE HeadID IN (SELECT ID FROM Head) OR HeadID IS NULL
