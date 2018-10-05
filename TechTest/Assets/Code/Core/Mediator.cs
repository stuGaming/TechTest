using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Author: Stuart McRoberts
//Messaging system to communicate between different projects
public class Mediator : MonoBehaviour
{
    public static Mediator Instance = null;


    public static Dictionary<object, List<CommunicationHandler>> RegisteredHandlers = new Dictionary<object, List<CommunicationHandler>>();



    public static Dictionary<object, List<object>> RegisteredObjects = new Dictionary<object, List<object>>();

    public delegate void CommunicationHandler(Message message);
    private void Awake()
    {
        Debug.Log(this.transform.name);
        if (Mediator.Instance != null)
        {
            Mediator.Instance = null;
            Mediator.Instance = this;

        }
        else
        {
            Mediator.Instance = this;
        }
    }

    public static void SendMessage(object Identification, params object[] args)
    {
        Message msg = new Message();
        if (args.Length > 1)
        {

            msg.CreatePayload(args);

        }
        if (RegisteredHandlers.ContainsKey(Identification))
        {
            foreach (CommunicationHandler handler in RegisteredHandlers[Identification])
            {
                handler(msg);
            }
        }
    }

    public static void RegisterHandler(object Identification, object baseObject, CommunicationHandler funct)
    {
        if (RegisteredHandlers.ContainsKey(Identification))
        {
            RegisteredHandlers[Identification].Add(funct);
        }
        else
        {
            RegisteredHandlers.Add(Identification, new List<CommunicationHandler>());
            RegisteredHandlers[Identification].Add(funct);
        }
        if (RegisteredObjects.ContainsKey(baseObject))
        {
            RegisteredObjects[baseObject].Add(Identification);
        }
        else
        {
            RegisteredObjects.Add(baseObject, new List<object>());
            RegisteredObjects[baseObject].Add(Identification);
        }


    }
    public class CommunicationPair
    {
        public object key;
        public object value;


    }


}
