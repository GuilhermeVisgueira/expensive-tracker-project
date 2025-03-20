// See https://aka.ms/new-console-template for more information


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
        int id = 0;
        do
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("             MENU              ");
            Console.WriteLine("Lista de itens:");
            Console.WriteLine("1 - Adicionar Item:");
            Console.WriteLine("2 - Alterar Item:");
            Console.WriteLine("3 - Remover Item:");
            Console.WriteLine("0 - Sair");
            option = int.Parse(Console.ReadLine());

            switch (option)
            {
                case 1:
                    Console.WriteLine("Digite o item e o valor:");
                    String item = Console.ReadLine();
                    double Valor = double.Parse(Console.ReadLine());
                    id++;
                    ExpenseList.Add(new Custo(id, item, Valor));
                    break;
                case 2: 
                   
                    Console.WriteLine("Alterar descrição digitar 1:");
                    Console.WriteLine("Alterar valor digitar 2:");
                    
                    int idCond = int.Parse(Console.ReadLine());

                    while (idScanner != id) 
                    {
                        if (idCond == 1)
                        {
                            Console.WriteLine("Descrição alterada com sucesso");
                        } else if (idCond == 2)
                        {
                            Console.WriteLine("Valor alterada com sucesso");
                            
                        }
                        else
                        {
                            Console.WriteLine("Digite um 1 ou 2");
                        }
                        
                    }
                    
                    Console.WriteLine("O valor foi alterado com sucesso");
                    break;
                    
                case 3:
                    Console.WriteLine("O valor foi removido com sucesso:");
                    Console.WriteLine("Digite o id do item:");
                    int idScanner = int.Parse(Console.ReadLine());
                    
                    break;
                case 0:
                    option = 0;
                    break;
            }
        }while (option != 0);
        
    }
}
