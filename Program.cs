
System.Console.WriteLine("Выберите задачу:");
System.Console.WriteLine();
System.Console.WriteLine("1 - Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.");
System.Console.WriteLine();
System.Console.WriteLine("2 - Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.");
System.Console.WriteLine();
System.Console.WriteLine("3 - Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.");
System.Console.WriteLine();
System.Console.WriteLine("4 - Задача 60. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив,");
System.Console.WriteLine(" добавляя индексы каждого элемента.");
System.Console.WriteLine();
System.Console.WriteLine("5 - Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.");
int TaskIndex = int.Parse(Console.ReadLine());
System.Console.WriteLine();
switch (TaskIndex)
{
    case 1:

        static void Task1()
        {
            int[,] array = {{1,4,7,2},
                        {5,9,2,3},
                        {8,4,2,4}};



            for (int i = 0; i < array.GetLength(0); i++)
            {

                for (int j = 0; j < array.GetLength(1) - 1; j++)
                {
                    for (int z = 0; z < array.GetLength(1) - 1; z++)
                    {
                        if (array[i, z] < array[i, z + 1])
                        {
                            int temp = 0;
                            temp = array[i, z];
                            array[i, z] = array[i, z + 1];
                            array[i, z + 1] = temp;
                        }
                    }
                }


            }

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    System.Console.Write(array[i, j]);
                }
                System.Console.WriteLine();
            }

        }
        Task1();

        break;

    case 2:

        static void Task2()
        {
            int[,] array = {{1,4,7,2},
                            {5,9,2,3},
                            {8,4,2,4}};
            int[] sum = new int[array.GetLength(0)];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    sum[i] = sum[i] + array[i,j];
                }
            }
            int min = sum[0];
            int stringName = new int(); 
            for (int i = 0; i < sum.Length; i++)
            {
                if (sum[i] <= min) 
                {
                min = sum[i]; 
                stringName = i+1;
                }               
            }
            System.Console.WriteLine($"Номер строки массива с наименьшим значением - {stringName}");
        }
        Task2();
        break;

    case 3:
        static void Task3()
        {
            int[,] Matrix1 = {{3,5},
                              {4,3}};
            int[,] Matrix2 = {{2,1},
                              {3,6}};
            int[,] MatrixProd = new int[2,2];

            for (int i = 0; i < Matrix1.GetLength(0)-1; i++)
            {
                for (int j = 0; j < Matrix1.GetLength(1)-1; j++)
                {   
                    MatrixProd[i,j] = Matrix1[i,j] * Matrix2[i,j] + Matrix1[i,j+1] * Matrix2[i+1,j];
                    MatrixProd[i,j+1] = Matrix1[i,j] * Matrix2[i,j+1] + Matrix1[i,j+1] * Matrix2[i+1,j+1];
                    MatrixProd[i+1,j] = Matrix1[i+1,j] * Matrix2[i,j] + Matrix1[i+1,j+1] * Matrix2[i+1,j];
                    MatrixProd[i+1,j+1] = Matrix1[i+1,j] * Matrix2[i,j+1] + Matrix1[i+1,j+1] * Matrix2[i+1,j+1];
                }                     
            }
            for (int i = 0; i < MatrixProd.GetLength(0); i++)
            {
                for (int j = 0; j < MatrixProd.GetLength(1); j++)
                {
                    System.Console.Write(MatrixProd[i,j] + " ");
                }
                System.Console.WriteLine();
            }
        }
        Task3();
        break;

    case 4:
        static void Task4()
        {
            int[,,] array = new int[2,2,2];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int c = 0; c < array.GetLength(2); c++)
                    {
                        array[i,j,c] = new Random().Next(1,10);
                    }
                    
                }
                
            }


            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    for (int c = 0; c < array.GetLength(2); c++)
                    {
                        System.Console.Write($"{array[i,j,c]}({i},{j},{c}) ");
                    }
                    System.Console.WriteLine();
                }
                System.Console.WriteLine();
            }
        }
        Task4();
        break;

    case 5:
        static void Task5() //Я бы сказал что решение не очень, но все что пришло в голову. Прошу прокоментировать что вы о нем думаете)
        //Видел как можно лучше, но хотел додуматься своими силами. Тфак и не понял почему у меня числа в цикле назад не печатаются, поэтому написал подобные костыли
        // изначально хотел сделать for с переменной которая убывает (a--) но тогда числа не печатались
        {
            int[,] numbers = new int[4,4];
            int num = 00;
            for (int j = 0; j < numbers.GetLength(1); j++)
            {
                numbers[0,j] = num + 1;
                num++;
                if (j == numbers.GetLength(1)-1)
                {
                    for (int i = 1; i < numbers.GetLength(0); i++)
                    {
                        numbers[i,j] = num + 1;
                        num++;
                        if (i == numbers.GetLength(0)-1)
                        {
                            
                            for (int a = 3; a < 0; a--)
                            {
                                
                                numbers[i,a] = num + 1;
                                num++;
                                
                            }
                        }
                    }
                }
            }
            
              
            

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    if (numbers[i,j]<10)
                    {
                        System.Console.Write($"{0}{numbers[i,j]} ");
                    } else System.Console.Write(numbers[i,j] + " ");
                    
                }
                System.Console.WriteLine();
            }
        }
        Task5();
        break;

    default:
        System.Console.WriteLine("Такой задачи нет"); break;
}
