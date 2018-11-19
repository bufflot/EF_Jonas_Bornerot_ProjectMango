IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Apples] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [Price] int NOT NULL,
    [Organic] bit NOT NULL,
    CONSTRAINT [PK_Apples] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Bananas] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [Price] int NOT NULL,
    [Organic] bit NOT NULL,
    CONSTRAINT [PK_Bananas] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [Oranges] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [Price] int NOT NULL,
    [Organic] bit NOT NULL,
    CONSTRAINT [PK_Oranges] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [WaterMelons] (
    [Id] int NOT NULL IDENTITY,
    [Name] nvarchar(max) NULL,
    [Price] int NOT NULL,
    [Organic] bit NOT NULL,
    CONSTRAINT [PK_WaterMelons] PRIMARY KEY ([Id])
);

GO

CREATE TABLE [FruitBaskets] (
    [Id] int NOT NULL IDENTITY,
    [AppleId] int NULL,
    [BananaId] int NULL,
    [OrangeId] int NULL,
    [WaterMelonId] int NULL,
    CONSTRAINT [PK_FruitBaskets] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_FruitBaskets_Apples_AppleId] FOREIGN KEY ([AppleId]) REFERENCES [Apples] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_FruitBaskets_Bananas_BananaId] FOREIGN KEY ([BananaId]) REFERENCES [Bananas] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_FruitBaskets_Oranges_OrangeId] FOREIGN KEY ([OrangeId]) REFERENCES [Oranges] ([Id]) ON DELETE NO ACTION,
    CONSTRAINT [FK_FruitBaskets_WaterMelons_WaterMelonId] FOREIGN KEY ([WaterMelonId]) REFERENCES [WaterMelons] ([Id]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Orders] (
    [Id] int NOT NULL IDENTITY,
    [FruitBasketId] int NOT NULL,
    CONSTRAINT [PK_Orders] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Orders_FruitBaskets_FruitBasketId] FOREIGN KEY ([FruitBasketId]) REFERENCES [FruitBaskets] ([Id]) ON DELETE CASCADE
);

GO

CREATE INDEX [IX_FruitBaskets_AppleId] ON [FruitBaskets] ([AppleId]);

GO

CREATE INDEX [IX_FruitBaskets_BananaId] ON [FruitBaskets] ([BananaId]);

GO

CREATE INDEX [IX_FruitBaskets_OrangeId] ON [FruitBaskets] ([OrangeId]);

GO

CREATE INDEX [IX_FruitBaskets_WaterMelonId] ON [FruitBaskets] ([WaterMelonId]);

GO

CREATE INDEX [IX_Orders_FruitBasketId] ON [Orders] ([FruitBasketId]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20181118142238_init', N'2.1.4-rtm-31024');

GO

