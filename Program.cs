//void ImprimirMatriz(int[,] matrix)
//{
//    int fil = matrix.GetLength(0);
//    int col = matrix.GetLength(1);

//    for (int f = 0; f < fil; f++)
//    {
//        for (int c = 0; c < col; c++)
//        {
//            Console.Write(matrix[f, c] + "\t");
//        }
//        Console.WriteLine();
//    }
//    Console.WriteLine();



//}


//int[,] matrizA =
//{
//    {1,2,3 },
//    {4,5,6 },
//    {7,8,9 }

//};

//int[,] matrizB =
//{
//    {7,8,9 },
//    {4,5,6 },
//    {1,2,3 }

//};

//int fila = matrizA.GetLength(0);
//int columnas = matrizA.GetLength(1);
//int[,] matrizResultado = new int[fila, columnas];


//for (int f = 0; f < fila; f++)
//{
//    for (int c = 0; c < columnas; c++)
//    {
//        matrizResultado[f, c] = matrizA[f, c] + matrizB[f, c];
//    }

//}

//ImprimirMatriz(matrizResultado);

int[,] tablero = new int[5, 5];

void paso1creartablero()
{

    for (int f = 0; f < tablero.GetLength(0); f++)
    {

        for (int c = 0; c < tablero.GetLength(1); c++)
        {
            tablero[f, c] = 0;
        }
            
    }


}

void paso2colocarbarcos()
{

    tablero[4, 3] = 1;
    tablero[1, 1] = 1;
    tablero[2, 1] = 1;
    tablero[3, 4] = 1;
    
}
void paso3imprimir()
{
    string caracteraimprimir = "";
    for (int f = 0; f < tablero.GetLength(0); f++)
    {
        for (int c = 0; c < tablero.GetLength(1); c++)
        {
            switch (tablero[f, c])
            {
                case 0:
                    caracteraimprimir = "~";
                    break;
                case 1:
                    caracteraimprimir = "b";
                    break;
                case -1:
                    caracteraimprimir = "*";
                    break;
                case -2:
                    caracteraimprimir = "x";
                    break;
                default:
          
                    caracteraimprimir = "~";
                    break;



            }
            Console.Write(caracteraimprimir + " ");
        }
        Console.WriteLine();
    }
    
   }
void paso4ingresocordenadas()
{
    int fila, columna = 0;
    Console.Clear();

    do
    {
        Console.Write("ingresa la fila");
        fila = Convert.ToInt32(Console.ReadLine());
        Console.Write("ingresa la columna");
        columna = Convert.ToInt32(Console.ReadLine());

        if (tablero[fila, columna] == 1)
        {
            Console.Beep();
            tablero[fila, columna] = -1;

        }else
        {
            tablero[fila, columna] = -2;
        }
        Console.Clear();
        paso3imprimir();
    } while (true);
}



paso4ingresocordenadas();
paso1creartablero();
paso2colocarbarcos();
paso3imprimir();