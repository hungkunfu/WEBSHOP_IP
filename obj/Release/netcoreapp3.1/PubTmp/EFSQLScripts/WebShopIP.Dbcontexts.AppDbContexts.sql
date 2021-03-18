IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210312150103_Init')
BEGIN
    CREATE TABLE [AspNetRoles] (
        [Id] nvarchar(450) NOT NULL,
        [Name] nvarchar(256) NULL,
        [NormalizedName] nvarchar(256) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210312150103_Init')
BEGIN
    CREATE TABLE [AspNetUsers] (
        [Id] nvarchar(450) NOT NULL,
        [UserName] nvarchar(256) NULL,
        [NormalizedUserName] nvarchar(256) NULL,
        [Email] nvarchar(256) NULL,
        [NormalizedEmail] nvarchar(256) NULL,
        [EmailConfirmed] bit NOT NULL,
        [PasswordHash] nvarchar(max) NULL,
        [SecurityStamp] nvarchar(max) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        [PhoneNumber] nvarchar(max) NULL,
        [PhoneNumberConfirmed] bit NOT NULL,
        [TwoFactorEnabled] bit NOT NULL,
        [LockoutEnd] datetimeoffset NULL,
        [LockoutEnabled] bit NOT NULL,
        [AccessFailedCount] int NOT NULL,
        CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210312150103_Init')
BEGIN
    CREATE TABLE [AspNetRoleClaims] (
        [Id] int NOT NULL IDENTITY,
        [RoleId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210312150103_Init')
BEGIN
    CREATE TABLE [AspNetUserClaims] (
        [Id] int NOT NULL IDENTITY,
        [UserId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210312150103_Init')
BEGIN
    CREATE TABLE [AspNetUserLogins] (
        [LoginProvider] nvarchar(450) NOT NULL,
        [ProviderKey] nvarchar(450) NOT NULL,
        [ProviderDisplayName] nvarchar(max) NULL,
        [UserId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
        CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210312150103_Init')
BEGIN
    CREATE TABLE [AspNetUserRoles] (
        [UserId] nvarchar(450) NOT NULL,
        [RoleId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
        CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210312150103_Init')
BEGIN
    CREATE TABLE [AspNetUserTokens] (
        [UserId] nvarchar(450) NOT NULL,
        [LoginProvider] nvarchar(450) NOT NULL,
        [Name] nvarchar(450) NOT NULL,
        [Value] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
        CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210312150103_Init')
BEGIN
    CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210312150103_Init')
BEGIN
    CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210312150103_Init')
BEGIN
    CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210312150103_Init')
BEGIN
    CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210312150103_Init')
BEGIN
    CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210312150103_Init')
BEGIN
    CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210312150103_Init')
BEGIN
    CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210312150103_Init')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210312150103_Init', N'3.1.5');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210313152047_AlterInit')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210313152047_AlterInit', N'3.1.5');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210313153800_AlterApplication')
BEGIN
    ALTER TABLE [AspNetUsers] ADD [Address] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210313153800_AlterApplication')
BEGIN
    ALTER TABLE [AspNetUsers] ADD [City] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210313153800_AlterApplication')
BEGIN
    ALTER TABLE [AspNetUsers] ADD [FirstName] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210313153800_AlterApplication')
BEGIN
    ALTER TABLE [AspNetUsers] ADD [LastName] nvarchar(max) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210313153800_AlterApplication')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210313153800_AlterApplication', N'3.1.5');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210313162629_Product_Category')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210313162629_Product_Category', N'3.1.5');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210313163110_AlterProduct_Categorys')
BEGIN
    CREATE TABLE [Category] (
        [ID] bigint NOT NULL IDENTITY,
        [Name] nvarchar(250) NOT NULL,
        [MetaTitle] nvarchar(250) NULL,
        [ParentID] bigint NULL,
        [DisplayOrder] int NULL,
        [SeoTitle] nvarchar(250) NULL,
        [CreatedDate] datetime2 NULL,
        [CreatedBy] nvarchar(50) NULL,
        [ModifiedDate] datetime2 NULL,
        [ModifiedBy] nvarchar(50) NULL,
        [MetaKeywords] nvarchar(250) NULL,
        [MetaDescriptions] nvarchar(250) NULL,
        [Status] bit NULL,
        [ShowOnHome] bit NULL,
        [Language] nvarchar(max) NULL,
        CONSTRAINT [PK_Category] PRIMARY KEY ([ID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210313163110_AlterProduct_Categorys')
BEGIN
    CREATE TABLE [Product] (
        [ID] bigint NOT NULL IDENTITY,
        [Name] nvarchar(250) NULL,
        [Code] nvarchar(10) NULL,
        [MetaTitle] nvarchar(250) NULL,
        [Description] nvarchar(500) NULL,
        [Image] nvarchar(250) NULL,
        [MoreImages] xml NULL,
        [Price] decimal(18,2) NULL,
        [PromotionPrice] decimal(18,2) NULL,
        [IncludedVAT] bit NULL,
        [Quantity] int NOT NULL,
        [CategoryID] bigint NULL,
        [Detail] ntext NULL,
        [Warranty] int NULL,
        [CreatedDate] datetime2 NULL,
        [CreatedBy] nvarchar(50) NULL,
        [ModifiedDate] datetime2 NULL,
        [ModifiedBy] nvarchar(50) NULL,
        [MetaKeywords] nvarchar(250) NULL,
        [MetaDescriptions] nvarchar(250) NULL,
        [Status] bit NULL,
        [TopHot] datetime2 NULL,
        [ViewCount] int NULL,
        CONSTRAINT [PK_Product] PRIMARY KEY ([ID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210313163110_AlterProduct_Categorys')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210313163110_AlterProduct_Categorys', N'3.1.5');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210313170215_UpdateTableWebShop')
BEGIN
    CREATE TABLE [About] (
        [ID] bigint NOT NULL IDENTITY,
        [Name] nvarchar(250) NULL,
        [MetaTitle] nvarchar(250) NULL,
        [Description] nvarchar(500) NULL,
        [Image] nvarchar(250) NULL,
        [Detail] ntext NULL,
        [CreatedDate] datetime2 NULL,
        [CreatedBy] nvarchar(50) NULL,
        [ModifiedDate] datetime2 NULL,
        [ModifiedBy] nvarchar(50) NULL,
        [MetaKeywords] nvarchar(250) NULL,
        [MetaDescriptions] nvarchar(250) NULL,
        [Status] bit NULL,
        CONSTRAINT [PK_About] PRIMARY KEY ([ID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210313170215_UpdateTableWebShop')
BEGIN
    CREATE TABLE [Contact] (
        [ID] int NOT NULL IDENTITY,
        [Content] ntext NULL,
        [Status] bit NULL,
        CONSTRAINT [PK_Contact] PRIMARY KEY ([ID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210313170215_UpdateTableWebShop')
BEGIN
    CREATE TABLE [Content] (
        [ID] bigint NOT NULL IDENTITY,
        [Name] nvarchar(250) NULL,
        [MetaTitle] nvarchar(250) NULL,
        [Description] nvarchar(500) NULL,
        [Image] nvarchar(250) NULL,
        [CategoryID] bigint NULL,
        [Detail] ntext NULL,
        [Warranty] int NULL,
        [CreatedDate] datetime2 NULL,
        [CreatedBy] nvarchar(50) NULL,
        [ModifiedDate] datetime2 NULL,
        [ModifiedBy] nvarchar(50) NULL,
        [MetaKeywords] nvarchar(250) NULL,
        [MetaDescriptions] nvarchar(250) NULL,
        [Status] bit NOT NULL,
        [TopHot] datetime2 NULL,
        [ViewCount] int NULL,
        [Tags] nvarchar(500) NULL,
        [Language] nvarchar(max) NULL,
        CONSTRAINT [PK_Content] PRIMARY KEY ([ID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210313170215_UpdateTableWebShop')
BEGIN
    CREATE TABLE [ContentTag] (
        [ContentID] bigint NOT NULL IDENTITY,
        [TagID] nvarchar(50) NULL,
        CONSTRAINT [PK_ContentTag] PRIMARY KEY ([ContentID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210313170215_UpdateTableWebShop')
BEGIN
    CREATE TABLE [Feedback] (
        [ID] int NOT NULL IDENTITY,
        [Name] nvarchar(50) NULL,
        [Phone] nvarchar(50) NULL,
        [Email] nvarchar(50) NULL,
        [Address] nvarchar(50) NULL,
        [Content] nvarchar(250) NULL,
        [CreatedDate] datetime2 NULL,
        [Status] bit NULL,
        CONSTRAINT [PK_Feedback] PRIMARY KEY ([ID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210313170215_UpdateTableWebShop')
BEGIN
    CREATE TABLE [Footer] (
        [ID] nvarchar(50) NOT NULL,
        [Content] ntext NULL,
        [Status] bit NULL,
        CONSTRAINT [PK_Footer] PRIMARY KEY ([ID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210313170215_UpdateTableWebShop')
BEGIN
    CREATE TABLE [Menu] (
        [ID] int NOT NULL IDENTITY,
        [Text] nvarchar(50) NULL,
        [Link] nvarchar(250) NULL,
        [DisplayOrder] int NULL,
        [Target] nvarchar(50) NULL,
        [Status] bit NULL,
        [TypeID] int NULL,
        CONSTRAINT [PK_Menu] PRIMARY KEY ([ID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210313170215_UpdateTableWebShop')
BEGIN
    CREATE TABLE [MenuType] (
        [ID] int NOT NULL IDENTITY,
        [Name] nvarchar(50) NULL,
        CONSTRAINT [PK_MenuType] PRIMARY KEY ([ID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210313170215_UpdateTableWebShop')
BEGIN
    CREATE TABLE [Order] (
        [ID] bigint NOT NULL IDENTITY,
        [CreatedDate] datetime2 NULL,
        [CustomerID] bigint NULL,
        [ShipName] nvarchar(50) NULL,
        [ShipMobile] nvarchar(50) NULL,
        [ShipAddress] nvarchar(50) NULL,
        [ShipEmail] nvarchar(50) NULL,
        [Status] int NULL,
        CONSTRAINT [PK_Order] PRIMARY KEY ([ID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210313170215_UpdateTableWebShop')
BEGIN
    CREATE TABLE [OrderDetail] (
        [ProductID] bigint NOT NULL,
        [OrderID] bigint NOT NULL,
        [Quantity] int NULL,
        [Price] decimal(18,2) NULL,
        CONSTRAINT [PK_OrderDetail] PRIMARY KEY ([ProductID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210313170215_UpdateTableWebShop')
BEGIN
    CREATE TABLE [ProductCategory] (
        [ID] bigint NOT NULL IDENTITY,
        [Name] nvarchar(250) NULL,
        [MetaTitle] nvarchar(250) NULL,
        [ParentID] bigint NULL,
        [DisplayOrder] int NULL,
        [SeoTitle] nvarchar(250) NULL,
        [CreatedDate] datetime2 NULL,
        [CreatedBy] nvarchar(50) NULL,
        [ModifiedDate] datetime2 NULL,
        [ModifiedBy] nvarchar(50) NULL,
        [MetaKeywords] nvarchar(250) NULL,
        [MetaDescriptions] nvarchar(250) NULL,
        [Status] bit NULL,
        [ShowOnHome] bit NULL,
        CONSTRAINT [PK_ProductCategory] PRIMARY KEY ([ID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210313170215_UpdateTableWebShop')
BEGIN
    CREATE TABLE [Slide] (
        [ID] int NOT NULL IDENTITY,
        [Image] nvarchar(250) NULL,
        [DisplayOrder] int NULL,
        [Link] nvarchar(250) NULL,
        [Description] nvarchar(50) NULL,
        [CreatedDate] datetime2 NULL,
        [CreatedBy] nvarchar(50) NULL,
        [ModifiedDate] datetime2 NULL,
        [ModifiedBy] nvarchar(50) NULL,
        [Status] bit NULL,
        CONSTRAINT [PK_Slide] PRIMARY KEY ([ID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210313170215_UpdateTableWebShop')
BEGIN
    CREATE TABLE [sysdiagrams] (
        [diagram_id] int NOT NULL IDENTITY,
        [name] nvarchar(128) NOT NULL,
        [principal_id] int NOT NULL,
        [version] int NULL,
        [definition] varbinary(max) NULL,
        CONSTRAINT [PK_sysdiagrams] PRIMARY KEY ([diagram_id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210313170215_UpdateTableWebShop')
BEGIN
    CREATE TABLE [SystemConfig] (
        [ID] nvarchar(50) NOT NULL,
        [Name] nvarchar(50) NULL,
        [Type] nvarchar(50) NULL,
        [Value] nvarchar(250) NULL,
        [Status] bit NULL,
        CONSTRAINT [PK_SystemConfig] PRIMARY KEY ([ID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210313170215_UpdateTableWebShop')
BEGIN
    CREATE TABLE [Tag] (
        [ID] nvarchar(50) NOT NULL,
        [Name] nvarchar(50) NULL,
        CONSTRAINT [PK_Tag] PRIMARY KEY ([ID])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210313170215_UpdateTableWebShop')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210313170215_UpdateTableWebShop', N'3.1.5');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210315100949_AlterDB')
BEGIN
    DROP TABLE [About];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210315100949_AlterDB')
BEGIN
    DROP TABLE [Category];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210315100949_AlterDB')
BEGIN
    DROP TABLE [Contact];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210315100949_AlterDB')
BEGIN
    DROP TABLE [Content];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210315100949_AlterDB')
BEGIN
    DROP TABLE [ContentTag];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210315100949_AlterDB')
BEGIN
    DROP TABLE [Feedback];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210315100949_AlterDB')
BEGIN
    DROP TABLE [Footer];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210315100949_AlterDB')
BEGIN
    DROP TABLE [Menu];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210315100949_AlterDB')
BEGIN
    DROP TABLE [MenuType];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210315100949_AlterDB')
BEGIN
    DROP TABLE [Order];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210315100949_AlterDB')
BEGIN
    DROP TABLE [OrderDetail];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210315100949_AlterDB')
BEGIN
    DROP TABLE [Product];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210315100949_AlterDB')
BEGIN
    DROP TABLE [ProductCategory];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210315100949_AlterDB')
BEGIN
    DROP TABLE [Slide];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210315100949_AlterDB')
BEGIN
    DROP TABLE [sysdiagrams];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210315100949_AlterDB')
BEGIN
    DROP TABLE [SystemConfig];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210315100949_AlterDB')
BEGIN
    DROP TABLE [Tag];
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210315100949_AlterDB')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210315100949_AlterDB', N'3.1.5');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210315102327_ALLDBContext')
BEGIN
    CREATE TABLE [Categories] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Status] int NOT NULL,
        [CreateAt] datetime2 NOT NULL,
        [Logo] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [CreateBy] nvarchar(max) NULL,
        [ApplicationUserId] nvarchar(450) NULL,
        CONSTRAINT [PK_Categories] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Categories_AspNetUsers_ApplicationUserId] FOREIGN KEY ([ApplicationUserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210315102327_ALLDBContext')
BEGIN
    CREATE TABLE [InfoCustomers] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [PhoneNum] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [Address] nvarchar(max) NULL,
        CONSTRAINT [PK_InfoCustomers] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210315102327_ALLDBContext')
BEGIN
    CREATE TABLE [Orders] (
        [Id] int NOT NULL IDENTITY,
        [PayStatus] int NOT NULL,
        [CreateAt] datetime2 NOT NULL,
        [ShipperDate] datetime2 NOT NULL,
        [CreateBy] nvarchar(max) NULL,
        [ApplicationUserId] nvarchar(450) NULL,
        [InfoCustomerId] int NOT NULL,
        CONSTRAINT [PK_Orders] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Orders_AspNetUsers_ApplicationUserId] FOREIGN KEY ([ApplicationUserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210315102327_ALLDBContext')
BEGIN
    CREATE TABLE [Products] (
        [Id] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [PricePerUnit] float NOT NULL,
        [CreateAt] datetime2 NOT NULL,
        [ImagePath] nvarchar(max) NULL,
        [Status] int NOT NULL,
        [SaleCount] int NOT NULL,
        [CategoryId] int NOT NULL,
        [CreateBy] nvarchar(max) NULL,
        [ApplicationUserId] nvarchar(450) NULL,
        CONSTRAINT [PK_Products] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Products_AspNetUsers_ApplicationUserId] FOREIGN KEY ([ApplicationUserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE NO ACTION,
        CONSTRAINT [FK_Products_Categories_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [Categories] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210315102327_ALLDBContext')
BEGIN
    CREATE TABLE [OrderDetails] (
        [ProductId] int NOT NULL IDENTITY,
        [ProductId1] int NULL,
        [OrderId] int NOT NULL,
        [Quantity] int NOT NULL,
        [Discount] float NOT NULL,
        [UnitPrice] float NOT NULL,
        [PayStatus] int NOT NULL,
        CONSTRAINT [PK_OrderDetails] PRIMARY KEY ([ProductId]),
        CONSTRAINT [FK_OrderDetails_Orders_OrderId] FOREIGN KEY ([OrderId]) REFERENCES [Orders] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_OrderDetails_Products_ProductId1] FOREIGN KEY ([ProductId1]) REFERENCES [Products] ([Id]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210315102327_ALLDBContext')
BEGIN
    CREATE INDEX [IX_Categories_ApplicationUserId] ON [Categories] ([ApplicationUserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210315102327_ALLDBContext')
BEGIN
    CREATE INDEX [IX_OrderDetails_OrderId] ON [OrderDetails] ([OrderId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210315102327_ALLDBContext')
BEGIN
    CREATE INDEX [IX_OrderDetails_ProductId1] ON [OrderDetails] ([ProductId1]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210315102327_ALLDBContext')
BEGIN
    CREATE INDEX [IX_Orders_ApplicationUserId] ON [Orders] ([ApplicationUserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210315102327_ALLDBContext')
BEGIN
    CREATE INDEX [IX_Products_ApplicationUserId] ON [Products] ([ApplicationUserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210315102327_ALLDBContext')
BEGIN
    CREATE INDEX [IX_Products_CategoryId] ON [Products] ([CategoryId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210315102327_ALLDBContext')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210315102327_ALLDBContext', N'3.1.5');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20210316043046_AlterUserViewModel')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20210316043046_AlterUserViewModel', N'3.1.5');
END;

GO

