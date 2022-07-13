// // Testando exercício "Tempo de um evento"

// int W1, X1, Y1, Z1, W, X, Y, Z, W2, X2, Y2, Z2, inicio, fim, duracao, resto;

// string[] valores = Console.ReadLine().Split(' ');

// W1 = int.Parse(valores[1]);

// valores = Console.ReadLine().Split(' ');
// X1 = int.Parse(valores[0]);
// Y1 = int.Parse(valores[2]);
// Z1 = int.Parse(valores[4]);

// valores = Console.ReadLine().Split(' ');

// W2 = int.Parse(valores[1]);

// valores = Console.ReadLine().Split(' ');
// X2 = int.Parse(valores[0]);
// Y2 = int.Parse(valores[2]);
// Z2 = int.Parse(valores[4]);

// inicio = (W1 - 1) * 24 * 60 * 60 + X1 * 60 * 60 + Y1 * 60 + Z1;
// fim = (W2 - 1) * 24 * 60 * 60 + X2 * 60 * 60 + Y2 * 60 + Z2;

// duracao = fim - inicio;

// W = duracao / (24 * 60 * 60);
// resto = duracao % (24 * 60 * 60);
// X = resto / (60 * 60);
// resto = resto % (60 * 60);
// Y = resto / 60;
// Z = resto % 60;

// Console.WriteLine(W + " dia(s)");
// Console.WriteLine(X + " hora(s)");
// Console.WriteLine(Y + " minuto(s)");
// Console.WriteLine(Z + " segundo(s)");



// Testando exercício curso Nélio Alves

// int Minutos;
// double Total;

// Minutos = int.Parse(Console.ReadLine());

// if(Minutos <= 100)
// {
//     Console.WriteLine("Valor a pagar: R$ 50,00");
// }
// else
// {
//     Minutos = Minutos - 100;
//     Total = (double) Minutos * 2.00 + 50.00;
//     Console.WriteLine("Valor a pagar R$ " + Total.ToString("F2"));
// }



// Testando exercício "Lanche"

// int  X, Y;
// double Total;

// string [] vet = (Console.ReadLine().Split(' '));
// X = int.Parse(vet[0]);
// Y = int.Parse(vet[1]);
// Total = 0;

// switch (X){
//     case 1:
//         Total = Y * 4.00;
//         break;
//     case 2:
//         Total = Y * 4.50;
//         break;
//     case 3:
//         Total = Y * 5.00;
//         break;
//     case 4:
//         Total = Y * 2.00;
//         break;
//     case 5:
//         Total = Y * 1.50;
//         break;
// }

// Console.WriteLine("Total: R$ " + Total.ToString("F2"));


// Testando exercício "Multiplos"

// int A, B;

// string [] Num = Console.ReadLine().Split(' ');
// A = int.Parse(Num[0]);
// B = int.Parse(Num[1]);

// if(A % B == 0 || B % A == 0)
// {
//     Console.WriteLine("Sao Multiplos");
// }
// else
// {
//     Console.WriteLine("Nao sao multiplos");
// }



// Testando exercício "Tempo de jogo"

// int X, Y, Duracao;

// string [] Hora = Console.ReadLine().Split(' ');
// X = int.Parse(Hora[0]);
// Y = int.Parse(Hora[1]);

// if(X < Y)
// {
//     Duracao = Y - X;
// }
// else
// {
//     Duracao = 24 - X + Y;
// }
// Console.WriteLine("O JOGO DUROU " + Duracao + " HORA(S)");



// Testando exercício "Aumento de salário"

// double Salario, Reajuste, Diferenca;

// Salario = double.Parse(Console.ReadLine());

// if (Salario <= 400.00)
// {
//     Reajuste = Salario + Salario * 0.15;
//     Diferenca = Reajuste - Salario;
//     Console.WriteLine("Novo salario: " + Reajuste.ToString("F2"));
//     Console.WriteLine("Reajuste ganho: " + Diferenca.ToString("F2"));
//     Console.WriteLine("Em percentual: 15 %");
// }
// else if (Salario <= 800.00)
// {
//     Reajuste = Salario + Salario * 0.12;
//     Diferenca = Reajuste - Salario;
//     Console.WriteLine("Novo salario: " + Reajuste.ToString("F2"));
//     Console.WriteLine("Reajuste ganho: " + Diferenca.ToString("F2"));
//     Console.WriteLine("Em percentual: 12 %");
// }
// else if (Salario <= 1200.00)
// {
//     Reajuste = Salario + Salario * 0.10;
//     Diferenca = Reajuste - Salario;
//     Console.WriteLine("Novo salario: " + Reajuste.ToString("F2"));
//     Console.WriteLine("Reajuste ganho: " + Diferenca.ToString("F2"));
//     Console.WriteLine("Em percentual: 10 %");
// }
// else if (Salario <= 2000.00)
// {
//     Reajuste = Salario + Salario * 0.07;
//     Diferenca = Reajuste - Salario;
//     Console.WriteLine("Novo salario: " + Reajuste.ToString("F2"));
//     Console.WriteLine("Reajuste ganho: " + Diferenca.ToString("F2"));
//     Console.WriteLine("Em percentual: 7 %");
// }
// else if (Salario > 2000.00)
// {
//     Reajuste = Salario + Salario * 0.04;
//     Diferenca = Reajuste - Salario;
//     Console.WriteLine("Novo salario: " + Reajuste.ToString("F2"));
//     Console.WriteLine("Reajuste ganho: " + Diferenca.ToString("F2"));
//     Console.WriteLine("Em percentual: 4 %");
// }



