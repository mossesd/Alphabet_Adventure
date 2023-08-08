d;
                if (actuation <= releasePoint)
                {
                    actionState->releasedInUpdate = InputUpdate.s_UpdateStepCount;
                    actionState->isPressed = false;
                }
            }
        }

        /// <summary>
        /// Whether the given state change on a composite binding should be ignored.
        /// </summary>
        /// <param name="binding"></param>
        /// <param name="eventPtr"></param>
        /// <returns></returns>
        /// <remarks>
        /// Each state event may change the state of arbitrary many controls on a device and thus may trigger
        /// several bindings at once that are part of the same composite binding. We still want to trigger the
        /// composite binding only once for the event.
        ///
        /// To do so, we store the ID of the event on the binding and ignore events if they have the same
        /// ID as the one we've already recorded.
        /// </remarks>
        private static bool ShouldIgnoreInputOnCompositeBinding(BindingState* binding, InputEvent* eventPtr)
        {
            if (eventPtr == null)
                return false;

            var eventId = eventPtr->eventId;
            if (eventId != 0 && binding->triggerEventIdForComposite == eventId)
                return true;

            binding->triggerEventIdForComposite = eventId;
            return false;
        }

        /// <summary>
        /// Whether the given control state should be ignored.
        /// </summary>
        /// <param name="trigger"></param>
        /// <param name="actionIndex"></param>
        /// <returns></returns>
        /// <remarks>
        /// If an action has multiple controls bound to it, control state changes on the action may conflict with each other.
        /// If that happens, we resolve the conflict by always sticking to the most actuated control.
        ///
        /// Pass-through actions (<see cref="InputAction.passThrough"/>) will always bypass conflict resolution and respond
        /// to eve