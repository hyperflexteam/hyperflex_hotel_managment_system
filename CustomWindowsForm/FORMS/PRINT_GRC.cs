using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using CustomWindowsForm;
using CustomWindowsForm.FORMS;
using HYFLEX_HMS.CLASS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HYFLEX_HMS.FORMS
{
    public partial class PRINT_GRC : Form
    {
        public PRINT_GRC()
        {
            InitializeComponent();
        }

        private void LOAD_GRC()
        {
            try
            {
                String RES_NO = REPORT.RESERVATION_NO;
                ReportDocument cryRpt = new ReportDocument();
                cryRpt.Load(Application.StartupPath + "\\reports\\GRC.rpt");
                ParameterFieldDefinitions crParameterFieldDefinitions;
                ParameterFieldDefinition crParameterFieldDefinition;
                ParameterValues crParameterValues = new ParameterValues();
                ParameterDiscreteValue crParameterDiscreteValue = new ParameterDiscreteValue();

                crParameterFieldDefinitions = cryRpt.DataDefinition.ParameterFields;
                crParameterDiscreteValue.Value = RES_NO;
                crParameterFieldDefinition = crParameterFieldDefinitions["RES"];
                crParameterValues = crParameterFieldDefinition.CurrentValues;
                crParameterValues.Clear();
                crParameterValues.Add(crParameterDiscreteValue);
                crParameterFieldDefinition.ApplyCurrentValues(crParameterValues);

                crystalReportViewer1.ReportSource = cryRpt;
                crystalReportViewer1.Refresh();
            }
            catch (Exception EX)
            {
                MSGBOX mdg = new MSGBOX(MessageAlertHeder.Error(), EX.Message, MessageAlertImage.Error());
                mdg.ShowDialog();
            }
        }
        private void PRINT_GRC_Load(object sender, EventArgs e)
        {
            LOAD_GRC();
        }
    }
}
