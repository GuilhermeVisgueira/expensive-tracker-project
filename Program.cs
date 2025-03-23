﻿// See https://aka.ms/new-console-template for more information


/*  REQUIRENMENTS
    Users can add an expense with a description and amount.
    Users can update an expense.
    Users can delete an expense.
    Users can view all expenses.
    Users can view a summary of all expenses.
    Users can view a summary of expenses for a specific month (of current year).
*/

using ExpenseTracker;

class Program
{
    public static void Main()
    {
        List<Custo> ExpenseList = new List<Custo>();

        // loop de um menu
        int option = 0;
        int id = 1;
        do
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("             MENU              ");
            Console.WriteLine("Lista de itens:");
            Console.WriteLine("1 - Adicionar Item:");
            Console.WriteLine("2 - Alterar Item:");
            Console.WriteLine("3 - Remover Item:");
            Console.WriteLine("0 - Sair");
            Console.WriteLine("-------------////---------------");
            option = int.Parse(Console.ReadLine());


            switch (option)
            {
                case 1:
                    Console.WriteLine("Digite o item:");
                    String item = Console.ReadLine();
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("Digite o valor do item:");
                    double Valor = double.Parse(Console.ReadLine());
                    Console.WriteLine("-------------------------------");
                    ExpenseList.Add(new Custo(id, item, Valor));
                    id++;
                    break;
                case 2:

                    Console.WriteLine("Digite o id do item:");
                    Console.WriteLine("-------------------------------");
                    int ChangeAmountOrDescription = int.Parse(Console.ReadLine());

                    Console.WriteLine("Alterar descrição digitar 1:");
                    Console.WriteLine("Alterar valor digitar 2:");
                    Console.WriteLine("Sair da alteração digitar 0:");
                    Console.WriteLine("-------------------------------");
                    int OptionAmountOrDescripion = int.Parse(Console.ReadLine());

                    int index = Utility.FindIndex(ChangeAmountOrDescription, ExpenseList);


                    while (OptionAmountOrDescripion != 0)
                    {
                        if (OptionAmountOrDescripion == 1)
                        {
                            Console.WriteLine("Digite nova descrição:");
                            string newDescription = Console.ReadLine();

                            if (index < 0)
                            {
                                Console.WriteLine("Item não encontrado");
                                Console.WriteLine("-------------------------------");
                            }
                            else
                            {
                                Custo custo = ExpenseList[index];
                                custo.ChangeDescription(newDescription);
                                Console.WriteLine("Descrição alterada com sucesso");
                                Console.WriteLine("-------------------------------");
                                break;
                            }
                        }
                        else if (OptionAmountOrDescripion == 2)
                        {
                            Console.WriteLine("Digite o novo valor:");
                            double newAmount = double.Parse(Console.ReadLine());

                            if (index < 0)
                            {
                                Console.WriteLine("Item não encontrado");
                                Console.WriteLine("-------------------------------");
                            }
                            else
                            {
                                Custo custo = ExpenseList[index];
                                custo.ChangeAmount(newAmount);
                                Console.WriteLine("Valor alterado com sucesso");
                                Console.WriteLine("-------------------------------");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Digite um 1 ou 2:");
                            OptionAmountOrDescripion = int.Parse(Console.ReadLine());
                            Console.WriteLine("-------------------------------");
                        }
                    }

                    Console.WriteLine("O valor foi alterado com sucesso");
                    break;

                case 3:
                    Console.WriteLine("O valor foi removido com sucesso:");


                    break;
                case 0:
                    option = 0;
                    break;
            }
        } while (option != 0);
    }
}