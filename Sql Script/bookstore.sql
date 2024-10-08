USE [BookStoreDb]
GO
/****** Object:  Table [dbo].[Authors]    Script Date: 2/24/2022 21:40:28 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authors](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [FirstName] [nvarchar](60) NOT NULL,
    [LastName] [nvarchar](60) NOT NULL,
    [Bio] [nvarchar](max) NULL,
    CONSTRAINT [PK_Authors] PRIMARY KEY CLUSTERED
(
[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
    ) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
    GO
/****** Object:  Table [dbo].[Books]    Script Date: 2/24/2022 21:40:28 ******/
    SET ANSI_NULLS ON
    GO
    SET QUOTED_IDENTIFIER ON
    GO
CREATE TABLE [dbo].[Books](
    [Id] [int] IDENTITY(1,1) NOT NULL,
    [Title] [nvarchar](100) NOT NULL,
    [Year] [int] NULL,
    [Isbn] [nvarchar](20) NOT NULL,
    [Summary] [nvarchar](200) NOT NULL,
    [Image] [nvarchar](max) NOT NULL,
    [Price] [float] NULL,
    [AuthorId] [int] NULL,
    CONSTRAINT [PK_Books] PRIMARY KEY CLUSTERED
(
[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
    ) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
    GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK_Books_Authors_AuthorId] FOREIGN KEY([AuthorId])
    REFERENCES [dbo].[Authors] ([Id])
    GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK_Books_Authors_AuthorId]
    GO

-- Inserting mock data for the Authors table
    INSERT INTO [dbo].[Authors] (FirstName, LastName, Bio)
    VALUES
    ('John', 'Doe', 'John Doe is a prolific author known for his engaging storytelling and character development.'),
    ('Jane', 'Smith', 'Jane Smith specializes in historical fiction and has written numerous bestsellers.'),
    ('Mark', 'Twain', 'Mark Twain was an American writer, humorist, and entrepreneur.'),
    ('Emily', 'Brontë', 'Emily Brontë was an English novelist and poet, best known for her novel Wuthering Heights.'),
    ('George', 'Orwell', 'George Orwell was an English novelist, essayist, journalist, and critic, known for his works Animal Farm and 1984.'),
    ('Agatha', 'Christie', 'Agatha Christie is known as the Queen of Crime for her detective novels and short stories.'),
    ('F. Scott', 'Fitzgerald', 'F. Scott Fitzgerald is a renowned American novelist, best known for The Great Gatsby.'),
    ('J.K.', 'Rowling', 'J.K. Rowling is the author of the famous Harry Potter series.'),
    ('Ernest', 'Hemingway', 'Ernest Hemingway was an American novelist and short story writer, known for his concise and direct writing style.'),
    ('Virginia', 'Woolf', 'Virginia Woolf was an English writer, considered one of the most important modernist authors of the 20th century.');

-- Inserting mock data for the Books table
INSERT INTO [dbo].[Books] (Title, Year, Isbn, Summary, Image, Price, AuthorId)
VALUES
    ('The Adventures of Tom Sawyer', 1876, '978-0451530936', 'A classic novel about the adventures of a young boy growing up along the Mississippi River.', 'image1.jpg', 9.99, 3),
    ('Wuthering Heights', 1847, '978-0486452616', 'A tale of passion and revenge set in the moors of Yorkshire.', 'image2.jpg', 12.99, 4),
    ('1984', 1949, '978-0451524935', 'A dystopian novel that explores the dangers of totalitarianism.', 'image3.jpg', 14.99, 5),
    ('Pride and Prejudice', 1813, '978-0141040349', 'A romantic novel that also critiques the British class structure.', 'image4.jpg', 8.99, 2),
    ('Adventures in Time', 2023, '978-1234567890', 'A thrilling adventure through time and space.', 'image5.jpg', 19.99, 1),
    ('Murder on the Orient Express', 1934, '978-0007119318', 'A classic detective novel featuring Hercule Poirot.', 'image6.jpg', 10.99, 6),
    ('The Great Gatsby', 1925, '978-0743273565', 'A novel about the American dream and the roaring twenties.', 'image7.jpg', 13.99, 7),
    ('Harry Potter and the Philosopher''s Stone', 1997, '978-0747532743', 'The first book in the Harry Potter series, introducing the wizarding world.', 'image8.jpg', 15.99, 8),
    ('The Old Man and the Sea', 1952, '978-0684801223', 'A short novel about an aging fisherman’s struggle to catch a giant marlin.', 'image9.jpg', 11.99, 9),
    ('To the Lighthouse', 1927, '978-0156907392', 'A novel exploring the complexities of human relationships and the passage of time.', 'image10.jpg', 9.49, 10);

-- Verify the inserted data
SELECT * FROM [dbo].[Authors];
SELECT * FROM [dbo].[Books];