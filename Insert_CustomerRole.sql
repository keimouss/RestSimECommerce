SET IDENTITY_INSERT [dbo].[CustomerRole] ON
INSERT [dbo].[CustomerRole] ([Id], [Name], [FreeShipping], [TaxExempt], [Active], [IsSystemRole], [SystemName], [PurchasedWithProductId]) VALUES (1, N'Administrators', 0, 0, 1, 1, N'Administrators', 0)
INSERT [dbo].[CustomerRole] ([Id], [Name], [FreeShipping], [TaxExempt], [Active], [IsSystemRole], [SystemName], [PurchasedWithProductId]) VALUES (2, N'Forum Moderators', 0, 0, 1, 1, N'ForumModerators', 0)
INSERT [dbo].[CustomerRole] ([Id], [Name], [FreeShipping], [TaxExempt], [Active], [IsSystemRole], [SystemName], [PurchasedWithProductId]) VALUES (3, N'Registered', 0, 0, 1, 1, N'Registered', 0)
INSERT [dbo].[CustomerRole] ([Id], [Name], [FreeShipping], [TaxExempt], [Active], [IsSystemRole], [SystemName], [PurchasedWithProductId]) VALUES (4, N'Guests', 0, 0, 1, 1, N'Guests', 0)
INSERT [dbo].[CustomerRole] ([Id], [Name], [FreeShipping], [TaxExempt], [Active], [IsSystemRole], [SystemName], [PurchasedWithProductId]) VALUES (5, N'Vendors', 0, 0, 1, 1, N'Vendors', 0)
SET IDENTITY_INSERT [dbo].[CustomerRole] OFF