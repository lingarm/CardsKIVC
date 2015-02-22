use Timecard

exec ViewEmployees

use CardsKIVC

SELECT * FROM work_place

ALTER procedure [dbo].[ViewEmployees]
as
select e.number, e.lname, e.fname, e.patronymic, e.sex, p.position, p.alias, d.department, d.alias, g.graph, e.combination
from Employees as e, Positions as p, Graphs as g, Departments as d
where e.id_position=p.id and e.id_graph=g.id and e.id_department=d.id
return

CREATE PROCEDURE ViewCards
AS
SELECT w.id, w.username, w.building, w.cabinet, w.cpu
FROM work_place AS w

DROP PROCEDURE ViewCards

exec ViewCards

INSERT INTO work_place (username, building, cabinet, cpu, )