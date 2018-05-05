CREATE PROCEDURE SP_SearchHotelInform 
(

	@voteStar int, 
	@City nvarchar(30), 
	@Price money
)
AS 
BEGIN

DECLARE @SqlString nvarchar(2000), @input nvarchar(1000);

--SET @SqlString = 'SELECT * FROM dbo.KhachSan KS WHERE';

IF (@City IS NOT NULL AND @voteStar IS NOT NULL AND @Price IS NOT NULL)
SET @SqlString = 'SELECT * FROM dbo.KhachSan KS WHERE KS.thanhPho = @City AND KS.soSao = @voteStar AND KS.giaTB = @Price'

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


SET @input = '@voteStar int, @City nvarchar(30), @Price money'

EXEC SP_EXECUTESQL @SqlString, @input, @voteStar, @City, @Price

END