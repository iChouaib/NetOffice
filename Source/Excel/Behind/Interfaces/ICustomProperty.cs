﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.ExcelApi;

namespace NetOffice.ExcelApi.Behind
{
    /// <summary>
    /// Interface ICustomProperty 
    /// SupportByVersion Excel, 10,11,12,14,15,16
    /// </summary>
    [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
    [EntityType(EntityType.IsInterface)]
    public class ICustomProperty : COMObject, NetOffice.ExcelApi.ICustomProperty
    {
        #pragma warning disable

        #region Type Information

        /// <summary>        /// Instance Type
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
                    _type = typeof(ICustomProperty);
                return _type;
            }
        }

        #endregion

		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public ICustomProperty() : base()
		{

		}

		#endregion

        #region Properties

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Application Application
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Application>(this, "Application", typeof(NetOffice.ExcelApi.Application));
            }
        }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Enums.XlCreator Creator
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlCreator>(this, "Creator");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// Get
        /// Unknown COM Proxy
        /// </summary>
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16), ProxyResult]
        public virtual object Parent
        {
            get
            {
                return Factory.ExecuteReferencePropertyGet(this, "Parent");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        public virtual string Name
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "Name");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "Name", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        public virtual object Value
        {
            get
            {
                return Factory.ExecuteVariantPropertyGet(this, "Value");
            }
            set
            {
                Factory.ExecuteVariantPropertySet(this, "Value", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        public virtual object _Default
        {
            get
            {
                return Factory.ExecuteVariantPropertyGet(this, "_Default");
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// </summary>
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        public virtual Int32 Delete()
        {
            return Factory.ExecuteInt32MethodGet(this, "Delete");
        }

        #endregion

        #pragma warning restore
    }
}

