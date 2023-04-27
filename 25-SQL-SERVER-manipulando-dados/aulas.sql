--count

SELECT count(*) as QuantidadeProdutos FROM Produtos

SELECT count(*) as QuantidadeProdutosMedios FROM Produtos where tamanho = 'M'


--sum

SELECT sum(preco) as precototalprodutosmedios FROM Produtos where tamanho = 'M'


--min

select min(preco) from produtos

--max

select max(preco) from produtos

--avg

select avg(preco) from produtos


--concatenacao

select Nome + ', Cor: ' + Cor + ' - ' + Genero AS NomeProduto
FROM Produtos


--upper

select upper(nome)
from produtos

--lower

select lower(nome)
from produtos

--add column

alter table produtos
add DataCadastro datetime
update produtos set DataCadastro = getdate()

--format

select format(datacadastro, 'dd-MM-yyyy') as data from produtos

--group by

select tamanho,
       count(*) as quantidade
from produtos
where tamanho <> ''
group by tamanho

-- adicionando foreign key
CREATE TABLE Enderecos (
	Id int Primary key identity(1,1) not null,
	IdCliente int null,
	Rua varchar(255) null,
	Bairro varchar(255) null,
	Cidade varchar(255) null,
	Estado char(2) null

constraint FK_Enderecos_Clientes FOREIGN KEY(IDCliente)
REFERENCES clientes(id))


select * from clientes