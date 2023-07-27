using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Введите количество учебных заданий: ");
        int count = int.Parse(Console.ReadLine());

        if (count < 10 || count > 40)
        {
            Console.WriteLine("Количество учебных заданий должно быть в диапазоне от 10 до 40");
        }
        else
        {
            string description;

            switch (count)
            {
                case 10: description = "десять учебных заданий"; break;
                case 11: description = "одиннадцать учебных заданий"; break;
                case 12: description = "двенадцать учебных заданий"; break;
                case 13: description = "тринадцать учебных заданий"; break;
                case 14: description = "четырнадцать учебных заданий"; break;
                case 15: description = "пятнадцать учебных заданий"; break;
                case 16: description = "шестнадцать учебных заданий"; break;
                case 17: description = "семнадцать учебных заданий"; break;
                case 18: description = "восемнадцать учебных заданий"; break;
                case 19: description = "девятнадцать учебных заданий"; break;
                case 20: description = "двадцать учебных заданий"; break;
                case 30: description = "тридцать учебных заданий"; break;
                case 40: description = "сорок учебных заданий"; break;
                default:
                    {
                        int units = count % 10;
                        int tens = count - units;

                        string unitsDescription = GetUnitsDescription(units);
                        string tensDescription = GetTensDescription(tens);

                        if (units == 0)
                        {
                            description = tensDescription + " учебных заданий";
                        }
                        else
                        {
                            description = tensDescription + " " + unitsDescription + " учебных задания";
                        }

                        break;
                    }
            }

            Console.WriteLine(description);
        }

        Console.ReadKey();
    }

    static string GetTensDescription(int tens)
    {
        switch (tens)
        {
            case 20: return "двадцать";
            case 30: return "тридцать";
            case 40: return "сорок";
            default: return "";
        }
    }

    static string GetUnitsDescription(int units)
    {
        switch (units)
        {
            case 1: return "одно";
            case 2: return "два";
            case 3: return "три";
            case 4: return "четыре";
            case 5: return "пять";
            case 6: return "шесть";
            case 7: return "семь";
            case 8: return "восемь";
            case 9: return "девять";
            default: return "";
        }
    }
}
