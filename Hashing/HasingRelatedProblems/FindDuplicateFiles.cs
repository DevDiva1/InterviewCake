using System.Collections.Generic;
using System.IO;

namespace HashingRelatedProblems
{
    public class FindDuplicateFiles
    {
        public static void Main(string[] args)
        {
            //Invoke FindDuplicateFiles method
        }

        public class FilePaths
        {
            public string DuplicatePaths { get; }
            public string OriginalPaths { get; }

            public FilePaths(string duplicatePaths, string originalPaths)
            {
                DuplicatePaths = duplicatePaths;
                OriginalPaths = originalPaths;
            }

            public override string ToString()
            {
                return $"(original:{OriginalPaths},duplicate:{DuplicatePaths})";
            }

            public List<FilePaths> FindDuplicateFiles(string startingDirectory)
            {
                var fileSeenAlready = new Dictionary<string, FileInfo>();
                var stack = new Stack<FileSystemInfo>();
                stack.Push(new DirectoryInfo(startingDirectory));
                var duplicates = new List<FilePaths>();

                while (stack.Count > 0)
                {
                    var currentInfo = stack.Pop();
                    //if it's a directory, put the contents in our stack
                    var currentDirectoryInfo = currentInfo as DirectoryInfo;
                    if (currentDirectoryInfo != null)
                        foreach (var info in currentDirectoryInfo.GetFileSystemInfos())
                            stack.Push(info);

                    //if it's a file
                    var currentFileInfo = currentInfo as FileInfo;
                    if (currentFileInfo != null)
                    {
                        //get its contents
                        string fileContents;
                        using (var stream = currentFileInfo.OpenText())
                        {
                            fileContents = stream.ReadToEnd();
                        }

                        //if we've seen it before
                        if (fileSeenAlready.ContainsKey(fileContents))
                        {
                            var existingFileInfo = fileSeenAlready[fileContents];
                            if (currentFileInfo.LastWriteTime > existingFileInfo.LastWriteTime)
                            {
                                //current file is the duplicate
                                duplicates.Add(new FilePaths(currentFileInfo.FullName, existingFileInfo.FullName));
                            }
                            else
                            {
                                duplicates.Add(new FilePaths(existingFileInfo.FullName, currentFileInfo.FullName));

                                //Also update fileSeenAlready to have the new file info
                                fileSeenAlready[fileContents] = currentFileInfo;
                            }
                        }
                        else
                        {
                            //throw new files in fileSeenAlready so we can compare later
                            fileSeenAlready[fileContents] = currentFileInfo;
                        }
                    }
                }
                return duplicates;
            }
        }
    }
}