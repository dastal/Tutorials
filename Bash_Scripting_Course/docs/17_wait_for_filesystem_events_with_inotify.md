# Wait for Filesystem Events with `inotify` #

`inotify` is a monitoring Linux-Kernel-System that supervises changes in the filesystem and notifies those chages to the applications which use the correspoding files.
To install it use:

```
sudo apt install inotify-tools
```

To watch a folder, use the following command:

```
inotifywait -m AnyFolder
```

This will create a "watch" in "AnyFolder", which can be seen in the terminal and which notifies the user everytime when an action has been done to "AnyFolder".

For more information, go to the [inotify documentation](https://wiki.ubuntuusers.de/inotify/).