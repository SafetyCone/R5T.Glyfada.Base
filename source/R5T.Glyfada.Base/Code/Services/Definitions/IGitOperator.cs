using System;


namespace R5T.Glyfada
{
    public interface IGitOperator
    {
        void Add(string path);
        void Clone(string repositoryURL, string localDirectoryPath);
        void Commit(string path, string message);
        void Init(string directoryPath, bool quiet = false);
        bool IsUnderSourceControl(string path);
        void Pull(string path);
        void Push(string path);
    }
}
