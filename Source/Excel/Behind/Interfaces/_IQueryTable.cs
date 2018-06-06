﻿using System;
using NetRuntimeSystem = System;
using System.ComponentModel;
using NetOffice.Attributes;
using NetOffice.ExcelApi;

namespace NetOffice.ExcelApi.Behind
{
    /// <summary>
    /// Interface _IQueryTable 
    /// SupportByVersion Excel, 9,10,11,12,14,15,16
    /// </summary>
    [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
    [EntityType(EntityType.IsInterface)]
    public class _IQueryTable : COMObject, NetOffice.ExcelApi._IQueryTable
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
                    _type = typeof(_IQueryTable);
                return _type;
            }
        }

        #endregion

		#region Ctor

		/// <summary>
		/// Stub Ctor, not indented to use
		/// </summary>
		public _IQueryTable() : base()
		{

		}

		#endregion

        #region Properties

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Application Application
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
        public virtual NetOffice.ExcelApi.Enums.XlCreator Creator
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
        public virtual object Parent
        {
            get
            {
                return Factory.ExecuteReferencePropertyGet(this, "Parent");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
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
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool FieldNames
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "FieldNames");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "FieldNames", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool RowNumbers
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "RowNumbers");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "RowNumbers", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool FillAdjacentFormulas
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "FillAdjacentFormulas");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "FillAdjacentFormulas", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual bool HasAutoFormat
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "HasAutoFormat");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "HasAutoFormat", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool RefreshOnFileOpen
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "RefreshOnFileOpen");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "RefreshOnFileOpen", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool Refreshing
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "Refreshing");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool FetchedRowOverflow
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "FetchedRowOverflow");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool BackgroundQuery
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "BackgroundQuery");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "BackgroundQuery", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Enums.XlCellInsertionMode RefreshStyle
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlCellInsertionMode>(this, "RefreshStyle");
            }
            set
            {
                Factory.ExecuteEnumPropertySet(this, "RefreshStyle", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool EnableRefresh
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "EnableRefresh");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "EnableRefresh", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool SavePassword
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "SavePassword");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "SavePassword", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Range Destination
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Range>(this, "Destination", typeof(NetOffice.ExcelApi.Range));
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual object Connection
        {
            get
            {
                return Factory.ExecuteVariantPropertyGet(this, "Connection");
            }
            set
            {
                Factory.ExecuteVariantPropertySet(this, "Connection", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual object Sql
        {
            get
            {
                return Factory.ExecuteVariantPropertyGet(this, "Sql");
            }
            set
            {
                Factory.ExecuteVariantPropertySet(this, "Sql", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual string PostText
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "PostText");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "PostText", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Range ResultRange
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Range>(this, "ResultRange", typeof(NetOffice.ExcelApi.Range));
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Parameters Parameters
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Parameters>(this, "Parameters", typeof(NetOffice.ExcelApi.Parameters));
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// Unknown COM Proxy
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16), ProxyResult]
        public virtual object Recordset
        {
            get
            {
                return Factory.ExecuteReferencePropertyGet(this, "Recordset");
            }
            set
            {
                Factory.ExecuteReferencePropertySet(this, "Recordset", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool SaveData
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "SaveData");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "SaveData", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        [EditorBrowsable(EditorBrowsableState.Never), Browsable(false)]
        public virtual bool TablesOnlyFromHTML
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "TablesOnlyFromHTML");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "TablesOnlyFromHTML", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool EnableEditing
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "EnableEditing");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "EnableEditing", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Enums.XlPlatform TextFilePlatform
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlPlatform>(this, "TextFilePlatform");
            }
            set
            {
                Factory.ExecuteEnumPropertySet(this, "TextFilePlatform", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 TextFileStartRow
        {
            get
            {
                return Factory.ExecuteInt32PropertyGet(this, "TextFileStartRow");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "TextFileStartRow", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Enums.XlTextParsingType TextFileParseType
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlTextParsingType>(this, "TextFileParseType");
            }
            set
            {
                Factory.ExecuteEnumPropertySet(this, "TextFileParseType", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Enums.XlTextQualifier TextFileTextQualifier
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlTextQualifier>(this, "TextFileTextQualifier");
            }
            set
            {
                Factory.ExecuteEnumPropertySet(this, "TextFileTextQualifier", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool TextFileConsecutiveDelimiter
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "TextFileConsecutiveDelimiter");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "TextFileConsecutiveDelimiter", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool TextFileTabDelimiter
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "TextFileTabDelimiter");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "TextFileTabDelimiter", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool TextFileSemicolonDelimiter
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "TextFileSemicolonDelimiter");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "TextFileSemicolonDelimiter", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool TextFileCommaDelimiter
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "TextFileCommaDelimiter");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "TextFileCommaDelimiter", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool TextFileSpaceDelimiter
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "TextFileSpaceDelimiter");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "TextFileSpaceDelimiter", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual string TextFileOtherDelimiter
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "TextFileOtherDelimiter");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "TextFileOtherDelimiter", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual object TextFileColumnDataTypes
        {
            get
            {
                return Factory.ExecuteVariantPropertyGet(this, "TextFileColumnDataTypes");
            }
            set
            {
                Factory.ExecuteVariantPropertySet(this, "TextFileColumnDataTypes", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual object TextFileFixedColumnWidths
        {
            get
            {
                return Factory.ExecuteVariantPropertyGet(this, "TextFileFixedColumnWidths");
            }
            set
            {
                Factory.ExecuteVariantPropertySet(this, "TextFileFixedColumnWidths", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool PreserveColumnInfo
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "PreserveColumnInfo");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "PreserveColumnInfo", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool PreserveFormatting
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "PreserveFormatting");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "PreserveFormatting", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool AdjustColumnWidth
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "AdjustColumnWidth");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "AdjustColumnWidth", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual object CommandText
        {
            get
            {
                return Factory.ExecuteVariantPropertyGet(this, "CommandText");
            }
            set
            {
                Factory.ExecuteVariantPropertySet(this, "CommandText", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Enums.XlCmdType CommandType
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlCmdType>(this, "CommandType");
            }
            set
            {
                Factory.ExecuteEnumPropertySet(this, "CommandType", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool TextFilePromptOnRefresh
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "TextFilePromptOnRefresh");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "TextFilePromptOnRefresh", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Enums.xlQueryType QueryType
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.xlQueryType>(this, "QueryType");
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool MaintainConnection
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "MaintainConnection");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "MaintainConnection", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual string TextFileDecimalSeparator
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "TextFileDecimalSeparator");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "TextFileDecimalSeparator", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual string TextFileThousandsSeparator
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "TextFileThousandsSeparator");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "TextFileThousandsSeparator", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 RefreshPeriod
        {
            get
            {
                return Factory.ExecuteInt32PropertyGet(this, "RefreshPeriod");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "RefreshPeriod", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Enums.xlWebSelectionType WebSelectionType
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.xlWebSelectionType>(this, "WebSelectionType");
            }
            set
            {
                Factory.ExecuteEnumPropertySet(this, "WebSelectionType", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Enums.xlWebFormatting WebFormatting
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.xlWebFormatting>(this, "WebFormatting");
            }
            set
            {
                Factory.ExecuteEnumPropertySet(this, "WebFormatting", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual string WebTables
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "WebTables");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "WebTables", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool WebPreFormattedTextToColumns
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "WebPreFormattedTextToColumns");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "WebPreFormattedTextToColumns", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool WebSingleBlockTextImport
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "WebSingleBlockTextImport");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "WebSingleBlockTextImport", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool WebDisableDateRecognition
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "WebDisableDateRecognition");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "WebDisableDateRecognition", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool WebConsecutiveDelimitersAsOne
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "WebConsecutiveDelimitersAsOne");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "WebConsecutiveDelimitersAsOne", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        public virtual bool WebDisableRedirections
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "WebDisableRedirections");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "WebDisableRedirections", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        public virtual object EditWebPage
        {
            get
            {
                return Factory.ExecuteVariantPropertyGet(this, "EditWebPage");
            }
            set
            {
                Factory.ExecuteVariantPropertySet(this, "EditWebPage", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        public virtual string SourceConnectionFile
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "SourceConnectionFile");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "SourceConnectionFile", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        public virtual string SourceDataFile
        {
            get
            {
                return Factory.ExecuteStringPropertyGet(this, "SourceDataFile");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "SourceDataFile", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Enums.XlRobustConnect RobustConnect
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlRobustConnect>(this, "RobustConnect");
            }
            set
            {
                Factory.ExecuteEnumPropertySet(this, "RobustConnect", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        public virtual bool TextFileTrailingMinusNumbers
        {
            get
            {
                return Factory.ExecuteBoolPropertyGet(this, "TextFileTrailingMinusNumbers");
            }
            set
            {
                Factory.ExecuteValuePropertySet(this, "TextFileTrailingMinusNumbers", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 11, 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.ListObject ListObject
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.ListObject>(this, "ListObject", typeof(NetOffice.ExcelApi.ListObject));
            }
        }

        /// <summary>
        /// SupportByVersion Excel 11, 12, 14, 15, 16
        /// Get/Set
        /// </summary>
        [SupportByVersion("Excel", 11, 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Enums.XlTextVisualLayoutType TextFileVisualLayout
        {
            get
            {
                return Factory.ExecuteEnumPropertyGet<NetOffice.ExcelApi.Enums.XlTextVisualLayoutType>(this, "TextFileVisualLayout");
            }
            set
            {
                Factory.ExecuteEnumPropertySet(this, "TextFileVisualLayout", value);
            }
        }

        /// <summary>
        /// SupportByVersion Excel 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.WorkbookConnection WorkbookConnection
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.WorkbookConnection>(this, "WorkbookConnection", typeof(NetOffice.ExcelApi.WorkbookConnection));
            }
        }

        /// <summary>
        /// SupportByVersion Excel 12, 14, 15, 16
        /// Get
        /// </summary>
        [SupportByVersion("Excel", 12, 14, 15, 16)]
        public virtual NetOffice.ExcelApi.Sort Sort
        {
            get
            {
                return Factory.ExecuteKnownReferencePropertyGet<NetOffice.ExcelApi.Sort>(this, "Sort", typeof(NetOffice.ExcelApi.Sort));
            }
        }

        #endregion

        #region Methods

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 CancelRefresh()
        {
            return Factory.ExecuteInt32MethodGet(this, "CancelRefresh");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 Delete()
        {
            return Factory.ExecuteInt32MethodGet(this, "Delete");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="backgroundQuery">optional object backgroundQuery</param>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool Refresh(object backgroundQuery)
        {
            return Factory.ExecuteBoolMethodGet(this, "Refresh", backgroundQuery);
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [CustomMethod]
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual bool Refresh()
        {
            return Factory.ExecuteBoolMethodGet(this, "Refresh");
        }

        /// <summary>
        /// SupportByVersion Excel 9, 10, 11, 12, 14, 15, 16
        /// </summary>
        [SupportByVersion("Excel", 9, 10, 11, 12, 14, 15, 16)]
        public virtual Int32 ResetTimer()
        {
            return Factory.ExecuteInt32MethodGet(this, "ResetTimer");
        }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="oDCFileName">string oDCFileName</param>
        /// <param name="description">optional object description</param>
        /// <param name="keywords">optional object keywords</param>
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        public virtual Int32 SaveAsODC(string oDCFileName, object description, object keywords)
        {
            return Factory.ExecuteInt32MethodGet(this, "SaveAsODC", oDCFileName, description, keywords);
        }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="oDCFileName">string oDCFileName</param>
        [CustomMethod]
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        public virtual Int32 SaveAsODC(string oDCFileName)
        {
            return Factory.ExecuteInt32MethodGet(this, "SaveAsODC", oDCFileName);
        }

        /// <summary>
        /// SupportByVersion Excel 10, 11, 12, 14, 15, 16
        /// </summary>
        /// <param name="oDCFileName">string oDCFileName</param>
        /// <param name="description">optional object description</param>
        [CustomMethod]
        [SupportByVersion("Excel", 10, 11, 12, 14, 15, 16)]
        public virtual Int32 SaveAsODC(string oDCFileName, object description)
        {
            return Factory.ExecuteInt32MethodGet(this, "SaveAsODC", oDCFileName, description);
        }

        #endregion

        #pragma warning restore
    }
}

