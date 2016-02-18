﻿/*
 * Author(s): Isaiah Mann 
 * Description: A single event class that others can subscribe to and call events from
 * Currently relies on event names as strings
 * Event method can be overloaded to implement different event types
 * Dependencies: EventList
 */

using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public static class EventController {

	public delegate void NamedEventAction (string nameOfEvent);
	public static event NamedEventAction OnNamedEvent;


	static EventController () {
		Init();
	}
	
	public static void Event (string eventName) {
		if (OnNamedEvent != null) {
			OnNamedEvent(eventName);
		}
	}

}