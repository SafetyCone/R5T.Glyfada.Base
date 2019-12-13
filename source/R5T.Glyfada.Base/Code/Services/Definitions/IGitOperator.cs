using System;


namespace R5T.Glyfada
{
    public interface IGitOperator
    {
        void Init(string directoryPath, bool quiet = false);
    }
}
