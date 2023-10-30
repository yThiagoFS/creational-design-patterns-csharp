int[] list = { 1, 2, 3, 4, 5 };

var indexadores = new Indexadores.Models.Indexadores();

for (int index = 0; index < list.Length; index++)
    indexadores[index] = new Indexadores.Models.Indexadores($"Indexador {index}");

for (int index = 0; index < list.Length; index++)
    Console.WriteLine(indexadores[index].Mensagem);
