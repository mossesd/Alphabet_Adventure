word.Trim(),
                    out mErrorMessage))
            {
                mErrorMessage = string.Empty;
                OkButtonAction();
                return;
            }

            mPassword = string.Empty;
            mRetypePassword = string.Empty;
        }

        static bool IsValidPassword(
            string password, string retypePassword,
            out string errorMessage)
        {
            errorMessage = string.Empty;

            if (string.IsNullOrEmpty(password))
            {
                errorMessage = PlasticLocalization.GetString(
                    PlasticLocalization.Name.InvalidEmptyPassword);
                return false;
            }

            if (!password.Equals(retypePassword))
            {
                errorMessage = PlasticLocalization.GetString(
                    PlasticLocalization.Name.PasswordDoesntMatch);
                return false;
            }

            return true;
        }

        static EncryptionConfigurationDialog Create(string server)
        {
            var instance = CreateInstance<EncryptionConfigurationDialog>();
            instance.mServer = server;
            instance.mEnterKeyAction = instance.OkButtonWithValidationAction;
            instance.mEscapeKeyAction = instance.CancelButtonAction;
            return instance;
        }

        string mPassword = string.Empty;
        string mRetypePassword = string.Empty;
        string mErrorMessage = string.Empty;

        string mServer = string.Empty;

        const float PASSWORD_TEXT_WIDTH = 250f;
        const float PASSWORD_TEXT_X = 200f;
    }
}

                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                          // -----------------------------------------------------------------------
// <copyright file="MeshValidator.cs">
// Original Triangle code by Jonathan Richard Shewchuk, http://www.cs.cmu.edu/~quake/triangle.html
// Triangle.NET code by Christian Woltering, http://triangle.codeplex.com/
// </copyright>
// -----------------------------------------------------------------------

namespace UnityEngine.U2D.Animation.TriangleNet
{
    using System;
    using Animation.TriangleNet.Topology;
    using Animation.TriangleNet.Geometry;

    internal static class MeshValidator
    {
        private static RobustPredicates predicates = RobustPredicates.Default;

        /// <summary>
        /// Test the mesh for topological consistency.
        /// </summary>
        internal static bool IsConsistent(Mesh mesh)
        {
            Otri tri = default(Otri);
            Otri oppotri = default(Otri), oppooppotri = default(Otri);
            Vertex org, dest, apex;
            Vertex oppoorg, oppodest;

            var logger = Log.Instance;

            // Temporarily turn on exact arithmetic if it's off.
            bool saveexact = Behavior.NoExact;
            Behavior.NoExact = false;

            int horrors = 0;

            // Run through the list of triangles, checking each one.
            foreach (var t in mesh.triangles)
            {
                tri.tri = t;

                // Check all three edges of the triangle.
                for (tri.orient = 0; tri.orient < 3; tri.orient++)
                {
                    org = tri.Org();
                    dest = tri.Dest();
                    if (tri.orient == 0)
                    {
                        // Only test for inversion once.
                        // Test if the triangle is flat or inverted.
                        apex = tri.Apex();
                        if (predicates.CounterClockwise(org, dest, apex) <= 0.0)
                        {
                            if (Log.Verbose)
                            {
                                logger.Warning(String.Format("Triangle is flat or inverted (ID {0}).", t.id),
                                    "MeshValidator.IsConsistent()");
                            }

                            horrors++;
                        }
                    }

                    // Find the neighboring triangle on this edge.
                    tri.Sym(ref oppotri);
                    if (oppotri.tri.id != Mesh.DUMMY)
                    {
                        // Check that the tr