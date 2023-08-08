ffset = Vector2.zero;
                }

                capPosition.position += capOffset;
                end -= endOffset;

                if (BoltCore.Configuration.developerMode && BoltCore.Configuration.debug)
                {
                    EditorGUI.DrawRect(capPosition, new Color(0, 0, 1, 0.25f));
                }

                using (LudiqGUI.color.Override(LudiqGUI.color.value * color))
                {
                    GUI.DrawTexture(capPosition, cap);
                }
            }

            var startTangent = GetStartTangent(start, end, startEdge, endEdge, relativeBend, minBend);
            var endTangent = GetEndTangent(start, end, startEdge, endEdge, relativeBend, minBend);

            Handles.DrawBezier(start, end, startTangent, endTangent, LudiqGUI.color.value * color, AliasedBezierTexture(thickness), thickness);

            if (BoltCore.Configuration.developerMode && BoltCore.Configuration.debug)
            {
                Handles.color = Color.yellow;
                Handles.DrawLine(start, startTangent);
                Handles.DrawLine(end, endTangent);
            }
        }

        private static Vector2 GetStartTangent(Vector2 start, Vector2 end, Edge startEdge, Edge? endEdge, float relativeBend, float minBend)
        {
            var startDirection = startEdge.Normal();

            var startBend = Mathf.Abs(Vector2.Dot(end - start, startDirection)) * relativeBend;

            if (startDirection.y != 0)
            {
                startBend *= -1;
            }

            if (Mathf.Abs(startBend) < Mathf.Abs(minBend))
            {
                startBend = Mathf.Sign(startBend) * minBend;
            }

            var startTangent = start + startDirection * startBend;

            return startTangent;
        }

        private static Vector2 GetEndTangent(Vector2 start, Vector2 end, Edge startEdge, Edge? endEdge, float relativeBend, float minBend)
        {
            var endDirection = endEdge?.Normal() ?? startEdge.Opposite().Normal();

            var endBend = Mathf.Abs(Vector2.Dot(start - end, endDirection)) * relativeBend;

            if (endDirection.y != 0)
            {
                endBend *= -1;
            }

            if (Mathf.Abs(endBend) < Mathf.Abs(minBend))
            {
                endBend = Mathf.Sign(endBend) * minBend;
            }

            var endTangent = end + endDirection * endBend;

            return endTangent;
        }

        public static bool PositionOverlaps(ICanvas canvas, IGraphElementWidget widget, float threshold = 3)
        {
         