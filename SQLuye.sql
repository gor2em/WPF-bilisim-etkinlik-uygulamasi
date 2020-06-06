
/*CREATE TABLE uyeler(
Id int IDENTITY(1,1) PRIMARY KEY,
adsoyad varchar(30),
tel varchar(11) UNIQUE,
sehir varchar(11),
unvan varchar(20),
sirket varchar(20),
resimyolu varchar(100),
kayitTarihi varchar(50)
)
*/
DROP TABLE uyeler /*tablo silindi*/

select * from uyeler

TRUNCATE TABLE uyeler /* tablo içerik temizlendi*/

DBCC CHECKIDENT ('uyeler',RESEED,1) /*id restart*/

INSERT INTO  uyeler values('user','11111111111','aa','bb','cc','dd','123')

INSERT INTO  salon values('admin','1')
INSERT INTO  salon values('00000','2')
INSERT INTO  salon values('00001','3')
INSERT INTO  salon values('00002','4')
INSERT INTO  salon values('00003','5')
INSERT INTO  salon2 values('admin')
DBCC CHECKIDENT ('salon',RESEED,0) /*id restart*/
DELETE FROM salon

DBCC CHECKIDENT ('salon2',RESEED,0) /*id restart*/
DELETE FROM salon2

ALTER TABLE uyeler
DROP CONSTRAINT UQ_uyeler_tel


/* VIP ÜYELER */


SELECT * FROM vipUyeler
TRUNCATE TABLE vipUyeler
DELETE FROM vipUyeler
DBCC CHECKIDENT ('vipUyeler',RESEED,1) /*id restart*/
DBCC CHECKIDENT ('uyeler',RESEED,0) /*id restart*/
DELETE FROM uyeler

/* SALON */



SELECT * FROM salon
TRUNCATE TABLE salon



/*URUNLER*/

SELECT * FROM urunler
TRUNCATE TABLE urunler
DBCC CHECKIDENT ('urunler',RESEED,1) /*id restart*/
DELETE FROM urunler



SELECT * FROM urunler
TRUNCATE TABLE urunler


DBCC CHECKIDENT ('hizliKayit',RESEED,1) /*id restart*/
DELETE FROM hizliKayit

