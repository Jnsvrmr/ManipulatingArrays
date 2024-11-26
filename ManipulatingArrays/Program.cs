int[] scores = new int[4];  

void FillArray(int[] arrayOfIntegers)
{
    Random random = new Random();   
    for (int i = 0; i < arrayOfIntegers.Length; i++)
    {
        arrayOfIntegers[i] = random.Next(1,50); 
    }
}

FillArray(scores);

void PrintArray(int[] arrayOfIntegers)
{
    for (int i = 0; i < arrayOfIntegers.Length; i++)
    {
        Console.WriteLine($"array[{i}]: {arrayOfIntegers[i]}");
    }
    Console.WriteLine("");
}

PrintArray(scores); 
//scores[4] = 34;

int[] IncreaseSizeOfIntegerToArray(int[] arrayOfIntegers, int wishedIndex)
{
    
    int[] newArrayOfIntegers = new int[wishedIndex +1];
    Array.Copy(arrayOfIntegers, newArrayOfIntegers,arrayOfIntegers.Length);
    return newArrayOfIntegers;
}


int[] AddElementToArrayOfInteger(int[] arrayOfIntegers, int integerToAdd, int wishedIndex)
{
    if(wishedIndex > arrayOfIntegers.Length)
    {
        arrayOfIntegers = IncreaseSizeOfIntegerToArray(arrayOfIntegers, wishedIndex); 
    }
    arrayOfIntegers[wishedIndex] = integerToAdd;
    return arrayOfIntegers;
}

scores = AddElementToArrayOfInteger(scores, 9, 8);
PrintArray(scores);