using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Label = Microsoft.Xrm.Sdk.Label;

namespace MsCrmTools.SolutionComponentsMover.Forms
{
    public partial class ComponentTypeSelector : Form
    {
        private readonly OptionMetadataCollection _omc;

        public ComponentTypeSelector(OptionMetadataCollection omc)
        {
            InitializeComponent();

            _omc = omc;
        }

        public List<int> SelectedComponents { get; private set; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SelectedComponents = new List<int>();
            SelectedComponents.AddRange(lvTypes.CheckedItems.Cast<ListViewItem>().Select(i => (int)i.Tag));

            //foreach (var ctrl in Controls)
            //{
            //    var chk = ctrl as CheckBox;
            //    if (chk != null && chk != chkAll && (chk.Checked || chkAll.Checked))
            //    {
            //        SelectedComponents.Add(int.Parse(chk.Tag.ToString()));
            //    }
            //}

            //if (SelectedComponents.Contains(1))
            //{
            //    SelectedComponents.AddRange(new List<int> {
            //        2, // Attribut
            //        10, // Relationship
            //        14, // Key
            //        22, // Display string
            //        24, // Form
            //        26, // View
            //        59, // Chart
            //        60, // System Form
            //        65, // Hierarchical rules
            //    });
            //}

            Close();
        }

        private void chkAll_CheckedChanged(object sender, EventArgs e)
        {
            foreach (var ctrl in Controls)
            {
                var chk = ctrl as CheckBox;
                if (chk != null && chk != chkAll)
                {
                    chk.Enabled = !chkAll.Checked;
                }
            }
        }

        private void ComponentTypeSelector_Load(object sender, EventArgs e)
        {
            if (_omc.All(o => o.Value != 80))
            {
                var lb = new Label { UserLocalizedLabel = new LocalizedLabel("Model driven app", -1) };
                _omc.Add(new OptionMetadata(lb, 80));
            }

            if (_omc.All(o => o.Value != 10270))
            {
                var lb = new Label { UserLocalizedLabel = new LocalizedLabel("Custom API", -1) };
                _omc.Add(new OptionMetadata(lb, 10270));
            }

            if (_omc.All(o => o.Value != 10271))
            {
                var lb = new Label { UserLocalizedLabel = new LocalizedLabel("Custom API Request Parameter", -1) };
                _omc.Add(new OptionMetadata(lb, 10271));
            }

            if (_omc.All(o => o.Value != 810272))
            {
                var lb = new Label { UserLocalizedLabel = new LocalizedLabel("Custom API Response Parameter", -1) };
                _omc.Add(new OptionMetadata(lb, 10272));
            }

            foreach (var omd in _omc.OrderBy(o => o.Label?.UserLocalizedLabel?.Label ?? o.Label.LocalizedLabels.FirstOrDefault()?.Label))
            {
                lvTypes.Items.Add(new ListViewItem(omd.Label?.UserLocalizedLabel?.Label ?? omd.Label.LocalizedLabels.FirstOrDefault()?.Label) { Tag = omd.Value, Checked = true });
            }
        }

        private void llClearAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (ListViewItem item in lvTypes.Items)
            {
                item.Checked = false;
            }
        }

        private void llInvertSelection_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (ListViewItem item in lvTypes.Items)
            {
                item.Checked = !item.Checked;
            }
        }

        private void llSelectAll_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            foreach (ListViewItem item in lvTypes.Items)
            {
                item.Checked = true;
            }
        }
    }
}