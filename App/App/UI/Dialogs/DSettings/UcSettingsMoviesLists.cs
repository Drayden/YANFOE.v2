﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace YANFOE.UI.Dialogs.DSettings
{
    public partial class UcSettingsMoviesLists : DevExpress.XtraEditors.XtraUserControl
    {
        public UcSettingsMoviesLists()
        {
            InitializeComponent();
            listEditGenre.SetDataSource(Settings.Get.Genres.CustomGenres);
        }
    }
}
