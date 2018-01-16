using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventQueue : MonoBehaviour
{
    public class EventArgs
    {
        //Fill this up with data about what events were executed. This is implementation specific
        //Add a constructor too, so it is easy to pass to anyone that wants this information.
        //This can also be derived for specialized EventQueues, such as UI, Game State, Scene Transitions, etc.
    }

    public delegate void EventExecuted(EventArgs eqa);
    public event EventExecuted StateChangeEvent;

    public delegate void RunEvent();
    static LinkedList<RunEvent> eventQueue = new LinkedList<RunEvent>();

    public static void RaiseEvent(RunEvent re)
    {
        if (re == null)
            throw new System.ArgumentNullException("RunEvent must not be null");

        eventQueue.AddLast(re);
    }

    //Other systems are allowed to use LateUpdate, however
    //state changes should only happen during regular Update
    void LateUpdate()
    {
        bool statesChanged = false;
        while(eventQueue.Count > 0)
        {
            LinkedListNode<RunEvent> first = eventQueue.First;
            first.Value.Invoke();
            eventQueue.RemoveFirst();
            statesChanged = true;
        }

        //TODO: make this fired off in the while loop.
        //This requires a lot more tracking information to notify what type of event was raised,
        //who raised it, and who was affected.
        //That data isn't tracked as this is a tech demo.
        if(statesChanged && StateChangeEvent != null)
        {
            StateChangeEvent(new EventArgs());
        }
        /*
         * In newer versions of C#, this can be shortened to "StateChangeEvent?.Invoke(new EventArgs());"
         */
    }
}