// Testando exercício "Média 3" (Ponderada)

// float N1, N2, N3, N4, Media, NotaExame, MediaExame;

// string [] Notas = Console.ReadLine().Split(' ');
// N1 = float.Parse(Notas[0]);
// N2 = float.Parse(Notas[1]);
// N3 = float.Parse(Notas[2]);
// N4 = float.Parse(Notas[3]);

// Media = (N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1) / 10;

// Console.WriteLine("Media: " + Media.ToString("F1"));

// if (Media >= 7.0)
// {
//     Console.WriteLine("Aluno aprovado.");
// }
// else if (Media < 5.0)
// {
//     Console.WriteLine("Aluno reprovado.");
// }
// else if (Media >= 5.0 || Media < 7.0)
// {
//     Console.WriteLine("Aluno em exame.");
//     NotaExame = float.Parse(Console.ReadLine());
//     Console.WriteLine("Nota do exame: " + NotaExame.ToString("F1"));
//     MediaExame = (Media + NotaExame) / 2;

//     if(MediaExame >= 5.0)
//     {
//         Console.WriteLine("Aluno aprovado.");
//     }
//     else
//     {
//         Console.WriteLine("Aluno reprovado.");
//     }
//     Console.WriteLine("Media final: " + MediaExame.ToString("F1"));
// }



// Teste exercício "Cordenadas de um ponto"

// double X, Y;

// string [] Cordenada = Console.ReadLine().Split(' ');
// X = double.Parse(Cordenada[0]);
// Y = double.Parse(Cordenada[1]);

// if (X == 0.0 && Y == 0.0)
// {
//     Console.WriteLine("Origem");
// }
// else if (X == 0 && Y != 0.0)
// {
//     Console.WriteLine("Eixo X");
// }
// else if (X != 0 && Y == 0.0)
// {
//     Console.WriteLine("Eixo Y");
// }
// else if (X < 0.0 && Y > 0.0)
// {
//     Console.WriteLine("Q2");
// }
// else if (X > 0.0 && Y > 0.0)
// {
//     Console.WriteLine("Q1");
// }
// else if (X > 0.0 && Y < 0.0)
// {
//     Console.WriteLine("Q4");
// }
// else if (X < 0.0 && Y < 0.0)
// {
//     Console.WriteLine("Q3");
// }



// Testando exercício "Tipos de triangulos"

// string[] valores = Console.ReadLine().Split(' ');
// double n1 = double.Parse(valores[0]);
// double n2 = double.Parse(valores[1]);
// double n3 = double.Parse(valores[2]);

// double A, B, C;
// if (n1 > n2 && n1 > n3)
// {
//     A = n1;
//     if (n2 > n3)
//     {
//         B = n2;
//         C = n3;
//     }
//     else
//     {
//         B = n3;
//         C = n2;
//     }
// }
// else if (n2 > n3)
// {
//     A = n2;
//     if (n1 > n3)
//     {
//         B = n1;
//         C = n3;
//     }
//     else
//     {
//         B = n3;
//         C = n1;
//     }
// }
// else
// {
//     A = n3;
//     if (n1 > n2)
//     {
//         B = n1;
//         C = n2;
//     }
//     else
//     {
//         B = n2;
//         C = n1;
//     }
// }

// if (A >= B + C)
// {
//     Console.WriteLine("NAO FORMA TRIANGULO");
// }
// else
// {
//     if (A * A == B * B + C * C)
//     {
//         Console.WriteLine("TRIANGULO RETANGULO");
//     }
//     else if (A * A > B * B + C * C)
//     {
//         Console.WriteLine("TRIANGULO OBTUSANGULO");
//     }
//     else
//     {
//         Console.WriteLine("TRIANGULO ACUTANGULO");
//     }
//     if (A == B && B == C)
//     {
//         Console.WriteLine("TRIANGULO EQUILATERO");
//     }
//     else if (A == B || A == C || B == C)
//     {
//         Console.WriteLine("TRIANGULO ISOSCELES");
//     }
// }



