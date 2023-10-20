using System.Linq.Expressions;

//---------------------------COLECOES DE OBJECTOS--------------------------------------//

//----------------------------------LISTA---------------------------------------------//
/* Uma lista e uma extensao do array, a qual permite manipular os dados sem precisar
 se preocupar com a definicao do tamanho(memoria a alocar) da lista, ela vai aumentando
 consoante as nossas necessidades.
 Uma Lista trabalha internamente com um Array interno, mas ele nao mostra para que nao precise se preocupar
 com a complexibilidade dos arrays
 */

List<string> nomes = new List<string>(); 

nomes.Add("Anjo");
nomes.Add("Ana");
nomes.Add("juba");

Console.WriteLine($"o tamanho da minha lista e {nomes.Count} e a capacidade {nomes.Capacity}");

nomes.Add("Belton");
nomes.Add("Neto");
Console.WriteLine($"o tamanho da minha lista e {nomes.Count} e a capacidade {nomes.Capacity}");


for(int cont = 0; cont < nomes.Count; cont++) // nao usamos u <= porque o tamanho da lista e 3, comecando do 0 terminara em 2, enquando que o cont vai contar ate 3, por isso colocamos < que o tamanho da lsita
{
    Console.WriteLine($"A posicao {cont} e do/a {nomes[cont]}");
}

nomes.Remove("Ana");

Console.WriteLine($"o tamanho da minha lista e {nomes.Count} e a capacidade {nomes.Capacity}");

int conter = 0;
foreach (string item in nomes)
{
     Console.WriteLine($"A posicao {conter} e do/a {item}");
     conter++;
}




// //--------------ARRAYS E NAVEGACAO EM ARRAYS-------------------//



// int[] arrayL = new int[4];

// arrayL[0] = 1;
// arrayL[1] = 4;
// arrayL[2] = 3;
// arrayL[3] = 5;

// //PODE SE REDIMENSIONAR O ARRAY USANDO A CLASSE ARRAY.RESIZE()->METODO.
//   //Array.Resize(ref arrayL, arrayL.Length * 2);

// //COPIANDO ITENS DE UM ARRAY
// int[] arraycopy = new int[arrayL.Length]; //determinando o tamanho do novo array atraves do tamanho do antigo
// Array.Copy(arrayL, arraycopy, arrayL.Length);

// int contador = 0;

// foreach (int valor in arrayL)
// {
//     Console.WriteLine($"O Numero actual e {contador} - {valor} ");
//     contador++;
// }


//-------------------------------------------------------------------------------------------------//

//--------------------APLICACAO DE ESTRUTURAS DE REPETICAO----------------------------------------//

//-------------------------------------------------------------------------------------------------//

//----------------Construindo um Menu interativo-------------------------------------//
// string opcao;
// bool exibirMenu = true;

// while (exibirMenu)
// {
//     Console.WriteLine("Digite a sua opcao");
//     Console.WriteLine("1 - Cadastrar cliente");
//     Console.WriteLine("2 - Buscar cliente");
//     Console.WriteLine("3 - Actualizar cliente");
//     Console.WriteLine("4 - Encerrar");


//     opcao = Console.ReadLine();

//     switch (opcao)
//     {
//         case "1":
//         Console.WriteLine("Cliente cadastrado");
//         break;
//         case "2":
//         Console.WriteLine("Cliente encontrado");
//         break;
//         case "3":
//         Console.WriteLine("Cliente Actualizado");
//         break;
//         case "4":
//         Console.WriteLine("Cliente apagado");
//         exibirMenu = false;
//         break;

//         default:
//         Console.WriteLine("Opcao Invalida!");
//         //Environment.Exit(0);
//         break;
//     }
// }

// Console.WriteLine("\n Programa encerrad0");




//----------------Calculadora usando o metodo **DO WHILE**--------------------------------//

/* O metodo Do e executado em primeiro independente da condicao;
 A condicao e verificada no final da execucao;
*/
// int numeroAlvo = 10;
// int contador = 0;
// do
// {
//     Console.WriteLine($"{numeroAlvo} x {contador} = {numeroAlvo*contador}");
//     contador++;
//     /*if(contador >= 8)
//     {
//         break;
//     }*/
// } while (contador <= numeroAlvo);





/*-------------Calculadora usando o metodo **WHILE** --------------------------------------*/

/* O metodo while leva apenas um paramento que e a condicao.
 As variaveis sao definidas fora;
 NB: Temos que tomar cuidado se nao caimos em uma repeticao infinita, 
 entao tem que definir a condicao para sair do Loop pode usar o Break*/
