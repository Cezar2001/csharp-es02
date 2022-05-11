using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] ArrayComands = new string[] {"somma", "prodotto", "divisione", "sottrazione", "quadrato", "media", "potenza", "min/max"};
            Console.WriteLine("Che tipo di operazione vuole effettuare? 0->addizione, 1->moltiplicazione, " +
                "2->divisione, 3->sottrazione, 4->quadrato, 5->media, 6->potenza, 7->min/max");
            string comand = Console.ReadLine();

            switch (comand)
            {
                case "0":
                    {
                        Console.WriteLine("Operazione richiesta: {0}", ArrayComands[Convert.ToInt32(comand)]);
                        Console.WriteLine("Inserire due numeri!");
                        string numbers = Console.ReadLine();
                        if (numbers == null)
                        {
                            Console.WriteLine("Non hai inserito alcun numero");
                            Environment.Exit(1);
                        }
 
                        string[] sVect = numbers.Split(' ');    
                        int num1 = Convert.ToInt32(sVect[0]);
                        int num2 = Convert.ToInt32(sVect[1]);
                        Console.WriteLine("La somma è: {0}", num1 + num2);
                    }
                    break;

                case "1":
                    {
                        Console.WriteLine("Operazione richiesta: {0}", ArrayComands[Convert.ToInt32(comand)]);
                        Console.WriteLine("Inserire due numeri!");
                        string numbers = Console.ReadLine();
                        if (numbers == null)
                        {
                            Console.WriteLine("Non hai inserito alcun numero");
                            Environment.Exit(1);
                        }

                        string[] sVect = numbers.Split(' ');
                        int num1 = Convert.ToInt32(sVect[0]);
                        int num2 = Convert.ToInt32(sVect[1]);
                        Console.WriteLine("Il prodotto è: {0}", num1 * num2);
                    }
                    break;

                case "2":
                    {
                        Console.WriteLine("Operazione richiesta: {0}", ArrayComands[Convert.ToInt32(comand)]);
                        Console.WriteLine("Inserire due numeri!");
                        string numbers = Console.ReadLine();
                        if (numbers == null)
                        {
                            Console.WriteLine("Non hai inserito alcun numero");
                            Environment.Exit(1);
                        }

                        string[] sVect = numbers.Split(' ');
                        int num1 = Convert.ToInt32(sVect[0]);
                        int num2 = Convert.ToInt32(sVect[1]);
                        Console.WriteLine("La divisione è: {0}", num1 / num2);
                    }
                    break;

                case "3":
                    {
                        Console.WriteLine("Operazione richiesta: {0}", ArrayComands[Convert.ToInt32(comand)]);
                        Console.WriteLine("Inserire due numeri!");
                        string numbers = Console.ReadLine();
                        if (numbers == null)
                        {
                            Console.WriteLine("Non hai inserito alcun numero");
                            Environment.Exit(1);
                        }

                        string[] sVect = numbers.Split(' ');
                        int num1 = Convert.ToInt32(sVect[0]);
                        int num2 = Convert.ToInt32(sVect[1]);
                        Console.WriteLine("La sottrazione è: {0}", num1 - num2);
                    }
                    break;

                case "4":
                    {
                        Console.WriteLine("Operazione richiesta: {0}", ArrayComands[Convert.ToInt32(comand)]);
                        Console.WriteLine("Inserire un solo numero!");
                        int numberOne;
                        numberOne = int.Parse(Console.ReadLine());
                        double Result = Math.Pow(numberOne, 2);
                        Console.Write("Il quadrato del numero è: {0}", Result);
                    }
                    break;

                case "5":
                    {
                        Console.WriteLine("Operazione richiesta: {0}", ArrayComands[Convert.ToInt32(comand)]);
                        Console.WriteLine("Inserire alcuni numeri!");
                        string numbers = Console.ReadLine();
                        if (numbers == null)
                        {
                            Console.WriteLine("Non hai inserito alcun numero");
                            Environment.Exit(1);
                        }
                        string[] sVect = numbers.Split(' ');

                        double media = 0.0;
                        int n = 0;
                        foreach (string snum in sVect)
                        {
                            double num;
                            if (double.TryParse(snum, out num))
                            {
                                media += num;
                                n++;
                            }
                        }
                        media /= n;
                        Console.WriteLine("La media dei numeri forniti è: {0}", media);
                    }
                    break;

                case "6":
                    {
                        Console.WriteLine("Operazione richiesta: {0}", ArrayComands[Convert.ToInt32(comand)]);
                        Console.WriteLine("Inserire due numeri: ricorda, il primo numero è la base mentre il secondo è l'esponente!");
                        int numberOne;
                        int numberTwo;
                        numberOne = int.Parse(Console.ReadLine());
                        numberTwo = int.Parse(Console.ReadLine());
                        double Result = Math.Pow(numberOne, numberTwo);
                        Console.Write("Il quadrato del numero è: {0}", Result);
                    }
                    break;

                case "7":
                    {
                        int min, max, n;
                        Console.WriteLine("Operazione richiesta: {0}", ArrayComands[Convert.ToInt32(comand)]);
                        Console.WriteLine("Questa operazione fa il minimo e il massimo dati n numeri");
                        int[] arraySearch = new int[10];
                        Console.WriteLine("Digitare alcuni numeri");
                        n = Convert.ToInt32(Console.ReadLine());

                        for (int i = 0; i < n; i++)
                        {
                            Console.WriteLine("Inserire un numero:", i);
                            arraySearch[i] = Convert.ToInt32(Console.ReadLine());
                        }

                        min = arraySearch[0];
                        max = arraySearch[0];

                        for (int i = 0; i < n; i++)
                        {
                            if (arraySearch[i] < min)
                            {
                                min = arraySearch[i];
                            }

                            if (arraySearch[i] > max)
                            {
                                max = arraySearch[i];
                            }
                        }

                        Console.WriteLine("Il numero minimo è: {0}", min);
                        Console.WriteLine("Il numero massimo è: {0}", max);
                    }
                    break;

                default:
                    Console.WriteLine("Operazione non esistente: la preghiamo di selezionare un numero tra quelli sopra elencati!");
                    break;
            }
        }
    }
}