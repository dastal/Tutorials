# Debugging Bash Scripts #
There are three different ways to debug a defective bash script.

One way is to use the command:

```
bash -x ./scriptName.sh
```

Here you can see the steps which are executed until the error, like a log file where every action is noted.
Finally yoou know in which section of your code the error is situated.

The exact same procedure happens when in the first line of the script where you have `#! /bin/bash`. If you use:

```
#! /bin/bash -x
```

The last way is to use:

```
set -x
..some code..
set +x
```

Whith this procedure you limit the show of the code from `set -x` to `set +x`.