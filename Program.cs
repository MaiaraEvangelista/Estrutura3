using System;

namespace Estruturas3
{
    class Program
    {
        static void Main(string[] args)
        {
            //nome diferente de vazio
                    string nome;
            do{
                Console.WriteLine("Digite seu nome: ");
                nome = Console.ReadLine();

            }while(nome == "" || nome == " ");

            //idade entre 0 e 150
            int idade;

                do{
                    Console.WriteLine("Qual a sua idade?: ");
                    idade = int.Parse(Console.ReadLine());
                    
                    if(idade <= 0 || idade >150){
                        Console.WriteLine("Resposta Inválida!");
                    }
                } while (idade <=0 || idade > 150);
                    Console.WriteLine("Continue a operação");


                    Console.WriteLine("-----------------------------------");
                
                    //salario maior que zero
                        int salario;

                    do{
                        Console.WriteLine("Informe seu salário: ");
                        salario = int.Parse(Console.ReadLine());

                        if(salario < 0  ){
                            Console.WriteLine("Valor Inválido");
                        
                        }
                    } while (salario < 0  );
                        Console.WriteLine("Continue a operação");

                    
                    Console.WriteLine("------------------------------------------");

                    //Estado Civil's : solteiro, casado, viuvo, divorciado
                       int estadoCivil;
                       do
                       {
                           Console.WriteLine("Digite seu estado civil: 's'(solteiro(a)), 'c'(casado(a)), 'd'(divorciado(a)), 'v'(viuvo(a)) ");
                           string estado = Console.ReadLine();
                           estadoCivil = estado.ToCharArray()[0];
                       } while (estadoCivil != 's' && estadoCivil !=  'c' && estadoCivil != 'd' && estadoCivil != 'v');

                        Console.WriteLine("-----------------------------------------------------------------------------");
                       Console.WriteLine("Valores Aceitos");

                       
        }  

                
    }
}
