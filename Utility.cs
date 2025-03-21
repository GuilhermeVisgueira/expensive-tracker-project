namespace ExpenseTracker;

/// <summary>
/// Guardar as funções que são mais utilizadas para diminuir redundancias
/// </summary>
public static class Utility
{
    // Print a message and read a string from the console
    public static string PrintAndRead(string message)
    {
        Console.WriteLine(message);
        return Console.ReadLine();
    }

    /// <summary>
    /// Procura o id que o usuario colocou e retorna o index se o index nao for encontrado retorna negativo
    /// </summary>
    /// <param name="id">Usuario vai colocar o id que deseja alterar</param>
    /// <param name="lista">Lista do tipo Custo, para servir de aux na procura do index</param>
    /// <returns>retorna um INT que é o index</returns>
    public static int FindIndex(int id, List<Custo> lista)
    {
        //achar o index da lista
        for (int indexList = 0; indexList < lista.Count; indexList++)
        {
            Custo item = lista[indexList];
            if (item.GetId() == id)
            {
                return indexList;
            }
            
        }
        return -1;
    }
}