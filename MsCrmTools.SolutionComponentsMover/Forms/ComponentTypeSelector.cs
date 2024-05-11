using Microsoft.Xrm.Sdk;
using Microsoft.Xrm.Sdk.Metadata;
using MsCrmTools.SolutionComponentsMover.AppCode;
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
        private bool _isOnline;
        private bool _onlySourceComponentTypes = false;

        public ComponentTypeSelector(OptionMetadataCollection omc)
        {
            InitializeComponent();
            _isOnline = false;
            _omc = omc;
        }

        public ComponentTypeSelector(OptionMetadataCollection omc, EntityMetadataCollection emc, List<Entity> solutionComponents, bool onlySourceComponentTypes)
        {
            InitializeComponent();

            _omc = omc;
            _emc = emc;
            _solutionComponents = solutionComponents;
            _isOnline = true;
            _onlySourceComponentTypes = onlySourceComponentTypes;
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
            if (_onlySourceComponentTypes)
            {
                LoadSourceComponentTypes();
                return;
            }
            LoadAllComponentType();
            AddMissingTypes();
        }

        private void AddMissingTypes()
        {
            var modelDrivenAppNotFound = lvTypes.Items.Cast<ListViewItem>().All(o => (int)o.Tag != 80);
            if (modelDrivenAppNotFound)
            {
                lvTypes.Items.Add(new ListViewItem("Model driven app") { Tag = 80, Checked = true });
            }
            foreach (var omd in _omc)
            {
                var componentTypeNotFound = lvTypes.Items.Cast<ListViewItem>().All(o => (int)o.Tag != omd.Value);
                if (componentTypeNotFound)
                {
                    lvTypes.Items.Add(new ListViewItem(omd.Label?.UserLocalizedLabel?.Label ?? omd.Label.LocalizedLabels.FirstOrDefault()?.Label) { Tag = omd.Value, Checked = true });
                }
            }
        }

        private void LoadAllComponentType()
        {
            if (!_isOnline)
                return;
            foreach (var component in _solutionComponents)
            {
                var entity = _emc.First(emd => emd.LogicalName == component.GetAttributeValue<string>("primaryentityname"));
                lvTypes.Items.Add(new ListViewItem(entity.DisplayName?.UserLocalizedLabel?.Label ?? entity.SchemaName) { Tag = component.GetAttributeValue<int>("objecttypecode"), Checked = true });
            }
        }

        private void LoadSourceComponentTypes()
        {
            if (!_isOnline)
                return;
            foreach (var component in _solutionComponents)
            {
                string displayName;
                var relatedTag = component.GetAttributeValue<OptionSetValue>("componenttype").Value;
                component.FormattedValues.TryGetValue("componenttype", out displayName);
                if (string.IsNullOrEmpty(displayName))
                    displayName = $"No Valid Name Found For This Component. Type :{component.GetAttributeValue<OptionSetValue>("componenttype").Value}";
                var desiredItem = new ListViewItem(displayName) { Tag = relatedTag, Checked = true };
                bool repeated = false;
                foreach (ListViewItem item in lvTypes.Items)
                {
                    if ((int)item.Tag == relatedTag)
                    {
                        repeated = true;
                        break;
                    }
                }
                if (repeated)
                    continue;
                lvTypes.Items.Add(desiredItem);
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