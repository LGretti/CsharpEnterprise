--count

SELECT count(*) as QuantidadeProdutos FROM Produtos

SELECT count(*) as QuantidadeProdutosMedios FROM Produtos where tamanho = 'M'


--sum

SELECT sum(preco) as precototalprodutosmedios FROM Produtos where tamanho = 'M'