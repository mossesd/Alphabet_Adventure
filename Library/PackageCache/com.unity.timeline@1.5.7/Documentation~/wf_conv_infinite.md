_Objects[i];
                if (o == null)
                {
                    Debug.LogWarning("Empty marker found while loading timeline. It will be removed.");
                    m_Objects.RemoveAt(i);
                }
            }
#endif
            m_CacheDirty = true;
        }

        void BuildCache()
        {
            if (m_CacheDirty)
            {
                m_Cache = new List<IMarker>(m_Objects.Count);
                m_HasNotifications = false;
                foreach (var o in m_Objects)
                {
                    if (o != null)
                    {
                        m_Cache.Add(o as IMarker);
                        if (o is INotification)
                        {
                            m_HasNotifications = true;
                        }
                    }
                }

                m_CacheDirty = false;
            }
        }
    }
}
                     
   MarkerList                                                                                         