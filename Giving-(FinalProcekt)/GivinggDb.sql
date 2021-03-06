USE [GivinggDb]
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'586c438e-4e34-4464-98c4-19c8322c1b57', N'Super Admin', N'SUPER ADMIN', N'5dea0257-0545-4019-af9f-c08f89b094aa')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'9b412ecc-e475-42c8-8293-bedb70b8077d', N'Moderator', N'MODERATOR', N'011cee49-97df-4e8a-8315-a0bc8146f0ca')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'c19c066b-ad0f-4382-8571-d90820f60376', N'Admin', N'ADMIN', N'6a4317ab-1a07-4bef-89dd-879e5798c68d')
GO
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [Image], [Name], [Title]) VALUES (N'23479823-d3eb-4be6-b22b-4a91b1defb44', N'orxan@gmail.com', N'ORXAN@GMAIL.COM', N'orxan@gmail.com', N'ORXAN@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAEEtNRrIp6koWiTvYGCNJKpKPYrtn5o61/pLNdn3MF8AMD0CPrB1F+TB7W+bAz62poQ==', N'4S5BHWR3OUZ2NJS7B4L5RVBNEV3VVZQ2', N'15086da8-88b5-497b-9f40-154ce353aed8', NULL, 0, 0, NULL, 1, 0, N'CustomUser', N'97709695-dc41-4ab9-8cc3-3ef389b12a4d-11March2022-IMG-5386.jpg', N'Orxan', NULL)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [Image], [Name], [Title]) VALUES (N'8ab41f1f-545c-4484-b5a6-7866de08644a', N'hasanov@gmail.com', N'HASANOV@GMAIL.COM', N'hasanov@gmail.com', N'HASANOV@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAELYwoysg7wfcG5OK7hpxLq+pJBvTlMXb3/TDTum9I+jbmMQqS4RX1DMA7XYEc0A/7Q==', N'KN3PTZN5LECSRW45FZYYTHIPJR7TQ5AC', N'45f0c434-2319-4dd7-8043-44a9d30a5d02', N'1', 0, 0, NULL, 1, 0, N'CustomUser', N'60a4e1da-ef32-4970-939f-89407d1407ed-11March2022-be26483c-e769-4460-8c0b-9be72884521a.JPG', N'Amin', NULL)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount], [Discriminator], [Image], [Name], [Title]) VALUES (N'e35eb1be-7029-473e-a0d7-4c93d1b841fb', N'sahibaa@gmail.com', N'SAHIBAA@GMAIL.COM', N'sahibaa@gmail.com', N'SAHIBAA@GMAIL.COM', 0, N'AQAAAAEAACcQAAAAELKvpJ5DhBeFQvMyLBdCXpB509wZix/bj3h6NkPc83iC7iABFDAQru8RQxalC81IxQ==', N'DJ657H4SP2MNH67LZCEBQBNDZ4DW7LHA', N'053b87ab-2b8c-412d-bce3-6b86d2fb159d', NULL, 0, 0, NULL, 1, 0, N'CustomUser', N'b264d3bc-17a3-4bb6-99a3-074a0b9f11be-11March2022-Me.jpeg', N'Sahib', NULL)
GO
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e35eb1be-7029-473e-a0d7-4c93d1b841fb', N'586c438e-4e34-4464-98c4-19c8322c1b57')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'8ab41f1f-545c-4484-b5a6-7866de08644a', N'9b412ecc-e475-42c8-8293-bedb70b8077d')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'23479823-d3eb-4be6-b22b-4a91b1defb44', N'c19c066b-ad0f-4382-8571-d90820f60376')
GO
SET IDENTITY_INSERT [dbo].[Causes] ON 

