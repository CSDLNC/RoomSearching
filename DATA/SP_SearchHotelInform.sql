CREATE PROCEDURE SP_SearchHotelInform 
( 
	@City nvarchar(30) 
)
AS 
BEGIN

DECLARE @SqlString nvarchar(2000), @input nvarchar(1000), @Price money, @voteStar int;

--SET @SqlString = 'SELECT * FROM dbo.KhachSan KS WHERE';

ELSE IF (@City IS NOT NULL AND @voteStar IS NOT NULL AND @Price IS NULL)
SET @SqlString = 'SELECT * FROM dbo.KhachSan KS WHERE KS.thanhPho = @City AND KS.soSao = @voteStar'

ELSE IF (@City IS NOT NULL AND @voteStar IS NULL AND @Price IS NOT NULL)
SET @SqlString = 'SELECT * FROM dbo.KhachSan KS WHERE KS.thanhPho = @City AND KS.giaTB = @Price'

ELSE IF (@City IS NOT NULL AND @voteStar IS NULL AND @Price IS NULL)
SET @SqlString = 'SELECT * FROM dbo.KhachSan KS WHERE KS.thanhPho = @City'

ELSE IF (@City IS NULL OR @voteStar IS NOT NULL OR @Price IS NOT NULL)
PRINT 'Thành phố không thể để trống.';

ELSE 
PRINT 'Không tìm thấy nội dung khách sạn.';


SET @input = '@City nvarchar(30)'

EXEC SP_EXECUTESQL @SqlString, @input, @voteStar, @City, @Price

END





