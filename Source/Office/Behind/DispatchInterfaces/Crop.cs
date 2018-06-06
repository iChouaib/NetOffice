﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.OfficeApi;

namespace NetOffice.OfficeApi.Behind
{
    /// <summary>
    /// DispatchInterface Crop 
    /// SupportByVersion Office, 14,15,16
    /// </summary>
    /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff860761.aspx </remarks>
    [SupportByVersion("Office", 14, 15, 16)]
    [EntityType(EntityType.IsDispatchInterface)]
    public class Crop : NetOffice.OfficeApi.Behind._IMsoDispObj, NetOffice.OfficeApi.Crop
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
                    _type = typeof(Crop);
                return _type;
            }
        }

        #endregion

		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public Crop() : base()
		{

		}

		#endregion

        #region Properties

        /// <summary>
        /// SupportByVersion Office 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff862450.aspx </remarks>
        [SupportByVersion("Office", 14, 15, 16)]
        public virtual Single PictureOffsetX
        {
            get
            {
                return Factory.ExecuteSinglePropertyGet(this, "PictureOffsetX");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "PictureOffsetX", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff864637.aspx </remarks>
        [SupportByVersion("Office", 14, 15, 16)]
        public virtual Single PictureOffsetY
        {
            get
            {
                return Factory.ExecuteSinglePropertyGet(this, "PictureOffsetY");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "PictureOffsetY", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff860544.aspx </remarks>
        [SupportByVersion("Office", 14, 15, 16)]
        public virtual Single PictureWidth
        {
            get
            {
                return Factory.ExecuteSinglePropertyGet(this, "PictureWidth");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "PictureWidth", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff860512.aspx </remarks>
        [SupportByVersion("Office", 14, 15, 16)]
        public virtual Single PictureHeight
        {
            get
            {
                return Factory.ExecuteSinglePropertyGet(this, "PictureHeight");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "PictureHeight", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff861232.aspx </remarks>
        [SupportByVersion("Office", 14, 15, 16)]
        public virtual Single ShapeLeft
        {
            get
            {
                return Factory.ExecuteSinglePropertyGet(this, "ShapeLeft");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "ShapeLeft", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff861517.aspx </remarks>
        [SupportByVersion("Office", 14, 15, 16)]
        public virtual Single ShapeTop
        {
            get
            {
                return Factory.ExecuteSinglePropertyGet(this, "ShapeTop");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "ShapeTop", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff861716.aspx </remarks>
        [SupportByVersion("Office", 14, 15, 16)]
        public virtual Single ShapeWidth
        {
            get
            {
                return Factory.ExecuteSinglePropertyGet(this, "ShapeWidth");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "ShapeWidth", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff864643.aspx </remarks>
        [SupportByVersion("Office", 14, 15, 16)]
        public virtual Single ShapeHeight
        {
            get
            {
                return Factory.ExecuteSinglePropertyGet(this, "ShapeHeight");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "ShapeHeight", value);
            }
        }

        #endregion

        #region Methods

        #endregion

        #pragma warning restore
    }
}
