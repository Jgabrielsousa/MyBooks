
create view vw_book_avg
as


Select
	a.Name as authorName, 
	b.Title as Book,
	Count(st.id) as AmountSalesType ,
	QndSubjects.qdtSubject  ,
	Avg(st.Value) as ValueAverage
from [dbo].[Authors] a 
inner join [AuthorBook] ab
on a.id = ab.AuthorId 
inner join [dbo].[Books] b 
on b.id = ab.BookId
inner join  [dbo].[SaleTypeBook] stb
on stb.BookId = b.id
inner join [dbo].[SalesType] as st 
on st.Id  = stb.SaleTypeId
inner join 
(
select b.id as bookId, count(s.id) as qdtSubject from [Books] as b
 inner join [dbo].[SubjectBook] sb
on sb.BookId = b.id 
inner join [Subjects] s
on s.Id = sb.SubjectId
group by b.id
) as QndSubjects
on QndSubjects.bookId = b.Id
group by b.Title,a.Name ,QndSubjects.qdtSubject