# Brain Teasers

### A collection of brain teasers and spot-the-bug problems

Each problem below is in its own branch. Be sure to follow the steps below to get started. **Always read the `README.md` file before starting each problem.** Each problem also contains a solution branch. Optionally there may be `Hint*.md` files in the branches if you need a little help on your way. I recommend resisting the urge to open them right away and think on the problem for a bit before jumping right to the hints/solution.

Each problem may list its own dependencies, however, in general these are expected to work on the latest version of Visual Studio with the latest release of .NET/C#. Though many problem will likely work on older versions of .NET/C#, unless specified they may not be tested there. You will also need some familiarity using `git`. The CLI commands provided here assume a new-ish version of `git` (2.39.0 or newer). Alternatively if you are new to `git` and GitHub, I would recommend checking out [GitKraken](https://gitkraken.keboo.dev) and their [free Foundations of Git course](https://learn.gitkraken.com).


## Getting started

1. Get a copy of the repository.
Because each problem is stored in its own branch you will likely want to either [fork this repository](https://docs.github.com/get-started/quickstart/fork-a-repo) or [directly clone it](https://docs.github.com/repositories/creating-and-managing-repositories/cloning-a-repository) (if you want to be able to commit and push your work you will need to fork).

2. Update your copy to ensure you have the latest version. 
If you previously forked or cloned the repository you will need to update it to make sure you have the latest version. If you forked, you will first want to [sync your fork](https://docs.github.com/pull-requests/collaborating-with-pull-requests/working-with-forks/syncing-a-fork) so that your fork has the latest changes. For your local repositories you will want to run `git fetch --all` to ensure your have updated all of your local branches. For [GitKraken](https://gitkraken.keboo.dev) users, you can simply right click on the remote (likely named origin) in the remotes list on the left, and select "Fetch origin".

3. Select a problem you wish to do.
Each of the problems below lists its branch name in paraenthesis. Also notes the the solution branch name will be the problem's branch name with the `-solution` suffix appended to it. Check out the branch by running


## Brain teasers
These problems require you to write a little code to produce a desired outcome.

1. Mutating strings Part 1 (mutating-strings-part1)
2. Mutating strings Part 2 (mutating-strings-part1)
3. Multiple Static Constructors (multiple-static-constrcutors)

## Spot the bug
These problems require you to identify the what/why of how some code is working. Though you can clone the code and look at it, these can often simply be viewed in the browser to acquire the problem.

1. List error

## I found a mistake or have a suggestion for an entry
Great! Feel free to open an issue, or submit a pull request. 
Be aware that pull requests are not going to get directly merged, as I need to move each into its own branch.

When submitting new problem it is quite helpful to replace the `README.md` file with a filled in version from the `BrainTeaserTemplate.md`

## Can I get help if I am stuck?
Though I will try to answer questions raised in issues here, my intention is to make a [YouTube video](https://youtube.keboo.dev) for each of the problems explaining them. Please check for a video link within the problems `README.md` file to see if your question is answered there.