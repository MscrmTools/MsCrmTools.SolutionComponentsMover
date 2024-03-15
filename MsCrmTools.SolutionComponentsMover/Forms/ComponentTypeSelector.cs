using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MsCrmTools.SolutionComponentsMover.Forms
{
    public partial class ComponentTypeSelector : Form
    {
        private readonly EntityMetadataCollection _emc;
        private readonly OptionMetadataCollection _omc;
        private readonly List<Entity> _solutionComponents;
        private bool isOnline;

        public ComponentTypeSelector(OptionMetadataCollection omc)
        {
            InitializeComponent();
            isOnline = false;
            _omc = omc;
        }

        public ComponentTypeSelector(EntityMetadataCollection emc, List<Entity> solutionComponents)
        {
            InitializeComponent();

            _emc = emc;
            _solutionComponents = solutionComponents;
            isOnline = true;
        }

        public ComponentTypeSelector(OptionMetadataCollection omc, EntityMetadataCollection emc, List<Entity> solutionComponents)
        {
            InitializeComponent();

            _omc = omc;
            _emc = emc;
            _solutionComponents = solutionComponents;
            isOnline = true;
        }

        public bool AllItemsSelected { get; private set; }
        public List<int> SelectedComponents { get; private set; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SelectedComponents = new List<int>();
            SelectedComponents.AddRange(lvTypes.CheckedItems.Cast<ListViewItem>().Select(i => (int)i.Tag));

            AllItemsSelected = lvTypes.CheckedItems.Count == lvTypes.Items.Count;

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
            if (isOnline)
            {
                foreach (var component in _solutionComponents)
                {
                    var entity = _emc.First(emd => emd.LogicalName == component.GetAttributeValue<string>("primaryentityname"));

                    lvTypes.Items.Add(new ListViewItem(entity.DisplayName?.UserLocalizedLabel?.Label ?? entity.SchemaName) { Tag = component.GetAttributeValue<int>("solutioncomponenttype"), Checked = true });
                }
            }

            if (lvTypes.Items.Cast<ListViewItem>().All(o => (int)o.Tag != 80))
            {
                lvTypes.Items.Add(new ListViewItem("Model driven app") { Tag = 80, Checked = true });
            }

            foreach (var omd in _omc)
            {
                if (lvTypes.Items.Cast<ListViewItem>().All(o => (int)o.Tag != omd.Value))
                {
                    lvTypes.Items.Add(new ListViewItem(omd.Label?.UserLocalizedLabel?.Label ?? omd.Label.LocalizedLabels.FirstOrDefault()?.Label) { Tag = omd.Value, Checked = true });
                }
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