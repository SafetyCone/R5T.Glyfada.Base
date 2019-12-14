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

        public void Init(string directoryPath, bool quiet = false)
        {
            this.Core.Init(directoryPath, quiet);
        }

        public void Clone(string repositoryURL, string localDiretoryPath)
        {
            this.Core.Clone(repositoryURL, localDiretoryPath);
        }
    }
}
