using System;


namespace R5T.Glyfada
{
    public class GitOperator : IGitOperator
    {
        private IGitOperatorCore Core { get; }


        public GitOperator(IGitOperatorCore core)
        {
            this.Core = core;
        }
    }
}
