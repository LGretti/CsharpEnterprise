CREATE TABLE Produtos (Id      Integer IDENTITY(1,1) NOT NULL,
                       Nome    Varchar(255)          NOT NULL,
											 Cor     Varchar(50)           NULL,
											 Preco   decimal(13,2)         NOT NULL,
											 Tamanho Varchar(5)            NULL,
											 Genero   char(1)              NULL);