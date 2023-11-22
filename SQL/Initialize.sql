USE [master]
GO

/****** Object:  Database [YouTify]    Script Date: 22/11/2023 09:31:43 ******/
CREATE DATABASE [YouTify]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'YouTify', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\YouTify.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'YouTify_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.SQLEXPRESS\MSSQL\DATA\YouTify_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [YouTify].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [YouTify] SET ANSI_NULL_DEFAULT OFF 
GO

ALTER DATABASE [YouTify] SET ANSI_NULLS OFF 
GO

ALTER DATABASE [YouTify] SET ANSI_PADDING OFF 
GO

ALTER DATABASE [YouTify] SET ANSI_WARNINGS OFF 
GO

ALTER DATABASE [YouTify] SET ARITHABORT OFF 
GO

ALTER DATABASE [YouTify] SET AUTO_CLOSE OFF 
GO

ALTER DATABASE [YouTify] SET AUTO_SHRINK OFF 
GO

ALTER DATABASE [YouTify] SET AUTO_UPDATE_STATISTICS ON 
GO

ALTER DATABASE [YouTify] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO

ALTER DATABASE [YouTify] SET CURSOR_DEFAULT  GLOBAL 
GO

ALTER DATABASE [YouTify] SET CONCAT_NULL_YIELDS_NULL OFF 
GO

ALTER DATABASE [YouTify] SET NUMERIC_ROUNDABORT OFF 
GO

ALTER DATABASE [YouTify] SET QUOTED_IDENTIFIER OFF 
GO

ALTER DATABASE [YouTify] SET RECURSIVE_TRIGGERS OFF 
GO

ALTER DATABASE [YouTify] SET  DISABLE_BROKER 
GO

ALTER DATABASE [YouTify] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO

ALTER DATABASE [YouTify] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO

ALTER DATABASE [YouTify] SET TRUSTWORTHY OFF 
GO

ALTER DATABASE [YouTify] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO

ALTER DATABASE [YouTify] SET PARAMETERIZATION SIMPLE 
GO

ALTER DATABASE [YouTify] SET READ_COMMITTED_SNAPSHOT OFF 
GO

ALTER DATABASE [YouTify] SET HONOR_BROKER_PRIORITY OFF 
GO

ALTER DATABASE [YouTify] SET RECOVERY SIMPLE 
GO

ALTER DATABASE [YouTify] SET  MULTI_USER 
GO

ALTER DATABASE [YouTify] SET PAGE_VERIFY CHECKSUM  
GO

ALTER DATABASE [YouTify] SET DB_CHAINING OFF 
GO

ALTER DATABASE [YouTify] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO

ALTER DATABASE [YouTify] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO

ALTER DATABASE [YouTify] SET DELAYED_DURABILITY = DISABLED 
GO

ALTER DATABASE [YouTify] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO

ALTER DATABASE [YouTify] SET QUERY_STORE = ON
GO

ALTER DATABASE [YouTify] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO

ALTER DATABASE [YouTify] SET  READ_WRITE 
GO


USE [YouTify]
GO

