using DevExpress.XtraWaitForm;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ScreenerApp
{
    public partial class ProgressForm : WaitForm
    {
        public static string Description { get; set; }

        public ProgressForm()
        {
            InitializeComponent();
            this.panelProgress.AutoHeight = true;
            SetDescription(Description);
        }

        #region Overrides

        public override void SetCaption(string caption)
        {
            base.SetCaption(caption);
            this.panelProgress.Caption = caption;
        }
        public override void SetDescription(string description)
        {
            base.SetDescription(description);
            this.panelProgress.Description = description;
        }
        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum WaitFormCommand
        {
        }
    }
}