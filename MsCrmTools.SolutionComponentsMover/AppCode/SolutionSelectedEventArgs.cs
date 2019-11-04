using Microsoft.Xrm.Sdk;
using System;

namespace MsCrmTools.SolutionComponentsMover.AppCode
{
    public class SolutionSelectedEventArgs : EventArgs
    {
        public SolutionSelectedEventArgs(Entity solution)
        {
            Solution = solution;
        }

        public Entity Solution { get; private set; }
    }
}