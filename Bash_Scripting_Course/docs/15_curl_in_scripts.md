# Curl in Scripts #
If you want to download files via script, you can use curl. Therefore you just need the URL of the file you want to download. Then you can use the following code:

```
url="https://some_url.example/file.dat"
curl ${url} -O
```

The `-O` (capital o) indicates that you want to download the file with its original file name.

If you want to change the file name, use:

```
curl ${url} -o NewFileName
```

or:

```
curl ${url} > OutputFile
```

If you do not want to download the file directly, but you want to have the information about it, use:

```
curl -I ${url}
```

Here, the `-I` indiactes that you want the information, and the file will not be downloaded.

