using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MsCrmTools.SolutionComponentsMover.Forms
{
    public partial class ComponentTypeSelector : Form
    {
        public ComponentTypeSelector()
        {
            InitializeComponent();
        }

        public List<int> SelectedComponents { get; private set; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            SelectedComponents = new List<int>();
            foreach (var ctrl in Controls)
            {
                var chk = ctrl as CheckBox;
                if (chk != null && chk != chkAll && (chk.Checked || chkAll.Checked))
                {
                    SelectedComponents.Add(int.Parse(chk.Tag.ToString()));
                }
            }

            if (SelectedComponents.Contains(1))
            {
                SelectedComponents.AddRange(new List<int> {
                    2, // Attribut
                    10, // Relationship
                    14, // Key
                    22, // Display string
                    24, // Form
                    26, // View
                    59, // Chart
                    60, // System Form
                    65, // Hierarchical rules
                });
            }

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
    }
}