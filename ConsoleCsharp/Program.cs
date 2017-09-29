
//CONDIÇÃO IF, ELSE, ELSE IF

using System;

class consoleCSharp
    {
    static void Main()
    {

        int idade = 17;

        if (idade < 17)
        {
            Console.WriteLine("Menor de Idade");
            Console.WriteLine("Proibido Bebidas Alcoolicas");
            Console.WriteLine("Entrada Proibida");
        }
                
         else if (idade > 17)
        {
            Console.WriteLine("Maior de Idade");
            Console.WriteLine("Autorizado a Venda de Bebidas Alcoolicas");
            Console.WriteLine("Entrada Autorizada");
        }

                
            Console.ReadLine();
        
}

}





//class ConsoleCSharp
//{
//    static void Main()
//    {

//        int idade = 12;
        
//        if(idade > 17)
//            {
//            Console.WriteLine("Autorizado!");
//            Console.WriteLine("Autorizado!");
//            Console.WriteLine("Autorizado!");
//            }
//        else if (idade > 2)
            
//            Console.WriteLine("Bebe Suco");
        
//        else 
//            Console.WriteLine("Bebe Leite");

     
//        Console.ReadLine();
//    }
//}






//using System;

//class ConsoleCSharp
//{
//    static void Main()
//    {

//        int a = 15;
//        int b = 2;

//        int resultado = a / b;
//        int resto = a % b;

//        Console.WriteLine(resultado);
//        Console.WriteLine(resto);
//    }
//}


//-----------------------------------------------------------------------------------------


//OPERADORES ARITIMÉTICOS - RESTO


//using System;

//class ConsoleCSharp
//{
//    static void Main()
//    {

//        int a = 15;
//        int b = 2;

//        int resultado = a / b;
//        int resto = a % b;

//        Console.WriteLine(resultado);
//        Console.WriteLine(resto);
//    }
//}

//-----------------------------------------------------------------------------------------

////OPERADORES ARITIMÉTICOS

//using System;

//class ConsoleCSharp
//{
//    static void Main()
//    {

//        int a = 15;
//        int b = 2;

//        decimal resultado = Convert.ToDecimal(a) / Convert.ToDecimal(b);

//        Console.WriteLine(resultado);
//    }
//}

//-----------------------------------------------------------------------------------------

////TIPOS DE VARIAVEIS

//using System;

//class ConsoleCSharp
//{
//    static void Main()
//    {



// int matricula = 10;                     //Varievel do tipo inteiro 

//string nome = "Pedro";                    //Varievel do tipo String
//                                          //Nunca esquecer as aspas - EX: "String"  

//string sobrenome = "Silva";                 //Varievel do tipo String

//DateTime dataNascimento = DateTime.Now; //Varievel do tipo Data 
//                                        //DateTime.Now -> Informa a data e hora atual

//decimal Salario = 1000.50m;             //Varievel do tipo decimal "=" Ultiliza para atribuir valores
//                                        //Formato: (R$ 500.50m) representa R$ 500,00 na vida real
//                                        //(Lembrar de adicionar esse "m" no sufixo)

//bool FeriasVencidas = true;             //Varievel do tipo boleando "=" Ultiliza para atribuir valores
//                                        //bool -> Se a informação é verdadeira ou falsa

//char Sexo = 'M';                        //Varievel do tipo inteiro "=" Ultiliza para atribuir valores

//        Console.WriteLine(matricula + " -" + " " + nome + " " + sobrenome + " -" + " " + dataNascimento + " -" + " " + Salario + " -" + " " + FeriasVencidas + " " + "-" + Sexo); //Escreve a string!!!
//        Console.ReadLine();  //Lê tudo que está na tela preta!!!
//    }
//}
