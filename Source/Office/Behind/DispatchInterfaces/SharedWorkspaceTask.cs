﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.OfficeApi;

namespace NetOffice.OfficeApi.Behind
{
    /// <summary>
    /// DispatchInterface SharedWorkspaceTask 
    /// SupportByVersion Office, 11,12,14,15,16
    /// </summary>
    /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff865531.aspx </remarks>
    [SupportByVersion("Office", 11, 12, 14, 15, 16)]
    [EntityType(EntityType.IsDispatchInterface)]
    public class SharedWorkspaceTask : NetOffice.OfficeApi.Behind._IMsoDispObj, NetOffice.OfficeApi.SharedWorkspaceTask
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
                    _type = typeof(SharedWorkspaceTask);
                return _type;
            }
        }

        #endregion

		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public SharedWorkspaceTask() : base()
		{

		}

		#endregion

        #region Properties

        /// <summary>
        /// SupportByVersion Office 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff860234.aspx </remarks>
        [SupportByVersion("Office", 11, 12, 14, 15, 16)]
        public virtual string Title
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "Title");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "Title", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff861531.aspx </remarks>
        [SupportByVersion("Office", 11, 12, 14, 15, 16)]
        public virtual string AssignedTo
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "AssignedTo");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "AssignedTo", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff864957.aspx </remarks>
        [SupportByVersion("Office", 11, 12, 14, 15, 16)]
        public virtual NetOffice.OfficeApi.Enums.MsoSharedWorkspaceTaskStatus Status
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.OfficeApi.Enums.MsoSharedWorkspaceTaskStatus>(this, "Status");
            }
            set
            {
                Factory.ExecuteEnumPropertySet(this, "Status", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff863054.aspx </remarks>
        [SupportByVersion("Office", 11, 12, 14, 15, 16)]
        public virtual NetOffice.OfficeApi.Enums.MsoSharedWorkspaceTaskPriority Priority
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.OfficeApi.Enums.MsoSharedWorkspaceTaskPriority>(this, "Priority");
            }
            set
            {
                Factory.ExecuteEnumPropertySet(this, "Priority", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff860514.aspx </remarks>
        [SupportByVersion("Office", 11, 12, 14, 15, 16)]
        public virtual string Description
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "Description");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "Description", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff862835.aspx </remarks>
        [SupportByVersion("Office", 11, 12, 14, 15, 16)]
        public virtual object DueDate
        {
            get
            {
                return Factory.ExecuteVariantPropertyGet(this, "DueDate");
            }
            set
            {
                Factory.ExecuteVariantPropertySet(this, "DueDate", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff864667.aspx </remarks>
        [SupportByVersion("Office", 11, 12, 14, 15, 16)]
        public virtual string CreatedBy
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "CreatedBy");
            }
        }

        /// <summary>
        /// SupportByVersion Office 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff862213.aspx </remarks>
        [SupportByVersion("Office", 11, 12, 14, 15, 16)]
        public virtual object CreatedDate
        {
            get
            {
                return Factory.ExecuteVariantPropertyGet(this, "CreatedDate");
            }
        }

        /// <summary>
        /// SupportByVersion Office 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff864980.aspx </remarks>
        [SupportByVersion("Office", 11, 12, 14, 15, 16)]
        public virtual string ModifiedBy
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "ModifiedBy");
            }
        }

        /// <summary>
        /// SupportByVersion Office 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff860842.aspx </remarks>
        [SupportByVersion("Office", 11, 12, 14, 15, 16)]
        public virtual object ModifiedDate
        {
            get
            {
                return Factory.ExecuteVariantPropertyGet(this, "ModifiedDate");
            }
        }

        /// <summary>
        /// SupportByVersion Office 11, 12, 14, 15, 16
        /// Get
        /// Unknown COM Proxy
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff862819.aspx </remarks>
        [SupportByVersion("Office", 11, 12, 14, 15, 16), ProxyResult]
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
        /// SupportByVersion Office 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff865262.aspx </remarks>
        [SupportByVersion("Office", 11, 12, 14, 15, 16)]
        public virtual void Save()
        {
            Factory.ExecuteMethod(this, "Save");
        }

        /// <summary>
        /// SupportByVersion Office 11, 12, 14, 15, 16
        /// </summary>
        /// <remarks> MSDN Online: http://msdn.microsoft.com/en-us/en-us/library/office/ff862097.aspx </remarks>
        [SupportByVersion("Office", 11, 12, 14, 15, 16)]
        public virtual void Delete()
        {
            Factory.ExecuteMethod(this, "Delete");
        }

        #endregion

        #pragma warning restore
    }
}
