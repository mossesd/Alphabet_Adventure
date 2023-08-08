't complete until added runtime thread have exited. Owner of threads attached to the
	* runtime but not identified as runtime threads needs to make sure thread detach calls won't
	* race with runtime shutdown.
	*/
#ifdef HOST_WIN32
	mono_threads_add_joinable_runtime_thread (info);
#endif

	/*
	 * thread->synch_cs can be NULL if this was called after
	 * ves_icall_System_Threading_InternalThread_Thread_free_internal.
	 * This can happen only during shutdown.
	 * The shutting_down flag is not always set, so we can't assert on it.
	 */
	if (thread->synch_cs)
		LOCK_THREAD (thread);

	thread->state |= ThreadState_Stopped;
	thread->state &= ~ThreadState_Background;

	if (thread->synch_cs)
		UNLOCK_THREAD (thread);

	/*
	An interruption request has leaked to cleanup. Adjust the global counter.

	This can happen is the abort source thread finds the abortee (this) thread
	in unmanaged code. If this thread never trips back to managed code or check
	the local flag it will be left set and positively unbalance the global counter.

	Leaving the counter unbalanced will cause a performance degradation since all threads
	will now keep checking their local flags all the time.
	*/
	mono_thread_clear_interruption_requested (thread);

	mono_threads_lock ();

	if (!threads) {
		removed = FALSE;
	} else if (mono_g_hash_table_lookup (threads, (gpointer)thread->tid) != thread) {
		/* We have to check whether the thread object for the
		 * tid is still t