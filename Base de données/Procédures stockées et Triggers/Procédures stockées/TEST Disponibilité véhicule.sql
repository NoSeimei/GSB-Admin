--Modifier les valeurs en fonction de ce que vous voulez teste ICI
DECLARE @dateDebut as date
SET @dateDebut = '2019-05-12' 
DECLARE @dateFin as date
SET @dateFin = '2019-07-20'
DECLARE @immat as varchar(10)
SET @immat = '97-FF-12'


EXEC verifAdd_VoitureForVisiteur
@immat = @immat,
@dateDebut = @dateDebut,
@dateFin = @dateFin;

select * from utiliser WHERE immat = @immat ORDER BY dateFin
select DATEDIFF(day, '2020-11-04', '2020-12-03') as Intervalle_EntresDeuxEmprunts, DATEDIFF(day, @dateDebut, @dateFin) as Intervalle_DateVoulue
