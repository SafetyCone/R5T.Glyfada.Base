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

        public void Add(string localPath)
        {
            this.Core.Add(localPath);
        }

        public void Clone(string repositoryURL, string localDiretoryPath)
        {
            this.Core.Clone(repositoryURL, localDiretoryPath);
        }

        public void Commit(string localPath, string message)
        {
            this.Core.Commit(localPath, message);
        }

        public void Init(string directoryPath, bool quiet = false)
        {
            this.Core.Init(directoryPath, quiet);
        }

        public void Push(string directoryPath)
        {
            this.Core.Push(directoryPath);
        }
    }
}
