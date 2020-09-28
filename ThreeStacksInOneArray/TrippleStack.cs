using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;

namespace ThreeStacksInOneArray
{
    public class TrippleStack
    {
        public enum StackId
        {
            StackOne,
            StackTwo,
            StackThree
        }
        private object[] values;
        private Dictionary<StackId, List<int>> stackIndex;

        public TrippleStack(int defaultStackCapacity)
        {
            values = new object[defaultStackCapacity * 3];
            stackIndex = new Dictionary<StackId, List<int>>();
            // stack 1
            stackIndex.Add(StackId.StackOne, new List<int>());
            // stack 2
            stackIndex.Add(StackId.StackTwo, new List<int>());
            // stack 3
            stackIndex.Add(StackId.StackThree, new List<int>());
        }

        private int GetAvailableIndex()
        {
            if (values.Any(a => a == null))
                return Array.FindIndex(values, v => v == null);
            else
                return -1; // array full
        }

        private bool StackHasItem(StackId stackId)
        {
            return stackIndex[stackId].Count > 0;
        }

        public int Count(StackId stackId)
        {
            return stackIndex[stackId].Count;
        }

        public void Push(StackId stackId, object value)
        {
            int availableIndex = GetAvailableIndex();

            if (availableIndex == -1)
            {
                // array full
                throw new Exception("Array is full!");
            }
            else
            {
                values[availableIndex] = value;
                stackIndex[stackId].Add(availableIndex);

            }

        }

        public object Pop(StackId stackId)
        {
            if (StackHasItem(stackId))
            {
                int lastIndexOfStack = stackIndex[stackId].Last();
                object currentItem = values[lastIndexOfStack];
                values[lastIndexOfStack] = null; // remove item from array which is the last item of current stack
                stackIndex[stackId].RemoveAt(stackIndex[stackId].Count - 1); // remove the last item index from the index list

                return currentItem;
            }
            else
            {
                throw new Exception("Stack has no item to pop.");
            }
        }

        public object Peek(StackId stackId)
        {
            if (!StackHasItem(stackId))
            {
                // stack has no items
                return null;
            }

            int lastElemenentIndexOfStack = stackIndex[stackId].Last();
            return values[lastElemenentIndexOfStack];
        }
    }

}
