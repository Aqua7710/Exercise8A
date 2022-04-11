// See https://aka.ms/new-console-template for more information

int counter = 0;
Console.WriteLine("Hello user, this program will display the even numbers between 1 and 100:\n");
Console.ReadLine(); // so that you can see the message 
while(counter < 100)
{
    counter++;
    if(counter%2 == 0)
    {
        Console.WriteLine(counter.ToString());
    }
}