/****** Object:  Table [dbo].[SpotifyCredentials]    Script Date: 22/11/2023 09:32:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SpotifyCredentials](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_SpotifyCredentials] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_SpotifyCredentials] UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [uSpotifyUsername] UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [YouTify]
GO

/****** Object:  Table [dbo].[YoutubeCredentials]    Script Date: 22/11/2023 09:32:18 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[YoutubeCredentials](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[username] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_YoutubeCredentials] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [IX_YoutubeCredentials] UNIQUE NONCLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY],
 CONSTRAINT [uYoutubeUsername] UNIQUE NONCLUSTERED 
(
	[username] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [YouTify]
GO

/****** Object:  Table [dbo].[Songs]    Script Date: 22/11/2023 09:32:29 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Songs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Title] [varchar](255) NOT NULL,
	[Artist] [varchar](255) NULL,
	[creationDate] [datetime] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [YouTify]
GO

/****** Object:  Table [dbo].[SpotifySongs]    Script Date: 22/11/2023 09:32:43 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SpotifySongs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SongId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[SpotifySongs]  WITH CHECK ADD FOREIGN KEY([SongId])
REFERENCES [dbo].[Songs] ([Id])
GO

USE [YouTify]
GO

/****** Object:  Table [dbo].[YouTubeSongs]    Script Date: 22/11/2023 09:32:48 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[YouTubeSongs](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[SongId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[YouTubeSongs]  WITH CHECK ADD FOREIGN KEY([SongId])
REFERENCES [dbo].[Songs] ([Id])
GO

USE [YouTify]
GO

/****** Object:  Table [dbo].[SpotifyPlaylists]    Script Date: 22/11/2023 09:32:56 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SpotifyPlaylists](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[owner] [nvarchar](50) NOT NULL,
	[iconFilePath] [nvarchar](max) NULL,
 CONSTRAINT [PK_SpotifyPlaylists] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[SpotifyPlaylists]  WITH CHECK ADD  CONSTRAINT [FK_SP_OWNER] FOREIGN KEY([owner])
REFERENCES [dbo].[SpotifyCredentials] ([username])
GO

ALTER TABLE [dbo].[SpotifyPlaylists] CHECK CONSTRAINT [FK_SP_OWNER]
GO

USE [YouTify]
GO

/****** Object:  Table [dbo].[YoutubePlaylists]    Script Date: 22/11/2023 09:33:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[YoutubePlaylists](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
	[owner] [nvarchar](50) NOT NULL,
	[iconFilePath] [nvarchar](max) NULL,
 CONSTRAINT [PK_YoutubePlaylists] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

ALTER TABLE [dbo].[YoutubePlaylists]  WITH CHECK ADD  CONSTRAINT [FK_YT_OWNER] FOREIGN KEY([owner])
REFERENCES [dbo].[YoutubeCredentials] ([username])
GO

ALTER TABLE [dbo].[YoutubePlaylists] CHECK CONSTRAINT [FK_YT_OWNER]
GO

USE [YouTify]
GO

/****** Object:  Table [dbo].[SpotifyPlaylistSong]    Script Date: 22/11/2023 09:33:09 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[SpotifyPlaylistSong](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PlaylistId] [int] NULL,
	[SongId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[SpotifyPlaylistSong]  WITH CHECK ADD FOREIGN KEY([PlaylistId])
REFERENCES [dbo].[SpotifyPlaylists] ([id])
GO

ALTER TABLE [dbo].[SpotifyPlaylistSong]  WITH CHECK ADD FOREIGN KEY([SongId])
REFERENCES [dbo].[Songs] ([Id])
GO

USE [YouTify]
GO

/****** Object:  Table [dbo].[YoutubePlaylistSong]    Script Date: 22/11/2023 09:33:14 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[YoutubePlaylistSong](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[PlaylistId] [int] NULL,
	[SongId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[YoutubePlaylistSong]  WITH CHECK ADD FOREIGN KEY([PlaylistId])
REFERENCES [dbo].[YoutubePlaylists] ([id])
GO

ALTER TABLE [dbo].[YoutubePlaylistSong]  WITH CHECK ADD FOREIGN KEY([SongId])
REFERENCES [dbo].[Songs] ([Id])
GO

-- Inserting additional data into the Songs table with real song data
INSERT INTO Songs (Title, Artist, CreationDate)
VALUES
    ('Shape of You', 'Ed Sheeran', GETDATE()),
    ('Someone You Loved', 'Lewis Capaldi', GETDATE()),
    ('Blinding Lights', 'The Weeknd', GETDATE()),
    ('Dance Monkey', 'Tones and I', GETDATE()),
    ('Rolling in the Deep', 'Adele', GETDATE()),
    ('Old Town Road', 'Lil Nas X ft. Billy Ray Cyrus', GETDATE()),
    ('Bad Guy', 'Billie Eilish', GETDATE()),
    ('Sicko Mode', 'Travis Scott', GETDATE()),
    ('Despacito', 'Luis Fonsi ft. Daddy Yankee', GETDATE()),
    ('Uptown Funk', 'Mark Ronson ft. Bruno Mars', GETDATE()),
    ('Havana', 'Camila Cabello', GETDATE()),
    ('Someone Like You', 'Adele', GETDATE()),
    ('Stressed Out', 'Twenty One Pilots', GETDATE()),
    ('Hello', 'Adele', GETDATE()),
    ('Closer', 'The Chainsmokers ft. Halsey', GETDATE()),
    ('Thinking Out Loud', 'Ed Sheeran', GETDATE()),
    ('Sunflower', 'Post Malone ft. Swae Lee', GETDATE()),
    ('Watermelon Sugar', 'Harry Styles', GETDATE()),
    ('Bad Romance', 'Lady Gaga', GETDATE()),
    ('Love Story', 'Taylor Swift', GETDATE()),
    ('Riptide', 'Vance Joy', GETDATE()),
    ('Take Me to Church', 'Hozier', GETDATE()),
    ('All of Me', 'John Legend', GETDATE()),
    ('Radioactive', 'Imagine Dragons', GETDATE());
GO

INSERT INTO YouTubeSongs (SongId)
VALUES
    (1),  -- Shape of You
    (2),  -- Someone You Loved
    (3),  -- Blinding Lights
    (4),  -- Dance Monkey
    (5),  -- Rolling in the Deep
    (6),  -- Old Town Road
    (7),  -- Bad Guy
    (8),  -- Sicko Mode
    (9),  -- Despacito
    (10), -- Uptown Funk
    (11), -- Havana
    (12), -- Stressed Out
    (13), -- Hello
    (14), -- Closer
    (15), -- Thinking Out Loud
    (16), -- Bad Romance (Unique YouTube song)
    (17), -- Love Story (Unique YouTube song)
    (18), -- Riptide (Unique YouTube song)
    (19), -- Take Me to Church (Unique YouTube song)
    (20); -- Radioactive (Unique YouTube song)


INSERT INTO SpotifySongs (SongId)
VALUES
    (1),  -- Shape of You
    (2),  -- Someone You Loved
    (3),  -- Blinding Lights
    (4),  -- Dance Monkey
    (5),  -- Rolling in the Deep
    (6),  -- Old Town Road
    (7),  -- Bad Guy
    (8),  -- Sicko Mode
    (9),  -- Despacito
    (10), -- Uptown Funk
    (11), -- Watermelon Sugar (Unique Spotify song)
    (12), -- Bad Romance (Unique Spotify song)
    (13), -- Love Story (Unique Spotify song)
    (14), -- Take Me to Church (Unique Spotify song)
    (15), -- Radioactive (Unique Spotify song)
    (21), -- Watermelon Sugar (Unique Spotify song)
    (22), -- Bad Romance (Unique Spotify song)
    (23), -- Love Story (Unique Spotify song)
    (24), -- Take Me to Church (Unique Spotify song)
    (25); -- Radioactive (Unique Spotify song)
