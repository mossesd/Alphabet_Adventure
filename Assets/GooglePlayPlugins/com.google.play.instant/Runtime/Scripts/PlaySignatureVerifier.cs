                           Ş(               0.0.0 ţ˙˙˙      ˙˙f!ë59Ý4QÁóB   í          7  ˙˙˙˙                 Ś ˛                       E                    Ţ  #                     . ,                     5   a                    Ţ  #                     . ,                      r                    Ţ  #      	               . ,      
               H Ť ˙˙˙˙             1  1  ˙˙˙˙   @           Ţ                     Q  j                    ń  J   ˙˙˙˙   Ŕ           1  1  ˙˙˙˙               Ţ                       j  ˙˙˙˙               \     ˙˙˙˙               H r   ˙˙˙˙              1  1  ˙˙˙˙   @            Ţ                      Q  j                     H w   ˙˙˙˙              1  1  ˙˙˙˙   @            Ţ                      Q  j                     H    ˙˙˙˙              1  1  ˙˙˙˙   @            Ţ                      Q  j                     y 
                     Ţ  #      !               . ,      "                   ˙˙˙˙#   @          1  1  ˙˙˙˙$               Ţ      %               . j     &               Ő    ˙˙˙˙'               1  1  ˙˙˙˙(    Ŕ            Ţ      )                  j  ˙˙˙˙*                H   ˙˙˙˙+               1  1  ˙˙˙˙,   @            Ţ      -                Q  j     .                y 
    /                 Ţ  #      0               . ,      1                 §      2    @            ž ś      3    @            Ţ  #      4               . ,      5               H ť   ˙˙˙˙6              1  1  ˙˙˙˙7   @            Ţ      8                Q  j     9                H Ć   ˙˙˙˙:              1  1  ˙˙˙˙;   @            Ţ      <                Q  j     =                H Ř   ˙˙˙˙>              1  1  ˙˙˙˙?   @            Ţ      @                Q  j     A              MonoImporter PPtr<EditorExtension> m_FileID m_PathID PPtr<PrefabInstance> m_ExternalObjects SourceAssetIdentifier type assembly name m_UsedFileIDs m_DefaultReferences executionOrder icon m_UserData m_AssetBundleName m_AssetBundleVariant     s    ˙˙ŁGń×ÜZ56 :!@iÁJ*          7  ˙˙˙˙                 Ś ˛                        E                    Ţ                       .                      (   a                    Ţ                       .                       r                    Ţ        	               .       
               H Ť ˙˙˙˙             1  1  ˙˙˙˙   @           Ţ                     Q  j                    H ę ˙˙˙˙              1  1  ˙˙˙˙   @            Ţ                      Q  j                     ń  =   ˙˙˙˙              1  1  ˙˙˙˙               Ţ                       j  ˙˙˙˙               H   ˙˙˙˙              1  1  ˙˙˙˙   @            Ţ                      Q  j                     y 
                    Ţ                       .                      y Q                       Ţ                       .                       Ţ  X      !                H i   ˙˙˙˙"              1  1  ˙˙˙˙#   @            Ţ      $                Q  j     %                H u   ˙˙˙˙&              1  1  ˙˙˙˙'   @            Ţ      (                Q  j     )              PPtr<EditorExtension> m_FileID m_PathID PPtr<PrefabInstance> m_DefaultReferences m_Icon m_ExecutionOrder m_ClassName m_Namespace                        \       ŕyŻ     `       Č                                                                                                                                                ŕyŻ                                                                                    RTHandleSystem  C  using System;
using System.Collections.Generic;
using UnityEngine.Assertions;
using UnityEngine.Experimental.Rendering;

namespace UnityEngine.Rendering
{
    /// <summary>
    /// Scaled function used to compute the size of a RTHandle for the current frame.
    /// </summary>
    /// <param name="size">Reference size of the RTHandle system for the frame.</param>
    /// <returns>The size of the RTHandled computed from the reference size.</returns>
    public delegate Vector2Int ScaleFunc(Vector2Int size);

    /// <summary>
    /// List of properties of the RTHandle System for the current frame.
    /// </summary>
    public struct RTHandleProperties
    {
        /// <summary>
        /// Size set as reference at the previous frame
        /// </summary>
        public Vector2Int previousViewportSize;
        /// <summary>
        /// Size of the render targets at the previous frame
        /// </summary>
        public Vector2Int previousRenderTargetSize;
        /// <summary>
        /// Size set as reference at the current frame
        /// </summary>
        public Vector2Int currentViewportSize;
        /// <summary>
        /// Size of the render targets at the current frame
        /// </summary>
        public Vector2Int currentRenderTargetSize;
        /// <summary>
        /// Scale factor from RTHandleSystem max size to requested reference size (referenceSize/maxSize)
        /// (x,y) current frame (z,w) last frame (this is only used for buffered RTHandle Systems)
        /// </summary>
        public Vector4 rtHandleScale;
    }

    /// <summary>
    /// System managing a set of RTHandle textures
    /// </summary>
    public partial class RTHandleSystem : IDisposable
    {
        internal enum ResizeMode
        {
            Auto,
            OnDemand
        }

        // Parameters for auto-scaled Render Textures
        bool m_HardwareDynamicResRequested = false;
        HashSet<RTHandle> m_AutoSizedRTs;
        RTHandle[] m_AutoSizedRTsArray; // For fast iteration
        HashSet<RTHandle> m_ResizeOnDemandRTs;
        RTHandleProperties m_RTHandleProperties;

        /// <summary>
        /// Current properties of the RTHandle System.
        /// </summary>
        public RTHandleProperties rtHandleProperties { get { return m_RTHandleProperties; } }

        int m_MaxWidths = 0;
        int m_MaxHeights = 0;
#if UNITY_EDITOR
        // In editor every now and then we must reset the size of the rthandle system if it was set very high and then switched back to a much smaller scale.
        int m_FramesSinceLastReset = 0;
#endif

        /// <summary>
        /// RTHandleSystem constructor.
        /// </summary>
        public RTHandleSystem()
        {
            m_AutoSizedRTs = new HashSet<RTHandle>();
            m_ResizeOnDemandRTs = new HashSet<RTHandle>();
            m_MaxWidths = 1;
            m_MaxHeights = 1;
        }

        /// <summary>
        /// Disposable pattern implementation
        /// </summary>
        public void Dispose()
        {
            Dispose(true);
        }

        /// <summary>
        /// Initialize the RTHandle system.
        /// </summary>
        /// <param name="width">Initial reference rendering width.</param>
        /// <param name="height">Initial reference rendering height.</param>
        public void Initialize(int width, int height)
        {
            if (m_AutoSizedRTs.Count != 0)
            {
                string leakingResources = "Unreleased RTHandles:";
                foreach (var rt in m_AutoSizedRTs)
                {
                    leakingResources = string.Format("{0}\n    {1}", leakingResources, rt.name);
                }
                Debug.LogError(string.Format("RTHandle.Initialize should only be called once before allocating any Render Texture. This may be caused by an unreleased RTHandle resource.\n{0}\n", leakingResources));
            }

            m_MaxWidths = width;
            m_MaxHeights = height;

            m_HardwareDynamicResRequested = DynamicResolutionHandler.instance.RequestsHardwareDynamicResolution();
        }

        /// <summary>
        /// Release memory of a RTHandle from the RTHandle System
        /// </summary>
        /// <param name="rth">RTHandle that should be released.</param>
        public void Release(RTHandle rth)
        {
            if (rth != null)
            {
                Assert.AreEqual(this, rth.m_Owner);
                rth.Release();
            }
        }

        internal void Remove(RTHandle rth)
        {
            m_AutoSizedRTs.Remove(rth);
        }

        /// <summary>
        /// Reset the reference size of the system and reallocate all textures.
        /// </summary>
        /// <param name="width">New width.</param>
        /// <param name="height">New height.</param>
        public void ResetReferenceSize(int width, int height)
        {
            m_MaxWidths = width;
            m_MaxHeights = height;
            SetReferenceSize(width, height, reset: true);
        }

        /// <summary>
        /// Sets the reference rendering size for subsequent rendering for the RTHandle System
        /// </summary>
        /// <param name="width">Reference rendering width for subsequent rendering.</param>
        /// <param name="height">Reference rendering height for subsequent rendering.</param>
        public void SetReferenceSize(int width, int height)
        {
            SetReferenceSize(width, height, false);
        }

        /// <summary>
        /// Sets the reference rendering size for subsequent rendering for the RTHandle System
        /// </summary>
        /// <param name="width">Reference rendering width for subsequent rendering.</param>
        /// <param name="height">Reference rendering height for subsequent rendering.</param>
        /// <param name="reset">If set to true, the new width and height will override the old values even if they are not bigger.</param>
        public void SetReferenceSize(int width, int height, bool reset)
        {
            m_RTHandleProperties.previousViewportSize = m_RTHandleProperties.currentViewportSize;
            m_RTHandleProperties.previousRenderTargetSize = m_RTHandleProperties.currentRenderTargetSize;
            Vector2 lastFrameMaxSize = new Vector2(GetMaxWidth(), GetMaxHeight());

            width = Mathf.Max(width, 1);
            height = Mathf.Max(height, 1);

#if UNITY_EDITOR
            // If the reference size is significantly higher than the current actualWidth/Height and it is larger than 1440p dimensions, we reset the reference size every several frames
            // in editor to avoid issues if a large resolution was temporarily set.
            const int resetInterval = 100;
            if (((m_MaxWidths / (float)width) > 2.0f && m_MaxWidths > 2560) ||
                ((m_MaxHeights / (float)height) > 2.0f && m_MaxHeights > 1440))
            {
          