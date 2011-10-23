﻿//Generated by LateBindingApi.CodeGenerator
using System;
using System.Reflection;
using System.ComponentModel;
using System.Collections.Generic;
using LateBindingApi.Core;

namespace OfficeApi.Utils
{
	#pragma warning disable
    /// <summary>
    /// necessary factory info, used from LateBindingApi.Core.Factory while Initialize()
    /// </summary>
    public class ProjectInfo : IFactoryInfo
    {
        #region Field

        private string   _namespace     = "NetOffice.OfficeApi";
        private Guid     _componentGuid = new Guid("2DF8D04C-5BFA-101B-BDE5-00AA0044DE52");
        private Assembly _assembly;
		private Type[]	 _exportedTypes;

        #endregion

        #region Construction

        public ProjectInfo()
        {
            _assembly = Assembly.GetExecutingAssembly();
        }

        #endregion

        #region IFactoryInfo Members

		public bool Contains(string className)
		{
			if(null == _exportedTypes)
				_exportedTypes = Assembly.GetExportedTypes();
			
			foreach (Type item in _exportedTypes)
            {
				if (item.Name.EndsWith(className, StringComparison.InvariantCultureIgnoreCase))
					return true;
            }
				
			return false;			
		}
		
        public string Namespace
        {
            get
            {
                return _namespace;
            }
        }

        public Guid ComponentGuid
        {
            get
            {
                return _componentGuid;
            }
        }

        public Assembly Assembly
        {
            get
            {
                return _assembly;
            }
        }

        #endregion
    }
    #pragma warning restore
}