INSERT [dbo].[Causes] ([Id], [Image], [Title], [Content], [Address], [CauseNeed], [CreatedDate]) VALUES (1, N'dbf03d8c-b53e-495a-9b52-4285c33b7933-20220311142605-full-1.jpg', N'Big night walk', N'It will be an experience like no other. Starting off in central London at St John’s Church, Waterloo, the unique 12.5 mile route through central London will take you on a tour of the iconic sites at night.', N'Vellington, 941 Vic', 9000, CAST(N'2022-03-11T14:26:05.3963748' AS DateTime2))
INSERT [dbo].[Causes] ([Id], [Image], [Title], [Content], [Address], [CauseNeed], [CreatedDate]) VALUES (2, N'68eb2c8c-04e6-4157-ae70-731b99deb135-20220311142707-full-2.jpg', N'Heart to heart', N'Heart to Heart is a gathering of wives, mothers, sisters, daughters, and best friends for a luncheon and fashion show to help raise awareness about the unique characteristics of cardiovascular disease in women.', N'142 Santa Monica, LA, USA', 9500, CAST(N'2022-03-11T14:27:07.8005028' AS DateTime2))
INSERT [dbo].[Causes] ([Id], [Image], [Title], [Content], [Address], [CauseNeed], [CreatedDate]) VALUES (3, N'332257d2-a269-40d9-85f9-f7718b3fc95f-20220311142805-full-3.jpg', N'Rice for life', N'If you are representing an organisation or a group of volunteers, please discuss the size of your group with your Area Event Manager who will contact you after registration. All members of your organisation or group, aged 18 or over, should either register online or complete a volunteer registration form at the event.', N'142 Santa Monica, LA, USA', 19000, CAST(N'2022-03-11T14:28:05.7664827' AS DateTime2))
INSERT [dbo].[Causes] ([Id], [Image], [Title], [Content], [Address], [CauseNeed], [CreatedDate]) VALUES (4, N'a65d1e5f-0007-4ac3-b7f4-5c968b959c61-20220311142843-full-4.jpg', N'Back to school', N'Our primary mission is essential and clear-cut: To provide a full range of high-quality health care services to all children and youth up to the age of 21 who seek our care or who are referred to us. To complement that mission, we manage teaching and research programs that achieve excellence and support our ability to be a world-class children’s hospital.', N'2 Riverside Plaza, Chicago', 12000, CAST(N'2022-03-11T14:28:43.2854993' AS DateTime2))
INSERT [dbo].[Causes] ([Id], [Image], [Title], [Content], [Address], [CauseNeed], [CreatedDate]) VALUES (5, N'6fa9a455-ca13-4078-a15f-b4a17b015ad0-20220311142927-full-5.jpg', N'Mini fundraiser', N'You will need to arrange a place to play and that’s best done well in advance. Seasonal factors will affect price and availability, but most of the time you can arrange either a flat payment for exclusive facility use or a per game fee that’s substantially lower than standard rates.', N'142 Santa Monica, LA, USA', 7000, CAST(N'2022-03-11T14:29:27.9115480' AS DateTime2))
INSERT [dbo].[Causes] ([Id], [Image], [Title], [Content], [Address], [CauseNeed], [CreatedDate]) VALUES (6, N'27b7d53d-db38-46d6-b1b0-ecd0c66441a2-20220311143002-full-6.jpg', N'Share a future', N'Shaping Futures offers a brighter future to disadvantaged youngsters by teaching them the craft of hairdressing. Voluntary teams from our partner salons have been bringing their hairdressing knowledge and expertise to disadvantaged youngsters in twenty-five countries

Shape a Future is the ultimate bundle to help children live and learn — Vaccines and School-in-a-Box. Measles and Polio Vaccines shield young bodies from grave harm, protecting them from preventable, deadly infections.School-in-a-Box creates an oasis of learning for children in trauma, giving them the chance to forget the devastation and focus on their studies.', N'Vellington, 941 Vic', 10000, CAST(N'2022-03-11T14:30:02.9495610' AS DateTime2))
INSERT [dbo].[Causes] ([Id], [Image], [Title], [Content], [Address], [CauseNeed], [CreatedDate]) VALUES (7, N'0c335f4e-5117-41aa-a5dc-5eabc6e8418a-20220311143041-full-7.jpg', N'Give education', N'Volunteer coordinators are as busy as the organization is. In many cases, this will involve personal travel time to and from major organization offices to give personal instructions, planning events, maintaining facilities, and freeing up work for the paid staff.', N'142 Santa Monica, LA, USA', 13000, CAST(N'2022-03-11T14:30:41.0030350' AS DateTime2))
INSERT [dbo].[Causes] ([Id], [Image], [Title], [Content], [Address], [CauseNeed], [CreatedDate]) VALUES (8, N'26f33303-1f30-44df-8476-de4236e5f312-20220311143150-full-8.jpg', N'Therapeutic food', N'Volunteer Therapeutic Course Facilitators will deliver one or more of our Therapeutic Courses. These will usually take place over a six week period, for two hours a week.', N'Vellington, 941 Vic', 10000, CAST(N'2022-03-11T14:31:50.6317828' AS DateTime2))
INSERT [dbo].[Causes] ([Id], [Image], [Title], [Content], [Address], [CauseNeed], [CreatedDate]) VALUES (9, N'f9bf8b6d-4e70-4e37-a578-8d8e77a45fd9-20220311143256-full-9.jpg', N'Give scholarship', N'These scholarships reward you for helping others. It’s a nice way of doing well by doing good. Schools are required to use 7% of their Federal Work Study program funds to pay for students employed in community service jobs.', N'142 Santa Monica, LA, USA', 7000, CAST(N'2022-03-11T14:32:56.6612912' AS DateTime2))
INSERT [dbo].[Causes] ([Id], [Image], [Title], [Content], [Address], [CauseNeed], [CreatedDate]) VALUES (10, N'cb453af9-1441-4e2c-9b5c-fd42bbbd9c06-20220311143339-full-10.jpg', N'Stop child’s diseases', N'Sed ut perspiciatis, unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam eaque ipsa, quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt, explicabo. Nemo enim ipsam voluptatem, quia voluptas sit, aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos, qui ratione voluptatem sequi nesciunt, neque porro quisquam est, qui dolorem ipsum, quia dolor sit, amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt, ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur?', N'142 Santa Monica, LA, USA', 10000, CAST(N'2022-03-11T14:33:39.7331112' AS DateTime2))
INSERT [dbo].[Causes] ([Id], [Image], [Title], [Content], [Address], [CauseNeed], [CreatedDate]) VALUES (11, N'b174258f-36ed-4fb5-a8a1-2322368285b5-20220311143427-full-11.jpg', N'Hospital for bosnian children', N'Sed ut perspiciatis, unde omnis iste natus error sit voluptatem accusantium doloremque laudantium, totam rem aperiam eaque ipsa, quae ab illo inventore veritatis et quasi architecto beatae vitae dicta sunt, explicabo. Nemo enim ipsam voluptatem, quia voluptas sit, aspernatur aut odit aut fugit, sed quia consequuntur magni dolores eos, qui ratione voluptatem sequi nesciunt, neque porro quisquam est, qui dolorem ipsum, quia dolor sit, amet, consectetur, adipisci velit, sed quia non numquam eius modi tempora incidunt, ut labore et dolore magnam aliquam quaerat voluptatem. Ut enim ad minima veniam, quis nostrum exercitationem ullam corporis suscipit laboriosam, nisi ut aliquid ex ea commodi consequatur?', N'NYC 21th street #43', 14000, CAST(N'2022-03-11T14:34:27.8147892' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Causes] OFF
GO
SET IDENTITY_INSERT [dbo].[CauseGalleries] ON 

INSERT [dbo].[CauseGalleries] ([Id], [Image], [CauseId]) VALUES (1, N'1d6e4ec2-1202-47f5-926e-bc97e7da2e77-20220311143447-small1.jpg', 1)
INSERT [dbo].[CauseGalleries] ([Id], [Image], [CauseId]) VALUES (2, N'be902c3a-dd68-4010-9156-422466a9422b-20220311143454-small2.jpg', 2)
INSERT [dbo].[CauseGalleries] ([Id], [Image], [CauseId]) VALUES (3, N'd53b16d6-0914-43f1-bb16-3c670476f36c-20220311143503-small3.jpg', 1)
INSERT [dbo].[CauseGalleries] ([Id], [Image], [CauseId]) VALUES (4, N'c1e66976-afc7-45c2-9a70-03e8e97c16d7-20220311143520-small4.jpg', 3)
INSERT [dbo].[CauseGalleries] ([Id], [Image], [CauseId]) VALUES (5, N'd2156fb0-5e43-4091-b1a5-a4d588b359e2-20220311143531-small3.jpg', 2)
INSERT [dbo].[CauseGalleries] ([Id], [Image], [CauseId]) VALUES (6, N'df96b3ff-5b06-431c-8a95-a52de2d7d6d1-20220311143541-small5.jpg', 1)
INSERT [dbo].[CauseGalleries] ([Id], [Image], [CauseId]) VALUES (7, N'b7fcdf3d-7ec6-4404-813f-6338e321d1a0-20220311143557-small6.jpg', 1)
INSERT [dbo].[CauseGalleries] ([Id], [Image], [CauseId]) VALUES (8, N'416f41fe-05d8-4e26-b937-37cc0324e376-20220311143613-small1.jpg', 2)
INSERT [dbo].[CauseGalleries] ([Id], [Image], [CauseId]) VALUES (9, N'a19006f1-2976-4bdf-a5e4-e4e88b9b7c39-20220311143619-small1.jpg', 4)
INSERT [dbo].[CauseGalleries] ([Id], [Image], [CauseId]) VALUES (10, N'8136950d-d72e-4d50-9c67-4c7711ca6c3e-20220311143625-small2.jpg', 2)
INSERT [dbo].[CauseGalleries] ([Id], [Image], [CauseId]) VALUES (11, N'c21c6157-8a79-4aa4-b9a2-f63fffa537db-20220311143631-small6.jpg', 6)
INSERT [dbo].[CauseGalleries] ([Id], [Image], [CauseId]) VALUES (12, N'39869c24-5955-43c7-8056-bfd0dc0c55b0-20220311143638-small5.jpg', 1)
INSERT [dbo].[CauseGalleries] ([Id], [Image], [CauseId]) VALUES (13, N'104d19b7-84a5-49c0-9676-59fcbde8ab76-20220311143644-small2.jpg', 2)
SET IDENTITY_INSERT [dbo].[CauseGalleries] OFF
GO
SET IDENTITY_INSERT [dbo].[CommentPosts] ON 

INSERT [dbo].[CommentPosts] ([Id], [Name], [Email], [Content]) VALUES (1, N'Punhan', N'punhan@gmail.com', N'Salam.Yardimi nece ede bilerem komek lazimdir.')
INSERT [dbo].[CommentPosts] ([Id], [Name], [Email], [Content]) VALUES (2, N'Asif', N'asif@gmail.com', N'+')
INSERT [dbo].[CommentPosts] ([Id], [Name], [Email], [Content]) VALUES (3, N'Orxan', N'orxan@gmail.com', N'Ne qeder pula ehtiyac var??')
SET IDENTITY_INSERT [dbo].[CommentPosts] OFF
GO
SET IDENTITY_INSERT [dbo].[Comments] ON 

INSERT [dbo].[Comments] ([Id], [Content], [CreatedDate], [ParentCommentId], [CauseId], [CommentPostId]) VALUES (1, N'Salam.Yardimi nece ede bilerem komek lazimdir.', CAST(N'2022-03-11T15:00:09.4593002' AS DateTime2), NULL, 1, 1)
INSERT [dbo].[Comments] ([Id], [Content], [CreatedDate], [ParentCommentId], [CauseId], [CommentPostId]) VALUES (2, N'+', CAST(N'2022-03-11T15:00:40.4348471' AS DateTime2), 1, 1, 2)
INSERT [dbo].[Comments] ([Id], [Content], [CreatedDate], [ParentCommentId], [CauseId], [CommentPostId]) VALUES (3, N'Ne qeder pula ehtiyac var??', CAST(N'2022-03-11T15:01:56.2620396' AS DateTime2), NULL, 2, 3)
SET IDENTITY_INSERT [dbo].[Comments] OFF
GO
SET IDENTITY_INSERT [dbo].[Donates] ON 

INSERT [dbo].[Donates] ([Id], [FName], [LName], [Email], [Phone], [Address], [Not], [CreatedDate]) VALUES (1, N'Eldeniz', N'Besirov', N'eldeniz@gmail.com', N'+9945888828', N'Sumqayit', N'Esq olsun Sumqayitlilara', CAST(N'2022-03-11T16:38:30.5298719' AS DateTime2))
INSERT [dbo].[Donates] ([Id], [FName], [LName], [Email], [Phone], [Address], [Not], [CreatedDate]) VALUES (2, N'Sahib', N'Akbar', N'sahibaa@code.edu.az', N'+9945888829', N'Yasamal', N'Allah saxlasin', CAST(N'2022-03-11T18:40:25.6628129' AS DateTime2))
INSERT [dbo].[Donates] ([Id], [FName], [LName], [Email], [Phone], [Address], [Not], [CreatedDate]) VALUES (3, N'Aytan', N'Abbasova', N'aytanab@code.edu.az', N'+9945251231', N'Emircan', N'Xeyirlikle xercleyin', CAST(N'2022-03-11T21:50:24.2318565' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Donates] OFF
GO
SET IDENTITY_INSERT [dbo].[Prices] ON 

INSERT [dbo].[Prices] ([Id], [Money]) VALUES (1, 100)
INSERT [dbo].[Prices] ([Id], [Money]) VALUES (2, 500)
INSERT [dbo].[Prices] ([Id], [Money]) VALUES (3, 1000)
SET IDENTITY_INSERT [dbo].[Prices] OFF
GO
SET IDENTITY_INSERT [dbo].[DonatePrices] ON 

INSERT [dbo].[DonatePrices] ([Id], [DonateId], [PriceId], [CauseId]) VALUES (1, 1, 3, 1)
INSERT [dbo].[DonatePrices] ([Id], [DonateId], [PriceId], [CauseId]) VALUES (2, 2, 2, 2)
INSERT [dbo].[DonatePrices] ([Id], [DonateId], [PriceId], [CauseId]) VALUES (3, 3, 3, 3)
SET IDENTITY_INSERT [dbo].[DonatePrices] OFF
GO
SET IDENTITY_INSERT [dbo].[Events] ON 

INSERT [dbo].[Events] ([Id], [Image], [Title], [Content], [Address], [IframeLink], [CreatedDate]) VALUES (1, N'544baa8a-de58-48b6-8b09-7d1ed154a994-202203111442SS-full1.jpg', N'Providing water for charity', N'Nonprofit that brings clean and safe drinking water to people in developing countries. 100% of the nonprofit’s public donations go directly to clean water technologies that range from wells to water filtration.

In an effort to change that statistic, we have compiled a list of seven organizations, ranging from nonprofits to good doing companies, who are on a mission to ensure that everyone has drinkable water. Feel free to tell us about other water organizations who are guaranteeing that clean water isn’t a privilege, but a right.', N'1900 W. Field Court, Lake Forest', N'https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d2953.7580197185457!2d-87.89557848468178!3d42.240982379195074!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x880f95a0a9951fb1%3A0xbc2608b079c9e9b2!2zMTkwMCBXIEZpZWxkIEN0LCBMYWtlIEZvcmVzdCwgSUwgNjAwNDUsIEFtZXJpa2EgQmlybMmZxZ9tacWfIMWedGF0bGFyxLE!5e0!3m2!1saz!2s!4v1646995291245!5m2!1saz!2s', CAST(N'2022-03-11T14:42:20.1154646' AS DateTime2))
INSERT [dbo].[Events] ([Id], [Image], [Title], [Content], [Address], [IframeLink], [CreatedDate]) VALUES (2, N'88c43653-836c-4c7f-90f4-57eb71d5db6e-202203111443SS-full2.jpg', N'Fun it forward official charity', N'We wanted to do more, but realistically, we could only do so much. We were actually thinking of doing a repeat of the novels-in-verse theme in the near future, we shall see how that goes.

Better a hand that gives than the one that receiveth. Run it forward to benefit a soul. Sometimes in life you get signs along the way that let’s you know you are on the right path! Believe in yourself and follow your heart! Do the next right thing and always know the best is yet to come!', N'20 S. Wacker Drive, Chicago', N'https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d48625.60582524108!2d49.776006019715005!3d40.384468168275916!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x40307d8c33c62a3f%3A0x77807ca915edd570!2zWWFzYW1hbCwgQmFrxLEsIEF6yZlyYmF5Y2Fu!5e0!3m2!1saz!2s!4v1646522390866!5m2!1saz!2s', CAST(N'2022-03-11T14:43:01.2534625' AS DateTime2))
INSERT [dbo].[Events] ([Id], [Image], [Title], [Content], [Address], [IframeLink], [CreatedDate]) VALUES (3, N'd30b3420-e80d-4d95-b03d-d33926b2de74-202203111443SS-full3.jpg', N'The future for learning', N'Children might be interested in material objects, but you have something much more valuable to offer them: a chance to exercise language skills! Most are delighted to do so, and hand games and high fives are something that can easily be explained in basic English and can be used amongst themselves for days to come.

Giving pens to children in India is a big no no for foreign tourists. Though it may seem an innocent act of goodwill, it has some long-lasting repercussions. Here’s why you should stop giving pens to children in India, and some alternative ways to give to children in the country.', N'1900 W. Field Court, Lake Forest', N'https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3194.5088716871037!2d144.3546696152478!3d-36.80632417994725!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x6ad75c0539940349%3A0x1d6c76f88e40b9c7!2s941%20Wellington%20St%2C%20Strathfieldsaye%20VIC%203551%2C%20Avstraliya!5e0!3m2!1saz!2s!4v1646268523095!5m2!1saz!2s', CAST(N'2022-03-11T14:43:50.0771411' AS DateTime2))
INSERT [dbo].[Events] ([Id], [Image], [Title], [Content], [Address], [IframeLink], [CreatedDate]) VALUES (4, N'10ef74ef-0066-47cf-81cd-0774aa916228-202203111444SS-full4.jpg', N'Gathering books for children', N'Amazingly, the first month of the year is nearly over. Before we know it, December 2012 is upon us! Is it just me or does time seem to be on overdrive lately, zooming and streaking past, leaving specks of dust from unfinished tasks in its wake. Before I get lost in my random ruminations, let me do our very first round-up post for January, which shall likewise be our contribution for the Carnival of Children’s Literature which is hosted this month by Delightful Children’s Books.

Our bimonthly theme for November and December which has a spill-over until the middle of January was on Poetry-Filled Yuletide Cheer. Since we simply love participating in Poetry Fridays, we thought that we might as well allow poetry to overtake our sensibilities and do it on a daily basis. This, by far, is one of my absolute favorite bimonthly themes. It gave me so much joy to review quite a number of novels-in-verse. We wanted to do more, but realistically, we could only do so much. We were actually thinking of doing a repeat of the novels-in-verse theme in the near future, we shall see how that goes.

This, by far, is one of my absolute favorite bimonthly themes. It gave me so much joy to review quite a number of novels-in-verse. We wanted to do more, but realistically, we could only do so much. We were actually thinking of doing a repeat of the novels-in-verse theme in the near future, we shall see how that goes.', N'1900 W. Field Court, Lake Forest', N'https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d48625.60582524108!2d49.776006019715005!3d40.384468168275916!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x40307d8c33c62a3f%3A0x77807ca915edd570!2zWWFzYW1hbCwgQmFrxLEsIEF6yZlyYmF5Y2Fu!5e0!3m2!1saz!2s!4v1646522390866!5m2!1saz!2s', CAST(N'2022-03-11T14:44:24.6679147' AS DateTime2))
INSERT [dbo].[Events] ([Id], [Image], [Title], [Content], [Address], [IframeLink], [CreatedDate]) VALUES (5, N'12d58d57-5d0e-4115-a2ef-907885bc0c8b-202203111445SS-detail1.jpg', N'Providing pens for children', N'Children might be interested in material objects, but you have something much more valuable to offer them: a chance to exercise language skills! Most are delighted to do so, and hand games and high fives are something that can easily be explained in basic English and can be used amongst themselves for days to come.

Giving pens to children in India is a big no no for foreign tourists. Though it may seem an innocent act of goodwill, it has some long-lasting repercussions. Here’s why you should stop giving pens to children in India, and some alternative ways to give to children in the country.', N'142 Santa Monica, LA, USA', N'https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3194.5088716871037!2d144.3546696152478!3d-36.80632417994725!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x6ad75c0539940349%3A0x1d6c76f88e40b9c7!2s941%20Wellington%20St%2C%20Strathfieldsaye%20VIC%203551%2C%20Avstraliya!5e0!3m2!1saz!2s!4v1646268523095!5m2!1saz!2s', CAST(N'2022-03-11T14:45:12.8867390' AS DateTime2))
INSERT [dbo].[Events] ([Id], [Image], [Title], [Content], [Address], [IframeLink], [CreatedDate]) VALUES (6, N'c9f63613-5b43-437a-b71b-c223c8417a97-202203111446SS-full5.png', N'How to become a good volunteer', N'Be dependable. Do what you say you''ll do, and do your best. Don''t show up late, and always keep your promises. People will be relying on you so you don''t want to let them down. Be enthusiastic. Don''t moan and groan your way through your volunteer work. If you really don''t like what you''re doing, find something else. Always have a positive attitude and show others that you''re doing this because you WANT to.

Volunteering is fun and rewarding, but it’s also a little more complicated than just showing up and having a good time. Here’s some advice on how to make the most of your volunteer work:

Be selfless. Selfless is the opposite of selfish. Don’t think about what you can do to help yourself. Think about what you can do to help others. Be well-trained. Know what you’re doing as a volunteer. If you need some time to learn your job, take that time. If you need training or need someone to show you what you’re supposed to do, speak up. If you’re good at your job, it will be much easier to help others (plus you’ll have a lot more fun).', N' 142 Santa Monica, LA, USA', N'https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d48625.60582524107!2d49.77600601971502!3d40.38446816827592!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x40307d8c33c62a3f%3A0x77807ca915edd570!2zWWFzYW1hbCwgQmFrxLEsIEF6yZlyYmF5Y2Fu!5e0!3m2!1saz!2s!4v1646995568067!5m2!1saz!2s', CAST(N'2022-03-11T14:46:40.3273209' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Events] OFF
GO
SET IDENTITY_INSERT [dbo].[TagEvents] ON 

INSERT [dbo].[TagEvents] ([Id], [Name]) VALUES (1, N'non profit')
INSERT [dbo].[TagEvents] ([Id], [Name]) VALUES (2, N'volunteer')
INSERT [dbo].[TagEvents] ([Id], [Name]) VALUES (3, N'charity')
INSERT [dbo].[TagEvents] ([Id], [Name]) VALUES (4, N'children')
SET IDENTITY_INSERT [dbo].[TagEvents] OFF
GO
SET IDENTITY_INSERT [dbo].[TagToEvents] ON 

INSERT [dbo].[TagToEvents] ([Id], [EventId], [TagEventId]) VALUES (1, 1, 1)
INSERT [dbo].[TagToEvents] ([Id], [EventId], [TagEventId]) VALUES (2, 1, 4)
INSERT [dbo].[TagToEvents] ([Id], [EventId], [TagEventId]) VALUES (3, 2, 4)
INSERT [dbo].[TagToEvents] ([Id], [EventId], [TagEventId]) VALUES (4, 3, 2)
INSERT [dbo].[TagToEvents] ([Id], [EventId], [TagEventId]) VALUES (5, 3, 3)
INSERT [dbo].[TagToEvents] ([Id], [EventId], [TagEventId]) VALUES (6, 4, 2)
INSERT [dbo].[TagToEvents] ([Id], [EventId], [TagEventId]) VALUES (7, 4, 4)
INSERT [dbo].[TagToEvents] ([Id], [EventId], [TagEventId]) VALUES (8, 5, 1)
INSERT [dbo].[TagToEvents] ([Id], [EventId], [TagEventId]) VALUES (9, 5, 2)
INSERT [dbo].[TagToEvents] ([Id], [EventId], [TagEventId]) VALUES (10, 5, 3)
INSERT [dbo].[TagToEvents] ([Id], [EventId], [TagEventId]) VALUES (11, 5, 4)
INSERT [dbo].[TagToEvents] ([Id], [EventId], [TagEventId]) VALUES (12, 6, 1)
INSERT [dbo].[TagToEvents] ([Id], [EventId], [TagEventId]) VALUES (13, 6, 2)
INSERT [dbo].[TagToEvents] ([Id], [EventId], [TagEventId]) VALUES (14, 6, 3)
SET IDENTITY_INSERT [dbo].[TagToEvents] OFF
GO
SET IDENTITY_INSERT [dbo].[AboutOptions] ON 

INSERT [dbo].[AboutOptions] ([Id], [Icon], [Title], [Subtitle]) VALUES (1, N'fas fa-leaf', N'LIFE SAVING', N'dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor')
INSERT [dbo].[AboutOptions] ([Id], [Icon], [Title], [Subtitle]) VALUES (2, N'fas fa-heart', N'LIFE SAVING', N'dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor')
INSERT [dbo].[AboutOptions] ([Id], [Icon], [Title], [Subtitle]) VALUES (3, N'fas fa-gift', N'ADOPTING', N'dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor')
INSERT [dbo].[AboutOptions] ([Id], [Icon], [Title], [Subtitle]) VALUES (4, N'fas fa-thumbs-up', N'HELPING PEOPLE', N'dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor')
SET IDENTITY_INSERT [dbo].[AboutOptions] OFF
GO
SET IDENTITY_INSERT [dbo].[Abouts] ON 

INSERT [dbo].[Abouts] ([Id], [Image], [Title], [SubTitle]) VALUES (1, N'99901650-7685-40ac-a201-a90c1257daa3-20220310182638-life.png', N'WHO ARE WHERE?', N'Lorem ipsum dolor sit amet, consetetur sadipscing elitr, sed diam nonumy eirmod tempor invidunt ut labore et dolore magna aliquyam erat, sed diam voluptua. At vero eos et accusam et justo duo dolores et ea rebum. Stet clita kasd gubergren, no sea takimata sanctus est Lorem ipsum dolor sit amet.')
SET IDENTITY_INSERT [dbo].[Abouts] OFF
GO
SET IDENTITY_INSERT [dbo].[Banners] ON 

INSERT [dbo].[Banners] ([Id], [Image], [Name]) VALUES (1, N'8b25e28e-7fd8-46a7-9d1f-4a4b16f903e7-20220310170319-banner.jpg', N'About')
SET IDENTITY_INSERT [dbo].[Banners] OFF
GO
SET IDENTITY_INSERT [dbo].[Contacts] ON 

INSERT [dbo].[Contacts] ([Id], [Name], [Email], [Phone], [Message], [CreatedDate]) VALUES (1, N'Sahib', N'sahibaa@code.edu.az', N'+994514940818', N'Admin ellerve saglig beyendim :)', CAST(N'2022-03-11T15:03:06.3565267' AS DateTime2))
INSERT [dbo].[Contacts] ([Id], [Name], [Email], [Phone], [Message], [CreatedDate]) VALUES (2, N'Orxan Amirli', N'orxan@gmail.com', N'+994559994323', N'Elaqe nece saxlaya bilerem?
', CAST(N'2022-03-11T15:03:42.4094846' AS DateTime2))
INSERT [dbo].[Contacts] ([Id], [Name], [Email], [Phone], [Message], [CreatedDate]) VALUES (3, N'Rauf Rzayev', N'rauf@gmail.com', N'+994777666321', N'Bura haradi?', CAST(N'2022-03-11T15:04:14.0193251' AS DateTime2))
INSERT [dbo].[Contacts] ([Id], [Name], [Email], [Phone], [Message], [CreatedDate]) VALUES (4, N'Punhan Sahmurov', N'punhanash@code.edu.az', N'+9941247887', N'Sumqayitada gozleyirem.', CAST(N'2022-03-11T15:06:18.5313825' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Contacts] OFF
GO
SET IDENTITY_INSERT [dbo].[FAQs] ON 

INSERT [dbo].[FAQs] ([Id], [Title], [Content]) VALUES (1, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore ', N'<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Nullam tortor nunc, bibendum vitae semper a, volutpat eget massa. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer fringilla, orci sit amet posuere auctor, orci eros pellentesque odio, nec pellentesque erat ligula nec massa. Aenean consequat lorem ut felis ullamcorper posuere gravida tellus faucibus. Maecenas dolor elit, pulvinar eu vehicula eu, consequat et lacus.</p>

<p>Duis et purus ipsum. In auctor mattis ipsum id molestie. Donec risus nulla, fringilla a rhoncus vitae, semper a massa. Vivamus ullamcorper, enim sit amet consequat laoreet, tortor tortor dictum urna, ut egestas urna ipsum nec libero. Nulla justo leo, molestie vel tempor nec, egestas at massa. Aenean pulvinar, felis</p>
')
INSERT [dbo].[FAQs] ([Id], [Title], [Content]) VALUES (2, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore ', N'<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Nullam tortor nunc, bibendum vitae semper a, volutpat eget massa. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer fringilla, orci sit amet posuere auctor, orci eros pellentesque odio, nec pellentesque erat ligula nec massa. Aenean consequat lorem ut felis ullamcorper posuere gravida tellus faucibus. Maecenas dolor elit, pulvinar eu vehicula eu, consequat et lacus.</p>

<p>Duis et purus ipsum. In auctor mattis ipsum id molestie. Donec risus nulla, fringilla a rhoncus vitae, semper a massa. Vivamus ullamcorper, enim sit amet consequat laoreet, tortor tortor dictum urna, ut egestas urna ipsum nec libero. Nulla justo leo, molestie vel tempor nec, egestas at massa. Aenean pulvinar, felis</p>
')
INSERT [dbo].[FAQs] ([Id], [Title], [Content]) VALUES (3, N'Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore ', N'<p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Curabitur eget leo at velit imperdiet varius. In eu ipsum vitae velit congue iaculis vitae at risus. Nullam tortor nunc, bibendum vitae semper a, volutpat eget massa. Lorem ipsum dolor sit amet, consectetur adipiscing elit. Integer fringilla, orci sit amet posuere auctor, orci eros pellentesque odio, nec pellentesque erat ligula nec massa. Aenean consequat lorem ut felis ullamcorper posuere gravida tellus faucibus. Maecenas dolor elit, pulvinar eu vehicula eu, consequat et lacus.</p>

<p>Duis et purus ipsum. In auctor mattis ipsum id molestie. Donec risus nulla, fringilla a rhoncus vitae, semper a massa. Vivamus ullamcorper, enim sit amet consequat laoreet, tortor tortor dictum urna, ut egestas urna ipsum nec libero. Nulla justo leo, molestie vel tempor nec, egestas at massa. Aenean pulvinar, felis</p>
')
SET IDENTITY_INSERT [dbo].[FAQs] OFF
GO
SET IDENTITY_INSERT [dbo].[HappyFaces] ON 

INSERT [dbo].[HappyFaces] ([Id], [Image]) VALUES (1, N'd5931f83-4cbc-4c32-a4d3-75d0dd5b3aea-20220310170329-1.jpg')
INSERT [dbo].[HappyFaces] ([Id], [Image]) VALUES (2, N'83df42ae-178e-46ba-87bb-6cc2e61307f1-20220310170335-2.jpg')
INSERT [dbo].[HappyFaces] ([Id], [Image]) VALUES (3, N'cc9d5d76-8708-44d2-85be-30efb037de31-20220310170340-3.jpg')
INSERT [dbo].[HappyFaces] ([Id], [Image]) VALUES (4, N'f0e61791-3b6b-4d0d-a46c-a115ee66beed-20220310170345-4.jpg')
INSERT [dbo].[HappyFaces] ([Id], [Image]) VALUES (5, N'cf705780-ffa3-46ae-b52c-7c9a65e5a5a7-20220310170349-5.jpg')
INSERT [dbo].[HappyFaces] ([Id], [Image]) VALUES (6, N'2fb1baeb-d8df-4f88-bb93-d9d80bdecb58-20220310170354-6.jpg')
SET IDENTITY_INSERT [dbo].[HappyFaces] OFF
GO
SET IDENTITY_INSERT [dbo].[HomeSliders] ON 

INSERT [dbo].[HomeSliders] ([Id], [Title], [SubTitle], [Image]) VALUES (1, N'Save the Life ', N'Help People for their needs all over the world! ', N'8a66e07f-6d2b-4d4d-b485-0920c2f9fa42-20220311035436-banner-slider2.jpg')
INSERT [dbo].[HomeSliders] ([Id], [Title], [SubTitle], [Image]) VALUES (2, N'Help People', N'All of our afford can bring back the life ', N'ef533ca1-261b-4184-a9b3-cf40f38d9dd3-20220311035529-banner-slider1.jpg')
SET IDENTITY_INSERT [dbo].[HomeSliders] OFF
GO
SET IDENTITY_INSERT [dbo].[Partners] ON 

INSERT [dbo].[Partners] ([Id], [Image]) VALUES (1, N'b81ad223-1801-42d6-a94c-b9489a5bb6e2-20220311035305-1.png')
INSERT [dbo].[Partners] ([Id], [Image]) VALUES (2, N'beee250d-8e8a-453c-a80b-a30d1df00023-20220311035310-2.png')
INSERT [dbo].[Partners] ([Id], [Image]) VALUES (3, N'313cc6b3-3393-4d88-9bf0-58d9269b737c-20220311035316-3.png')
INSERT [dbo].[Partners] ([Id], [Image]) VALUES (4, N'e4bcc1a2-5ca7-4513-8e7e-9baf059f3054-20220311035321-4.png')
SET IDENTITY_INSERT [dbo].[Partners] OFF
GO
SET IDENTITY_INSERT [dbo].[Settings] ON 

INSERT [dbo].[Settings] ([Id], [Logo], [Email], [Phone], [Adress], [IframeLink]) VALUES (1, N'2315aed5-32ec-450c-a451-b83e3b1a5304-20220311150532-logo.png', N'info@giving.com', N' 800 516 3290', N'12 Ave., New York', N'https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3039.428674496238!2d49.85175681525654!3d40.37719087936978!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x40307d079efb5163%3A0xc20aa51a5f0b5e01!2sCode%20Academy!5e0!3m2!1saz!2s!4v1646996707546!5m2!1saz!2s')
SET IDENTITY_INSERT [dbo].[Settings] OFF
GO
SET IDENTITY_INSERT [dbo].[Socials] ON 

INSERT [dbo].[Socials] ([Id], [Icon], [Link]) VALUES (1, N'fab fa-facebook-f', N'facebook.com')
INSERT [dbo].[Socials] ([Id], [Icon], [Link]) VALUES (2, N'fab fa-twitter', N'twitter.com')
INSERT [dbo].[Socials] ([Id], [Icon], [Link]) VALUES (3, N'fab fa-google-plus-g', N'google.com')
INSERT [dbo].[Socials] ([Id], [Icon], [Link]) VALUES (4, N'fab fa-youtube', N'youtube.com')
INSERT [dbo].[Socials] ([Id], [Icon], [Link]) VALUES (5, N'fab fa-linkedin-in', N'linkedin.com')
INSERT [dbo].[Socials] ([Id], [Icon], [Link]) VALUES (6, N'fas fa-rss', N'rss.com')
SET IDENTITY_INSERT [dbo].[Socials] OFF
GO
SET IDENTITY_INSERT [dbo].[Subscribes] ON 

INSERT [dbo].[Subscribes] ([Id], [Email], [CreatedDate]) VALUES (1, N'sahibaa@code.edu.az', CAST(N'2022-03-11T14:58:17.0447427' AS DateTime2))
INSERT [dbo].[Subscribes] ([Id], [Email], [CreatedDate]) VALUES (2, N'punhansh@code.edu.az', CAST(N'2022-03-11T14:58:36.9735895' AS DateTime2))
INSERT [dbo].[Subscribes] ([Id], [Email], [CreatedDate]) VALUES (3, N'nahid.ekberov65@gmail.com', CAST(N'2022-03-11T14:58:45.3049969' AS DateTime2))
INSERT [dbo].[Subscribes] ([Id], [Email], [CreatedDate]) VALUES (4, N'orkhanea@gmail.com', CAST(N'2022-03-11T14:59:22.3137900' AS DateTime2))
INSERT [dbo].[Subscribes] ([Id], [Email], [CreatedDate]) VALUES (5, N'hasanov@gmail.com', CAST(N'2022-03-11T16:39:02.3828074' AS DateTime2))
SET IDENTITY_INSERT [dbo].[Subscribes] OFF
GO
SET IDENTITY_INSERT [dbo].[Volunteers] ON 

INSERT [dbo].[Volunteers] ([Id], [Image], [Name], [Position], [Description], [Experience], [DonaterTitle], [DonaterCount], [VoluteerTitle], [VoluteerCount]) VALUES (1, N'ae1e97e7-12e1-48f1-b377-504cca0ba45c-20220311144819-1.png', N' JOHN DOE', N'Head volunteer', N'At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis um voluptatum deleniti atque orrupti quos dolores et quas molestias. Excepturi sint occaecati cupiditate. At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis um voluptatum deleniti atque orrupti quos dolores et quas molestias. Excepturi sint occaecati cupiditate. Excepturi sint occaecati cupiditate. At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis um voluptatum deleniti atque orrupti quos dolores et quas molestias.', N'18', N'At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis um voluptatum deleniti atque orrupti quos', N'2500', N'At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis um voluptatum deleniti atque orrupti quos', N'5')
INSERT [dbo].[Volunteers] ([Id], [Image], [Name], [Position], [Description], [Experience], [DonaterTitle], [DonaterCount], [VoluteerTitle], [VoluteerCount]) VALUES (2, N'0afc5bf3-8085-44d6-a6dd-c40065ebadc8-20220311144851-2.png', N' MARY DOE', N'Head volunteer', N'At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis um voluptatum deleniti atque orrupti quos dolores et quas molestias. Excepturi sint occaecati cupiditate. At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis um voluptatum deleniti atque orrupti quos dolores et quas molestias. Excepturi sint occaecati cupiditate. Excepturi sint occaecati cupiditate. At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis um voluptatum deleniti atque orrupti quos dolores et quas molestias.', N'10 ', N'At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis um voluptatum deleniti atque orrupti quos', N'2200', N'At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis um voluptatum deleniti atque orrupti quos', N'6')
INSERT [dbo].[Volunteers] ([Id], [Image], [Name], [Position], [Description], [Experience], [DonaterTitle], [DonaterCount], [VoluteerTitle], [VoluteerCount]) VALUES (3, N'9dfbde41-56e9-44b3-b4b0-11e40a8a06b2-20220311144927-3.png', N' JENNY SIMPSON', N'Head volunteer', N'At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis um voluptatum deleniti atque orrupti quos dolores et quas molestias. Excepturi sint occaecati cupiditate. At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis um voluptatum deleniti atque orrupti quos dolores et quas molestias. Excepturi sint occaecati cupiditate. Excepturi sint occaecati cupiditate. At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis um voluptatum deleniti atque orrupti quos dolores et quas molestias.', N'10 ', N'At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis um voluptatum deleniti atque orrupti quos', N'2500', N'At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis um voluptatum deleniti atque orrupti quos', N'5')
INSERT [dbo].[Volunteers] ([Id], [Image], [Name], [Position], [Description], [Experience], [DonaterTitle], [DonaterCount], [VoluteerTitle], [VoluteerCount]) VALUES (4, N'721eb1b9-d54c-40dd-85fa-e71048415d43-20220311145006-4.png', N'MAXY RODRIGES', N'Head volunteer', N'At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis um voluptatum deleniti atque orrupti quos dolores et quas molestias. Excepturi sint occaecati cupiditate. At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis um voluptatum deleniti atque orrupti quos dolores et quas molestias. Excepturi sint occaecati cupiditate. Excepturi sint occaecati cupiditate. At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis um voluptatum deleniti atque orrupti quos dolores et quas molestias.', N'2 ', N'At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis um voluptatum deleniti atque orrupti quos', N'2200', N'At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis um voluptatum deleniti atque orrupti quos', N'4')
INSERT [dbo].[Volunteers] ([Id], [Image], [Name], [Position], [Description], [Experience], [DonaterTitle], [DonaterCount], [VoluteerTitle], [VoluteerCount]) VALUES (5, N'c9be7027-4171-439a-86c6-a599a5e1d7bc-20220311145037-5.png', N' NATALY SMITH', N'Head volunteer', N'At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis um voluptatum deleniti atque orrupti quos dolores et quas molestias. Excepturi sint occaecati cupiditate. At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis um voluptatum deleniti atque orrupti quos dolores et quas molestias. Excepturi sint occaecati cupiditate. Excepturi sint occaecati cupiditate. At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis um voluptatum deleniti atque orrupti quos dolores et quas molestias.', N'18', N'At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis um voluptatum deleniti atque orrupti quos', N'2200', N'At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis um voluptatum deleniti atque orrupti quos', N'6')
INSERT [dbo].[Volunteers] ([Id], [Image], [Name], [Position], [Description], [Experience], [DonaterTitle], [DonaterCount], [VoluteerTitle], [VoluteerCount]) VALUES (6, N'70b76711-2fa1-4004-b8ea-c242cef641e9-20220311145107-6.png', N'ANN MCFERSON', N'Head volunteer', N'At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis um voluptatum deleniti atque orrupti quos dolores et quas molestias. Excepturi sint occaecati cupiditate. At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis um voluptatum deleniti atque orrupti quos dolores et quas molestias. Excepturi sint occaecati cupiditate. Excepturi sint occaecati cupiditate. At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis um voluptatum deleniti atque orrupti quos dolores et quas molestias.', N'10 ', N'At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis um voluptatum deleniti atque orrupti quos', N'2200', N'At vero eos et accusamus et iusto odio dignissimos ducimus qui blanditiis um voluptatum deleniti atque orrupti quos', N'4')
SET IDENTITY_INSERT [dbo].[Volunteers] OFF
GO
