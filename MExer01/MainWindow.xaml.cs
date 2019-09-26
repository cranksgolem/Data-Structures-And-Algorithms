using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using MExer02;
using MExer03;

namespace MExer01
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void TbInfix_TextChanged(object sender, TextChangedEventArgs e)
        {
            QueueUsingDoublyLinkedList<string> temp = InfixToPostfixConverter.ConvertToPostfix(TbInfix.Text);
            QueueUsingDoublyLinkedList<string> postfix = new QueueUsingDoublyLinkedList<string>();
            var sb = new StringBuilder();
            int count = temp.Count;

            for (int x = 0; x < count; x++)
            {
                var y = temp.Dequeue();
                postfix.Enqueue(y);
                sb.Append(y);
            }
            TbPostfix.Text = sb.ToString();

            TbResult.Text = PostfixEvaluator.EvaluatePostFixExpression(postfix).ToString();
        }
    }
}
