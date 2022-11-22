using EX_01.Models;

Cachorro dog = new Cachorro();
dog.raca = "Pastor Alemão";
dog.tamanho = "Grande";

Gato cat = new Gato();
cat.raca = "Munchkin";
cat.tamanho = "Pequeno";

Passaro bird = new Passaro();
bird.raca = "Calopsita";
bird.tamanho = "Pequeno";

dog.dadosAnimais(dog.raca, dog.tamanho);
dog.EmitirSom();

cat.dadosAnimais(cat.raca, cat.tamanho);
cat.EmitirSom();

bird.dadosAnimais(bird.raca, bird.tamanho);
bird.EmitirSom();