﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;

namespace NetOffice.ExcelApi.Behind
{
    /// <summary>
    /// IEditBox
    /// </summary>
    [SyntaxBypass]
    public class IEditBox_ : COMObject, NetOffice.ExcelApi.IEditBox_
    {
        #region Ctor

        /// <summary>
        /// Stub Ctor, not indented to use
        /// </summary>
        public IEditBox_() : base()
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <param name="start">optional object start</param>
        /// <param name="length">optional object length</param>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public NetOffice.ExcelApi.Characters get_Characters(object start, object length)        {
            return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Characters>(this, "Characters", typeof(NetOffice.ExcelApi.Characters), start, length);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Alias for get_Characters
        /// </summary>
        /// <param name="start">optional object start</param>
        /// <param name="length">optional object length</param>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16), Redirect("get_Characters")]
        public NetOffice.ExcelApi.Characters Characters(object start, object length)
        {
            return get_Characters(start, length);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        /// <param name="start">optional object start</param>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public NetOffice.ExcelApi.Characters get_Characters(object start)
        {
            return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Characters>(this, "Characters", typeof(NetOffice.ExcelApi.Characters), start);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Alias for get_Characters
        /// </summary>
        /// <param name="start">optional object start</param>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16), Redirect("get_Characters")]
        public NetOffice.ExcelApi.Characters Characters(object start)
        {
            return get_Characters(start);
        }

        #endregion

        #region Methods

        #endregion
    }

    /// <summary>
    /// Interface IEditBox 
    /// SupportByVersion Excel, 9,10,11,12,14,15,16
    /// </summary>
    [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
    [EntityType(EntityType.IsInterface)]
    public class IEditBox : NetOffice.ExcelApi.Behind.IEditBox_, NetOffice.ExcelApi.IEditBox
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
                    _type = typeof(IEditBox);
                return _type;
            }
        }

        #endregion

        #region Ctor

        /// <summary>
        /// Stub Ctor, not indented to use
        /// </summary>
        public IEditBox() : base()
        {
        }

        #endregion

