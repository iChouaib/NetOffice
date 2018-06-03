﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.VBIDEApi.Behind
{
    /// <summary>
    /// DispatchInterface _dispVBComponentsEvents
    /// SupportByVersion VBIDE, 12,14,5.3
    /// </summary>
    [SupportByVersion("VBIDE", 12, 14, 5.3)]
    [EntityType(EntityType.IsDispatchInterface)]
    public class _dispVBComponentsEvents : COMObject, NetOffice.VBIDEApi._dispVBComponentsEvents
    {
        #pragma warning disable

        #region Type Information

        /// <summary>
        /// Instance Type
        /// </summary>
        [EditorBrowsable(EditorBrowsableState.Advanced), Browsable(false), Category("NetOffice"), CoreOverridden]
        public override Type InstanceType
        {
            get
            {
                return LateBindingApiWrapperType;
            }
        }

        private static Type _type;

        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public static Type LateBindingApiWrapperType
        {
            get
            {
                if (null == _type)
                    _type = typeof(_dispVBComponentsEvents);
                return _type;
            }
        }

        #endregion

		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public _dispVBComponentsEvents() : base()
		{

		}

		#endregion

        #region Properties

        #endregion

        #region Methods

        /// <summary>
        /// SupportByVersion VBIDE 12, 14, 5.3
        /// </summary>
        /// <param name="vBComponent">NetOffice.VBIDEApi.VBComponent vBComponent</param>
        [SupportByVersion("VBIDE", 12, 14, 5.3)]
        public void ItemAdded(NetOffice.VBIDEApi.VBComponent vBComponent)
        {
            Factory.ExecuteMethod(this, "ItemAdded", vBComponent);
        }

        /// <summary>
        /// SupportByVersion VBIDE 12, 14, 5.3
        /// </summary>
        /// <param name="vBComponent">NetOffice.VBIDEApi.VBComponent vBComponent</param>
        [SupportByVersion("VBIDE", 12, 14, 5.3)]
        public void ItemRemoved(NetOffice.VBIDEApi.VBComponent vBComponent)
        {
            Factory.ExecuteMethod(this, "ItemRemoved", vBComponent);
        }

        /// <summary>
        /// SupportByVersion VBIDE 12, 14, 5.3
        /// </summary>
        /// <param name="vBComponent">NetOffice.VBIDEApi.VBComponent vBComponent</param>
        /// <param name="oldName">string oldName</param>
        [SupportByVersion("VBIDE", 12, 14, 5.3)]
        public void ItemRenamed(NetOffice.VBIDEApi.VBComponent vBComponent, string oldName)
        {
            Factory.ExecuteMethod(this, "ItemRenamed", vBComponent, oldName);
        }

        /// <summary>
        /// SupportByVersion VBIDE 12, 14, 5.3
        /// </summary>
        /// <param name="vBComponent">NetOffice.VBIDEApi.VBComponent vBComponent</param>
        [SupportByVersion("VBIDE", 12, 14, 5.3)]
        public void ItemSelected(NetOffice.VBIDEApi.VBComponent vBComponent)
        {
            Factory.ExecuteMethod(this, "ItemSelected", vBComponent);
        }

        /// <summary>
        /// SupportByVersion VBIDE 12, 14, 5.3
        /// </summary>
        /// <param name="vBComponent">NetOffice.VBIDEApi.VBComponent vBComponent</param>
        [SupportByVersion("VBIDE", 12, 14, 5.3)]
        public void ItemActivated(NetOffice.VBIDEApi.VBComponent vBComponent)
        {
            Factory.ExecuteMethod(this, "ItemActivated", vBComponent);
        }

        /// <summary>
        /// SupportByVersion VBIDE 12, 14, 5.3
        /// </summary>
        /// <param name="vBComponent">NetOffice.VBIDEApi.VBComponent vBComponent</param>
        [SupportByVersion("VBIDE", 12, 14, 5.3)]
        public void ItemReloaded(NetOffice.VBIDEApi.VBComponent vBComponent)
        {
            Factory.ExecuteMethod(this, "ItemReloaded", vBComponent);
        }

        #endregion

        #pragma warning restore
    }
}