using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackImplementations;
using MExer02;

namespace MExer03
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public static class PostfixEvaluator
    {
        public static double EvaluatePostFixExpression(QueueUsingDoublyLinkedList<string> postfix)
        {
            StackUsingLinkedList<string> stack = new StackUsingLinkedList<string>();
            var count = postfix.Count;
            double answer = 0;

            for (int i = 0; i < count; i++)
            {
                if (stack.Count >= 2 && postfix.Peek().Length == 1 && IsOperator(postfix.Peek()[0]) == true)
                {
                    double x = 0;
                    double y = 0;
                    if (Double.TryParse(stack.Peek(), out x))
                        x = Convert.ToDouble(stack.Pop());
                    if (Double.TryParse(stack.Peek(), out y))
                        y = Convert.ToDouble(stack.Pop());
                    double result = Calculate(y, postfix.Dequeue()[0], x);
                    stack.Push(result.ToString());
                }

                else
                {
                    stack.Push(postfix.Dequeue());
                }
            }

            if (stack.Count != 0)
            {
                if (double.TryParse(stack.Peek(), out answer) == true)
                {
                    answer = Convert.ToDouble(stack.Pop());
                }

                else
                {
                    if (stack.Count != 1)
                        stack.Pop();
                    if (double.TryParse(stack.Peek(), out answer) == true)
                        answer = Convert.ToDouble(stack.Pop());
                }
            }

            return answer;
        }

        public static bool IsOperator(char c)
        {
            if (c == '+' || c == '-' || c == '*' || c == '/' || c == '^' || c == '%')
            {
                return true;
            }
            else
                return false;
        }

        public static double Calculate(double y, char op, double x)
        {
            if (op == '+')
            {
                return (y + x);
            }

            else if (op == '-')
            {
                return (y - x);
            }

            else if (op == '*')
            {
                return (y * x);
            }

            else if (op == '/')
            {
                return (y / x);
            }

            else if (op == '^')
            {
                return (Math.Pow(y, x));
            }

            else if (op == '%')
            {
                return (y % x);
            }

            else
            {
                return 0;
            }
        }

        public static class DelimiterCheck
        {
            public static bool IsMatchingPair(char opening, char closing)
            {
                if (opening == '(' && closing == ')')
                    return true;

                else if (opening == '{' && closing == '}')
                    return true;

                else if (opening == '[' && closing == ']')
                    return true;
                else
                    return false;
            }
        }

        public static class DelimiterChecker
        {
            public static StackUsingLinkedList<char> _list = new StackUsingLinkedList<char>();

            public static bool DelimiterMatching(string input)
            {
                _list.Clear();
                for (int x = 0; x < input.Length; x++)
                {
                    if (input[x] == '(' || input[x] == '[' || input[x] == '{')
                        _list.Push(input[x]);

                    else if (input[x] == ')' || input[x] == ']' || input[x] == '}')
                    {
                        if (DelimiterCheck.IsMatchingPair(_list.Pop(), input[x]) == false)
                            return false;
                    }
                }

                return true;
            }
        }
    }
}
