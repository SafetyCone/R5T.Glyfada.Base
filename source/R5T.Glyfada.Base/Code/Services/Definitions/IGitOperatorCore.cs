using System;


namespace R5T.Glyfada
{
    public interface IGitOperatorCore
    {
        void Add(string localPath);
        void Clone(string repositoryURL, string localDiretoryPath);
        void Commit(string localPath, string message);
        void Init(string directoryPath, bool quiet = false);
        void Push(string directoryPath);
    }
}
