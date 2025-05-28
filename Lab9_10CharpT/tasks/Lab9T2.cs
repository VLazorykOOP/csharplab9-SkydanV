using System;
using System.Collections;

class Student : ICloneable
{
    public string LastName;
    public string FirstName;
    public string Patronymic;
    public string Group;
    public int[] Grades = new int[3];

    public bool IsSuccessful()
    {
        foreach (int g in Grades)
            if (g < 4) return false;
        return true;
    }

    public override string ToString()
    {
        return $"{LastName} {FirstName} {Patronymic}, Група: {Group}, Оцінки: {string.Join(", ", Grades)}";
    }

    public object Clone()
    {
        Student clone = (Student)this.MemberwiseClone();
        clone.Grades = (int[])this.Grades.Clone();
        return clone;
    }
}

class StudentComparer : IComparer
{
    public int Compare(object x, object y)
    {
        Student s1 = (Student)x;
        Student s2 = (Student)y;

        bool s1Success = s1.IsSuccessful();
        bool s2Success = s2.IsSuccessful();

        // Перші йдуть успішні
        if (s1Success && !s2Success)
            return -1;
        if (!s1Success && s2Success)
            return 1;

        // Якщо обидва однакові по успішності, порядок не міняємо (0)
        return 0;
    }
}

class Lab9Task2 : IEnumerable
{
    private ArrayList students = new ArrayList();

    public void Run()
    {
        LoadStudents();

        ArrayList clonedStudents = new ArrayList();
        foreach (Student s in students)
            clonedStudents.Add(s.Clone());

        clonedStudents.Sort(new StudentComparer());

        Console.WriteLine("Студенти у порядку: успішні - потім інші");
        foreach (Student s in clonedStudents)
        {
            Console.WriteLine(s);
        }
    }

    private void LoadStudents()
    {
        students.Add(new Student { LastName = "Іванов", FirstName = "Іван", Patronymic = "Іванович", Group = "КП-101", Grades = new int[] { 5, 4, 5 } });
        students.Add(new Student { LastName = "Петров", FirstName = "Петро", Patronymic = "Петрович", Group = "КП-101", Grades = new int[] { 3, 4, 4 } });
        students.Add(new Student { LastName = "Сидоренко", FirstName = "Сидір", Patronymic = "Сидорович", Group = "КП-102", Grades = new int[] { 5, 5, 5 } });
        students.Add(new Student { LastName = "Коваленко", FirstName = "Віталій", Patronymic = "Дмитрович", Group = "КП-102", Grades = new int[] { 2, 3, 3 } });
    }

    public IEnumerator GetEnumerator()
    {
        return students.GetEnumerator();
    }
}
