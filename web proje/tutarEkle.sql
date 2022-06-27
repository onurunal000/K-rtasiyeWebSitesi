CREATE TRIGGER TUTAREKLE
ON FATURAKalems
AFTER INSERT
AS
DECLARE @Faturaid int
Declare @Tutar decimal(18,2)
Select @Faturaid=faturaid,@tutar=tutar from inserted
update Faturalars set Toplam=Toplam + @Tutar where Faturaid=@Faturaid