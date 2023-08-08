se;
                EditMode.FinishTrim();
                TimelineWindow.instance.Repaint();
            }

            public void OnSetValue(IEnumerable<ITimelineItem> items, double endValue, WindowState state)
            {
                foreach (var item in items.OfType<ITrimmable>())
                {
                    EditMode.BeginTrim(item, TrimEdge.End);
                    EditMode.TrimEnd(item, endValue, stretch);
                    EditMode.FinishTrim();
                }
                state.UpdateRootPlayableDuration(state.editSequence.duration);
            }

            public void OnGUI(WindowState state)
            {
                if (!isDragging) return;

                foreach (var item in grabbedItems)
                {
                    EditMode.DrawTrimGUI(state, item.gui, TrimEdge.End);
                }
            }
        }

        class MoveInputHandler : IInputHandler
        {
            MoveItemHandler m_MoveItemHandler;

            public void OnEnterDrag(IEnumerable<ITimelineItem> items, WindowState state)
            {
                if (items.Any())
                {
                    m_MoveItemHandler = new MoveItemHandler(state);
                    m_MoveItemHandler.Grab(items, items.First().parentTrack);
                }
            }

            public void OnDrag(double value, WindowState state)
            {
                if (m_MoveItemHa