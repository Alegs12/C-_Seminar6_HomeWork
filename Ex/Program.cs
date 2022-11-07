// Семинар 6 ДЗ

Start();

int SetNumber(string str)
{
    System.Console.WriteLine(str);
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}

int GetPositiveSumm(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i] > 0) sum += arr[i];
    }
return sum;
}


void Start()
{
    while(true)
    {
        System.Console.WriteLine("Нажмите Enter");
        Console.ReadLine();
        Console.Clear();

        System.Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел.Посчитайте, сколько чисел больше 0 ввёл пользователь.");
        System.Console.WriteLine("Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 *x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
        System.Console.WriteLine("0 - Выход из программы");

        int numberTask = SetNumber("Введите номер задачи и нажмите Enter");

        switch(numberTask)
        {
            case 0: 
            {
                return; 
                break;
            }
            case 41: 
            {
                int sum = GetPosiSumFromKeyboard(); 
                Console.WriteLine("Сумма полжительных элементов равна " + sum);
                break;
            }
            case 43:
            {
                SetCrossLines(); 
                break;
            }
            default:
            {
                System.Console.WriteLine("Неверный номер");
                break;
            }
                
        }
    }

}


// Задача 41: Пользователь вводит с клавиатуры M чисел.
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2

int GetPosiSumFromKeyboard()
{
    System.Console.WriteLine("Введите числa через пробел ");
    string st=Console.ReadLine();
    string[] st1 = st.Split(' ', StringSplitOptions.RemoveEmptyEntries);
    int[] arr = new int[st1.Length];

    for (int i = 0; i < st1.Length; i++)
    {
        arr[i] = Convert.ToInt32(st1[i]);
    }
    int sum = GetPositiveSumm(arr);
    return sum;
}


//Задача 43. Напишите программу, которая найдёт точку пересечения двух прямых, заданных 
//уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

void SetCrossLines()
{
    int k1 = SetNumber("Введите k1");
    int b1 = SetNumber("Введите b1");
    int k2 = SetNumber("Введите k2");
    int b2 = SetNumber("Введите b2");

    int x = (b2-b1)/(k1-k2);
    int y = k1*x+b1;
    System.Console.WriteLine($"Линии y = k1*x + b1 и y = k2*x + b2 пересекаются в точках ({x};{y})");
}