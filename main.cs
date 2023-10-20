using System;

class Program {
  public static void Main (string[] args) {
  
    int numNPCs;

    // Variáveis para guardar características de cada NPC
    Classes[] npcClasses;
    Perks[] npcPerks;

    // Pedir número de NPCs
    Console.Write("Indica o número de NPCs: ");
    numNPCs = int.Parse(Console.ReadLine());

    // Inicializar array de NPCs
    npcClasses = new Classes[numNPCs];
    npcPerks = new Perks[numNPCs];

    Console.WriteLine();

    // Ciclo FOR para pedir características de cada NPC
    for (int i = 0; i < numNPCs; i++)
    {
        for (int j = 0; j < Enum.GetNames(typeof(Classes)).Length; j++)
        {
            // Variável que irá guardar input do utilizador em cada ciclo
            string input;

            // Definir classe de NPC atual
            Console.Write($"NPC {i + 1} tem classe {(Classes) j}? (s/n): ");
            input = Console.ReadLine();

            // Determinar característica de NPC atual 
            // com base na sua classe
            if (input == "s")
            {
                npcClasses[i] = (Classes) j;

                switch ((Classes) j)
                {
                case (Classes) 0:
                    npcPerks[i] = Perks.Combat|Perks.Luck                     ;
                    break;
                case (Classes) 1:
                    npcPerks[i] = Perks.Lockpick;
                    break;
                case (Classes) 2:
                    npcPerks[i] = Perks.Intelligence;
                    break;
                case (Classes) 3:
                    npcPerks[i] = Perks.Combat;
                    break;
                case (Classes) 4:
                    npcPerks[i] = Perks.Lockpick;
                    break;
                case (Classes) 5:
                    npcPerks[i] = Perks.Luck;
                    break;
                case (Classes) 6:
                    npcPerks[i] = Perks.None;
                    break;
                case (Classes) 7:
                    npcPerks[i] = Perks.Stealth;
                    break;
                case (Classes) 8:
                    npcPerks[i] = Perks.Luck;
                    break;
                case (Classes) 9:
                    npcPerks[i] = Perks.Stealth;
                    break;
                }
                break;
            }
        }

        Console.WriteLine();
    }

    // Ciclo FOR para categorizar cada NPC
    for (int i = 0; i < numNPCs; i++)
    {
        Console.WriteLine($"NPC {i + 1}");

        // Mostrar classe de NPC atual no ecrã
        Console.WriteLine($"\t Classe: {npcClasses[i]}");

        // Mostrar característica de NPC atual no ecrã
        Console.WriteLine($"\t Característica: {npcPerks[i]}");

        Console.WriteLine();
  }
}
  }