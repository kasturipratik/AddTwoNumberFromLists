using System;
using System.Collections.Generic;
using System.Linq;

namespace AddTwoNumberFromLists
{
    class Program
    {
        static void Main(string[] args)
        {
            var c = new List<int>() { 2, 4, 3 };
            var d = new List<int>() { 5, 6, 4 };
            var addedList3 = TwoNumberListsElementAddition(c, d);
            PrintAdditionSolution(addedList3);

            PrintSolution();
        }

        public static void PrintSolution()
        {
            var l1 = new List<int>() { 9, 9, 9, 9, 9, 9, 9 };
            var l2 = new List<int>() { 9, 9, 9, 9 };
            var addedList = TwoNumberListsElementAddition(l1, l2);
            PrintAdditionSolution(addedList);

            var k = new List<int>() { 5, 0};
            var j = new List<int>() { 1, 1 };
            var addedList5 = TwoNumberListsElementAddition(k, j);
            PrintAdditionSolution(addedList5);


            var a = new List<int>() { 0 };
            var b = new List<int>() { 0 };
            var addedList2 = TwoNumberListsElementAddition(a, b);
            PrintAdditionSolution(addedList2);

            var e = new List<int>() { 1, 0, 0, 0, 0 };
            var f = new List<int>() { 1, 0, 0, 0, 0 };
            var addedList4 = TwoNumberListsElementAddition(e, f);
            PrintAdditionSolution(addedList4);


            var list = new List<string>() { "pratik", "parajuli" };
            Console.WriteLine(list.ElementAt(0));
        } 

        public static List<int> TwoNumberListsElementAddition(List<int> firstList, List<int> secondList) {
            int countListOne = firstList.Count;
            int countListTwo = secondList.Count;
            int elementIndexListOne = 0;
            int elementIndexListTwo = 0;
            var addedList = new List<int>();
            var carryOver = 0;

            while (countListOne != 0 || countListTwo != 0)
            {


                var getElementAtProvidedIndexOfListOne = (countListOne != 0) ? firstList.ElementAt(countListOne - 1) : 0;
                var getElementAtProvidedIndexOfListTwo = (countListTwo != 0) ? secondList.ElementAt(countListTwo -1) : 0;

                var additionTotal = carryOver + getElementAtProvidedIndexOfListOne + getElementAtProvidedIndexOfListTwo;
                if (additionTotal / 10 > 0)
                {
                    addedList.Add(additionTotal % 10);
                    carryOver = additionTotal / 10;
                }
                else 
                { 
                    addedList.Add(additionTotal);
                    carryOver = 0;
                }

                if (countListOne != 0) { elementIndexListOne++; } else { elementIndexListOne = 0; };
                if (countListTwo != 0) { elementIndexListTwo++; } else { elementIndexListTwo = 0; };
                if (countListOne != 0) { countListOne--; } else { countListOne = 0; };
                if (countListTwo != 0) { countListTwo--; } else { countListTwo = 0; };

            }
            if (carryOver > 0)
            {
                addedList.Add(carryOver);
            }
            addedList.Reverse();

            return addedList;
        }

        public static void PrintAdditionSolution(List<int> addedList)
        {
            Console.Write("{ ");
            foreach (int i in addedList)
            {
                Console.Write(i + " ");
            }
            Console.Write("}");
            Console.WriteLine();
        }
    }       

    // leet code solution
    public class ListNode {
         public int val;
         public ListNode next;
         public ListNode(int val=0, ListNode next=null) {
             this.val = val;
              this.next = next;
         }
     }
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            ListNode dummyHead = new ListNode(0);
            ListNode p = l1, q = l2, curr = dummyHead;
            int carry = 0;
            while (p != null || q != null)
            {
                int x = (p != null) ? p.val : 0;
                int y = (q != null) ? q.val : 0;
                int sum = carry + x + y;
                carry = sum / 10;
                curr.next = new ListNode(sum % 10);
                curr = curr.next;
                if (p != null) p = p.next;
                if (q != null) q = q.next;
            }
            if (carry > 0)
            {
                curr.next = new ListNode(carry);
            }
            return dummyHead.next;

        }
    }   
}
