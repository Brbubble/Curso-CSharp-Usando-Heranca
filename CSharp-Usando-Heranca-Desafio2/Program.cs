using CSharp_Usando_Heranca_Desafio2;



Livro livro = new Livro("8535914846","George Orwell", "1984");

livro.AnoPublicacao = 1949;
livro.Genero = "Ficção Cientifica Social";
livro.NumeroPaginas = 416;
livro.PaisPublicacao = "Reino Unido";

Console.WriteLine("Informações do Livro");
Console.WriteLine("--------------------");
Console.WriteLine("Titulo: " + livro.Titulo);
Console.WriteLine("Autor: " + livro.Autor);
Console.WriteLine("Ano de Publicação: " + livro.AnoPublicacao);
Console.WriteLine("Estilo de Leitura: " + livro.Genero);
Console.WriteLine("Número de Páginas: " + livro.NumeroPaginas);
Console.WriteLine("Pais onde foi pubilcado: " + livro.PaisPublicacao);
Console.WriteLine("ISBN: " + livro.Isbn);

Console.ReadLine();


