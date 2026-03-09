using System;

public struct Participant
{
    // ПРИВАТНЫЕ ПОЛЯ
    private string name;        // имя участника
    private string surname;      // фамилия участника
    private double[] scores;     // массив для хранения результатов матчей
    private int count;           // количество сыгранных матчей

    // ПУБЛИЧНЫЕ СВОЙСТВА (только для чтения)
    public string Name => name;
    public string Surname => surname;
    public double[] Scores => scores;  // массив результатов

    // СВОЙСТВО для суммы очков за все матчи
    public double TotalScore
    {
        get
        {
            double sum = 0;
            for (int i = 0; i < count; i++)  // суммируем все результаты
                sum += scores[i];
            return sum;
        }
    }

    // КОНСТРУКТОР
    public Participant(string name, string surname)
    {
        this.name = name;
        this.surname = surname;
        scores = new double[100];  // максимум 100 матчей
        count = 0;                  // пока матчей нет
    }

    // МЕТОД для добавления результата матча
    public void PlayMatch(double result)
    {
        scores[count] = result;  // записываем результат
        count++;                  // увеличиваем счетчик матчей
    }

    // СОРТИРОВКА по убыванию суммы очков
    public static void Sort(Participant[] array)
    {
        Array.Sort(array, (a, b) => b.TotalScore.CompareTo(a.TotalScore));
    }

    // ВЫВОД информации
    public void Print()
    {
        Console.WriteLine($"{name} {surname} | Всего очков: {TotalScore}");
    }
}