// Testando exercício "Tempo de jogo com minutos"

// string[] valores = Console.ReadLine().Split(' ');
// int horaInicial = int.Parse(valores[0]);
// int minutoInicial = int.Parse(valores[1]);
// int horaFinal = int.Parse(valores[2]);
// int minutoFinal = int.Parse(valores[3]);

// int instanteInicial = horaInicial * 60 + minutoInicial;
// int instanteFinal = horaFinal * 60 + minutoFinal;

// int duracao;
// if (instanteInicial < instanteFinal)
// {
//     duracao = instanteFinal - instanteInicial;
// }
// else
// {
//     duracao = (24 * 60 - instanteInicial) + instanteFinal;
// }

// int duracaoHoras = duracao / 60;
// int duracaoMinutos = duracao % 60;

// Console.WriteLine("O JOGO DUROU " + duracaoHoras + " HORA(S) E " + duracaoMinutos + " MINUTO(S)");



// Testando exercício "Animal"

// string palavra1 = Console.ReadLine();
// string palavra2 = Console.ReadLine();
// string palavra3 = Console.ReadLine();

// if (palavra1 == "vertebrado")
// {
//     if (palavra2 == "ave")
//     {
//         if (palavra3 == "carnivoro")
//         {
//             Console.WriteLine("aguia");
//         }
//         else
//         {
//             Console.WriteLine("pomba");
//         }
//     }
//     else
//     {
//         if (palavra3 == "onivoro")
//         {
//             Console.WriteLine("homem");
//         }
//         else
//         {
//             Console.WriteLine("vaca");
//         }
//     }
// }
// else
// {
//     if (palavra2 == "inseto")
//     {
//         if (palavra3 == "hematofago")
//         {
//             Console.WriteLine("pulga");
//         }
//         else
//         {
//             Console.WriteLine("lagarta");
//         }
//     }
//     else
//     {
//         if (palavra3 == "hematofago")
//         {
//             Console.WriteLine("sanguessuga");
//         }
//         else
//         {
//             Console.WriteLine("minhoca");
//         }
//     }
// }



// Testando exercício "Sort Simples"

// int x, y, z, maior, meio, menor;

// string[] valores = Console.ReadLine().Split(' ');
// x = int.Parse(valores[0]);
// y = int.Parse(valores[1]);
// z = int.Parse(valores[2]);

// if (x < y && x < z)
// {
//     menor = x;
//     if (y < z)
//     {
//         meio = y;
//         maior = z;
//     }
//     else
//     {
//         meio = z;
//         maior = y;
//     }
// }
// else if (y < z)
// {
//     menor = y;
//     if (x < z)
//     {
//         meio = x;
//         maior = z;
//     }
//     else
//     {
//         meio = z;
//         maior = x;
//     }
// }
// else
// {
//     menor = z;
//     if (x < y)
//     {
//         meio = x;
//         maior = y;
//     }
//     else
//     {
//         meio = y;
//         maior = x;
//     }
// }

// Console.WriteLine(menor);
// Console.WriteLine(meio);
// Console.WriteLine(maior);
// Console.WriteLine();
// Console.WriteLine(x);
// Console.WriteLine(y);
// Console.WriteLine(z);



// Testando exercício "triangulo"

// double area, perimetro;

// string[] X = Console.ReadLine().Split(' ');
// double a = double.Parse(X[0]);
// double b = double.Parse(X[1]);
// double c = double.Parse(X[2]);

// if (a < b + c && b < a + c && c < a + b)
// {
//     perimetro = a + b + c;
//     Console.WriteLine("Perimetro = " + perimetro.ToString("F1"));
// }
// else
// {
//     area = ((a + b) * c) / 2;
//     Console.WriteLine("Area = " + area.ToString("F1"));
// }



// int X = int.Parse(Console.ReadLine());

// switch(X)
// {
//     case 61:
//     Console.WriteLine("Brasilia");
//     break;
//     case 71:
//     Console.WriteLine("Salvador");
//     break;
//     case 11:
//     Console.WriteLine("Sao Paulo");
//     break;
//     case 21:
//     Console.WriteLine("Rio de Janeiro");
//     break;
//     case 32:
//     Console.WriteLine("Juiz de Fora");
//     break;
//     case 19:
//     Console.WriteLine("Campinas");
//     break;
//     case 27:
//     Console.WriteLine("Vitoria");
//     break;
//     case 31:
//     Console.WriteLine("Belo Horizonte");
//     break;
//     default:
//     Console.WriteLine("DDD nao cadastrado");
//     break;
// }



// Testando Exercício "Mês"

// int m = int.Parse(Console.ReadLine());

