using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Paper
{
    public static class Examples
    {
        [CompilerGenerated]
        private sealed class __genFromToHead__d__2 : INestedEnumerable<int>, INestedEnumerator<int>, IDisposable
        {
            private int __gen__1__state;

            private int __gen__2__current;

            private INestedEnumerator<int>? __gen__2__current_enumerator;

            private int __gen__l__initialThreadId;

            private int b;

            public int __gen__3__b;

            private int e;

            public int __gen__3__e;

            int INestedEnumerator<int>.Current
            {
                [DebuggerHidden]
                get
                {
                    return __gen__2__current;
                }
            }

            INestedEnumerator<int>? INestedEnumerator<int>.CurrentEnumerator
            {
                [DebuggerHidden]
                get
                {
                    return __gen__2__current_enumerator;
                }
            }

            [DebuggerHidden]
            public __genFromToHead__d__2(int __gen__1__state)
            {
                this.__gen__1__state = __gen__1__state;
                __gen__l__initialThreadId = Environment.CurrentManagedThreadId;
            }

            [DebuggerHidden]
            void IDisposable.Dispose()
            {
                int num = __gen__1__state;
                if (num == -3 || num == 1)
                {
                    try
                    {
                    }
                    finally
                    {
                        __gen__m__Finally1();
                    }
                }
            }

            NestedEnumState INestedEnumerator<int>.NestedMoveNext()
            {
                try
                {
                    switch (__gen__1__state)
                    {
                        default:
                            return NestedEnumState.Done;
                        case 0:
                            __gen__1__state = -1;
                            if (b > e)
                            {
                                return NestedEnumState.Done;
                            }
                            __gen__2__current_enumerator = FromToHead(b, e - 1).GetNestedEnumerator();
                            __gen__1__state = 1;
                            return NestedEnumState.Enumerator;
                        case 1:
                            __gen__1__state = -1;
                            __gen__m__Finally1();
                            __gen__2__current_enumerator = null;
                            __gen__2__current = e;
                            __gen__1__state = 2;
                            return NestedEnumState.Value;
                        case 2:
                            __gen__1__state = -3;
                            return NestedEnumState.Done;
                    }
                }
                catch
                {
                    //try-fault
                    ((IDisposable)this).Dispose();
                    throw;
                }
            }

            private void __gen__m__Finally1()
            {
                __gen__1__state = -1;
                if (__gen__2__current_enumerator != null)
                {
                    __gen__2__current_enumerator.Dispose();
                }
            }

            [DebuggerHidden]
            INestedEnumerator<int> INestedEnumerable<int>.GetNestedEnumerator()
            {
                __genFromToHead__d__2 __genFromToHead__d__;
                if (__gen__1__state == -2 && __gen__l__initialThreadId == Environment.CurrentManagedThreadId)
                {
                    __gen__1__state = 0;
                    __genFromToHead__d__ = this;
                }
                else
                {
                    __genFromToHead__d__ = new __genFromToHead__d__2(0);
                }
                __genFromToHead__d__.b = __gen__3__b;
                __genFromToHead__d__.e = __gen__3__e;
                return __genFromToHead__d__;
            }
        }


        [CompilerGenerated]
        private sealed class __genFromToIdeal__d__0 : INestedEnumerable<int>, INestedEnumerator<int>, IDisposable
        {
            private int __gen__1__state;

            private int __gen__2__current;

            private INestedEnumerator<int>? __gen__2__current_enumerator;

            private int __gen__l__initialThreadId;

            private int b;

            public int __gen__3__b;

            private int e;

            public int __gen__3__e;

            private int __genx__5__2;

            int INestedEnumerator<int>.Current
            {
                [DebuggerHidden]
                get
                {
                    return __gen__2__current;
                }
            }

            INestedEnumerator<int>? INestedEnumerator<int>.CurrentEnumerator
            {
                [DebuggerHidden]
                get
                {
                    return __gen__2__current_enumerator;
                }
            }

            [DebuggerHidden]
            public __genFromToIdeal__d__0(int __gen__1__state)
            {
                this.__gen__1__state = __gen__1__state;
                __gen__l__initialThreadId = Environment.CurrentManagedThreadId;
            }

            [DebuggerHidden]
            void IDisposable.Dispose()
            {
            }

            NestedEnumState INestedEnumerator<int>.NestedMoveNext()
            {
                int num = __gen__1__state;
                if (num != 0)
                {
                    if (num != 1)
                    {
                        return NestedEnumState.Done;
                    }
                    __gen__1__state = -1;
                    __genx__5__2++;
                }
                else
                {
                    __gen__1__state = -1;
                    __genx__5__2 = b;
                }
                if (__genx__5__2 <= e)
                {
                    __gen__2__current = __genx__5__2;
                    __gen__1__state = 1;
                    return NestedEnumState.Value;
                }
                return NestedEnumState.Done;
            }

            [DebuggerHidden]
            INestedEnumerator<int> INestedEnumerable<int>.GetNestedEnumerator()
            {
                __genFromToIdeal__d__0 __genFromToIdeal__d__;
                if (__gen__1__state == -2 && __gen__l__initialThreadId == Environment.CurrentManagedThreadId)
                {
                    __gen__1__state = 0;
                    __genFromToIdeal__d__ = this;
                }
                else
                {
                    __genFromToIdeal__d__ = new __genFromToIdeal__d__0(0);
                }
                __genFromToIdeal__d__.b = __gen__3__b;
                __genFromToIdeal__d__.e = __gen__3__e;
                return __genFromToIdeal__d__;
            }
        }


        [CompilerGenerated]
        private sealed class __genFromToTail__d__1 : INestedEnumerable<int>, INestedEnumerator<int>, IDisposable
        {
            private int __gen__1__state;

            private int __gen__2__current;

            private INestedEnumerator<int>? __gen__2__current_enumerator;

            private int __gen__l__initialThreadId;

            private int b;

            public int __gen__3__b;

            private int e;

            public int __gen__3__e;


            int INestedEnumerator<int>.Current
            {
                [DebuggerHidden]
                get
                {
                    return __gen__2__current;
                }
            }

            INestedEnumerator<int>? INestedEnumerator<int>.CurrentEnumerator
            {
                [DebuggerHidden]
                get
                {
                    return __gen__2__current_enumerator;
                }
            }

            [DebuggerHidden]
            public __genFromToTail__d__1(int __gen__1__state)
            {
                this.__gen__1__state = __gen__1__state;
                __gen__l__initialThreadId = Environment.CurrentManagedThreadId;
            }

            [DebuggerHidden]
            void IDisposable.Dispose()
            {
                int num = __gen__1__state;
                if (num == -3 || num == 2)
                {
                    try
                    {
                    }
                    finally
                    {
                        __gen__m__Finally1();
                    }
                }
            }

            NestedEnumState INestedEnumerator<int>.NestedMoveNext()
            {
                try
                {
                    switch (__gen__1__state)
                    {
                        default:
                            return NestedEnumState.Done;
                        case 0:
                            __gen__1__state = -1;
                            if (b > e)
                            {
                                return NestedEnumState.Done;
                            }
                            __gen__2__current = b;
                            __gen__1__state = 1;
                            return NestedEnumState.Value;
                        case 1:
                            __gen__1__state = -1;
                            __gen__2__current_enumerator = FromToTail(b + 1, e).GetNestedEnumerator();
                            __gen__1__state = 2;
                            return NestedEnumState.TailEnumerator;
                        case 2:
                            __gen__1__state = -3;
                            break;
                    }
                    __gen__m__Finally1();
                    __gen__2__current_enumerator = null;
                    return NestedEnumState.Done;
                }
                catch
                {
                    //try-fault
                    ((IDisposable)this).Dispose();
                    throw;
                }
            }

            private void __gen__m__Finally1()
            {
                __gen__1__state = -1;
                if (__gen__2__current_enumerator != null)
                {
                    __gen__2__current_enumerator.Dispose();
                }
            }

            [DebuggerHidden]
            INestedEnumerator<int> INestedEnumerable<int>.GetNestedEnumerator()
            {
                __genFromToTail__d__1 __genFromToTail__d__;
                if (__gen__1__state == -2 && __gen__l__initialThreadId == Environment.CurrentManagedThreadId)
                {
                    __gen__1__state = 0;
                    __genFromToTail__d__ = this;
                }
                else
                {
                    __genFromToTail__d__ = new __genFromToTail__d__1(0);
                }
                __genFromToTail__d__.b = __gen__3__b;
                __genFromToTail__d__.e = __gen__3__e;
                return __genFromToTail__d__;
            }
        }

        [IteratorStateMachine(typeof(__genFromToIdeal__d__0))]
        public static INestedEnumerable<int> FromToIdeal(int b, int e)
        {
            __genFromToIdeal__d__0 __genFromToIdeal__d__ = new __genFromToIdeal__d__0(-2);
            __genFromToIdeal__d__.__gen__3__b = b;
            __genFromToIdeal__d__.__gen__3__e = e;
            return __genFromToIdeal__d__;
        }

        [IteratorStateMachine(typeof(__genFromToTail__d__1))]
        public static INestedEnumerable<int> FromToTail(int b, int e)
        {
            __genFromToTail__d__1 __genFromToTail__d__ = new __genFromToTail__d__1(-2);
            __genFromToTail__d__.__gen__3__b = b;
            __genFromToTail__d__.__gen__3__e = e;
            return __genFromToTail__d__;
        }

        [IteratorStateMachine(typeof(__genFromToHead__d__2))]
        public static INestedEnumerable<int> FromToHead(int b, int e)
        {
            __genFromToHead__d__2 __genFromToHead__d__ = new __genFromToHead__d__2(-2);
            __genFromToHead__d__.__gen__3__b = b;
            __genFromToHead__d__.__gen__3__e = e;
            return __genFromToHead__d__;
        }
    }
}
