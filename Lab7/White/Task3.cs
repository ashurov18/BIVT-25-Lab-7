using System;

namespace Lab7.White
{
    public class Task3
    {
        public struct Student
        {
            private string name;
            private string surname;
            private int[] marks;
            private int count;
            private int skipped;

            public string Name => name;
            public string Surname => surname;
            public int Skipped => skipped;

            public double AverageMark
            {
                get
                {
                    if (count == 0) return 0;
                    int sum = 0;
                    for (int i = 0; i < count; i++) sum += marks[i];
                    return (double)sum / count;
                }
            }

            public Student(string name, string surname)
            {
                this.name = name;
                this.surname = surname;
                marks = new int[100];
                count = 0;
                skipped = 0;
            }

            public void Lesson(int mark)
            {
                if (mark == 0)
                    skipped++;
                else
                {
                    marks[count] = mark;
                    count++;
                }
            }

            // ВАЖНО: имя метода должно быть Sort, а не SortBySkipped!
            public static void Sort(Student[] array)
            {
                Array.Sort(array, (a, b) => b.Skipped.CompareTo(a.Skipped));
            }

            public void Print()
            {
                Console.WriteLine($"{name} {surname} | Ср.балл: {AverageMark:F2} | Пропуски: {skipped}");
            }
        }
    }
}
