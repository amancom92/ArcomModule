SET IDENTITY_INSERT [dbo].[User] ON 
GO
INSERT [dbo].[User] ([UserId], [FirstName], [LastName], [Email], [Password], [IsActive], [CreatedOn], [CreatedBy], [UpdatedOn], [UpdatedBy], [LastAccessTime], [SecurityQuestion], [SecurityQuestionAnswer]) VALUES (2, N'Admin', N'User', N'aman.mehta@compunnel.com', N'Aman', 1, GETDATE(), 22, NULL, 1, GETDATE(), 1, N'aman')
GO
SET IDENTITY_INSERT [dbo].[User] OFF
GO


SET IDENTITY_INSERT [dbo].[SecurityQuestions] ON 
GO
INSERT [dbo].[SecurityQuestions] ([QuestionId], [QuestionName], [IsActive], [CreatedBy], [CreatedOn]) VALUES (1, N'What is your pet name?', 1, 0, GETDATE())
GO
INSERT [dbo].[SecurityQuestions] ([QuestionId], [QuestionName], [IsActive], [CreatedBy], [CreatedOn]) VALUES (2, N'Which is your favorite sports?', 1, 0, GETDATE())
GO
INSERT [dbo].[SecurityQuestions] ([QuestionId], [QuestionName], [IsActive], [CreatedBy], [CreatedOn]) VALUES (3, N'What is your father name?', 1, 0, GETDATE())
GO
INSERT [dbo].[SecurityQuestions] ([QuestionId], [QuestionName], [IsActive], [CreatedBy], [CreatedOn]) VALUES (4, N'Your Favorite color?', 1, 0, GETDATE())
GO
SET IDENTITY_INSERT [dbo].[SecurityQuestions] OFF
GO