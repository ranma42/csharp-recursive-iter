using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Stackless
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

            // public int INestedEnumerator<int>.Current
            // {
            //     [DebuggerHidden]
            //     get
            //     {
            //         return __gen__2__current;
            //     }
            // }

            [DebuggerHidden]
            public __genFromToHead__d__2(int __gen__1__state)
            {
                this.__gen__1__state = __gen__1__state;
                __gen__l__initialThreadId = Environment.CurrentManagedThreadId;
            }

            [DebuggerHidden]
            void IDisposable.Dispose()
            {
                if (__gen__2__current_enumerator != null)
                {
                    __gen__2__current_enumerator.Dispose();
                    __gen__2__current_enumerator = null;
                }
            }

            INestedEnumerator<int>? INestedEnumerator<int>.TryMoveNext(ref int item)
            {
                try
                {
                    switch (__gen__1__state)
                    {
                        default:
                            return __gen__2__current_enumerator?.TryMoveNext(ref item);
                        case 0:
                            __gen__1__state = -1;
                            if (b > e)
                            {
                                return __gen__2__current_enumerator?.TryMoveNext(ref item);
                            }
                            __gen__1__state = 1;
                            return FromToHead(b, e - 1).GetNestedEnumerator(this).TryMoveNext(ref item);
                        case 1:
                            __gen__1__state = -1;
                            item = e;
                            __gen__1__state = 2;
                            return this;
                        case 2:
                            return __gen__2__current_enumerator?.TryMoveNext(ref item);
                    }
                }
                catch
                {
                    //try-fault
                    ((IDisposable)this).Dispose();
                    throw;
                }
            }

            [DebuggerHidden]
            INestedEnumerator<int> INestedEnumerable<int>.GetNestedEnumerator(INestedEnumerator<int>? src)
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
                __genFromToHead__d__.__gen__2__current_enumerator = src;
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

            // int INestedEnumerator<int>.Current
            // {
            //     [DebuggerHidden]
            //     get
            //     {
            //         return __gen__2__current;
            //     }
            // }

            [DebuggerHidden]
            public __genFromToIdeal__d__0(int __gen__1__state)
            {
                this.__gen__1__state = __gen__1__state;
                __gen__l__initialThreadId = Environment.CurrentManagedThreadId;
            }

            [DebuggerHidden]
            void IDisposable.Dispose()
            {
                if (__gen__2__current_enumerator != null)
                {
                    __gen__2__current_enumerator.Dispose();
                    __gen__2__current_enumerator = null;
                }
            }

            INestedEnumerator<int>? INestedEnumerator<int>.TryMoveNext(ref int item)
            {
                int num = __gen__1__state;
                if (num != 0)
                {
                    if (num != 1)
                    {
                        return __gen__2__current_enumerator?.TryMoveNext(ref item);
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
                    item = __genx__5__2;
                    __gen__1__state = 1;
                    return this;
                }
                return __gen__2__current_enumerator?.TryMoveNext(ref item);
            }

            [DebuggerHidden]
            INestedEnumerator<int> INestedEnumerable<int>.GetNestedEnumerator(INestedEnumerator<int>? src)
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
                __genFromToIdeal__d__.__gen__2__current_enumerator = src;
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


            // int INestedEnumerator<int>.Current
            // {
            //     [DebuggerHidden]
            //     get
            //     {
            //         return __gen__2__current;
            //     }
            // }

            [DebuggerHidden]
            public __genFromToTail__d__1(int __gen__1__state)
            {
                this.__gen__1__state = __gen__1__state;
                __gen__l__initialThreadId = Environment.CurrentManagedThreadId;
            }

            [DebuggerHidden]
            void IDisposable.Dispose()
            {
                if (__gen__2__current_enumerator != null)
                {
                    __gen__2__current_enumerator.Dispose();
                    __gen__2__current_enumerator = null;
                }
            }

            INestedEnumerator<int>? INestedEnumerator<int>.TryMoveNext(ref int item)
            {
                try
                {
                    switch (__gen__1__state)
                    {
                        default:
                            return __gen__2__current_enumerator?.TryMoveNext(ref item);
                        case 0:
                            __gen__1__state = -1;
                            if (b > e)
                            {
                                return __gen__2__current_enumerator?.TryMoveNext(ref item);
                            }
                            item = b;
                            __gen__1__state = 1;
                            return this;
                        case 1:
                            __gen__1__state = -1;
                            __gen__2__current_enumerator = null;
                            __gen__1__state = -3;
                            return FromToTail(b + 1, e).GetNestedEnumerator(__gen__2__current_enumerator).TryMoveNext(ref item);
                    }
                }
                catch
                {
                    //try-fault
                    ((IDisposable)this).Dispose();
                    throw;
                }
            }

            [DebuggerHidden]
            INestedEnumerator<int> INestedEnumerable<int>.GetNestedEnumerator(INestedEnumerator<int>? src)
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
                __genFromToTail__d__.__gen__2__current_enumerator = src;
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