        #region Properties

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public NetOffice.ExcelApi.Application Application
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Application>(this, "Application", typeof(NetOffice.ExcelApi.Application));
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public NetOffice.ExcelApi.Enums.XlCreator Creator
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlCreator>(this, "Creator");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// Unknown COM Proxy
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16), ProxyResult]
        public object Parent
        {
            get
            {
                return Factory.ExecuteReferencePropertyGet(this, "Parent");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public NetOffice.ExcelApi.Range BottomRightCell
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Range>(this, "BottomRightCell", typeof(NetOffice.ExcelApi.Range));
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public bool Enabled
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "Enabled");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "Enabled", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public Double Height
        {
            get
            {
                return Factory.ExecuteDoublePropertyGet(this, "Height");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "Height", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public Int32 Index
        {
            get
            {
                return Factory.ExecuteInt32PropertyGet(this, "Index");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public Double Left
        {
            get
            {
                return Factory.ExecuteDoublePropertyGet(this, "Left");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "Left", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public bool Locked
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "Locked");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "Locked", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public string Name
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
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public string OnAction
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "OnAction");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "OnAction", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public object Placement
        {
            get
            {
                return Factory.ExecuteVariantPropertyGet(this, "Placement");
            }
            set
            {
                Factory.ExecuteVariantPropertySet(this, "Placement", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public bool PrintObject
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "PrintObject");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "PrintObject", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public Double Top
        {
            get
            {
                return Factory.ExecuteDoublePropertyGet(this, "Top");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "Top", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public NetOffice.ExcelApi.Range TopLeftCell
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Range>(this, "TopLeftCell", typeof(NetOffice.ExcelApi.Range));
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public bool Visible
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "Visible");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "Visible", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public Double Width
        {
            get
            {
                return Factory.ExecuteDoublePropertyGet(this, "Width");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "Width", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public Int32 ZOrder
        {
            get
            {
                return Factory.ExecuteInt32PropertyGet(this, "ZOrder");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public NetOffice.ExcelApi.ShapeRange ShapeRange
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.ShapeRange>(this, "ShapeRange", typeof(NetOffice.ExcelApi.ShapeRange));
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public string Caption
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "Caption");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "Caption", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public NetOffice.ExcelApi.Characters Characters
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Characters>(this, "Characters", typeof(NetOffice.ExcelApi.Characters));
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public bool LockedText
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "LockedText");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "LockedText", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public string Text
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "Text");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "Text", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public bool DisplayVerticalScrollBar
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "DisplayVerticalScrollBar");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "DisplayVerticalScrollBar", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public Int32 InputType
        {
            get
            {
                return Factory.ExecuteInt32PropertyGet(this, "InputType");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "InputType", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public string LinkedObject
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "LinkedObject");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public bool MultiLine
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "MultiLine");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "MultiLine", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public bool PasswordEdit
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "PasswordEdit");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "PasswordEdit", value);
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public object BringToFront()
        {
            return Factory.ExecuteVariantMethodGet(this, "BringToFront");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public object Copy()
        {
            return Factory.ExecuteVariantMethodGet(this, "Copy");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="appearance">optional NetOffice.ExcelApi.Enums.XlPictureAppearance Appearance = 2</param>
        /// <param name="format">optional NetOffice.ExcelApi.Enums.XlCopyPictureFormat Format = -4147</param>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public object CopyPicture(object appearance, object format)
        {
            return Factory.ExecuteVariantMethodGet(this, "CopyPicture", appearance, format);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [CustomMethod]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public object CopyPicture()
        {
            return Factory.ExecuteVariantMethodGet(this, "CopyPicture");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="appearance">optional NetOffice.ExcelApi.Enums.XlPictureAppearance Appearance = 2</param>
        [CustomMethod]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public object CopyPicture(object appearance)
        {
            return Factory.ExecuteVariantMethodGet(this, "CopyPicture", appearance);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public object Cut()
        {
            return Factory.ExecuteVariantMethodGet(this, "Cut");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public object Delete()
        {
            return Factory.ExecuteVariantMethodGet(this, "Delete");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public object Duplicate()
        {
            return Factory.ExecuteVariantMethodGet(this, "Duplicate");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="replace">optional object replace</param>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public object Select(object replace)
        {
            return Factory.ExecuteVariantMethodGet(this, "Select", replace);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [CustomMethod]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public object Select()
        {
            return Factory.ExecuteVariantMethodGet(this, "Select");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public object SendToBack()
        {
            return Factory.ExecuteVariantMethodGet(this, "SendToBack");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="customDictionary">optional object customDictionary</param>
        /// <param name="ignoreUppercase">optional object ignoreUppercase</param>
        /// <param name="alwaysSuggest">optional object alwaysSuggest</param>
        /// <param name="spellLang">optional object spellLang</param>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public object CheckSpelling(object customDictionary, object ignoreUppercase, object alwaysSuggest, object spellLang)
        {
            return Factory.ExecuteVariantMethodGet(this, "CheckSpelling", customDictionary, ignoreUppercase, alwaysSuggest, spellLang);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [CustomMethod]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public object CheckSpelling()
        {
            return Factory.ExecuteVariantMethodGet(this, "CheckSpelling");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="customDictionary">optional object customDictionary</param>
        [CustomMethod]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public object CheckSpelling(object customDictionary)
        {
            return Factory.ExecuteVariantMethodGet(this, "CheckSpelling", customDictionary);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="customDictionary">optional object customDictionary</param>
        /// <param name="ignoreUppercase">optional object ignoreUppercase</param>
        [CustomMethod]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public object CheckSpelling(object customDictionary, object ignoreUppercase)
        {
            return Factory.ExecuteVariantMethodGet(this, "CheckSpelling", customDictionary, ignoreUppercase);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="customDictionary">optional object customDictionary</param>
        /// <param name="ignoreUppercase">optional object ignoreUppercase</param>
        /// <param name="alwaysSuggest">optional object alwaysSuggest</param>
        [CustomMethod]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public object CheckSpelling(object customDictionary, object ignoreUppercase, object alwaysSuggest)
        {
            return Factory.ExecuteVariantMethodGet(this, "CheckSpelling", customDictionary, ignoreUppercase, alwaysSuggest);
        }

        #endregion

        #pragma warning restore
    }
}
