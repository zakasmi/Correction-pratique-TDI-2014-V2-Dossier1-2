create database GestProdPharma
Go
use GestProdPharma
Go
create table Magasin (
 Numero_Magasin int constraint PK_Magasin Primary key identity(1,1),
 Libelle_Magasin varchar(30),
 Date_Creation date ,
 Tel varchar(30),
 Ville varchar(30)
)
GO
create table Client(
CIN varchar(7) constraint PK_Client Primary key ,
Genre varchar(10),
Nom varchar(30),
Prenom varchar(30),
Tel varchar(20),
Adresse varchar(50),
Ville varchar(30),
Numero_Magasin int constraint FK_Client_Magasin Foreign key (Numero_Magasin) references Magasin(Numero_Magasin),
constraint CH_Genre Check ( Genre in ('Homme','Femme'))
)
GO
create table MotifsRejet(
Code_Motif varchar(10) constraint PK_MotifsRejet Primary key ,
Libelle_Motif varchar(30),
)
GO
create table Banque(
Code_Banque varchar(10) constraint PK_Banque Primary key,
Libelle_Banque varchar(30) , 
Adresse_Siege varchar(50) ,
Tel varchar(20) ,
Ville varchar(30) ,
)
GO
create table Cheque(
Numero_Cheque int constraint PK_Cheque Primary key,
Dtae_Emission Date,
Montant float ,
Url_Cheque varchar(30),
Code_Motif varchar(10)  constraint FK_Cheque_Motiffrejet Foreign key (Code_Motif) references MotifsRejet(Code_Motif),
CIN varchar(7)  constraint FK_Cheque_Client Foreign key (CIN) references Client(CIN),
Code_Banque varchar(10) constraint FK_Cheque_Banque Foreign key (Code_Banque) references Banque(Code_Banque),
Numero_Magasin int constraint FK_Cheque_Magasin Foreign key (Numero_Magasin) references Magasin(Numero_Magasin)
)
GO
USE [GestProdPharma]
GO
INSERT [dbo].[MotifsRejet] ([Code_Motif], [Libelle_Motif]) VALUES (N'CM1', N'LMotif1')
INSERT [dbo].[MotifsRejet] ([Code_Motif], [Libelle_Motif]) VALUES (N'CM2', N'LMotif2')
INSERT [dbo].[MotifsRejet] ([Code_Motif], [Libelle_Motif]) VALUES (N'CM3', N'LMotif3')
INSERT [dbo].[Banque] ([Code_Banque], [Libelle_Banque], [Adresse_Siege], [Tel], [Ville]) VALUES (N'B1', N'LBanque1', N'Oujda rue 11', N'060000000', N'Oujda')
INSERT [dbo].[Banque] ([Code_Banque], [Libelle_Banque], [Adresse_Siege], [Tel], [Ville]) VALUES (N'B2', N'LBanque2', N'Oujda rue 22', N'060000000', N'Casa')
INSERT [dbo].[Banque] ([Code_Banque], [Libelle_Banque], [Adresse_Siege], [Tel], [Ville]) VALUES (N'B3', N'LBanque3', N'Oujda rue 33', N'060000000', N'Fes')
SET IDENTITY_INSERT [dbo].[Magasin] ON 

INSERT [dbo].[Magasin] ([Numero_Magasin], [Libelle_Magasin], [Date_Creation], [Tel], [Ville]) VALUES (1, N'LMagasin1', CAST(N'2015-12-05' AS Date), N'0600000000', N'Nador')
INSERT [dbo].[Magasin] ([Numero_Magasin], [Libelle_Magasin], [Date_Creation], [Tel], [Ville]) VALUES (2, N'LMagasin2', CAST(N'2015-12-05' AS Date), N'0611111111', N'oujda')
INSERT [dbo].[Magasin] ([Numero_Magasin], [Libelle_Magasin], [Date_Creation], [Tel], [Ville]) VALUES (3, N'LMagasin3', CAST(N'2010-11-05' AS Date), N'0600000000', N'Tanger')
INSERT [dbo].[Magasin] ([Numero_Magasin], [Libelle_Magasin], [Date_Creation], [Tel], [Ville]) VALUES (4, N'LMagasin4', CAST(N'2015-12-05' AS Date), N'0600000000', N'Rabat')
SET IDENTITY_INSERT [dbo].[Magasin] OFF
INSERT [dbo].[Client] ([CIN], [Genre], [Nom], [Prenom], [Tel], [Adresse], [Ville], [Numero_Magasin]) VALUES (N'S1', N'Femme', N'Nom1', N'Prenom1', N'060000000', N'Adresse1', N'Oujda', 1)
INSERT [dbo].[Client] ([CIN], [Genre], [Nom], [Prenom], [Tel], [Adresse], [Ville], [Numero_Magasin]) VALUES (N'S2', N'Homme', N'Nom2', N'Prenom2', N'060000000', N'Adresse2', N'Casa', 2)
INSERT [dbo].[Client] ([CIN], [Genre], [Nom], [Prenom], [Tel], [Adresse], [Ville], [Numero_Magasin]) VALUES (N'S3', N'Homme', N'Nom3', N'Prenom3', N'063333333', N'Adresse3', N'Rabat', 3)
INSERT [dbo].[Cheque] ([Numero_Cheque], [Dtae_Emission], [Montant], [Url_Cheque], [Code_Motif], [CIN], [Code_Banque], [Numero_Magasin]) VALUES (10001, CAST(N'2015-12-11' AS Date), 4000, N'url1.com', N'CM1', N'S1', N'B1', 1)
INSERT [dbo].[Cheque] ([Numero_Cheque], [Dtae_Emission], [Montant], [Url_Cheque], [Code_Motif], [CIN], [Code_Banque], [Numero_Magasin]) VALUES (10002, CAST(N'2017-05-05' AS Date), 3000, N'url2.com', N'CM2', N'S2', N'B2', 1)
INSERT [dbo].[Cheque] ([Numero_Cheque], [Dtae_Emission], [Montant], [Url_Cheque], [Code_Motif], [CIN], [Code_Banque], [Numero_Magasin]) VALUES (10003, CAST(N'2017-05-05' AS Date), 5000, N'url3.com', N'CM3', N'S2', N'B2', 2)
INSERT [dbo].[Cheque] ([Numero_Cheque], [Dtae_Emission], [Montant], [Url_Cheque], [Code_Motif], [CIN], [Code_Banque], [Numero_Magasin]) VALUES (10004, CAST(N'2017-05-05' AS Date), 5000, N'url4.com', N'CM3', N'S3', N'B3', 3)
-- 2 Ajouter une contrainte qui permet de vérifier que le numero de chèque est supérieur à 1000.
GO
alter table dbo.Cheque add constraint CH_Numero_De check (Numero_Cheque > 1000)
GO
-- 3 Créer une procédure stockée qui affiche la liste des clients d'une ville donnée comme paramètre.
GO
create procedure Affiche_Liste_Client_Par_Ville @Ville varchar(30)
as begin 
select * from Client L where L.Ville = @Ville
End
GO
--Test 
--exec Affiche_Liste_Client_Par_Ville 'Oujda'
GO
-- 4 Créer une procédure stockée qui affiche les Magasins crée dans les 2 dernières années.
create procedure Affiche_Magasin_Cree_2ansdern 
as begin 
select * from Magasin M where  year(M.Date_Creation) > (year(GETDATE())-2)
End
GO
-- test 
GO
 --exec dbo.Affiche_Magasin_Cree_2ansdern
