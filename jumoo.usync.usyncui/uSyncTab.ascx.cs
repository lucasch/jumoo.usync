﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

using jumoo.usync.content;

namespace jumoo.usync.usyncui
{
    public partial class uSyncTab : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void exportContent_Click(object sender, EventArgs e)
        {
            // do the content exoort
            ContentWalker cw = new ContentWalker();
            cw.WalkSite();

            exportStatus.Text = "Content Exported"; 
            

        }

        protected void importContent_Click(object sender, EventArgs e)
        {
            ContentImporter ci = new ContentImporter();

            // 1. import the content 
            int importCount = ci.ImportDiskContent(false); 

            // 2. import again but try to map id's
            ci.ImportDiskContent(true); 

            importStatus.Text = String.Format("{0} Content nodes imported", importCount);


        }
    }
}