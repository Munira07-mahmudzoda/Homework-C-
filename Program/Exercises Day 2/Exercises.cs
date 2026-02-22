Exercise 2
using System;
class Program
{
	static void Main()
	{
		// 1. Сохтани массив барои 5 адад
		double[] temperatures = new double[5];
		double sum = 0;
		Console.WriteLine("Пожалуйста,введите 5 температур.:");
		// 2. Цикл барои гирифтани маълумот
		for (int i = 0; i < 5; i++)
		{
			Console.Write($"Температура {i + 1}: ");
			temperatures[i] = double.Parse(Console.ReadLine());
			sum += temperatures[i]; // Чамъ кардани хароратхо
		}
		// 3. Ёфтани миёнаи арифметики
		double average = sum / 5;
		Console.WriteLine("----------------------------------------");
		Console.WriteLine($"Миёнаи харорат: {average}");
		Console.ReadLine(); // Барои он ки тиреза фавран пушида нашавад
	}
}
Exercise 3
using System;
class Program
{
	static void Main() 
	{
		Console.Write("Введите число:");
		double num = double.Parse(Console.ReadLine());
		if(num > 0)
		{
			Console.WriteLine("Число положительное");
		}
		else if(num < 0)
		{
			Console.WriteLine("Число отрицательное");
		}
		else
		{
			Console.WriteLine("Это ноль");
		}
	}
}
Exercise 4
using System;
class Program
{
	static void Main() 
	{
Console.Write("Введите первое число:");
			  double a = double.Parse(Console.ReadLine());
			  Console.Write("Введите оператор(+,-,*,/):");
			  char op = Console.ReadKey().KeyChar;
			  Console.WriteLine();
			  Console.Write("Введите второе число:");
			  double b = double.Parse(Console.ReadLine());
			  switch (op)
			  {
				  case '+': Console.WriteLine($"Resultater:{a+b}"); break;
				   case '-': Console.WriteLine($"Resultater:{a-b}"); break;
				   case '*': Console.WriteLine($"Resultater:{a*b}"); break; 
				   case '/':
				  if(b!=0) Console.WriteLine($"Resultater:{a/b}"); 
				  else Console.WriteLine("Ошибка:деление на ноль!");
				  break;
				  default:Console.WriteLine("Неверный оператор"); break;
			  }
			  }
			  }
Exercise 5
using System;
class Program
{
	static void Main() 
	{
Console.Write("Введите число для таблицы умножения:");
		int n=
			int.Parse(Console.ReadLine());
		for(int i = 1; i <=10; i++) 
		{
			Console.WriteLine($"{n} x {i} = {n*i}");
		}
	}
}
Exercise 6
using System;
class Program
{
	static void Main() 
	{
int sum = 0;
		int i = 1;
		while (i <= 100)
		{
			sum += i; // добавляем i к сумме
			i++; //увеличиваем i на 1
		}
		Console.WriteLine("Сумма чисел от 1 до 100 равна:"+ sum);
	}
}
Exercise 7
  using System;
class Program
{
	static void Main() 
	{
int choice;
		do {
			Console.WriteLine("/n--- МЕНЮ ---");
			Console.WriteLine("1. Сказать Привет");
			Console.WriteLine("2. Узнать время");
			Console.WriteLine("0. Выход");
			Console.WriteLine("Выберите пункт:");
			choice =
				int.Parse(Console.ReadLine());
			switch (choice)
			{
				case 1: Console.WriteLine("Привет, пользователь!"); break;
				case 2: Console.WriteLine("Текущее время:" + DateTime
										 .Now.ToShortTimeString()); break;
						case 0: Console.WriteLine("Выход из программы..."); break;
				default: Console.WriteLine("Неверный выбор, попробуйте снова."); break;
			}
		} while (choice != 0); // Цикл повторяется, пока пользователь не ведет 0
	}
}
