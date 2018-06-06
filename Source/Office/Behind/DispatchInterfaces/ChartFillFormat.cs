﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.OfficeApi;

namespace NetOffice.OfficeApi.Behind
{
    /// <summary>
    /// DispatchInterface ChartFillFormat 
    /// SupportByVersion Office, 12,14,15,16
    /// </summary>
    [SupportByVersion("Office", 12, 14, 15, 16)]
    [EntityType(EntityType.IsDispatchInterface)]
    public class ChartFillFormat : COMObject, NetOffice.OfficeApi.ChartFillFormat
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
                    _type = typeof(ChartFillFormat);
                return _type;
            }
        }

        #endregion

		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public ChartFillFormat() : base()
		{

		}

		#endregion

        #region Properties

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual NetOffice.OfficeApi.ChartColorFormat BackColor
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.OfficeApi.ChartColorFormat>(this, "BackColor", typeof(NetOffice.OfficeApi.ChartColorFormat));
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual NetOffice.OfficeApi.ChartColorFormat ForeColor
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.OfficeApi.ChartColorFormat>(this, "ForeColor", typeof(NetOffice.OfficeApi.ChartColorFormat));
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual Int32 GradientColorType
        {
            get
            {
                return Factory.ExecuteInt32PropertyGet(this, "GradientColorType");
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual Single GradientDegree
        {
            get
            {
                return Factory.ExecuteSinglePropertyGet(this, "GradientDegree");
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual Int32 GradientStyle
        {
            get
            {
                return Factory.ExecuteInt32PropertyGet(this, "GradientStyle");
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual Int32 GradientVariant
        {
            get
            {
                return Factory.ExecuteInt32PropertyGet(this, "GradientVariant");
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual Int32 Pattern
        {
            get
            {
                return Factory.ExecuteInt32PropertyGet(this, "Pattern");
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual Int32 PresetGradientType
        {
            get
            {
                return Factory.ExecuteInt32PropertyGet(this, "PresetGradientType");
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual Int32 PresetTexture
        {
            get
            {
                return Factory.ExecuteInt32PropertyGet(this, "PresetTexture");
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual string TextureName
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "TextureName");
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual Int32 TextureType
        {
            get
            {
                return Factory.ExecuteInt32PropertyGet(this, "TextureType");
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual Int32 Type
        {
            get
            {
                return Factory.ExecuteInt32PropertyGet(this, "Type");
            }
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual Int32 Visible
        {
            get
            {
                return Factory.ExecuteInt32PropertyGet(this, "Visible");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "Visible", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 14, 15, 16
        /// Get
        /// Unknown COM Proxy
        /// </summary>
        [SupportByVersion("Office", 14, 15, 16), ProxyResult]
        public virtual object Application
        {
            get
            {
                return Factory.ExecuteReferencePropertyGet(this, "Application");
            }
        }

        /// <summary>
        /// SupportByVersion Office 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Office", 14, 15, 16)]
        public virtual Int32 Creator
        {
            get
            {
                return Factory.ExecuteInt32PropertyGet(this, "Creator");
            }
        }

        /// <summary>
        /// SupportByVersion Office 14, 15, 16
        /// Get
        /// Unknown COM Proxy
        /// </summary>
        [SupportByVersion("Office", 14, 15, 16), ProxyResult]
        public virtual object Parent
        {
            get
            {
                return Factory.ExecuteReferencePropertyGet(this, "Parent");
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// </summary>
        /// <param name="style">Int32 style</param>
        /// <param name="variant">Int32 variant</param>
        /// <param name="degree">Single degree</param>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual void OneColorGradient(Int32 style, Int32 variant, Single degree)
        {
            Factory.ExecuteMethod(this, "OneColorGradient", style, variant, degree);
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// </summary>
        /// <param name="style">Int32 style</param>
        /// <param name="variant">Int32 variant</param>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual void TwoColorGradient(Int32 style, Int32 variant)
        {
            Factory.ExecuteMethod(this, "TwoColorGradient", style, variant);
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// </summary>
        /// <param name="presetTexture">Int32 presetTexture</param>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual void PresetTextured(Int32 presetTexture)
        {
            Factory.ExecuteMethod(this, "PresetTextured", presetTexture);
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// </summary>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual void Solid()
        {
            Factory.ExecuteMethod(this, "Solid");
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// </summary>
        /// <param name="pattern">Int32 pattern</param>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual void Patterned(Int32 pattern)
        {
            Factory.ExecuteMethod(this, "Patterned", pattern);
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// </summary>
        /// <param name="pictureFile">object pictureFile</param>
        /// <param name="pictureFormat">object pictureFormat</param>
        /// <param name="pictureStackUnit">object pictureStackUnit</param>
        /// <param name="picturePlacement">object picturePlacement</param>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual void UserPicture(object pictureFile, object pictureFormat, object pictureStackUnit, object picturePlacement)
        {
            Factory.ExecuteMethod(this, "UserPicture", pictureFile, pictureFormat, pictureStackUnit, picturePlacement);
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// </summary>
        /// <param name="textureFile">string textureFile</param>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual void UserTextured(string textureFile)
        {
            Factory.ExecuteMethod(this, "UserTextured", textureFile);
        }

        /// <summary>
        /// SupportByVersion Office 12, 14, 15, 16
        /// </summary>
        /// <param name="style">Int32 style</param>
        /// <param name="variant">Int32 variant</param>
        /// <param name="presetGradientType">Int32 presetGradientType</param>
        [SupportByVersion("Office", 12, 14, 15, 16)]
        public virtual void PresetGradient(Int32 style, Int32 variant, Int32 presetGradientType)
        {
            Factory.ExecuteMethod(this, "PresetGradient", style, variant, presetGradientType);
        }

        #endregion

        #pragma warning restore
    }
}
