using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace reSixthProject
{
    public class Deque<T>
    {
        T[] deq = new T[10];
        int head = 0;
        int tail = 0;
        int count = 0;

        public void Push(T take)
        {
            if (count == deq.Length)
            {
                T[] newdeq = new T[deq.Length * 10];
                for (int i = 0; i < count; i++)
                {
                    newdeq[i] = deq[i];
                }
                deq = newdeq;
                tail = count;

                deq[tail] = take;
                tail++;
            }
            else
            {
                if (count == 0)
                {
                    deq[0] = take;
                    tail++;
                    count++;
                }
                else
                {
                    if (tail < deq.Length - 1)
                    {
                        deq[tail] = take;
                        count++;
                        tail++;
                    }
                    else
                    {
                        deq[tail] = take;
                        count++;
                        tail = 0;
                    }
                }
            }
        }
        public void Pop(T take)
        {
            if (count == deq.Length)
            {
                T[] newdeq = new T[deq.Length * 10];
                for (int i = 0; i < count; i++)
                {
                    newdeq[i] = deq[i];
                }
                deq = newdeq;
                tail = count;

                deq[tail] = take;
                tail++;
            }
            else
            {
                if (count == 0)
                {
                    deq[0] = take;
                    tail++;
                    count++;
                }
                else
                {
                    if (head == 0)
                    {
                        head = deq.Length - 1;
                        deq[head] = take;
                        count++;
                        head--;
                    }
                    else
                    {
                        deq[head] = take;
                        head--;
                    }
                }
            }
        }
        public T TakeTop()
        {
            if (count > 0)
            {
                if (head < deq.Length - 1)
                {
                    count--;
                    head++;
                    return deq[head - 1];
                }
                else
                {
                    count--;
                    head = 0;
                    return deq[deq.Length - 1];
                }
            }
            else throw new ArgumentOutOfRangeException();
        }
        public T TakeBot()
        {
            if (count > 0)
            {
                if (tail > 0)
                {
                    count--;
                    tail--;
                    return deq[tail + 1];
                }
                else
                {
                    count--;
                    tail = deq.Length - 1;
                    return deq[0];
                }
            }
            else throw new ArgumentOutOfRangeException();
        }
        /*
        public void PushToTheTop(T take)
        {
            T[] newdeq = new T[deq.Length + 1];
            newdeq[0] = take;
            if (deq.Length > 0)
            {
                for (int i = 0; i < deq.Length; i++)
                {
                    newdeq[i + 1] = deq[i];
                }
            }
            deq = newdeq;
        }

        public void PushToTheEnd(T take)
        {
            T[] newdeq = new T[deq.Length + 1];
            newdeq[newdeq.Length - 1] = take;
            if (deq.Length > 0)
            {
                for (int i = 0; i < deq.Length; i++)
                {
                    newdeq[i] = deq[i];
                }
            }
            deq = newdeq;
        }

        public T TakeFromTop()
        {
            if (deq != null)
            {
                T asd = deq[0];
                T[] mas = new T[deq.Length - 1];
                for (int i = 0; i < deq.Length - 1; i++)
                {
                    mas[i] = deq[i + 1];
                }
                deq = mas;
                return asd;
            }
            else throw new Exception("Массив пустой.");
        }

        public T TakeFromEnd()
        {
            if (deq != null)
            {
                T asd = deq[deq.Length - 1];
                T[] mas = new T[deq.Length - 1];
                for (int i = 0; i < deq.Length - 1; i++)
                {
                    mas[i] = deq[i];
                }
                deq = mas;
                return asd;
            }
            else throw new Exception("Массив пустой.");
        }*/
    }
}

