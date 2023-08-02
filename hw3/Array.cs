public class Array : IOutput, IMath, ISort
{
    public int[] elements;

    public Array(int[] elements)
    {
        this.elements = elements;
    }

    public void Show()
    {
        Console.WriteLine("Елементи даного масиву:");
        foreach (int element in elements)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    public void Show(string info)
    {
        Console.WriteLine("Інформація: " + info);
        Show();
    }

    public int Max()
    {
        int max = elements[0];
        foreach (int element in elements)
        {
            if (element > max)
            {
                max = element;
            }
        }
        return max;
    }

    public int Min()
    {
        int min = elements[0];
        foreach (int element in elements)
        {
            if (element < min)
            {
                min = element;
            }
        }
        return min;
    }

    public float Avg()
    {
        int sum = 0;
        foreach (int element in elements)
        {
            sum += element;
        }
        return (float) sum / elements.Length;
    }

    public bool Search(int value)
    {
        foreach (int element in elements)
        {
            if (element == value)
            {
                return true;
            }
        }
        return false;
    }

    public void SortAsc()
    {
        int temp;
        for (int i = 0; i < elements.Length - 1; i++)
        {
            for (int j = 0; j < elements.Length - 1 - i; j++)
            {
                if (elements[j] > elements[j + 1])
                {
                    temp = elements[j + 1];
                    elements[j + 1] = elements[j];
                    elements[j] = temp;
                }
            }
        }
    }

    public void SortDesc()
    {
        int temp;
        for (int i = 0; i < elements.Length - 1; i++)
        {
            for (int j = 0; j < elements.Length - 1 - i; j++)
            {
                if (elements[j] < elements[j + 1])
                {
                    temp = elements[j + 1];
                    elements[j + 1] = elements[j];
                    elements[j] = temp;
                }
            }
        }
    }

    public void SortByParam(bool isAsc)
    {
        if (isAsc)
        {
            SortAsc();
        }
        else
        {
            SortDesc();
        }
    }
}