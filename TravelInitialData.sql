USE [TravelAgencyDb]
GO
SET IDENTITY_INSERT [dbo].[Destinations] ON 

INSERT [dbo].[Destinations] ([DestinationId], [Country], [Distance], [LuxuryFactor]) VALUES (1, N'Monaco', 1300, 10)
INSERT [dbo].[Destinations] ([DestinationId], [Country], [Distance], [LuxuryFactor]) VALUES (2, N'France', 1436, 8)
INSERT [dbo].[Destinations] ([DestinationId], [Country], [Distance], [LuxuryFactor]) VALUES (3, N'Portugal', 2751, 7)
INSERT [dbo].[Destinations] ([DestinationId], [Country], [Distance], [LuxuryFactor]) VALUES (4, N'Turkey', 897, 7)
INSERT [dbo].[Destinations] ([DestinationId], [Country], [Distance], [LuxuryFactor]) VALUES (5, N'Egypt', 1920, 5)
INSERT [dbo].[Destinations] ([DestinationId], [Country], [Distance], [LuxuryFactor]) VALUES (6, N'Cyprus', 1240, 6)
INSERT [dbo].[Destinations] ([DestinationId], [Country], [Distance], [LuxuryFactor]) VALUES (7, N'Italy', 780, 8)
INSERT [dbo].[Destinations] ([DestinationId], [Country], [Distance], [LuxuryFactor]) VALUES (9, N'Spain', 1745, 7)
INSERT [dbo].[Destinations] ([DestinationId], [Country], [Distance], [LuxuryFactor]) VALUES (10, N'U.A.E', 3492, 9)
SET IDENTITY_INSERT [dbo].[Destinations] OFF
SET IDENTITY_INSERT [dbo].[Guides] ON 

INSERT [dbo].[Guides] ([GuideId], [Name], [Experience]) VALUES (1, N'Peter Moore', 7)
INSERT [dbo].[Guides] ([GuideId], [Name], [Experience]) VALUES (2, N'Tom Cruze', 2)
INSERT [dbo].[Guides] ([GuideId], [Name], [Experience]) VALUES (3, N'John Smith', 9)
INSERT [dbo].[Guides] ([GuideId], [Name], [Experience]) VALUES (4, N'Penelope Cruz', 10)
INSERT [dbo].[Guides] ([GuideId], [Name], [Experience]) VALUES (5, N'Halle Berry', 5)
INSERT [dbo].[Guides] ([GuideId], [Name], [Experience]) VALUES (6, N'Keira Knightley', 10)
INSERT [dbo].[Guides] ([GuideId], [Name], [Experience]) VALUES (7, N'Milles Teller', 4)
INSERT [dbo].[Guides] ([GuideId], [Name], [Experience]) VALUES (8, N'Marion Cotillard', 7)
INSERT [dbo].[Guides] ([GuideId], [Name], [Experience]) VALUES (9, N'Tom John', 5)
INSERT [dbo].[Guides] ([GuideId], [Name], [Experience]) VALUES (10, N'Kimberly Elise', 7)
SET IDENTITY_INSERT [dbo].[Guides] OFF
SET IDENTITY_INSERT [dbo].[Transports] ON 

