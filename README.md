# .NET Sandbox

Sandbox monorepo to try things out in the .NET ecosystem.

This repository is first organized by the broad version of .NET is being used
(e.g. it distinguishes .NET Core from .NET 6 and beyond).

As with my other "sandbox" repositories, each directory here is its own,
self-contained project.  Look for code and documentation in those directories,
to learn more.

## Git and line endings

We're dealing with Windows and at the very least Microsoft technologies, which
means CRLF line endings will appear from time to time (even the `dotnet` CLI
creates files with these, on some occasions).

What's a developer to do?  Consult these helpful posts:

* [How to see waht type of line endings are in a Git repository](https://stackoverflow.com/questions/35801024/how-to-see-what-type-of-line-endings-are-already-in-git-repository)
* [How to normalize working tree files](https://stackoverflow.com/questions/15641259/how-to-normalize-working-tree-line-endings-in-git)
* [Force LF eol in git repo and working copy](https://stackoverflow.com/questions/9976986/force-lf-eol-in-git-repo-and-working-copy)

### Make a `.gitattributes` file

Make some variation of the following, so that new files get added to Git with
the correct line endings, regardless of any particular user's Git config.
Personally, I haven't found grokking the nuances of and policing everyone's
`autocrlf` Git config to be a very productive use of my time.  I'd rather the
repository just set it, without requiing any user intervention.

```gitattributes
* text=auto eol=lf
```

### Git commands

Some variety of these commands may be helpful as well.

```shell
#What line endings are in the repository?
git ls-files --eol

#Re-normalize line endings in Git index
git add --renormalize .

#Re-create files in working directory so they match the Git index
git checkout-index --force --all
```
