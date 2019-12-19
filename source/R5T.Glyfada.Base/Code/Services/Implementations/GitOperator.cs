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

        public void Add(string path)
        {
            this.Core.Add(path);
        }

        public void Clone(string repositoryURL, string localDirectoryPath)
        {
            this.Core.Clone(repositoryURL, localDirectoryPath);
        }

        public void Commit(string path, string message)
        {
            this.Core.Commit(path, message);
        }

        public void Init(string directoryPath, bool quiet = false)
        {
            this.Core.Init(directoryPath, quiet);
        }

        public bool IsUnderSourceControl(string path)
        {
            var isUnderSourceControl = this.Core.IsUnderSourceControl(path);
            return isUnderSourceControl;
        }

        public void Push(string path)
        {
            this.Core.Push(path);
        }

        public void Pull(string path)
        {
            this.Core.Pull(path);
        }
    }
}
