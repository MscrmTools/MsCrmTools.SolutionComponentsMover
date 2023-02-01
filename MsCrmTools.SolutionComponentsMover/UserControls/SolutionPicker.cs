using Microsoft.Xrm.Sdk;
using MsCrmTools.SolutionComponentsMover.AppCode;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace MsCrmTools.SolutionComponentsMover.UserControls
{
    public partial class SolutionPicker : UserControl
    {
        private readonly List<ListViewItem> _items = new List<ListViewItem>();
        private ListViewColumnSorter lvColumnSorter;
        private Thread searchThread;
        private IOrganizationService service;

        public SolutionPicker()
        {
            InitializeComponent();
            lvColumnSorter = new ListViewColumnSorter();
            this.lvSolutions.ListViewItemSorter = lvColumnSorter;
        }

        public event EventHandler<SolutionSelectedEventArgs> OnSolutionSelected;

        public bool CanDisplayManagedSolutions { get; set; }

        public List<Entity> SelectedSolutions
        {
            get { return lvSolutions.SelectedItems.Cast<ListViewItem>().Select(i => (Entity)i.Tag).ToList(); }
        }

        public IOrganizationService Service
        { set { service = value; } }

        public void LoadSolutions(IEnumerable<Entity> solutions)
        {
            lvSolutions.Items.Clear();
            _items.Clear();

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
                item.SubItems.Add(solution.GetAttributeValue<DateTime>("installedon").ToShortDateString());
                item.SubItems.Add(solution.GetAttributeValue<string>("version"));
                item.SubItems.Add(solution.GetAttributeValue<bool>("ismanaged").ToString());
                item.Tag = solution;

                _items.Add(item);
            }

            lvSolutions.Items.AddRange(_items.ToArray());
        }

        private void DisplaySolutions()
        {
            Invoke(new Action(() =>
            {
                lvSolutions.Items.Clear();

                lvSolutions.Items.AddRange(_items
                    .Where(i => i.Text.ToLower().Contains(txtFilter.Text.ToLower())
                     || i.SubItems.Cast<ListViewItem.ListViewSubItem>().Any(s => s.Text.ToLower().Contains(txtFilter.Text.ToLower()))
                    )
                    .ToArray());
            }));
        }

        private void LvSolutions_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            // Determine if clicked column is already the column that is being sorted.
            if (e.Column == lvColumnSorter.SortColumn)
            {
                // Reverse the current sort direction for this column.
                if (lvColumnSorter.Order == SortOrder.Ascending)
                {
                    lvColumnSorter.Order = SortOrder.Descending;
                }
                else
                {
                    lvColumnSorter.Order = SortOrder.Ascending;
                }
            }
            else
            {
                // Set the column number that is to be sorted; default to ascending.
                lvColumnSorter.SortColumn = e.Column;
                lvColumnSorter.Order = SortOrder.Ascending;
            }

            // Perform the sort with these new sort options.
            this.lvSolutions.Sort();
        }

        private void lvSolutions_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lvSolutions.SelectedItems.Count == 1)
                OnSolutionSelected?.Invoke(this, new SolutionSelectedEventArgs((Entity)lvSolutions.SelectedItems.Cast<ListViewItem>().First().Tag));
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            searchThread?.Abort();
            searchThread = new Thread(DisplaySolutions);
            searchThread.Start();
        }
    }
}