 missing");
                    // }

                    return personalAtResolution;
                }
            }
        }

        public Texture2D Single()
        {
            if (EditorGUIUtility.isProSkin)
            {
                if (professional.Count > 1)
                {
                    throw new InvalidOperationException();
                }
                else if (professional.Count == 1)
                {
                    return professional.Values.Single();
                }
            }

            if (personal.Count > 1)
            {
                throw new InvalidOperationException();
            }
            else if (personal.Count == 1)
            {
                return personal.Values.Single();
            }
            else
            {
                throw new InvalidOperationException();
            }
        }

        private Texture2D GetHighestResolution(Dictionary<int, Texture2D> dictionary)
        {
            return dictionary.OrderByDescending(kvp => kvp.Key).Select(kvp => kvp.Value).FirstOrDefault();
        }

        #endregion


        #region Loading

        public static readonly TextureResolution[] StandardIconResolutions = new TextureResolution[]
        {
            IconSize.Small,
            I