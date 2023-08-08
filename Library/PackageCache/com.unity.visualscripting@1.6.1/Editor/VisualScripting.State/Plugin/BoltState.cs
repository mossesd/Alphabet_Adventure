ched to the clips.
        /// </summary>
        /// <param name="tracks">The timeline track being modified.</param>
        /// <param name="undoTitle">The title of the action to appear in the undo history (i.e. visible in the undo menu).</param>
        public static void RegisterTracks(IEnumerable<TrackAsset> tracks, string undoTitle)
        {
            using (var undo = new UndoScope(undoTitle))
                undo.Add(tracks);
        }

        /// <summary>
        /// Records any changes done on the clip after being called.
        /// </summary>
        /// <param name="clip">The timeline clip being modified.</param>
        /// <param name="undoTitle">The title of the action to appear in the undo history (i.e. visible in the undo menu).</param>
        /// <param name="includePlayableAsset">Set this value to true to also record changes on the attached playable asset.</param>
        public static void RegisterClip(TimelineClip clip, string undoTitle, bool includePlayableAsset = true)
        {
            using (var undo = new UndoScope(undoTitle))
            {
                undo.AddClip(clip, includePlayableAsset);
            }
        }

        /// <summary>
        /// Records any changes done on the PlayableAsset after being called.
        /// </summary>
        /// <param name="asset">The timeline track being modified.</param>
        /// <param name="undoTitle">The title of the action to appear in the undo history (i.e. visible in the undo menu).</param>
        public static void Regi