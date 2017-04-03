using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Threading;

namespace ZNLCRM.Utility
{
    //[DebuggerNonUserCode]
    public static class TaskHelpers
    {
        private static readonly Lazy<Task> CompletedTask = new Lazy<Task>(() => GetDoneTask<object>(null));

        public static Task GetDoneTask()
        {
            return CompletedTask.Value;
        }

        public static Task<T> GetDoneTask<T>(T result)
        {
            var tcs = new TaskCompletionSource<T>();
            tcs.SetResult(result);
            return tcs.Task;
        }

        public static Task<T> GetFaultedTask<T>(Exception exception)
        {
            var tcs = new TaskCompletionSource<T>();
            tcs.SetException(exception);
            return tcs.Task;
        }

        public static Task Done<T>(this Task<T> task,
            Action<T> done,
            bool onUI = true,
            TaskContinuationOptions options = TaskContinuationOptions.OnlyOnRanToCompletion)
        {
            return task.Done(
                t => done(t.Result),
                CancellationToken.None,
                onUI,
                options
            );
        }

        public static Task Done<T>(this Task<T> task,
            Action<Task<T>> done,
            bool onUI = true,
            TaskContinuationOptions options = TaskContinuationOptions.OnlyOnRanToCompletion)
        {
            return task.Done(
                    done,
                    CancellationToken.None,
                    onUI,
                    options
                );
        }

        public static Task Done(this Task task,
            Action done,
            bool onUI = true,
            TaskContinuationOptions options = TaskContinuationOptions.OnlyOnRanToCompletion)
        {
            return task.Done(
                    t => done(),
                    CancellationToken.None,
                    onUI,
                    options
                );
        }

        public static Task Done(this Task task,
            Action<Task> done,
            bool onUI = true,
            TaskContinuationOptions options = TaskContinuationOptions.OnlyOnRanToCompletion)
        {
            return task.Done(
                    done,
                    CancellationToken.None,
                    onUI,
                    options
                );
        }

        public static Task<TNew> Done<T, TNew>(this Task<T> task,
            Func<Task<T>, TNew> done,
            bool onUI = true,
            TaskContinuationOptions options = TaskContinuationOptions.OnlyOnRanToCompletion)
        {
            return task.Done(
                    done,
                    CancellationToken.None,
                    onUI,
                    options
                );
        }

        public static Task<TNew> Done<T, TNew>(this Task<T> task,
            Func<Task<T>, TNew> done,
            CancellationToken source,
            bool onUI = true,
            TaskContinuationOptions options = TaskContinuationOptions.OnlyOnRanToCompletion)
        {
            if (onUI)
            {
                return task.ContinueWith(
                    done,
                    source,
                    options,
                    TaskScheduler.FromCurrentSynchronizationContext()
                );
            }

            return task.ContinueWith(
                done,
                source,
                options,
                TaskScheduler.Current
            );
        }

        public static Task<TNew> Error<T, TNew>(this Task<T> task,
            Func<Task<T>, TNew> error,
            bool onUI = true,
            TaskContinuationOptions options = TaskContinuationOptions.OnlyOnFaulted)
        {
            return task.Done(
                    error,
                    CancellationToken.None,
                    onUI,
                    options
                );
        }

        public static Task Error(this Task task,
            Action<Task> error,
            bool onUI = true,
            TaskContinuationOptions options = TaskContinuationOptions.OnlyOnFaulted)
        {
            return task.Error(
                error,
                CancellationToken.None,
                onUI,
                options
            );
        }

        public static Task Error(this Task task,
            Action<Exception> error,
            bool onUI = true,
            TaskContinuationOptions options = TaskContinuationOptions.OnlyOnFaulted)
        {
            return task.Error(
                new Action<Task>(t => error(t.UnwrapIfSingleException())),
                CancellationToken.None,
                onUI,
                options
            );
        }

        public static Task Error(this Task task,
            Action<Exception> error,
            CancellationToken source,
            bool onUI = true,
            TaskContinuationOptions options = TaskContinuationOptions.OnlyOnFaulted)
        {
            return task.Error(
                    new Action<Task>(t => error(t.UnwrapIfSingleException())),
                    source,
                    onUI,
                    options
                );
        }

        #region Direct Implements

        public static Task Done<T>(this Task<T> task,
            Action<Task<T>> done,
            CancellationToken source,
            bool onUI = true,
            TaskContinuationOptions options = TaskContinuationOptions.OnlyOnRanToCompletion)
        {
            if (onUI)
            {
                return task.ContinueWith(
                    done,
                    source,
                    options,
                    TaskScheduler.FromCurrentSynchronizationContext()
                );
            }

            return task.ContinueWith(
                done,
                source,
                options,
                TaskScheduler.Current
            );
        }

        public static Task Done(this Task task,
            Action<Task> done,
            CancellationToken source,
            bool onUI = true,
            TaskContinuationOptions options = TaskContinuationOptions.OnlyOnRanToCompletion)
        {
            if (onUI)
            {
                return task.ContinueWith(
                    done,
                    source,
                    options,
                    TaskScheduler.FromCurrentSynchronizationContext()
                );
            }

            return task.ContinueWith(
                    done,
                    source,
                    options,
                    TaskScheduler.Default
                );
        }

        public static Task<TNew> Error<T, TNew>(this Task<T> task,
            Func<Task<T>, TNew> error,
            CancellationToken source,
            bool onUI = true,
            TaskContinuationOptions options = TaskContinuationOptions.OnlyOnFaulted)
        {
            if (onUI)
            {
                return task.ContinueWith<TNew>(
                        error,
                        source,
                        options,
                        TaskScheduler.FromCurrentSynchronizationContext()
                    );
            }

            return task.ContinueWith<TNew>(
                    error,
                    source,
                    options,
                    TaskScheduler.Current
                );
        }

        public static Task Error(this Task task,
            Action<Task> error,
            CancellationToken source,
            bool onUI = true,
            TaskContinuationOptions options = TaskContinuationOptions.OnlyOnFaulted)
        {
            if (onUI)
            {
                return task.ContinueWith(
                        error,
                        source,
                        options,
                        TaskScheduler.FromCurrentSynchronizationContext()
                    );
            }

            return task.ContinueWith(
                    error,
                    source,
                    options,
                    TaskScheduler.Current
                );
        }

        #endregion

        #region Handle exception

        public static Exception UnwrapIfSingleException<T>(this Task<T> task)
        {
            return task.Exception.UnwrapIfSingleException();
        }

        public static Exception UnwrapIfSingleException(this Task task)
        {
            return task.Exception.UnwrapIfSingleException();
        }

        public static Exception UnwrapIfSingleException(this Exception ex)
        {
            var aex = ex as AggregateException;
            if (aex == null)
                return ex;

            if (aex.InnerExceptions != null
                && aex.InnerExceptions.Count == 1)
                return aex.InnerExceptions[0];

            return ex;
        }

        #endregion
    }
}
