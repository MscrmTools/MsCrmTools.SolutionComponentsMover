using Microsoft.Xrm.Sdk;
using MsCrmTools.SolutionComponentsMover.AppCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MsCrmTools.SolutionComponentsMover.UserControls
{
    public partial class SolutionPicker : UserControl
    {
        private IOrganizationService service;

        public SolutionPicker()
        {
            InitializeComponent();
        }

        public event EventHandler<SolutionSelectedEventArgs> OnSolutionSelected;

        public bool CanDisplayManagedSolutions { get; set; }

        public List<Entity> SelectedSolutions
        {
            get { return lvSolutions.SelectedItems.Cast<ListViewItem>().Select(i => (Entity)i.Tag).ToList(); }
        }

        public IOrganizationService Service { set { service = value; } }

        public void LoadSolutions(IEnumerable<Entity> solutions)
        {
            lvSolutions.Items.Clear();

            var list = new List<ListViewItem>();

            IEnumerable<Entity> solutionsToDisplay = solutions;

            if (!CanDisplayManagedSolutions)
            {
                solutionsToDisplay = solutions.Where(s => s.GetAttributeValue<bool>("ismanaged") == false);
            }

            foreach (var solution in solutionsToDisplay)
            {
                var item = new ListViewItem(solution.GetAttributeValue<string>("friendlyname"));
                item.SubItems.Add(solution.GetAttributeValue<string>("uniquename"));
                item.SubItems.Add(solution.GetAttributeValue<EntityReference>("publisherid").Name);
                item.Tag = solution;

                list.Add(item);
            }

            lvSolutions.Items.AddRange(list.ToArray());
        }

        private void lvSolutions_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvSolutions.SelectedItems.Count == 1)
                OnSolutionSelected?.Invoke(this, new SolutionSelectedEventArgs((Entity)lvSolutions.SelectedItems.Cast<ListViewItem>().First().Tag));
        }
    }
}