﻿using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Messages;
using Microsoft.Xrm.Sdk.Metadata;
using MsCrmTools.SolutionComponentsMover.AppCode;
using MsCrmTools.SolutionComponentsMover.Forms;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using XrmToolBox.Extensibility;
using XrmToolBox.Extensibility.Interfaces;

namespace MsCrmTools.SolutionComponentsMover
{
    public partial class MainControl : PluginControlBase, IGitHubPlugin, IHelpPlugin
    {
        private OptionMetadataCollection _omc;
        private SolutionManager sManager;

        public MainControl()
        {
            InitializeComponent();
        }

        public string HelpUrl => "https://github.com/MscrmTools/MsCrmTools.SolutionComponentsMover/wiki";

        public string RepositoryName => "MsCrmTools.SolutionComponentsMover";

        public string UserName => "MscrmTools";

        public void LoadSolutions()
        {
            sManager = new SolutionManager(Service);

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Loading solutions...",
                Work = (bw, e) =>
                {
                    e.Result = sManager.RetrieveSolutions();

                    _omc = ((OptionSetMetadata)((RetrieveOptionSetResponse)Service.Execute(
                        new RetrieveOptionSetRequest
                        {
                            Name = "componenttype"
                        })).OptionSetMetadata).Options;
                    //_omc
                },
                PostWorkCallBack = e =>
                {
                    if (e.Error == null)
                    {
                        sourceSolutionPicker.LoadSolutions((IEnumerable<Entity>)e.Result);
                        targetSolutionPicker.LoadSolutions((IEnumerable<Entity>)e.Result);
                    }
                    else
                    {
                        MessageBox.Show(ParentForm, "An error occured: " + e.Error.Message, "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                },
            });
        }

        private void clearLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lvLogs.Items.Clear();
        }

        private void exportLogsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog
            {
                Filter = @"CSV file|*.csv"
            };

            if (sfd.ShowDialog(this) == DialogResult.OK)
            {
                lvLogs.ToCsv(sfd.FileName);
            }
        }

        private void lvLogs_Resize(object sender, EventArgs e)
        {
            chMessage.Width = lvLogs.Width;
        }

        private void SolutionSelected(object sender, SolutionSelectedEventArgs e)
        {
            Process.Start($"{ConnectionDetail.WebApplicationUrl}/tools/solution/edit.aspx?id={e.Solution.Id}");
        }

        private void tsbCloseThisTab_Click(object sender, EventArgs e)
        {
            CloseTool();
        }

        private void tsbCopyComponents_Click(object sender, EventArgs e)
        {
            var settings = new CopySettings
            {
                SourceSolutions = sourceSolutionPicker.SelectedSolutions,
                TargetSolutions = targetSolutionPicker.SelectedSolutions,
                ConnectionDetail = ConnectionDetail,
                CheckBestPractice = chkCheckBestPractice.Checked
            };
            var csForm = new ComponentTypeSelector(_omc);
            if (csForm.ShowDialog(ParentForm) == DialogResult.OK)
            {
                settings.ComponentsTypes = csForm.SelectedComponents;
            }
            else
            {
                return;
            }

            WorkAsync(new WorkAsyncInfo
            {
                Message = "Starting copy...",
                AsyncArgument = settings,
                Work = (bw, evt) =>
                {
                    sManager.CopyComponents((CopySettings)evt.Argument, _omc, bw);
                },
                PostWorkCallBack = evt =>
                {
                    if (evt.Error != null)
                    {
                        MessageBox.Show(ParentForm, "An error occured: " + evt.Error.Message, "Error",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                },
                ProgressChanged = evt =>
                {
                    if (evt.ProgressPercentage == 0)
                    {
                        SetWorkingMessage(evt.UserState.ToString());
                    }
                    else if (evt.ProgressPercentage == -1)
                    {
                        lvLogs.Items.Add(new ListViewItem(evt.UserState.ToString()) { ForeColor = Color.Red });
                    }
                    else if (evt.ProgressPercentage == 1)
                    {
                        lvLogs.Items.Add(new ListViewItem(evt.UserState.ToString()) { ForeColor = Color.Green });
                    }
                }
            });
        }

        private void tsbLoadSolutions_Click(object sender, EventArgs e)
        {
            ExecuteMethod(LoadSolutions);
        }
    }
}