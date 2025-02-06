using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quiz2
{
    public Queue<int> Merge(Queue<int> q, Stack<int> s)
    {
        Queue<int> result = new Queue<int>();
        while (q.Count > 0 && s.Count > 0)
        {
            result.Enqueue(q.Dequeue());
            result.Enqueue(s.Pop());
        }
        return result;
    }
}