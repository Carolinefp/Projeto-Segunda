int tamanho = 100;
int[] vetor = new int[tamanho];

//vetor valores aleatorios
Random random = new Random();
for (int i = 0; i < tamanho; i++)
{

    vetor[i] = random.Next(100);

}
// imprimir o vetor sem ordenação
for (int i = 0; i < tamanho; i++)
{

    Console.Write(vetor[i] + " ");

}

bool troca = false;
do
{
    for (int i = 0; i < tamanho - 1; i++)
    {

        if (vetor[i] > vetor[i + 1])
        {
            int aux = vetor[i];
            vetor[i] = vetor[i + 1];
            vetor[i + 1] = aux;
            troca = true;
        }

    }
} while (troca);

// imprimir o vetor ordenadas
for (int i = 0; i < tamanho; i++)
{

    Console.Write(vetor[i] + " ");

}