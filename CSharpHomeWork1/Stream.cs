using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KheUtil
{
    public abstract class Stream<T>
    {
        public abstract T Head { get; }
        public abstract Stream<T> Tail { get; }
        public abstract bool IsEmpty { get; }
        public delegate A get<A>();// () => A
        public delegate Tuple<A, S> state<A, S>(S s);// S => (A, S)
        public delegate bool pred<A>(A item);// A => bool
        public delegate A gen<A, S>(S s);// S => A
        public delegate S next<S>(S s);// S => S

        public static Stream<T> unfold<S>(S z, state<T, S> f)
        {
            var r = f(z);
            if (r == null)
            {
                return new Empty<T>();
            }
            else
            {
                var a = r.Item1;
                var s = r.Item2;
                return new Cons<T>(() => a, () => unfold(s, f));
            }
        }
        public Stream<T> take(int n)
        {
            state<T, Tuple<int, Stream<T>>> guard = t =>
            {
                var count = t.Item1;
                var stream = t.Item2;
                if (count <= 0) return null;
                else if (stream.IsEmpty) return null;
                else
                {
                    return new Tuple<T, Tuple<int, Stream<T>>>(stream.Head,
                        new Tuple<int, Stream<T>>(count - 1, stream.Tail));
                }
            };
            return unfold(new Tuple<int, Stream<T>>(n, this), guard);
        }
        public Stream<T> takeWhile(pred<T> pred)
        {
            state<T, Stream<T>> guard = s =>
            {
                if (s.IsEmpty) return null;
                else
                {
                    if (!pred(s.Head)) return null;
                    else
                    {
                        return new Tuple<T, Stream<T>>(s.Head, s.Tail);
                    }
                }
            };
            return unfold(this, guard);
        }
        public List<T> toList()
        {
            Stream<T> s = this;
            List<T> list = new List<T>();
            while (!s.IsEmpty)
            {
                list.Add(s.Head);
                s = s.Tail;
            }
            return list;
        }
        public static Stream<T> from<S>(gen<T, S> gen, next<S> next, S init)
        {
            state<T, S> guard = s => new Tuple<T, S>(gen(s), next(s));
            return unfold(init, guard);
        }
    }

    public class Empty<T> : Stream<T>
    {
        public override T Head => throw new NotImplementedException();

        public override Stream<T> Tail => throw new NotImplementedException();

        public override bool IsEmpty => true;
    }

    public class Cons<T> : Stream<T>
    {
        private get<T> head;
        private get<Stream<T>> tail;

        public override T Head => head();
        public override Stream<T> Tail => tail();
        public override bool IsEmpty => false;

        public Cons(get<T> head, get<Stream<T>> tail)
        {
            this.head = head;
            this.tail = tail;
        }
    }
}
