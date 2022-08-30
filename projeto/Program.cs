// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

// Alteração realizada por Lucas Parra Sgarbosa

Console.WriteLine("Lucas123123123123");

// Outra alteração realizada por Lucas Parra Sgarbosa

string [,] matrix = new string[3,3];

for(int i = 0; i < matrix.GetLength(0); i++){
    for(int j = 0; j < matrix.GetLength(1); j++){
        matrix[i, j] = "Lucas";
    }
}

for(int i = 0; i < matrix.GetLength(0); i++){
    for(int j = 0; j < matrix.GetLength(1); j++){
        Console.WriteLine(matrix[i, j]);
    }
}