GO
-- 5 Créer une procédure stockée qui affiche, pour un Magasin donné en paramètre, la liste des
--chèques qui se sont presentés durant I'année en cours. Prévoir dans le jeu d'essai, des lignes
--dans la table cheque avec des dates comprises dans I'année en cours.
create Procedure Afficher_Cheque_De_Magasin_anne_encours @NumMagasine int 
as 
begin 
SELECT  Cheque.* FROM         dbo.Magasin INNER JOIN
dbo.Cheque ON dbo.Magasin.Numero_Magasin = dbo.Cheque.Numero_Magasin
where  dbo.Magasin.Numero_Magasin = @NumMagasine and  year(dbo.Cheque.Dtae_Emission) = year(GETDATE())
 
End
GO
-- test
--exec Afficher_Cheque_De_Magasin_anne_encours '1'
GO
exec Afficher_Cheque_De_Magasin_anne_encours '1'
GO
-- 6 Créer un trigger qui permet d'annuler chaque tentative de suppression d'un cheque.
create trigger TG_Suprimmer_Cheque on Cheque 
Instead of Delete  
as 
begin 
if(Exists(select * from deleted))
begin
RaisError('Suppression refuse',16,1)
RollBack
end
End
GO
--7 Créer la procédure stockée qui permet de supprimer tous les clients qui n'ont pas de noms.
create procedure Supprimer_Client_Sans_Noms 
as begin 
delete from Client where Nom = null or Nom = ''
End 
GO
-- 8 Créer un déclencheur qui refuse !'ajout d'un magasin lorsque la date de création est supérieure à la date du jour
create trigger Ajoute_Magasin on Magasin 
instead of insert
as 
Begin
if(exists(select * from inserted where Date_Creation <= GETDATE()))
begin
raisError('La date de creation doit etre superieur ou egale a la date du jour',16,1)
return
end
set Identity_insert  dbo.Magasin on
INSERT INTO [dbo].[Magasin]
           (Numero_Magasin,
		   [Libelle_Magasin]
           ,[Date_Creation]
           ,[Tel]
           ,[Ville])
select * from inserted
set Identity_insert  Magasin off
End
-- Etat Q 5
SELECT     dbo.Cheque.Numero_Cheque, dbo.Cheque.Dtae_Emission, dbo.Cheque.Montant, dbo.MotifsRejet.Libelle_Motif, dbo.Magasin.Libelle_Magasin
FROM         dbo.Cheque INNER JOIN
                      dbo.Magasin ON dbo.Cheque.Numero_Magasin = dbo.Magasin.Numero_Magasin INNER JOIN
                      dbo.MotifsRejet ON dbo.Cheque.Code_Motif = dbo.MotifsRejet.Code_Motif
-- Etat Q6
					  SELECT     dbo.Cheque.Numero_Magasin as 'Numero Magasin',count(Magasin.Numero_Magasin) as 'Nombre cheques'
FROM         dbo.Cheque INNER JOIN
                      dbo.Magasin ON dbo.Cheque.Numero_Magasin = dbo.Magasin.Numero_Magasin
GROUP BY dbo.Cheque.Numero_Magasin

-- Dossier 3 ASP . 
--1 if you are using chrome open the web page in 2 Browsers . to see the number of users 
-- if you are using Firefox etc .. just open the web page in a new tab ? and the number of user will be incremented by 1
--2 Connexion 
create table LoginClient(
LoginClient varchar(30) constraint PK_Login Primary key ,
Mot_Pass varchar(30) not null,
Nom varchar(30),
Prenom varchar(30),
)
GO
insert into LoginClient values ('1','11','Nom1','Prenom1'),('2','22','Nom2','Prenom2')
GO


select sum(Montant) from Cheque where CIN = '2'










