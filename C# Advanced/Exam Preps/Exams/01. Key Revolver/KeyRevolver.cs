using System;
using System.Collections.Generic;
using System.Linq;

namespace _01._Key_Revolver
{
    class KeyRevolver
    {
        static void Main(string[] args)
        {
             int bulletPrice = int.Parse(Console.ReadLine());
             int size = int.Parse(Console.ReadLine());
            
             List<int> bullets = Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();
            
             List<int> locks = Console.ReadLine()
                 .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();
            
             int value = int.Parse(Console.ReadLine());
            
             Stack<int> bulletStack = new Stack<int>(bullets);
             Queue<int> queueStack = new Queue<int>(locks);
            
             int initialBulletCount = bullets.Count;
             int count = 0;
            
             while (bulletStack.Count > 0 || queueStack.Count > 0)
             {
                 if(bulletStack.Peek() <= queueStack.Peek())
                 {
                     Console.WriteLine("Bang!");
                     bulletStack.Pop();
                     queueStack.Dequeue();
                     count++;
                 }
                 else
                 {
                     Console.WriteLine("Ping!");
                     bulletStack.Pop();
                     count++; 
                 }
            
                 if(count % size == 0 && bulletStack.Any())
                 {
                     Console.WriteLine("Reloading!");
                 }
            
                 if(bulletStack.Count == 0 && queueStack.Count > 0)
                 {
                     Console.WriteLine($"Couldn't get through. Locks left: {queueStack.Count}");
                     break;
                 }
            
                 if(queueStack.Count == 0)
                 {
                     Console.WriteLine($"{bulletStack.Count} bullets left. Earned ${value - ((initialBulletCount - bulletStack.Count) * bulletPrice)}");
                     break;
                 }
               
             }
        }
    }
}