INSERT [dbo].[Transports] ([TransportId], [CompanyName], [Type]) VALUES (2, N'Qatar Airways', 1)
INSERT [dbo].[Transports] ([TransportId], [CompanyName], [Type]) VALUES (3, N'Singapore Airlines', 1)
INSERT [dbo].[Transports] ([TransportId], [CompanyName], [Type]) VALUES (4, N'Turkish Airlines', 1)
INSERT [dbo].[Transports] ([TransportId], [CompanyName], [Type]) VALUES (6, N'Etihad Airways', 1)
INSERT [dbo].[Transports] ([TransportId], [CompanyName], [Type]) VALUES (7, N'Air France', 1)
INSERT [dbo].[Transports] ([TransportId], [CompanyName], [Type]) VALUES (8, N'ANA All Nippon Airways', 1)
INSERT [dbo].[Transports] ([TransportId], [CompanyName], [Type]) VALUES (9, N'British Airways', 1)
INSERT [dbo].[Transports] ([TransportId], [CompanyName], [Type]) VALUES (10, N'AirAsia', 1)
INSERT [dbo].[Transports] ([TransportId], [CompanyName], [Type]) VALUES (12, N'Virgin America', 1)
INSERT [dbo].[Transports] ([TransportId], [CompanyName], [Type]) VALUES (13, N'Viking Ocean Cruises', 2)
INSERT [dbo].[Transports] ([TransportId], [CompanyName], [Type]) VALUES (14, N'Windstar Cruises', 2)
INSERT [dbo].[Transports] ([TransportId], [CompanyName], [Type]) VALUES (15, N'Crystal Cruises', 2)
INSERT [dbo].[Transports] ([TransportId], [CompanyName], [Type]) VALUES (16, N'Royal Caribbean International', 2)
INSERT [dbo].[Transports] ([TransportId], [CompanyName], [Type]) VALUES (17, N'Azamara Club Cruises', 2)
INSERT [dbo].[Transports] ([TransportId], [CompanyName], [Type]) VALUES (18, N'Un-Cruise Adventures', 2)
INSERT [dbo].[Transports] ([TransportId], [CompanyName], [Type]) VALUES (20, N'Carnival Cruise Line', 2)
INSERT [dbo].[Transports] ([TransportId], [CompanyName], [Type]) VALUES (21, N'Etap', 0)
INSERT [dbo].[Transports] ([TransportId], [CompanyName], [Type]) VALUES (22, N'Trans Five', 0)
INSERT [dbo].[Transports] ([TransportId], [CompanyName], [Type]) VALUES (23, N'Biomet Transports', 0)
INSERT [dbo].[Transports] ([TransportId], [CompanyName], [Type]) VALUES (24, N'Panalpina', 0)
INSERT [dbo].[Transports] ([TransportId], [CompanyName], [Type]) VALUES (25, N'C.H. Robinson', 0)
INSERT [dbo].[Transports] ([TransportId], [CompanyName], [Type]) VALUES (26, N'Kuehne + Nagel', 0)
SET IDENTITY_INSERT [dbo].[Transports] OFF
SET IDENTITY_INSERT [dbo].[Excursions] ON 