//-------------------------------------------------------------------------------------------//

// int numeroAlvo = 10;
// int contador = 0;

// while (contador <= numeroAlvo)
// {
//     Console.WriteLine($"{numeroAlvo} x {contador} = {numeroAlvo*contador}");
//     contador++; // incremento para continuar a repeticao e ajudar na condicao

//     if(contador == 7) //Condicao para parar a repeticao
//     {
//         break;
//     }
// }


//---------------calculadora de taboada 10 usando o metodo **FOR**-------------------------------// 
/* O FOR leva tres parametros:
 - A variavel inicial da condicao,
 - A Condicao ou comparacao
 - O incremento/ decremento*/
//--------------------------------------------------------------------------------------------------//
// int numeroAlvo = 10;

// for (int contador = 0;contador <= numeroAlvo; contador++)
// {

//     Console.WriteLine($"{numeroAlvo} x {contador} = {numeroAlvo * contador}");
// }


//------------------------------------------------------------------------------------------------------//

/* -------------------------USO DA CLASS Math e seus metodos-/consulte o modelo Calculadora-----*/

//-----------------------------------------------------------------------------------------------------//

// Calculadora matematica = new();

// matematica.Somar(4,6);

// matematica.Dividir(90, 9);

// matematica.Potencia(4, 5);

// matematica.Seno(30);
// matematica.Coseno(90);


//------------------------------------------------------------------------------//

// METODOS CONDICIONAIS iF/ELSEIF/ELSE E SWITCH CASE

//--------------------------IF-------------------------------------------
// //VAmos construir um programa que permite o usario ir a uma festa se for
// //maior de idade ou tiver autorizacao do encarregado e for maior de 15
// Console.WriteLine("Qual e a sua idade?:");
// string? entrada = Console.ReadLine();
// int idade = int.Parse(entrada);
// bool autorizacao = true;

// if(idade >= 18 || autorizacao == true && idade !> 15)
// {
//     Console.WriteLine("Entrada permitida");
// }
// else
// {
//     Console.WriteLine("Voce e menor! \n Entrada rejeitada");
// }

//--------------------SWITCH-----------------------------------------

// //Vamos construir um programa que diz se o input e uma vogal
// //Para tal usaremos o Console.ReadLine()
// Console.WriteLine("Escreva a letra");
// string letra = Console.ReadLine();

// switch (letra)
// {
//     case "a":
//     case "e":
//     case "i":
//     case "o":
//     case "u":
//         Console.WriteLine("Vogal");
//         break;

//     default:
//         Console.WriteLine("Nao e vogal");
//         break;
// }


//-------------------------------------------------------------------------------//

// INSTANCIANDO UMA CLASSE E ATRIBUINDO VALORES

//--------------------------CLASSE-----------------------------------------------------//

// Pessoa usuario1 = new();

// usuario1.Nome = "Leu";
// usuario1.Apelido = "Ngoca";
// usuario1.Idade = 18;
// usuario1.Altura = 1.70;
// usuario1.Saldo = 500.00M;

//-----------------------------------------------------------------------------------//

/// DECLARACAO DE VARIAVEL E CONVERSAO DE FORMATO

//-------------------------------------------------------------------------------------//

//------Declaracao de variaveis e tipos de dados mais usados---------/

// string palavras = "Ana";
// int numeroInteiro = 8;
// double numeroComCasasDecimais = 1.80;
// decimal numeroComCasasDecimais = 1.80M; //usado para casos como valores monetarios

/*-------Conversao de formatos---------------------------------------------------------
 Para converter um determinado valor para um formato diferente 
 nos utilizamos a Class Convert e selecionamos o metodo(.To) ou podemos usar o metodo:
 
 Parse() -> usado para converter numeros no formato string em numeros reais int/double/decimal
 ToString() -> metodo usado para converter numeros reais em strings
 TryParse() -> metodo usado para converter o formato de dados em outro quando se desconhece a sua natureza/ tipo
 
 */

//-------------------- exemplo------------------------------
//Converta o saldo do usuario em string 

// // string nome = "Bala "+ Convert.ToString(usuario1.Saldo);
// string nome = usuario1.Altura.ToString("0.00");
// //Podemos converter int para string usando o metodo ToString

// //Podemos fazer o mesmo processo para converter string pa numero inteiro usando  o metodo Parse
// int altura = int.Parse("5");
// usuario1.Apresentar();
// Console.WriteLine(nome);
