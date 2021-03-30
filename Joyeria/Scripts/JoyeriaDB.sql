INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'da4a7bec-5dcb-43a8-bcaa-50ba95419805', N'admin', N'admin', N'95348aeb-c3d3-463a-af2d-cf96ef8f41c6')
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'7207ee71-aa2d-49be-84f6-857013f29238', N'admin@joyeria.com', N'ADMIN@JOYERIA.COM', N'admin@joyeria.com', N'ADMIN@JOYERIA.COM', 0, N'AQAAAAEAACcQAAAAEPWQbZy/IQMYi2jUYDCFGMkX8JrjTYaPk0azhyz+fuFjp/ac4LCT4SJ3+ST1NwrLKA==', N'IDDNTMHJ5ZFBEQ2JD3PASF3CNC4WXKWG', N'd1c9fd77-b18c-42cf-8d88-9b3ac8251f34', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'86aeeac4-1d79-4f55-874b-68565acc1e7e', N'adminz@joyeria.com', N'ADMINZ@JOYERIA.COM', N'adminz@joyeria.com', N'ADMINZ@JOYERIA.COM', 1, N'AQAAAAEAACcQAAAAEMS4RC6pbNIZ5gMzit9uvfAA2Rs6Gmi1k+J8LNnlfAloxAbZ30XtfJWcW3g+h0+fxg==', N'JC5ME3MG7MDCM2VJTW26SCDCXP5RWLLD', N'4e220ce1-537f-404b-bd0d-aec42e2a238c', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'b63e7a90-9881-490b-a186-4765cca238f2', N'admins@joyeria.com', N'ADMINS@JOYERIA.COM', N'admins@joyeria.com', N'ADMINS@JOYERIA.COM', 1, N'AQAAAAEAACcQAAAAEI6b9VUxdPaUkrKAYf4JLlCBInQHys/pwwNEigF2NIj3KVnJOAKOpA3v4dhaYtinmQ==', N'NBAE5A7FMJHYKD2MW5EGNFNG5ZGVSPT3', N'bb7040ad-bd1b-437e-99de-9856f78dc861', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'd78dfa12-fbb8-40c9-abea-134231c319f0', N'user@joyeria.com', N'USER@JOYERIA.COM', N'user@joyeria.com', N'USER@JOYERIA.COM', 1, N'AQAAAAEAACcQAAAAEHWewoU+tcEejE6wG4jvUr6T7BCKuoxtTIfnqTpTna4mlE+Bv/dTv7Jb19WVZGvCjQ==', N'VY7CSMXJD7MSTHXNGV67KUZ7C7YRW3NF', N'4651d521-9584-406b-91dc-23cfb741bca1', NULL, 0, 0, NULL, 1, 0)
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'86aeeac4-1d79-4f55-874b-68565acc1e7e', N'da4a7bec-5dcb-43a8-bcaa-50ba95419805')
GO
SET IDENTITY_INSERT [dbo].[GenderTypes] ON 
GO
INSERT [dbo].[GenderTypes] ([GenderTypeID], [GenderTypeName]) VALUES (1, N'KIDS')
GO
INSERT [dbo].[GenderTypes] ([GenderTypeID], [GenderTypeName]) VALUES (2, N'LADIES')
GO
INSERT [dbo].[GenderTypes] ([GenderTypeID], [GenderTypeName]) VALUES (3, N'MEN')
GO
INSERT [dbo].[GenderTypes] ([GenderTypeID], [GenderTypeName]) VALUES (4, N'PAIR')
GO
INSERT [dbo].[GenderTypes] ([GenderTypeID], [GenderTypeName]) VALUES (5, N'UNISEX')
GO
SET IDENTITY_INSERT [dbo].[GenderTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[JewelleryTypes] ON 
GO
INSERT [dbo].[JewelleryTypes] ([JewelleryTypeID], [JewelleryTypeName]) VALUES (1, N'DIAMOND JEWELLERY')
GO
INSERT [dbo].[JewelleryTypes] ([JewelleryTypeID], [JewelleryTypeName]) VALUES (2, N'JEWELLERY WITH GEMSTONES')
GO
INSERT [dbo].[JewelleryTypes] ([JewelleryTypeID], [JewelleryTypeName]) VALUES (3, N'PLAIN GOLD JEWELLERY')
GO
INSERT [dbo].[JewelleryTypes] ([JewelleryTypeID], [JewelleryTypeName]) VALUES (4, N'PLAIN JEWELLERY WITH STONES')
GO
INSERT [dbo].[JewelleryTypes] ([JewelleryTypeID], [JewelleryTypeName]) VALUES (5, N'PLATINUM JEWELLERY')
GO
SET IDENTITY_INSERT [dbo].[JewelleryTypes] OFF
GO
SET IDENTITY_INSERT [dbo].[JewelleryInfos] ON 
GO
INSERT [dbo].[JewelleryInfos] ([JewelleryID], [Title], [Description], [Extension], [Weight], [Price], [GenderTypeID], [JewelleryTypeID]) VALUES (1, N'CONTEMPORARY ANIMAL DIAMOND STUD EARRINGS FOR KIDS', N'Sparrow Stud Earrings set in 18 Karat Yellow Gold and studded with Diamonds (SI2, TTLC)', N'.PNG', 0.965, 146.5, 1, 1)
GO
INSERT [dbo].[JewelleryInfos] ([JewelleryID], [Title], [Description], [Extension], [Weight], [Price], [GenderTypeID], [JewelleryTypeID]) VALUES (2, N'CONTEMPORARY ANIMAL DIAMOND STUD EARRINGS FOR KIDS', N'Sparrow Stud Earrings set in 18 Karat Yellow Gold and studded with Diamonds (I1/I2, G-H)', N'.PNG', 0.9, 100.1, 1, 1)
GO
INSERT [dbo].[JewelleryInfos] ([JewelleryID], [Title], [Description], [Extension], [Weight], [Price], [GenderTypeID], [JewelleryTypeID]) VALUES (3, N'CHARMING DIAMOND STUD EARRINGS FOR KIDS', N'Duckling Stud Earrings Crafted in 18 Karat Yellow Gold and Studded with Diamonds', N'.PNG', 0.85, 120.56, 1, 1)
GO
INSERT [dbo].[JewelleryInfos] ([JewelleryID], [Title], [Description], [Extension], [Weight], [Price], [GenderTypeID], [JewelleryTypeID]) VALUES (4, N'CHARMING DIAMOND BRACELET IN WHITE AND ROSE GOLD FOR KIDS', N'Dainty Bangle Crafted in 18 Karat White and Rose Gold and Studded with Diamonds (SI2, GH)', N'.PNG', 0.987, 897.8, 1, 1)
GO
INSERT [dbo].[JewelleryInfos] ([JewelleryID], [Title], [Description], [Extension], [Weight], [Price], [GenderTypeID], [JewelleryTypeID]) VALUES (5, N'SLEEK TWO TONED GOLD RING FOR MEN', N'The price for this item will vary based on grammage and gold rate on that particular day
Stacked Pattern Ring set in 18 Karat White and Rose Gold', N'.PNG', 5.481, 372.67, 3, 3)
GO
INSERT [dbo].[JewelleryInfos] ([JewelleryID], [Title], [Description], [Extension], [Weight], [Price], [GenderTypeID], [JewelleryTypeID]) VALUES (6, N'DAZZLING SQUARE GOLD RING FOR MEN', N'Textured square ring with traditional design set in 22 karat yellow gold. Exude regalia fit for a king with this majestic ring!', N'.PNG', 3.093, 243.3, 3, 3)
GO
INSERT [dbo].[JewelleryInfos] ([JewelleryID], [Title], [Description], [Extension], [Weight], [Price], [GenderTypeID], [JewelleryTypeID]) VALUES (7, N'CHARMING TWISTED MOTIF GOLD RING FOR MEN', N'Swirling pattern ring set in 22 karat yellow gold. The artistic design of this ring makes it simply charming.', N'.PNG', 4.228, 336.62, 3, 3)
GO
INSERT [dbo].[JewelleryInfos] ([JewelleryID], [Title], [Description], [Extension], [Weight], [Price], [GenderTypeID], [JewelleryTypeID]) VALUES (8, N'18 KARAT GOLD AND EMERALD PENDANT', N'18 Karat Gold and Emerald Pendant', N'.PNG', 1.569, 120.25, 2, 2)
GO
INSERT [dbo].[JewelleryInfos] ([JewelleryID], [Title], [Description], [Extension], [Weight], [Price], [GenderTypeID], [JewelleryTypeID]) VALUES (9, N'18 KARAT GOLD AND SAPPHIRE PENDANT', N'18 Karat Gold and Sapphire Pendant', N'.PNG', 1.695, 101.97, 2, 2)
GO
INSERT [dbo].[JewelleryInfos] ([JewelleryID], [Title], [Description], [Extension], [Weight], [Price], [GenderTypeID], [JewelleryTypeID]) VALUES (10, N'STYLISH GEOMETRIC GOLD MESH RING', N'Geometric mesh ring set in 22 karat yellow gold. The mesh pattern lends an abstract and graceful touch to this charming ring.', N'.PNG', 5.098, 401.02, 5, 3)
GO
INSERT [dbo].[JewelleryInfos] ([JewelleryID], [Title], [Description], [Extension], [Weight], [Price], [GenderTypeID], [JewelleryTypeID]) VALUES (11, N'TIMELESS GOLD CHAIN', N'Classic Interlinked Chain Crafted in 22 Karat Yellow Gold', N'.PNG', 11.965, 914.64, 5, 3)
GO
INSERT [dbo].[JewelleryInfos] ([JewelleryID], [Title], [Description], [Extension], [Weight], [Price], [GenderTypeID], [JewelleryTypeID]) VALUES (12, N'ROYAL GOLD RING', N'The price for this item will vary based on grammage and gold rate on that particular day. Dome Shaped Ring with Chakri Diamonds set in 22 Karat Yellow Gold', N'.PNG', 7.116, 722.24, 2, 4)
GO
INSERT [dbo].[JewelleryInfos] ([JewelleryID], [Title], [Description], [Extension], [Weight], [Price], [GenderTypeID], [JewelleryTypeID]) VALUES (13, N'TRADITIONAL FLORAL GOLD PENDANT', N'18 Karat Yellow Gold Pendant with a Ruby and Uncut Diamonds', N'.PNG', 1.401, 128.46, 2, 4)
GO
INSERT [dbo].[JewelleryInfos] ([JewelleryID], [Title], [Description], [Extension], [Weight], [Price], [GenderTypeID], [JewelleryTypeID]) VALUES (14, N'EXQUISITE ANTIQUE GOLD RING', N'The price for this item will vary based on grammage and gold rate on that particular day
Floral Ring with Kundan Stones set in 22 Karat Yellow Gold', N'.PNG', 6.806, 565.84, 2, 4)
GO
INSERT [dbo].[JewelleryInfos] ([JewelleryID], [Title], [Description], [Extension], [Weight], [Price], [GenderTypeID], [JewelleryTypeID]) VALUES (15, N'22 KARAT GOLD FINGER RING SET', N'Tanishq 22 Karat Yellow Gold Couple Bands', N'.PNG', 10.568, 900.68, 4, 3)
GO
INSERT [dbo].[JewelleryInfos] ([JewelleryID], [Title], [Description], [Extension], [Weight], [Price], [GenderTypeID], [JewelleryTypeID]) VALUES (16, N'PRISTINE ENGRAVED FINGER RING SET', N'Pristine Engraved Karat Yellow Gold Couple Bands. This ring symbolises the journey you are about to undertake and the many milestones waiting for you.', N'.PNG', 11.305, 999.99, 4, 3)
GO
INSERT [dbo].[JewelleryInfos] ([JewelleryID], [Title], [Description], [Extension], [Weight], [Price], [GenderTypeID], [JewelleryTypeID]) VALUES (17, N'ELEGANT PLATINUM TEARDROP PENDANT', N'Teardrop pendant set in 950 platinum. This pendant features a teardrop with laser cut motifs.', N'.PNG', 1.265, 114.93, 2, 5)
GO
INSERT [dbo].[JewelleryInfos] ([JewelleryID], [Title], [Description], [Extension], [Weight], [Price], [GenderTypeID], [JewelleryTypeID]) VALUES (18, N'MARVELLOUS FOLD PATTERN PLATINUM RING', N'Fold pattern ring set in 950 platinum. The masterfully crafted fold design makes this ring a stand-out piece.', N'.PNG', 4.673, 424.53, 2, 5)
GO
INSERT [dbo].[JewelleryInfos] ([JewelleryID], [Title], [Description], [Extension], [Weight], [Price], [GenderTypeID], [JewelleryTypeID]) VALUES (19, N'STRIKING PLATINUM BRACELET FOR MEN', N'Interlinked bracelet set in 950 platinum. Step out of your comfort zone and go bold with this one!', N'.PNG', 14.438, 1311.67, 3, 5)
GO
INSERT [dbo].[JewelleryInfos] ([JewelleryID], [Title], [Description], [Extension], [Weight], [Price], [GenderTypeID], [JewelleryTypeID]) VALUES (20, N'SPECTACULAR TIERED PLATINUM RING FOR MEN', N'Tiered ring set in 950 platinum. The layered design makes sure this ring always makes the right style statements.', N'.PNG', 8.809, 800.29, 3, 5)
GO
SET IDENTITY_INSERT [dbo].[JewelleryInfos] OFF
GO
SET IDENTITY_INSERT [dbo].[JewelleryReviews] ON 
GO
INSERT [dbo].[JewelleryReviews] ([ReviewID], [ReviewText], [ReviewDate], [ReviewerName], [JewelleryID]) VALUES (1, N'This is Nice Product Delivered by Joyeria', CAST(N'2021-03-30T14:54:01.3208354' AS DateTime2), N'user@joyeria.com', 1)
GO
SET IDENTITY_INSERT [dbo].[JewelleryReviews] OFF
GO
