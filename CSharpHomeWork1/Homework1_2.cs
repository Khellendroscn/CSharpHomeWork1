using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KheUtil;

namespace CSharpHomeWork1
{
    public partial class Homework1_2 : Form
    {
        public Homework1_2()
        {
            InitializeComponent();
            Fib fib = new Fib();// 斐波那契生成器
            // 通过斐波那契生成器创建一个无限流(初始为0， 步长为1)
            var fibs = Stream<int>.from(fib.fib, n => n + 1, 0);
            // 根据条件，截取所有小于200的斐波那契数，然后将它们放到列表中
            var list = fibs.takeWhile(n => n < 200).toList();
            // 将列表中的元素添加到列表框
            list.ForEach(item => fibsBox.Items.Add(item));
        }
    }
    // 用于生成斐波那契数的类
    class Fib
    {
        private List<int> fibs = new List<int>();
        public Fib()
        {
            fibs.Add(0);
            fibs.Add(1);
        }
        public int fib(int n)
        {
            if (n >= fibs.Count)
            {
                fibs.Add(fib(n - 2) + fib(n - 1));
            }
            return fibs[n];
        }
    }
}
