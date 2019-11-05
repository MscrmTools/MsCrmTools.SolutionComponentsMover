using McTools.Xrm.Connection;
using Microsoft.Xrm.Sdk;
using System.Collections.Generic;

namespace MsCrmTools.SolutionComponentsMover.AppCode
{
    internal class CopySettings
    {
        public bool CheckBestPractice { get; set; }
        public List<int> ComponentsTypes { get; set; }
        public ConnectionDetail ConnectionDetail { get; internal set; }
        public List<Entity> SourceSolutions { get; set; }
        public List<Entity> TargetSolutions { get; set; }
    }
}