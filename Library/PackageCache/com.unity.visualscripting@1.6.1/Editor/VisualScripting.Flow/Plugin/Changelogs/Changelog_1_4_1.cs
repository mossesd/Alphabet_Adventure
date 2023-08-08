lidateFrameRate(frameRate);

            double exact = ToExactFrames(time, frameRate);
            double rounded = Math.Round(exact);

            return Math.Abs(exact - rounded) < epsilon;
        }

        public static double RoundToFrame(double time, double frameRate)
        {
            ValidateFrameRate(frameRate);

            var frameBefore = (int)Math.Floor(time * frameRate) / frameRate;
            var frameAfter = (int)Math.Ceiling(time * frameRate) / frameRate;

            return Math.Abs(time - frameBefore) < Math.Abs(time - frameAfter) ? frameBefore : frameAfter;
        }

        public static string TimeAsFrames(double timeValue, double frameRate, string format = "F2")
        {
            if (OnFrameBoundary(timeValue, frameRate)) // make integral values when on time borders
                return ToFrames(timeValue, frameRate).ToString();
            return ToExactFrames(timeValue, frameRate).ToString(format);
        }

        public static string TimeAsTimeCode(double timeValue, double frameRate, string format = "F2")
        {
            ValidateFrameRate(frameRate);

            int intTime = (int)Math.Abs(timeValue);

            int hours = intTime / 3600;
            int minutes = (intTime % 3600) / 60;
            int seconds = intTime % 60;

            stri