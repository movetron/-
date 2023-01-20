using work_with_classes;

Random rand = new Random();
Triangle[] triang = new Triangle[5];
for (int i = 0; i < triang.Length; i++)
{
    triang[i] = new Triangle(rand.Next(1, 150), rand.Next(1, 150));
    Console.WriteLine(triang[i]);
}

