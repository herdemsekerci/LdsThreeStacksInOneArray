using System;

namespace ThreeStacksInOneArray
{
    class Program
    {
        static void Main(string[] args)
        {
            TrippleStack trippleStack = new TrippleStack(10);

            // pushing items into stack1
            trippleStack.Push(TrippleStack.StackId.StackOne, "erdem şekerci");
            trippleStack.Push(TrippleStack.StackId.StackOne, 118);
            trippleStack.Push(TrippleStack.StackId.StackOne, 1f);

            // pushing items into stack2
            trippleStack.Push(TrippleStack.StackId.StackTwo, "Test stack2 elemanı");
            trippleStack.Push(TrippleStack.StackId.StackTwo, "123456");
            trippleStack.Push(TrippleStack.StackId.StackTwo, 8.5);
            trippleStack.Push(TrippleStack.StackId.StackTwo, "loodos");

            // pushing items into stack3
            trippleStack.Push(TrippleStack.StackId.StackThree, "Stack 3");
            trippleStack.Push(TrippleStack.StackId.StackThree, "test");

            Console.WriteLine($"Stack1 last item: {trippleStack.Peek(TrippleStack.StackId.StackOne)}, stack1 current size: {trippleStack.Count(TrippleStack.StackId.StackOne)}");
            Console.WriteLine($"Stack 2 last item: {trippleStack.Peek(TrippleStack.StackId.StackTwo)}, stack2 current size: {trippleStack.Count(TrippleStack.StackId.StackTwo)}");
            Console.WriteLine($"Stack 3 last item: {trippleStack.Peek(TrippleStack.StackId.StackThree)}, stack3 current size: {trippleStack.Count(TrippleStack.StackId.StackThree)}");

        }
    }
}
