using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace Current
{
    public static class DecompiledExamples
    {
        [CompilerGenerated]
        private sealed class __genFromToHead__d__2 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IEnumerator, IDisposable
        {
            private int __gen__1__state;

            private int __gen__2__current;

            private int __gen__l__initialThreadId;

            private int b;

            public int __gen__3__b;

            private int e;

            public int __gen__3__e;

            private IEnumerator<int> __gen__7__wrap1;

            int IEnumerator<int>.Current
            {
                [DebuggerHidden]
                get
                {
                    return __gen__2__current;
                }
            }

            object IEnumerator.Current
            {
                [DebuggerHidden]
                get
                {
                    return __gen__2__current;
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

            private bool MoveNext()
            {
                try
                {
                    switch (__gen__1__state)
                    {
                        default:
                            return false;
                        case 0:
                            __gen__1__state = -1;
                            if (b > e)
                            {
                                return false;
                            }
                            __gen__7__wrap1 = FromToHead(b, e - 1).GetEnumerator();
                            __gen__1__state = -3;
                            goto IL_008a;
                        case 1:
                            __gen__1__state = -3;
                            goto IL_008a;
                        case 2:
                            {
                                __gen__1__state = -1;
                                return false;
                            }
                        IL_008a:
                            if (__gen__7__wrap1.MoveNext())
                            {
                                int num = (__gen__2__current = __gen__7__wrap1.Current);
                                __gen__1__state = 1;
                                return true;
                            }
                            __gen__m__Finally1();
                            __gen__7__wrap1 = null;
                            __gen__2__current = e;
                            __gen__1__state = 2;
                            return true;
                    }
                }
                catch
                {
                    //try-fault
                    ((IDisposable)this).Dispose();
                    throw;
                }
            }

            bool IEnumerator.MoveNext()
            {
                //ILSpy generated this explicit interface implementation from .override directive in MoveNext
                return this.MoveNext();
            }

            private void __gen__m__Finally1()
            {
                __gen__1__state = -1;
                if (__gen__7__wrap1 != null)
                {
                    __gen__7__wrap1.Dispose();
                }
            }

            [DebuggerHidden]
            void IEnumerator.Reset()
            {
                throw new NotSupportedException();
            }

            [DebuggerHidden]
            IEnumerator<int> IEnumerable<int>.GetEnumerator()
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

            [DebuggerHidden]
            IEnumerator IEnumerable.GetEnumerator()
            {
                return ((IEnumerable<int>)this).GetEnumerator();
            }
        }


        [CompilerGenerated]
        private sealed class __genFromToIdeal__d__0 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IEnumerator, IDisposable
        {
            private int __gen__1__state;

            private int __gen__2__current;

            private int __gen__l__initialThreadId;

            private int b;

            public int __gen__3__b;

            private int e;

            public int __gen__3__e;

            private int __genx__5__2;

            int IEnumerator<int>.Current
            {
                [DebuggerHidden]
                get
                {
                    return __gen__2__current;
                }
            }

            object IEnumerator.Current
            {
                [DebuggerHidden]
                get
                {
                    return __gen__2__current;
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

            private bool MoveNext()
            {
                int num = __gen__1__state;
                if (num != 0)
                {
                    if (num != 1)
                    {
                        return false;
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
                    return true;
                }
                return false;
            }

            bool IEnumerator.MoveNext()
            {
                //ILSpy generated this explicit interface implementation from .override directive in MoveNext
                return this.MoveNext();
            }

            [DebuggerHidden]
            void IEnumerator.Reset()
            {
                throw new NotSupportedException();
            }

            [DebuggerHidden]
            IEnumerator<int> IEnumerable<int>.GetEnumerator()
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

            [DebuggerHidden]
            IEnumerator IEnumerable.GetEnumerator()
            {
                return ((IEnumerable<int>)this).GetEnumerator();
            }
        }


        [CompilerGenerated]
        private sealed class __genFromToTail__d__1 : IEnumerable<int>, IEnumerable, IEnumerator<int>, IEnumerator, IDisposable
        {
            private int __gen__1__state;

            private int __gen__2__current;

            private int __gen__l__initialThreadId;

            private int b;

            public int __gen__3__b;

            private int e;

            public int __gen__3__e;

            private IEnumerator<int> __gen__7__wrap1;

            int IEnumerator<int>.Current
            {
                [DebuggerHidden]
                get
                {
                    return __gen__2__current;
                }
            }

            object IEnumerator.Current
            {
                [DebuggerHidden]
                get
                {
                    return __gen__2__current;
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

            private bool MoveNext()
            {
                try
                {
                    switch (__gen__1__state)
                    {
                        default:
                            return false;
                        case 0:
                            __gen__1__state = -1;
                            if (b > e)
                            {
                                return false;
                            }
                            __gen__2__current = b;
                            __gen__1__state = 1;
                            return true;
                        case 1:
                            __gen__1__state = -1;
                            __gen__7__wrap1 = FromToTail(b + 1, e).GetEnumerator();
                            __gen__1__state = -3;
                            break;
                        case 2:
                            __gen__1__state = -3;
                            break;
                    }
                    if (__gen__7__wrap1.MoveNext())
                    {
                        int num = (__gen__2__current = __gen__7__wrap1.Current);
                        __gen__1__state = 2;
                        return true;
                    }
                    __gen__m__Finally1();
                    __gen__7__wrap1 = null;
                    return false;
                }
                catch
                {
                    //try-fault
                    ((IDisposable)this).Dispose();
                    throw;
                }
            }

            bool IEnumerator.MoveNext()
            {
                //ILSpy generated this explicit interface implementation from .override directive in MoveNext
                return this.MoveNext();
            }

            private void __gen__m__Finally1()
            {
                __gen__1__state = -1;
                if (__gen__7__wrap1 != null)
                {
                    __gen__7__wrap1.Dispose();
                }
            }

            [DebuggerHidden]
            void IEnumerator.Reset()
            {
                throw new NotSupportedException();
            }

            [DebuggerHidden]
            IEnumerator<int> IEnumerable<int>.GetEnumerator()
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

            [DebuggerHidden]
            IEnumerator IEnumerable.GetEnumerator()
            {
                return ((IEnumerable<int>)this).GetEnumerator();
            }
        }

        [IteratorStateMachine(typeof(__genFromToIdeal__d__0))]
        public static IEnumerable<int> FromToIdeal(int b, int e)
        {
            __genFromToIdeal__d__0 __genFromToIdeal__d__ = new __genFromToIdeal__d__0(-2);
            __genFromToIdeal__d__.__gen__3__b = b;
            __genFromToIdeal__d__.__gen__3__e = e;
            return __genFromToIdeal__d__;
        }

        [IteratorStateMachine(typeof(__genFromToTail__d__1))]
        public static IEnumerable<int> FromToTail(int b, int e)
        {
            __genFromToTail__d__1 __genFromToTail__d__ = new __genFromToTail__d__1(-2);
            __genFromToTail__d__.__gen__3__b = b;
            __genFromToTail__d__.__gen__3__e = e;
            return __genFromToTail__d__;
        }

        [IteratorStateMachine(typeof(__genFromToHead__d__2))]
        public static IEnumerable<int> FromToHead(int b, int e)
        {
            __genFromToHead__d__2 __genFromToHead__d__ = new __genFromToHead__d__2(-2);
            __genFromToHead__d__.__gen__3__b = b;
            __genFromToHead__d__.__gen__3__e = e;
            return __genFromToHead__d__;
        }
    }
}
