using EX_02.Models;

Livro book = new Livro();
book.Nome = "O pequeno principe";

Autor autor = new Autor();
autor.nome = "Antoine de Saint Exupéry";
autor.Email = "antonine@gmail.com";

book.DadosAutor.Add(autor);

Console.WriteLine("'" + book.Nome + "'");
Console.WriteLine(book.DadosAutor[0].nome);
Console.WriteLine(book.DadosAutor[0].Email);