// if (m == 1)
// {
//     Console.WriteLine("January");
// }
// else if (m == 2)
// {
//     Console.WriteLine("February");
// }
// else if (m == 3)
// {
//     Console.WriteLine("March");
// }
// else if (m == 4)
// {
//     Console.WriteLine("April");
// }
// else if (m == 5)
// {
//     Console.WriteLine("May");
// }
// else if (m == 6)
// {
//     Console.WriteLine("June");
// }
// else if (m == 7)
// {
//     Console.WriteLine("July");
// }
// else if (m == 8)
// {
//     Console.WriteLine("August");
// }
// else if (m == 9)
// {
//     Console.WriteLine("September");
// }
// else if (m == 10)
// {
//     Console.WriteLine("October");
// }
// else if (m == 11)
// {
//     Console.WriteLine("November");
// }
// else
// {
//     Console.WriteLine("December");
// }



// /testando exercicio "Numeros positivos e media"

// double soma, media;

// double A = double.Parse(Console.ReadLine());
// double B = double.Parse(Console.ReadLine());
// double C = double.Parse(Console.ReadLine());
// double D = double.Parse(Console.ReadLine());
// double E = double.Parse(Console.ReadLine());
// double F = double.Parse(Console.ReadLine());

// soma = 0;
// media = 0;

// if (A > 0)
// {
//     soma = soma + 1;
//     media = media + A;
// }
// if (B > 0)
// {
//     soma = soma + 1;
//     media = media + B;
// }
// if (C > 0)
// {
//     soma = soma + 1;
//     media = media + C;
// }
// if (D > 0)
// {
//     soma = soma + 1;
//     media = media + D;
// }
// if (E > 0)
// {
//     soma = soma + 1;
//     media = media + E;
// }
// if (F > 0)
// {
//     soma = soma + 1;
//     media = media + F;
// }
// media = media / soma;

// Console.WriteLine(soma + " valores positivos");
// Console.WriteLine(media.ToString("F1"));



// Testando exercicio "Par, impar, negativo e positivo"

// int Par, Impar, Positivo, Negativo;

// int A = int.Parse(Console.ReadLine());
// int B = int.Parse(Console.ReadLine());
// int C = int.Parse(Console.ReadLine());
// int D = int.Parse(Console.ReadLine());
// int E = int.Parse(Console.ReadLine());

// Positivo = 0;
// Negativo = 0;
// Par = 0;
// Impar = 0;

// if(A > 0)
// {
//     Positivo = Positivo + 1;
// }
// else if (A < 0) {
//     Negativo = Negativo + 1;
// }
// if(A % 2 == 0)
// {
//     Par = Par + 1;
// }
// else{
//     Impar = Impar + 1;
// }
// if(B > 0)
// {
//     Positivo = Positivo + 1;
// }
// else if (B < 0) {
//     Negativo = Negativo + 1;
// }
// if(B % 2 == 0)
// {
//     Par = Par + 1;
// }
// else{
//     Impar = Impar + 1;
// }
// if(C > 0)
// {
//     Positivo = Positivo + 1;
// }
// else if (C < 0) {
//     Negativo = Negativo + 1;
// }
// if(C % 2 == 0)
// {
//     Par = Par + 1;
// }
// else{
//     Impar = Impar + 1;
// }
// if(D > 0)
// {
//     Positivo = Positivo + 1;
// }
// else if (D < 0) {
//     Negativo = Negativo + 1;
// }
// if(D % 2 == 0)
// {
//     Par = Par + 1;
// }
// else{
//     Impar = Impar + 1;
// }
// if(E > 0)
// {
//     Positivo = Positivo + 1;
// }
// else if (E < 0) {
//     Negativo = Negativo + 1;
// }
// if(E % 2 == 0)
// {
//     Par = Par + 1;
// }
// else{
//     Impar = Impar + 1;
// }
// Console.WriteLine(Par + " valor(es) par(es)");
// Console.WriteLine(Impar + " valor(es) impar(es)");
// Console.WriteLine(Positivo + " valor(es) positivo(s)");
// Console.WriteLine(Negativo + " valor(es) negativo(s)");



// Testando exercício "Seis numeros impares"

int X = int.Parse(Console.ReadLine());

if (X % 2 == 0)
{
    X = X + 1;
    Console.WriteLine(X);
    Console.WriteLine(X + 2);
    Console.WriteLine(X + 4);
    Console.WriteLine(X + 6);
    Console.WriteLine(X + 8);
    Console.WriteLine(X + 10);  
}
else{
    Console.WriteLine(X);
    Console.WriteLine(X + 2);
    Console.WriteLine(X + 4);
    Console.WriteLine(X + 6);
    Console.WriteLine(X + 8);
    Console.WriteLine(X + 10);
}