INSERT [dbo].[Excursions] ([ExcursionId], [Name], [StartDate], [EndDate], [DestinationId], [Clients], [PricePerClient], [TransportId], [GuideId], [ExpenseId]) VALUES (2, N'Sea Holiday', CAST(N'2015-08-10 00:00:00.000' AS DateTime), CAST(N'2015-08-20 00:00:00.000' AS DateTime), 6, 50, 895.0000, 9, 1, NULL)
INSERT [dbo].[Excursions] ([ExcursionId], [Name], [StartDate], [EndDate], [DestinationId], [Clients], [PricePerClient], [TransportId], [GuideId], [ExpenseId]) VALUES (3, N'Visit Monaco', CAST(N'2015-08-20 00:00:00.000' AS DateTime), CAST(N'2015-08-24 00:00:00.000' AS DateTime), 1, 15, 4500.0000, 1, 2, NULL)
INSERT [dbo].[Excursions] ([ExcursionId], [Name], [StartDate], [EndDate], [DestinationId], [Clients], [PricePerClient], [TransportId], [GuideId], [ExpenseId]) VALUES (4, N'Find the love in Paris', CAST(N'2015-08-15 00:00:00.000' AS DateTime), CAST(N'2015-08-23 00:00:00.000' AS DateTime), 2, 27, 1555.0000, 1, 4, NULL)
INSERT [dbo].[Excursions] ([ExcursionId], [Name], [StartDate], [EndDate], [DestinationId], [Clients], [PricePerClient], [TransportId], [GuideId], [ExpenseId]) VALUES (5, N'Surf in the Atlantic ocean', CAST(N'2015-08-21 00:00:00.000' AS DateTime), CAST(N'2015-08-27 00:00:00.000' AS DateTime), 3, 32, 2220.0000, 4, 1, NULL)
INSERT [dbo].[Excursions] ([ExcursionId], [Name], [StartDate], [EndDate], [DestinationId], [Clients], [PricePerClient], [TransportId], [GuideId], [ExpenseId]) VALUES (6, N'Sea Holiday', CAST(N'2015-09-01 00:00:00.000' AS DateTime), CAST(N'2015-09-07 00:00:00.000' AS DateTime), 6, 45, 875.0000, 9, 5, NULL)
INSERT [dbo].[Excursions] ([ExcursionId], [Name], [StartDate], [EndDate], [DestinationId], [Clients], [PricePerClient], [TransportId], [GuideId], [ExpenseId]) VALUES (8, N'Visit the Pyramids', CAST(N'2015-09-05 00:00:00.000' AS DateTime), CAST(N'2015-09-13 00:00:00.000' AS DateTime), 5, 75, 650.0000, 2, 8, NULL)
INSERT [dbo].[Excursions] ([ExcursionId], [Name], [StartDate], [EndDate], [DestinationId], [Clients], [PricePerClient], [TransportId], [GuideId], [ExpenseId]) VALUES (10, N'All Inclusive drinking', CAST(N'2015-09-11 00:00:00.000' AS DateTime), CAST(N'2015-09-20 00:00:00.000' AS DateTime), 4, 105, 777.0000, 25, 2, NULL)
INSERT [dbo].[Excursions] ([ExcursionId], [Name], [StartDate], [EndDate], [DestinationId], [Clients], [PricePerClient], [TransportId], [GuideId], [ExpenseId]) VALUES (12, N'Visit cote d''azur', CAST(N'2015-09-20 00:00:00.000' AS DateTime), CAST(N'2015-09-27 00:00:00.000' AS DateTime), 2, 66, 1200.0000, 26, 4, NULL)
INSERT [dbo].[Excursions] ([ExcursionId], [Name], [StartDate], [EndDate], [DestinationId], [Clients], [PricePerClient], [TransportId], [GuideId], [ExpenseId]) VALUES (13, N'Visit all Italian ports', CAST(N'2015-09-14 00:00:00.000' AS DateTime), CAST(N'2015-09-24 00:00:00.000' AS DateTime), 7, 150, 1050.0000, 15, 7, NULL)
INSERT [dbo].[Excursions] ([ExcursionId], [Name], [StartDate], [EndDate], [DestinationId], [Clients], [PricePerClient], [TransportId], [GuideId], [ExpenseId]) VALUES (14, N'Visit Lisbon', CAST(N'2015-09-23 00:00:00.000' AS DateTime), CAST(N'2015-09-30 00:00:00.000' AS DateTime), 3, 84, 1989.0000, 4, 1, NULL)
SET IDENTITY_INSERT [dbo].[Excursions] OFF
INSERT [dbo].[__MigrationHistory] ([MigrationId], [ContextKey], [Model], [ProductVersion]) VALUES (N'201510170956257_InitialCreate', N'TravelAgency.Data.TarvelAgencyDbContext', 0x1F8B0800000000000400DD5C5B6FE336167E2FB0FF41D06331B59D0C8A4E03BB45EA24DD602793609C29FA163012ED082B515A8A0A6C2CF697ED437F52FF42A91BCDBB45C9974C51A07078393C3CE7E3E121F571FEFCFF1FD39FD749ECBD429C47299AF967A389EF4114A461845633BF20CBEF3EF83FFFF48F6FA6D761B2F67E6BDBBD2FDBD19E289FF92F846417E3711EBCC004E4A3240A709AA74B320AD2640CC2747C3E99FC383E3B1B432AC2A7B23C6FFAB940244A60F507FD739EA20066A400F15D1AC2386FCA69CDA292EA7D0209CC3310C099FF88C12B8C2F5754CBCDE80A10E07B977104A8220B182F7D0F20941240A89A175F72B8203845AB45460B40FCB8C9206DB704710E1BF52FB6CDBBCE64725ECE64BCEDD88A0A8A9CA489A3C0B3F78D69C672F75E06F699E9A8F1AEA991C9A69C7565C0997F057312A146BA3CDEC53CC6655BC9C49547465CCF779E5AFF8E418322A8FCEF9D372F6252603843B02018D0160FC5731C05FF829BC7F4DF10CD5011C7BCB6545F5A2714D0A2079C661093CD67B854E7701BFADE58143196653009FAEEF5846F11797FEE7B9FA84AE039860C229C711624C5F05788200604860F801088A9876F4358195951441A769E52C4E34D3B2085255D60BE7707D61F215A919799FFC3F7BE7713AD61D816343A7C41115D8EB40FC105DC35CC55941340D7523BCE554A8D0E3533B38BF958AC0BBCB901019DF42E1B49923E81D76855994C9279BD0E8A0A22B9EF7D8671D5247F89B27ADD8E58F59300D21B9C269FD398EFCF37787A04780509D531B5B55AA4050E245DA7E3EDF2B02E1A26D271C9B07E275E304C8F3ECB45E87CACC552FEDFB252BE9F745A298E985F108009DD4FB66B87FE7E8C929D1DAF51D8A79B5320DA115CE2881A361F26E40147017C80B816C66603832801B1EF3D60FAAB49123EF8DE2200A564F761E852407996623274D2BF165108870AB95E6710E5EE628C514E085EFB0B736D00B387B93618760FC9D5EC0D8A56754F5CF4E395942A3571586EA18BC136E52AFF6A55AB6A9EF8FD64AB995CA728A63470D58B0158AB1BAB35E8A7AB5774D4361AB887359E76DCC1AA5E27DFBFD81A75DFBDFA2D6F49CC3F5302E346567EF8C8B8FF91762765FB88016A903245895E186E02821382AB3E27C62FDBA85CD1DB7187FBCAF3AE122598A61CDB43CB814F1A4EDB878C69E3FED20BD2DC5EE2046BD6EFC4D016923957783B6482FB3C872719409B9320BD1C8E0D2A240B75CDA100DF2B2791816F4D5CBA81BF4874D0AFE77E9BDFC460B5BD9CEBB71CCA16FB5C12D4E121C4F186E28307A8E8963B983C43DC4CEB97829AF6371017F4F744F1A0D0F432C2590C1064EDCFECED17D4A3ACEDB96AF4DABC7CE1659EA74154D94F468A70FC1007A5E759AFD359640B642E41B8A3768D326A490A8199FFAD32A55DD2592EBC952E9C9444F967BE1CA4EED1158C2181DE6550DFC1CE411E80505D4DD462A15842E31AC4651801F19CA29BC22242440D82110AA20CC45D66217576BFCF2CF56423CA355790E65765DCEBE2AEBDA8C246944CB9CB72D33107C55D0895734E337E8C09288FCCE6E023E266321AA9ABCD265A034B23E855C93D916550A28B2B2D977E8E983218B99B128693DB91B0A4647A267F9BD3BEADBB9BE3C701E38F451F17F8A931B717FC4C36E9E278C391C70979261B0C1CFF08B0D3E65B2657DB932F4DAE782408DA2FAA8E07439B7DBA40C172447182A3CD1E7BD063EFB0AC9370DA87D01E2C87A40AB3D4F8EAB9AC856BDDE1F34B0E9B843B6F0E3B324E4AE90B48D4CC81E6BFDB03802E8353765D51147F4651047168DB29A6BD44D3086972821D22AA28A213D06C053BBA338FEB4470CB5912C3F9536314F1B301D7D6FA7D41865BD7149F4D49748B02DFAE493D274F448C1C9844237432907255A9338E35B7EC985D0A4669416635892999EC64DE1EC6506FB8545BD873A36ED911A77FBB562C76302635873283FEDE4335C5EEFDBAFB8ECDCD855FFF16B35837DAA1A6692F63D83EC0EAA6E39A5AD5144CC7060ED6F40E645984561C27AB29F11635216BFEDDC29DAA94D432C641AE612C316DD94824C56005A5DAF2362F843711CECBEFF6E01994317D1E264A33FDAE6788DEED989A8D4D75621BD5DB4EE56F063E91A636B204E4AD516FE83C9332EBA8EE39F5F152EDED95443910036CE718CCD3B84850A7B3BE59266332F1D2586177395BAA92A0162BED2E49642BF1D2C41A55E2742C995DC9CB14172B19B4089B4EA0B2861917481937B20E80B2F435195AB854E0ED6CBD6D30CBAB6FE17941754977091C698717C3157797C5783CC2CCDA4207601F62D1B50C1F61D1B585DDE5C8241F5E9C5CD75DAA70B6E1455A0F3D6679ECF8CECB329EE96D7865F74F225A8DD752270C094D26393420D4479B3EE1C0D0739FC635C9920816BC3CA9AA0728F57235D56F060C4D323D0C0AF521D51D08867E875EABC3F7029E482023B22D7F332EE60E07C3DCBCBD487077B5A5EFB142BDF03D5ECC28B90A87555F7D4D1614AB4A8EEC78E5DC253761A3B3F39774CE9A36679EDD0F62944350DDA4A48BA5AF741DD203D062931398D48059FC276E77F8B6C11D40D192A626F5976FFF7C72762E3DAA793B0F5CC6791EC69A33A3E1958BE8B2933D30894A73EFA4AEB8D2BEC53725E815E0E00560E555C9566C9F2724CB3805642F2F482A2358E5F47893D1C3C1FB7E107110E7F20C25AD674B8ED2D0270E21FD4DAAB70A6E18919E3CF415635E2ACA07895B14C2F5CCFF6FD5F3C2BBFDFD49E8FCCEBBC734905D7813EF7F439F4FEC86A92A42FF7822491174F7BC8617D7D5265CD741169198A75D876FBA0D1A5AA16CEF356A68CE38C727A1773527EB38C8A05AF2FA4064F611E7C8F3EEE1A37D11ADBF9A78AE52A7F7B8580C8783D310830F943F295CE07D7986A7FAF6F7C950FEA6F0ADF804844ACD67E1A37247EC5F5C8E42C5FC5BF22E9D7CD98167D99BB1398CB17B0A22E5DF9037793296E469828AE95EF5302C4837B07E8DBCC793B21C4F0321DB9DEDE1188C6E507A1B7C4595E061B85DD73DBFB7D310EB5BD2991F3EA7D4F9756E6625A519898A769EA26E1C0B97C7C063B4D118F523E8BF6AE9498E668EA34EB69EEB65E63FDAE98FBA11CCD4A923D323357852D8389DE8907A2AD7DB243E3AA9ACCFE7341F96DF26AD5125319ED89F87262DEA298A479AB4031D51FDFC453717EE5F8DA3DB5B1EADB622CA7F430EC140D856589B5BB44CDB2D4ED2A86D221DE0EF200121DD732E3189962020B43A80795E3D146E9E605E27CF30BC45F705C90A42A70C93E75860C095BBA46DFC8A7329EA3CBDCFAACD671F53A06A46E5CDFC3DFAA588E290E97DA3B980308828B7DFE6C2A5F425292F5E561B26E9538A3A0A6ACCC7B286479864311596DFA30578857D74FB92C38F7005824DFB15D32C64B72344B34FAF22B0C220C91B19DBFEF44F8AE13059FFF417D12611863C510000, N'6.1.3-40302')
