﻿using System;

namespace AutocompleteEditorAllowSettingNewValues.ViewModels
{
    public class ResultEntryViewModel
    {
        #region [ CTOR ]

        // ------------------------------------------------------------------------------ //
        public ResultEntryViewModel()
        // ------------------------------------------------------------------------------ //
        {
        }

        #endregion
        #region [ Public Properties ]

        // ------------------------------------------------------------------------------ //         
        public virtual string ID
        // ------------------------------------------------------------------------------ //
        {
            get;
            set;
        }

        // ------------------------------------------------------------------------------ //
        public string Name
        // ------------------------------------------------------------------------------ //
        {
            get;
            set;
        }

        // ------------------------------------------------------------------------------ //
        public string MethodName
        // ------------------------------------------------------------------------------ //
        {
            get;
            set;
        }

        // ------------------------------------------------------------------------------ //
        public int MinimumChars
        // ------------------------------------------------------------------------------ //
        {
            get;
            set;
        }

        // ------------------------------------------------------------------------------ //
        public DateTime? SignDate
        // ------------------------------------------------------------------------------ //
        {
            get;
            set;
        }

        #endregion
    }
}
