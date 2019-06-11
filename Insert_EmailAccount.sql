SET IDENTITY_INSERT [dbo].[EmailAccount] ON
INSERT [dbo].[EmailAccount] ([Id], [Email], [DisplayName], [Host], [Port], [Username], [Password], [EnableSsl], [UseDefaultCredentials]) VALUES (1, N'test@mail.com', N'Store name', N'smtp.mail.com', 25, N'123', N'123', 0, 0)
SET IDENTITY_INSERT [dbo].[EmailAccount] OFF