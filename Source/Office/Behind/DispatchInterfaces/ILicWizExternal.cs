﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.OfficeApi;

namespace NetOffice.OfficeApi.Behind
{
    /// <summary>
    /// DispatchInterface ILicWizExternal 
    /// SupportByVersion Office, 10,11,12,14,15,16
    /// </summary>
    [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
    [EntityType(EntityType.IsDispatchInterface)]
    public class ILicWizExternal : COMObject, NetOffice.OfficeApi.ILicWizExternal
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
                    _type = typeof(ILicWizExternal);
                return _type;
            }
        }

        #endregion

		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public ILicWizExternal() : base()
		{

		}

		#endregion

        #region Properties

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public virtual Int32 Context
        {
            get
            {
                return Factory.ExecuteInt32PropertyGet(this, "Context");
            }
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// Get
        /// Unknown COM Proxy
        /// </summary>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16), ProxyResult]
        public virtual object Validator
        {
            get
            {
                return Factory.ExecuteReferencePropertyGet(this, "Validator");
            }
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// Get
        /// Unknown COM Proxy
        /// </summary>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16), ProxyResult]
        public virtual object LicAgent
        {
            get
            {
                return Factory.ExecuteReferencePropertyGet(this, "LicAgent");
            }
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public virtual string CountryInfo
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "CountryInfo");
            }
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public virtual Int32 WizardVisible
        {
            get
            {
                return Factory.ExecuteInt32PropertyGet(this, "WizardVisible");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "WizardVisible", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public virtual string WizardTitle
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "WizardTitle");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "WizardTitle", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public virtual Int32 AnimationEnabled
        {
            get
            {
                return Factory.ExecuteInt32PropertyGet(this, "AnimationEnabled");
            }
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public virtual Int32 CurrentHelpId
        {
            get
            {
                return Factory.ExecuteInt32PropertyGet(this, "CurrentHelpId");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "CurrentHelpId", value);
            }
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public virtual string OfficeOnTheWebUrl
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "OfficeOnTheWebUrl");
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="punkHtmlDoc">object punkHtmlDoc</param>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public virtual void PrintHtmlDocument(object punkHtmlDoc)
        {
            Factory.ExecuteMethod(this, "PrintHtmlDocument", punkHtmlDoc);
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public virtual void InvokeDateTimeApplet()
        {
            Factory.ExecuteMethod(this, "InvokeDateTimeApplet");
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="date">DateTime date</param>
        /// <param name="pFormat">optional string pFormat = </param>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public virtual string FormatDate(DateTime date, object pFormat)
        {
            return Factory.ExecuteStringMethodGet(this, "FormatDate", date, pFormat);
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="date">DateTime date</param>
        [CustomMethod]
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public virtual string FormatDate(DateTime date)
        {
            return Factory.ExecuteStringMethodGet(this, "FormatDate", date);
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="pvarId">optional object pvarId</param>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public virtual void ShowHelp(object pvarId)
        {
            Factory.ExecuteMethod(this, "ShowHelp", pvarId);
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        [CustomMethod]
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public virtual void ShowHelp()
        {
            Factory.ExecuteMethod(this, "ShowHelp");
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public virtual void Terminate()
        {
            Factory.ExecuteMethod(this, "Terminate");
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="bPC">Int32 bPC</param>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public virtual void DisableVORWReminder(Int32 bPC)
        {
            Factory.ExecuteMethod(this, "DisableVORWReminder", bPC);
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="bstrReceipt">string bstrReceipt</param>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public virtual string SaveReceipt(string bstrReceipt)
        {
            return Factory.ExecuteStringMethodGet(this, "SaveReceipt", bstrReceipt);
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="bstrUrl">string bstrUrl</param>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public virtual void OpenInDefaultBrowser(string bstrUrl)
        {
            Factory.ExecuteMethod(this, "OpenInDefaultBrowser", bstrUrl);
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="bstrText">string bstrText</param>
        /// <param name="bstrButtons">string bstrButtons</param>
        /// <param name="bstrIcon">string bstrIcon</param>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public virtual Int32 MsoAlert(string bstrText, string bstrButtons, string bstrIcon)
        {
            return Factory.ExecuteInt32MethodGet(this, "MsoAlert", bstrText, bstrButtons, bstrIcon);
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="bstrKey">string bstrKey</param>
        /// <param name="fMORW">Int32 fMORW</param>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public virtual Int32 DepositPidKey(string bstrKey, Int32 fMORW)
        {
            return Factory.ExecuteInt32MethodGet(this, "DepositPidKey", bstrKey, fMORW);
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="bstrMessage">string bstrMessage</param>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public virtual void WriteLog(string bstrMessage)
        {
            Factory.ExecuteMethod(this, "WriteLog", bstrMessage);
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="bstrProductCode">string bstrProductCode</param>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public virtual void ResignDpc(string bstrProductCode)
        {
            Factory.ExecuteMethod(this, "ResignDpc", bstrProductCode);
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public virtual void ResetPID()
        {
            Factory.ExecuteMethod(this, "ResetPID");
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="dx">Int32 dx</param>
        /// <param name="dy">Int32 dy</param>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public virtual void SetDialogSize(Int32 dx, Int32 dy)
        {
            Factory.ExecuteMethod(this, "SetDialogSize", dx, dy);
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="lMode">Int32 lMode</param>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public virtual Int32 VerifyClock(Int32 lMode)
        {
            return Factory.ExecuteInt32MethodGet(this, "VerifyClock", lMode);
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="pdispSelect">object pdispSelect</param>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public virtual void SortSelectOptions(object pdispSelect)
        {
            Factory.ExecuteMethod(this, "SortSelectOptions", pdispSelect);
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public virtual void InternetDisconnect()
        {
            Factory.ExecuteMethod(this, "InternetDisconnect");
        }

        /// <summary>
        /// SupportByVersion Office 10, 11, 12, 14, 15, 16
        /// </summary>
        [SupportByVersion("Office", 10, 11, 12, 14, 15, 16)]
        public virtual Int32 GetConnectedState()
        {
            return Factory.ExecuteInt32MethodGet(this, "GetConnectedState");
        }

        #endregion

        #pragma warning restore
    }
}
