USE [Estate]
GO
/****** Object:  Table [dbo].[Menu]    Script Date: 10/12/2017 23:46:23 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Menu](
	[ID] [int] NOT NULL,
	[ParentMenuId] [int] NULL,
	[Caption] [nvarchar](max) NULL,
	[Destination] [nvarchar](max) NULL,
 CONSTRAINT [PK_Menu] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
INSERT [dbo].[Menu] ([ID], [ParentMenuId], [Caption], [Destination]) VALUES (1, 0, N'Tasks', N'tasks')
GO
INSERT [dbo].[Menu] ([ID], [ParentMenuId], [Caption], [Destination]) VALUES (2, 0, N'Property', N'property')
GO
INSERT [dbo].[Menu] ([ID], [ParentMenuId], [Caption], [Destination]) VALUES (3, 0, N'Management Plans', N'managementplans')
GO
INSERT [dbo].[Menu] ([ID], [ParentMenuId], [Caption], [Destination]) VALUES (4, 0, N'Safety', N'safety')
GO
INSERT [dbo].[Menu] ([ID], [ParentMenuId], [Caption], [Destination]) VALUES (5, 0, N'Tree Planting', N'treeplanting')
GO
INSERT [dbo].[Menu] ([ID], [ParentMenuId], [Caption], [Destination]) VALUES (6, 0, N'Public Information', N'publicinformation')
GO
INSERT [dbo].[Menu] ([ID], [ParentMenuId], [Caption], [Destination]) VALUES (7, 0, N'Maps', N'maps')
GO
INSERT [dbo].[Menu] ([ID], [ParentMenuId], [Caption], [Destination]) VALUES (8, 0, N'Reports', N'reports')
GO
INSERT [dbo].[Menu] ([ID], [ParentMenuId], [Caption], [Destination]) VALUES (9, 0, N'Internal Audits', N'internalaudits')
GO
INSERT [dbo].[Menu] ([ID], [ParentMenuId], [Caption], [Destination]) VALUES (10, 0, N'Documents', N'documents')
GO
INSERT [dbo].[Menu] ([ID], [ParentMenuId], [Caption], [Destination]) VALUES (11, 0, N'Administrative Area', N'administrativearea')
GO
INSERT [dbo].[Menu] ([ID], [ParentMenuId], [Caption], [Destination]) VALUES (12, 1, N'Today', N'taskstoday')
GO
INSERT [dbo].[Menu] ([ID], [ParentMenuId], [Caption], [Destination]) VALUES (13, 1, N'Week', N'taskweek')
GO
INSERT [dbo].[Menu] ([ID], [ParentMenuId], [Caption], [Destination]) VALUES (14, 1, N'Month', N'taskmonth')
GO
INSERT [dbo].[Menu] ([ID], [ParentMenuId], [Caption], [Destination]) VALUES (15, 1, N'Year', N'taskyear')
GO
INSERT [dbo].[Menu] ([ID], [ParentMenuId], [Caption], [Destination]) VALUES (16, 1, N'All', N'taskall')
GO
INSERT [dbo].[Menu] ([ID], [ParentMenuId], [Caption], [Destination]) VALUES (17, 3, N'Administration', N'administration')
GO
INSERT [dbo].[Menu] ([ID], [ParentMenuId], [Caption], [Destination]) VALUES (18, 3, N'Grant Contracts', N'grantcontracts')
GO
INSERT [dbo].[Menu] ([ID], [ParentMenuId], [Caption], [Destination]) VALUES (19, 3, N'Condition Assessments', N'conditionassessment')
GO
INSERT [dbo].[Menu] ([ID], [ParentMenuId], [Caption], [Destination]) VALUES (20, 3, N'Summary Description', N'summarydescription')
GO
INSERT [dbo].[Menu] ([ID], [ParentMenuId], [Caption], [Destination]) VALUES (21, 3, N'Objectives KF', N'objectiveskf')
GO
INSERT [dbo].[Menu] ([ID], [ParentMenuId], [Caption], [Destination]) VALUES (22, 3, N'Work Programme', N'workprogramme')
GO
INSERT [dbo].[Menu] ([ID], [ParentMenuId], [Caption], [Destination]) VALUES (23, 3, N'Purchase Orders', N'purchaseorders')
GO
INSERT [dbo].[Menu] ([ID], [ParentMenuId], [Caption], [Destination]) VALUES (24, 3, N'Sales Orders', N'salesorders')
GO
INSERT [dbo].[Menu] ([ID], [ParentMenuId], [Caption], [Destination]) VALUES (25, 3, N'Monitoring', N'monitoring')
GO
INSERT [dbo].[Menu] ([ID], [ParentMenuId], [Caption], [Destination]) VALUES (26, 3, N'Harvesting', N'harvesting')
GO
INSERT [dbo].[Menu] ([ID], [ParentMenuId], [Caption], [Destination]) VALUES (27, 3, N'Reference Information', N'referenceinformation')
GO
INSERT [dbo].[Menu] ([ID], [ParentMenuId], [Caption], [Destination]) VALUES (28, 11, N'General Details', N'general details')
GO
INSERT [dbo].[Menu] ([ID], [ParentMenuId], [Caption], [Destination]) VALUES (29, 11, N'Users and Groups', N'users and groups')
GO
INSERT [dbo].[Menu] ([ID], [ParentMenuId], [Caption], [Destination]) VALUES (30, 11, N'Work Programme', N'work programme')
GO
INSERT [dbo].[Menu] ([ID], [ParentMenuId], [Caption], [Destination]) VALUES (31, 11, N'Reports', N'reports')
GO
INSERT [dbo].[Menu] ([ID], [ParentMenuId], [Caption], [Destination]) VALUES (32, 11, N'VAT Codes', N'vat codes')
GO
INSERT [dbo].[Menu] ([ID], [ParentMenuId], [Caption], [Destination]) VALUES (33, 11, N'Lookup Editor', N'lookup editor')
GO
INSERT [dbo].[Menu] ([ID], [ParentMenuId], [Caption], [Destination]) VALUES (34, 11, N'WTFL Sites', N'wtfl sites')
GO
INSERT [dbo].[Menu] ([ID], [ParentMenuId], [Caption], [Destination]) VALUES (35, 11, N'Funded Project Sites', N'funded project sites')
GO
INSERT [dbo].[Menu] ([ID], [ParentMenuId], [Caption], [Destination]) VALUES (36, 11, N'Income Products', N'income products')
GO
INSERT [dbo].[Menu] ([ID], [ParentMenuId], [Caption], [Destination]) VALUES (37, 11, N'Expenditure Products', N'expenditure products')
GO
INSERT [dbo].[Menu] ([ID], [ParentMenuId], [Caption], [Destination]) VALUES (38, 11, N'VAT Rate Locks', N'vat rate locks')
GO
INSERT [dbo].[Menu] ([ID], [ParentMenuId], [Caption], [Destination]) VALUES (39, 11, N'Documents', N'documents')
GO


