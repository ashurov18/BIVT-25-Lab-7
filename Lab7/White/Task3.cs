using System;
namespace Lab7.White
{
    public class Task3
    {
public struct Student
{
    // ПРИВАТНЫЕ ПОЛЯ (скрыты от внешнего доступа)
    private string name;        // имя студента
    private string surname;      // фамилия студента
    private int[] marks;         // массив для хранения оценок
    private int count;           // количество полученных оценок
    private int skipped;         // количество пропусков

    // ПУБЛИЧНЫЕ СВОЙСТВА (только для чтения)
    public string Name => name;
    public string Surname => surname;
    public int Skipped => skipped;

    // СВОЙСТВО для средней оценки (вычисляется автоматически)
    public double AverageMark
    {
        get
        {
            if (count == 0) return 0;  // если оценок нет
            int sum = 0;
            for (int i = 0; i < count; i++) sum += marks[i];
            return (double)sum / count;  // среднее арифметическое
        }
    }

    // КОНСТРУКТОР (создание студента)
    public Student(string name, string surname)
    {
        this.name = name;
        this.surname = surname;
        marks = new int[100];  // макс. 100 оценок
        count = 0;
        skipped = 0;
    }

    // МЕТОД для учета посещений и оценок
    public void Lesson(int mark)
    {
        if (mark == 0)           // 0 = пропуск
            skipped++;           
        else                     // оценка
        {
            marks[count] = mark; 
            count++;             
        }
    }

    // СОРТИРОВКА по убыванию пропусков
    public static void SortBySkipped(Student[] array)
    {
        Array.Sort(array, (a, b) => b.Skipped.CompareTo(a.Skipped));
    }

    // ВЫВОД информации
    public void Print()
    {
        Console.WriteLine($"{name} {surname} | Ср.балл: {AverageMark:F2} | Пропуски: {skipped}");
    }
  }
 }
}

