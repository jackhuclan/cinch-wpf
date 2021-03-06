﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Collections.Generic;

namespace System.Windows
{
  /// <summary>
  /// Provides an implementation so that you can use the
  /// "weak event listener" pattern to attach listeners
  /// for the <see cref="PropertyChanged" /> event.
  /// 
  /// This class was obtained from Pete O'Hanlons blog
  /// http://peteohanlon.wordpress.com/tag/propertychangedeventmanager/
  /// </summary>
  public class PropertyChangedEventManager
  {
    #region Members
    private Dictionary<string, List<WeakReference>> _list;
    private static object SyncLock = new object();
    private static PropertyChangedEventManager _manager = null;
    #endregion

    #region Public methods
    /// <summary>
    /// Adds the specified listener to the list of listeners on the specified source.
    /// </summary>
    /// <param name="source">The object with the event.</param>
    /// <param name="listener">The object to add as a listener.</param>
    /// <param name="propertyName">The name of the property that exists on
    /// source upon which to listen for changes.</param>
    public static void AddListener(INotifyPropertyChanged source,
      IWeakEventListener listener,
      string propertyName)
    {
      Instance.PrivateAddListener(source, listener, propertyName);
    }

    /// <summary>
    /// Removes the specified listener from the list of listeners on the
    /// specified source.
    /// </summary>
    /// <param name="source">The object with the event.</param>
    /// <param name="listener">The object to remove as a listener.</param>
    /// <param name="propertyName">The name of the property that exists
    /// on source upon which to listen for changes.</param>
    public static void RemoveListener(INotifyPropertyChanged source,
      IWeakEventListener listener,
      string propertyName)
    {
      Instance.PrivateRemoveListener(source, listener, propertyName);
    }
    #endregion

    /// <summary>
    /// Get the current instance of <see cref="PropertyChangedEventManager"/>
    /// </summary>
    private static PropertyChangedEventManager Instance
    {
      get
      {
        if (_manager == null)
          _manager = new PropertyChangedEventManager();
        return _manager;
      }
    }

    /// <summary>
    /// Begin listening for the <see cref="PropertyChanged"/> event on
    /// the provided source.
    /// </summary>
    /// <param name="source">The object on which to start listening
    /// for <see cref="PropertyChanged"/>.</param>
    private void StartListening(INotifyPropertyChanged source)
    {
      source.PropertyChanged += new PropertyChangedEventHandler(this.PropertyChanged);
    }

    /// <summary>
    /// Stop listening for the <see cref="PropertyChanged"/> event on the
    /// provided source.
    /// </summary>
    /// <param name="source">The object on which to start listening for
    /// <see cref="PropertyChanged"/>.</param>
    private void StopListening(INotifyPropertyChanged source)
    {
      source.PropertyChanged -= new PropertyChangedEventHandler(this.PropertyChanged);
    }

    /// <summary>
    /// The method that handles the <see cref="INotifyPropertyChanged.PropertyChanged"/> event.
    /// </summary>
    /// <param name="sender">The source of the event.</param>
    /// <param name="args">A <see cref="PropertyChangedEventArgs"/> that
    /// contains the event data.</param>
    private void PropertyChanged(object sender, PropertyChangedEventArgs args)
    {
      List<WeakReference> list = _list[args.PropertyName];
      if (list != null)
      {
        // We have the listeners. Deal with them
        foreach (WeakReference item in list)
        {
          IWeakEventListener eventItem = item.Target as IWeakEventListener;
          if (eventItem != null && item.IsAlive)
          {
            eventItem.ReceiveWeakEvent(this.GetType(), sender, args);
          }
        }
      }
    }

    /// <summary>
    /// Private method to add the specified listener to the list of listeners
    /// on the specified source.
    /// </summary>
    /// <param name="source">The object with the event.</param>
    /// <param name="listener">The object to add as a listener.</param>
    /// <param name="propertyName">The name of the property that exists
    /// on source upon which to listen for changes.</param>
    private void PrivateAddListener(INotifyPropertyChanged source,
      IWeakEventListener listener,
      string propertyName)
    {
      if (_list == null)
      {
        _list = new Dictionary<string, List<WeakReference>>();
      }

      lock (SyncLock)
      {
        WeakReference reference = new WeakReference(listener);
        if (_list.ContainsKey(propertyName))
        {
          _list[propertyName].Add(reference);
        }
        else
        {
          List<WeakReference> list = new List<WeakReference>();
          list.Add(reference);
          _list.Add(propertyName, list);
        }
        // Now, start listening to source
        StartListening(source);
      }
    }

    /// <summary>
    /// Private method to remove the specified listener from the list of listeners
    /// on the specified source.
    /// </summary>
    /// <param name="source">The object with the event.</param>
    /// <param name="listener">The object to remove as a listener.</param>
    /// <param name="propertyName">The name of the property that exists on
    /// source upon which to listen for changes.</param>
    private void PrivateRemoveListener(INotifyPropertyChanged source,
      IWeakEventListener listener,
      string propertyName)
    {
      if (_list != null)
      {
        lock (SyncLock)
        {
          if (_list.ContainsKey(propertyName))
          {
            // Stop responding to changes
            StopListening(source);
            // Remove the item from the list.
            WeakReference reference = null;
            foreach (WeakReference item in _list[propertyName])
            {
              if (item.Target.Equals(listener))
              {
                reference = item;
              }
            }
            if (reference != null)
            {
              _list[propertyName].Remove(reference);
            }
          }
        }
      }
    }
  }
}