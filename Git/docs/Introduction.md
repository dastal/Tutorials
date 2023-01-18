# Introduction #
Following a short introduction into Git and Github.

## What is Git? ##
A Free and open source version control system

## What is Version Control? ##
The management of changes to documents, computer programs, large web sites, and other collections of information.

## Terms ##
- Directory: Folder
- Terminal or Command Line: Interface for text commands
- CLI: Command Line Interface
- `cd`: Change Directory
- Code Editor: Word Processor for writing code
- Repository: Project, or the folder/ place where the project is kept
- GitHub: A website to host the repositories

## Git Commands ##
- `clone`: Bring a repository that is hosted somewhere like Github into a folder on your local machine
- `add`: Track the files and changes in Git
- `commit`: Save the files in Git
- `push`: Upload Git commits to a remote repo, like GitHub
- `pull`: Download changes from remote repo to the local machine, the opposite of push

## Sign up in GitHub ##
- Sign up for [Github](https://github.com) and create an account
- Reopository: As mentioned above, place to save the project
- README.md: File that contains text and information about the project, found in mostly every project
- README.md files are always shown by Github
- Chapter Commits: History of every commit that was made during the editing of the project

## Using Git in Local Machine ##
- On Windows, [Git](https://git-scm.com/download/win) needs to be installed first.
- Checking Git version: enter `git --version` in terminal

## Code Editor ##
- [Visual Studio Code](https://code.visualstudio.com/download)
- Open a Folder in VS Code
- Open a terminal

## Cloning through VS Code ##
- In the terminal enter `git clone <address cloned by ssh in GitHub>`
- `cd <First Folder>` to get into the master branch
- This information is found in the .git directory
- With `la` (or `ls`) we can see the content of the .git folder

## Commit ##
(The following commands only work when we are in the respective folder)
- `git status` shows all the files that have been updated, created, or deleted
- `git add .` adds all the files that have been updated, created, or deleted
- `git commit -m "<Some message>"` Git commit command with the message to the commit which always has to be there, after this command the commit is not live on GitHub yet, it is only saved locally
- `git push` Make the commit live on GitHub